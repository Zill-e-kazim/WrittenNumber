namespace WrittenNumber.Models;

public static class pt_PortugueseLanguage
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: false,
            baseSeparator: " e ",
            unitSeparator: "e ",
            @base: new Dictionary<double, string>
            {
                [0] = "zero",
                [1] = "um",
                [2] = "dois",
                [3] = "três",
                [4] = "quatro",
                [5] = "cinco",
                [6] = "seis",
                [7] = "sete",
                [8] = "oito",
                [9] = "nove",
                [10] = "dez",
                [11] = "onze",
                [12] = "doze",
                [13] = "treze",
                [14] = "catorze",
                [15] = "quinze",
                [16] = "dezesseis",
                [17] = "dezessete",
                [18] = "dezoito",
                [19] = "dezenove",
                [20] = "vinte",
                [30] = "trinta",
                [40] = "quarenta",
                [50] = "cinquenta",
                [60] = "sessenta",
                [70] = "setenta",
                [80] = "oitenta",
                [90] = "noventa",
                [100] = "cem",
                [200] = "duzentos",
                [300] = "trezentos",
                [400] = "quatrocentos",
                [500] = "quinhentos",
                [600] = "seiscentos",
                [700] = "setecentos",
                [800] = "oitocentos",
                [900] = "novecentos",
                [1000] = "mil"
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
                    UseBaseExceptionWhenNoTrailingNumbers = true,
                    AndException = true,
                    Singular = "cento"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    AndException = true,
                    Singular = "mil"
                },
                new LanguageUnit
                {
                    Plural = "milhões",
                    Singular = "milhão"
                },
                new LanguageUnit
                {
                    Plural = "bilhões",
                    Singular = "bilhão"
                },
                new LanguageUnit
                {
                    Plural = "trilhões",
                    Singular = "trilhão"
                },
                new LanguageUnit
                {
                    Plural = "quadrilhão",
                    Singular = "quadrilhão"
                },
                new LanguageUnit
                {
                    Plural = "quintilhões",
                    Singular = "quintilhão"
                },
                new LanguageUnit
                {
                    Plural = "sextilhões",
                    Singular = "sextilhão"
                },
                new LanguageUnit
                {
                    Plural = "septilhões",
                    Singular = "septilhão"
                },
                new LanguageUnit
                {
                    Plural = "octilhões",
                    Singular = "octilhão"
                },
                new LanguageUnit
                {
                    Plural = "nonilhões",
                    Singular = "nonilhão"
                },
                new LanguageUnit
                {
                    Plural = "decilhões",
                    Singular = "decilhão"
                },
                new LanguageUnit
                {
                    Plural = "undecilhões",
                    Singular = "undecilhão"
                },
                new LanguageUnit
                {
                    Plural = "doudecilhões",
                    Singular = "doudecilhão"
                },
                new LanguageUnit
                {
                    Plural = "tredecilhões",
                    Singular = "tredecilhão"
                }
            })
        {
            UnitExceptions = new Dictionary<double, string>
            {
                [1] = "um"
            },
            AndWhenTrailing = true
        };
    }
}