namespace WrittenNumber.Models;

public static class FrenchLanguage
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: false,
            baseSeparator: "-",
            unitSeparator: "",
            @base: new Dictionary<double, string>
            {
                [0] = "zéro",
                [1] = "un",
                [2] = "deux",
                [3] = "trois",
                [4] = "quatre",
                [5] = "cinq",
                [6] = "six",
                [7] = "sept",
                [8] = "huit",
                [9] = "neuf",
                [10] = "dix",
                [11] = "onze",
                [12] = "douze",
                [13] = "treize",
                [14] = "quatorze",
                [15] = "quinze",
                [16] = "seize",
                [17] = "dix-sept",
                [18] = "dix-huit",
                [19] = "dix-neuf",
                [20] = "vingt",
                [30] = "trente",
                [40] = "quarante",
                [50] = "cinquante",
                [60] = "soixante",
                [70] = "soixante-dix",
                [80] = "quatre-vingt",
                [90] = "quatre-vingt-dix"
            },
            units: new List<object>
            {
                new LanguageUnit
                {
                    Plural = "cents",
                    AvoidInNumberPlural = true,
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "cent"
                },
                new LanguageUnit
                {
                    UseBaseException = new List<double>
                    {
                        1
                    },
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "mille"
                },
                new LanguageUnit
                {
                    Plural = "millions",
                    Singular = "million"
                },
                new LanguageUnit
                {
                    Plural = "milliards",
                    Singular = "milliard"
                },
                new LanguageUnit
                {
                    Plural = "billions",
                    Singular = "billion"
                },
                new LanguageUnit
                {
                    Plural = "billiards",
                    Singular = "billiard"
                },
                new LanguageUnit
                {
                    Plural = "trillions",
                    Singular = "trillion"
                },
                new LanguageUnit
                {
                    Plural = "trilliards",
                    Singular = "trilliard"
                },
                new LanguageUnit
                {
                    Plural = "quadrillions",
                    Singular = "quadrillion"
                },
                new LanguageUnit
                {
                    Plural = "quadrilliards",
                    Singular = "quadrilliard"
                },
                new LanguageUnit
                {
                    Plural = "quintillions",
                    Singular = "quintillion"
                },
                new LanguageUnit
                {
                    Plural = "quintilliards",
                    Singular = "quintilliard"
                },
                new LanguageUnit
                {
                    Plural = "sextillions",
                    Singular = "sextillion"
                },
                new LanguageUnit
                {
                    Plural = "sextilliards",
                    Singular = "sextilliard"
                },
                new LanguageUnit
                {
                    Plural = "septillions",
                    Singular = "septillion"
                },
                new LanguageUnit
                {
                    Plural = "septilliards",
                    Singular = "septilliard"
                },
                new LanguageUnit
                {
                    Plural = "octillions",
                    Singular = "octillion"
                }
            })
        {
            UnitExceptions = new Dictionary<double, string>
            {
                [21] = "vingt et un",
                [31] = "trente et un",
                [41] = "quarante et un",
                [51] = "cinquante et un",
                [61] = "soixante et un",
                [71] = "soixante et onze",
                [72] = "soixante-douze",
                [73] = "soixante-treize",
                [74] = "soixante-quatorze",
                [75] = "soixante-quinze",
                [76] = "soixante-seize",
                [77] = "soixante-dix-sept",
                [78] = "soixante-dix-huit",
                [79] = "soixante-dix-neuf",
                [80] = "quatre-vingts",
                [91] = "quatre-vingt-onze",
                [92] = "quatre-vingt-douze",
                [93] = "quatre-vingt-treize",
                [94] = "quatre-vingt-quatorze",
                [95] = "quatre-vingt-quinze",
                [96] = "quatre-vingt-seize",
                [97] = "quatre-vingt-dix-sept",
                [98] = "quatre-vingt-dix-huit",
                [99] = "quatre-vingt-dix-neuf"
            }
        };
    }
}