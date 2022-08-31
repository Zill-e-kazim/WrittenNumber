namespace WrittenNumber.Models;

public static class TurkishLanguage
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
                [4] = "dört",
                [5] = "beş",
                [6] = "altı",
                [7] = "yedi",
                [8] = "sekiz",
                [9] = "dokuz",
                [10] = "on",
                [20] = "yirmi",
                [30] = "otuz",
                [40] = "kırk",
                [50] = "elli",
                [60] = "altmış",
                [70] = "yetmiş",
                [80] = "seksen",
                [90] = "doksan"
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
                    Singular = "bin"
                },
                "milyon",
                "milyar",
                "trilyon",
                "katrilyon",
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
            })
        {
            UnitExceptions = new Dictionary<double, string>()
        };
    }
}