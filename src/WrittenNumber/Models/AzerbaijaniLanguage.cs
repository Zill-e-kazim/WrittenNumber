namespace WrittenNumber.Models;

public class AzerbaijaniLanguage
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: false,
            baseSeparator: " ",
            unitSeparator: "",
            @base: new Dictionary<double, string>
            {
                [0] = "sıfır",
                [1] = "bir",
                [2] = "iki",
                [3] = "üç",
                [4] = "dörd",
                [5] = "beş",
                [6] = "altı",
                [7] = "yeddi",
                [8] = "səkkiz",
                [9] = "doqquz",
                [10] = "on",
                [20] = "iyirmi",
                [30] = "otuz",
                [40] = "qırx",
                [50] = "əlli",
                [60] = "altmış",
                [70] = "yetmiş",
                [80] = "səksən",
                [90] = "doxsan"
            },
            units: new List<object>
            {
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "yüz"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "min"
                },
                "milyon",
                "milyard",
                "trilyon",
                "kvadrilyon",
                "kentilyon",
                "sekstilyon",
                "septilyon",
                "oktilyon",
                "nonilyon",
                "desilyon",
                "andesilyon",
                "dodesilyon",
                "tredesilyon",
                "katordesilyon",
                "kendesilyon"
            });
    }
}