namespace WrittenNumber.Models;

public static class EsperantoLanguage
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
                [0] = "nulo",
                [1] = "unu",
                [2] = "du",
                [3] = "tri",
                [4] = "kvar",
                [5] = "kvin",
                [6] = "ses",
                [7] = "sep",
                [8] = "ok",
                [9] = "naŭ",
                [10] = "dek",
                [20] = "dudek",
                [30] = "tridek",
                [40] = "kvardek",
                [50] = "kvindek",
                [60] = "sesdek",
                [70] = "sepdek",
                [80] = "okdek",
                [90] = "naŭdek",
                [100] = "cent",
                [200] = "ducent",
                [300] = "tricent",
                [400] = "kvarcent",
                [500] = "kvincent",
                [600] = "sescent",
                [700] = "sepcent",
                [800] = "okcent",
                [900] = "naŭcent"
            },
            units: new List<object>
            {
                new LanguageUnit
                {
                    UseBaseInstead = true,
                    UseBaseException = new List<double>()
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "mil"
                },
                new LanguageUnit
                {
                    Plural = "milionoj",
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "miliono"
                },
                new LanguageUnit
                {
                    Plural = "miliardoj",
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "miliardo"
                },
                new LanguageUnit
                {
                    Plural = "bilionoj",
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "biliono"
                }
            }
        );
    }
}