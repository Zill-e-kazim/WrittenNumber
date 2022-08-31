namespace WrittenNumber.Models;

public static class HungaraianLangauge
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: true,
            baseSeparator: "",
            unitSeparator: "és ",
            @base: new Dictionary<double, string>
            {
                [0] = "nulla",
                [1] = "egy",
                [2] = "kettő",
                [3] = "három",
                [4] = "négy",
                [5] = "öt",
                [6] = "hat",
                [7] = "hét",
                [8] = "nyolc",
                [9] = "kilenc",
                [10] = "tíz",
                [11] = "tizenegy",
                [12] = "tizenkettő",
                [13] = "tizenhárom",
                [14] = "tizennégy",
                [15] = "tizenöt",
                [16] = "tizenhat",
                [17] = "tizenhét",
                [18] = "tizennyolc",
                [19] = "tizenkilenc",
                [20] = "húsz",
                [21] = "huszonegy",
                [22] = "huszonkettő",
                [23] = "huszonhárom",
                [24] = "huszonnégy",
                [25] = "huszonöt",
                [26] = "huszonhat",
                [27] = "huszonhét",
                [28] = "huszonnyolc",
                [29] = "huszonkilenc",
                [30] = "harminc",
                [40] = "negyven",
                [50] = "ötven",
                [60] = "hatvan",
                [70] = "hetven",
                [80] = "nyolcvan",
                [90] = "kilencven",
                [100] = "száz",
                [200] = "kétszáz",
                [300] = "háromszáz",
                [400] = "négyszáz",
                [500] = "ötszáz",
                [600] = "hatszáz",
                [700] = "hétszáz",
                [800] = "nyolcszáz",
                [900] = "kilencszáz",
                [1000] = "ezer"
            },
            units: new List<object>
            {
                new LanguageUnit
                {
                    UseBaseInstead = true,
                    UseBaseException = new List<double>
                    {
                        1
                    },
                    Singular = "száz"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "ezer"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "millió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "milliárd"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "-billió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "billiárd"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "trillió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "trilliárd"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "kvadrillió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "kvadrilliárd"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "kvintillió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "kvintilliárd"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "szextillió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "szeptillió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "oktillió"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "nonillió"
                }
            })
        {
            UnitExceptions = new Dictionary<double, string>
            {
                [1] = "egy"
            }
        };
    }
}