using System.Text.RegularExpressions;
using WrittenNumber.Models;

namespace WrittenNumber;

public static class NumberExtension
{
    private static readonly List<double> _shortScale = new()
    {
        100
    };

    private static readonly List<double> _longScale = new()
    {
        100,
        1000
    };

    static NumberExtension()
    {
        for (var i = 1; i <= 16; i++) _shortScale.Add(Math.Pow(10, i * 3));

        for (var i = 1; i <= 15; i++) _longScale.Add(Math.Pow(10, i * 6));
    }

    private static string HandleSmallerThan100(double n, Language language, Dictionary<double, string>? baseCardinals,
        Dictionary<double, string>? alternativeBaseCardinals, Option options)
    {
        var dec = Math.Floor(n / 10) * 10;
        var unit = n - dec;

        var baseValue = alternativeBaseCardinals != null && alternativeBaseCardinals.ContainsKey(dec)
            ? alternativeBaseCardinals[dec]
            : baseCardinals != null && baseCardinals.ContainsKey(dec)
                ? baseCardinals[dec]
                : "";
        if (unit != 0) return baseValue + language.BaseSeparator + unit.WrittenNumber(options);

        return baseValue;
    }

    public static string WrittenNumber(this string n, Option option)
    {
        if (double.TryParse(n, out var value))
            return WrittenNumber(Convert.ToDouble(value), option);
        return "";
    }

    public static string WrittenNumber(this uint n, Option option)
    {
        return WrittenNumber(Convert.ToDouble(n), option);
    }

    public static string WrittenNumber(this long n, Option option)
    {
        return WrittenNumber(Convert.ToDouble(n), option);
    }

    public static string WrittenNumber(this int n, Option option)
    {
        return WrittenNumber(Convert.ToDouble(n), option);
    }

    public static string WrittenNumber(this double n, Option option)
    {
        try
        {
            if (n < 0) return "";

            n = Math.Round(+n);

            Language? language = null;

            if (option.Lang is string lang)
            {
                if (!string.IsNullOrEmpty(lang))
                    language = lang switch
                    {
                        "es" => SpanishLanguage.Get(),
                        "ar" => ArabicLanguage.Get(),
                        "az" => AzerbaijaniLanguage.Get(),
                        "pt" => pt_PortugueseLanguage.Get(),
                        "ptPT" => PortugueseLanguage.Get(),
                        "fr" => FrenchLanguage.Get(),
                        "eo" => EsperantoLanguage.Get(),
                        "it" => ItalianLanguage.Get(),
                        "vi" => VietnameseLanguage.Get(),
                        "tr" => TurkishLanguage.Get(),
                        "hu" => HungaraianLangauge.Get(),
                        "enIndian" => EnglishIndianLanguage.Get(),
                        "uk" => UkrainianLanguage.Get(),
                        "ru" => RussianLanguage.Get(),
                        "id" => IndonesianLanguage.Get(),
                        _ => EnglishLanguage.Get()
                    };
                else
                    throw new ArgumentException(nameof(option.Lang));
            }
            else if (option.Lang is Language customLanguage)
            {
                if (customLanguage != null) throw new ArgumentException(nameof(option.Lang));
                language = customLanguage;
            }

            var scale = language!.UseLongScale ? _longScale : _shortScale;
            var units = new List<object>();

            if (language.Units is Dictionary<double, string> dictLanguageUnits)
            {
                var rawUnits = dictLanguageUnits;
                scale = new List<double>(dictLanguageUnits.Keys);
                var rawScale = new List<double>();
                foreach (var i in scale.Select((value, i) => new { i, value }))
                {
                    var value = i.value;
                    var index = i.i;
                    rawScale.Add(Math.Pow(10, Convert.ToInt32(value)));
                }

                foreach (var (key, value) in dictLanguageUnits) units.Add(dictLanguageUnits[key]);
                scale = rawScale;
            }
            else if (language.Units is List<object> languageObjectUnits)
            {
                units.AddRange(languageObjectUnits);
            }
            else if (language.Units is List<string> languageStringUnits)
            {
                units.AddRange(languageStringUnits);
            }
            else
            {
                throw new ArgumentException(nameof(language.Units));
            }

            var baseCardinals = language.Base;
            var alternativeBaseCardinals =
                !string.IsNullOrEmpty(option.AlternativeBase) && language.AlternativeBase != null
                    ? language.AlternativeBase[option.AlternativeBase]
                    : null;

            if (language.UnitExceptions is Dictionary<double, string> unitExceptionDict &&
                unitExceptionDict.ContainsKey(n)) return unitExceptionDict[n];
            if (alternativeBaseCardinals is Dictionary<double, string> alternativeBaseCardinalsDict &&
                alternativeBaseCardinalsDict.ContainsKey(n)) return alternativeBaseCardinalsDict[n];
            if (baseCardinals.ContainsKey(n) && !string.IsNullOrEmpty(baseCardinals[n])) return baseCardinals[n];
            if (n < 100)
                return HandleSmallerThan100(n, language, baseCardinals, alternativeBaseCardinals, option);

            var m = n % 100;
            var ret = new List<string>();
            if (m != 0)
            {
                if (
                    option.NoAnd &&
                    !(language.AndException.HasValue &&
                      language.AndException.Value)
                )
                    ret.Add(m.WrittenNumber(option));
                else
                    ret.Add(language.UnitSeparator + m.WrittenNumber(option));
            }

            double firstSignificant = 0;
            var len = units.Count;
            for (var i = 0; i < len; i++)
            {
                var r = Math.Floor(n / scale[i]);
                double divideBy;

                if (i == len - 1) divideBy = 1000000;
                else divideBy = scale[i + 1] / scale[i];

                r %= divideBy;

                if (r == 0) continue;
                firstSignificant = scale[i];

                {
                    if (units[i] is LanguageUnit languageUnit && languageUnit.UseBaseInstead.HasValue &&
                        languageUnit.UseBaseInstead.Value)
                    {
                        var shouldUseBaseException =
                            languageUnit.UseBaseException!.IndexOf(r) > -1 &&
                            (!languageUnit.UseBaseExceptionWhenNoTrailingNumbers.HasValue ||
                             !languageUnit.UseBaseExceptionWhenNoTrailingNumbers.Value ||
                             (i == 0 && ret.Any()));
                        if (!shouldUseBaseException)
                            ret.Add(alternativeBaseCardinals != null &&
                                    alternativeBaseCardinals.ContainsKey(r * scale[i])
                                ? alternativeBaseCardinals[r * scale[i]]
                                : baseCardinals[r * scale[i]]);
                        else
                            ret.Add(r > 1 && !string.IsNullOrEmpty(languageUnit.Plural)
                                ? languageUnit.Plural
                                : languageUnit.Singular!);
                        continue;
                    }
                }

                var str = string.Empty;

                {
                    if (units[i] is string strUnit)
                    {
                        str = strUnit;
                    }
                    else if (units[i] is LanguageUnit languageUnit)
                    {
                        if ((r == 1 || (languageUnit.UseSingularEnding.HasValue &&
                                        languageUnit.UseSingularEnding.Value && r % 10 == 1
                                        && (languageUnit.AvoidEndingRules == null ||
                                            languageUnit.AvoidEndingRules.IndexOf(r) < 0))) &&
                            !string.IsNullOrEmpty(languageUnit.Singular))
                        {
                            str = languageUnit.Singular;
                        }
                        else if (!string.IsNullOrEmpty(languageUnit.Few) && ((r > 1 && r < 5) ||
                                                                             (languageUnit.UseFewEnding.HasValue &&
                                                                              languageUnit.UseFewEnding.Value &&
                                                                              r % 10 > 1 && r % 10 < 5
                                                                              && (languageUnit.AvoidEndingRules ==
                                                                                  null || languageUnit.AvoidEndingRules
                                                                                      .IndexOf(r) < 0))))
                        {
                            str = languageUnit.Few;
                        }
                        else
                        {
                            str = !string.IsNullOrEmpty(languageUnit.Plural) &&
                                  (!languageUnit.AvoidInNumberPlural.HasValue ||
                                   !languageUnit.AvoidInNumberPlural.Value || m == 0)
                                ? languageUnit.Plural
                                : languageUnit.Singular!;

                            // Languages with dual
                            str = r == 2 && !string.IsNullOrEmpty(languageUnit.Dual) ? languageUnit.Dual : str;

                            // "restrictedPlural" : use plural only for 3 to 10
                            str = r > 10 && languageUnit.RestrictedPlural.HasValue &&
                                  languageUnit.RestrictedPlural.Value
                                ? languageUnit.Singular!
                                : str;
                        }
                    }
                }

                {
                    if (
                        units[i] is LanguageUnit languageUnit &&
                        languageUnit.AvoidPrefixException != null &&
                        languageUnit.AvoidPrefixException.Any() &&
                        languageUnit.AvoidPrefixException.IndexOf(r) > -1
                    )
                    {
                        ret.Add(str);
                        continue;
                    }
                }
                string number;
                if (language.UnitExceptions != null &&
                    r < language.UnitExceptions.Count &&
                    language.UnitExceptions.ContainsKey(r))
                    number = language.UnitExceptions[r];
                else if (units[i] is string)
                    number = WrittenNumber(
                        r,
                        new Option
                        {
                            NoAnd = !(language.AndException.HasValue &&
                                      language.AndException.Value) && true,
                            AlternativeBase = null,
                            Lang = option.Lang
                        });
                else if (units[i] is LanguageUnit languageUnitCheck)
                    number = WrittenNumber(
                        r,
                        new Option
                        {
                            NoAnd = !((language.AndException.HasValue &&
                                       language.AndException.Value) ||
                                      (languageUnitCheck.AndException.HasValue &&
                                       languageUnitCheck.AndException.Value)) && true,
                            AlternativeBase = languageUnitCheck.UseAlternativeBase,
                            Lang = option.Lang
                        });
                else number = "";
                n -= r * scale[i];
                ret.Add(number + " " + str);
            }

            var firstSignificantN = firstSignificant * Math.Floor(n / firstSignificant);
            var rest = n - firstSignificantN;

            if (
                language.AndWhenTrailing == true &&
                firstSignificant != 0 &&
                0 < rest &&
                ret[0].IndexOf(language.UnitSeparator) != 0
            )
            {
                var a = new List<string>
                {
                    ret[0],
                    Regex.Replace(language.UnitSeparator, @"\s+", "")
                };
                ret.RemoveAt(0);
                a.AddRange(ret);
                ret = a;
            }

            if (!string.IsNullOrEmpty(language.AllSeparator))
                for (var j = 0; j < ret.Count - 1; j++)
                    ret[j] = language.AllSeparator + ret[j];
            ret.Reverse();
            var result = string.Join(" ", ret.ToArray());
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}