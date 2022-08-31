namespace WrittenNumber.Models;

public static class ItalianLanguage
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: false,
            baseSeparator: "",
            unitSeparator: "",
            @base: new Dictionary<double, string>
            {
                [0] = "zero",
                [1] = "uno",
                [2] = "due",
                [3] = "tre",
                [4] = "quattro",
                [5] = "cinque",
                [6] = "sei",
                [7] = "sette",
                [8] = "otto",
                [9] = "nove",
                [10] = "dieci",
                [11] = "undici",
                [12] = "dodici",
                [13] = "tredici",
                [14] = "quattordici",
                [15] = "quindici",
                [16] = "sedici",
                [17] = "diciassette",
                [18] = "diciotto",
                [19] = "diciannove",
                [20] = "venti",
                [21] = "ventuno",
                [23] = "ventitré",
                [28] = "ventotto",
                [30] = "trenta",
                [31] = "trentuno",
                [33] = "trentatré",
                [38] = "trentotto",
                [40] = "quaranta",
                [41] = "quarantuno",
                [43] = "quaranta­tré",
                [48] = "quarantotto",
                [50] = "cinquanta",
                [51] = "cinquantuno",
                [53] = "cinquantatré",
                [58] = "cinquantotto",
                [60] = "sessanta",
                [61] = "sessantuno",
                [63] = "sessanta­tré",
                [68] = "sessantotto",
                [70] = "settanta",
                [71] = "settantuno",
                [73] = "settantatré",
                [78] = "settantotto",
                [80] = "ottanta",
                [81] = "ottantuno",
                [83] = "ottantatré",
                [88] = "ottantotto",
                [90] = "novanta",
                [91] = "novantuno",
                [93] = "novantatré",
                [98] = "novantotto",
                [100] = "cento",
                [101] = "centuno",
                [108] = "centootto",
                [180] = "centottanta",
                [201] = "duecentuno",
                [301] = "tre­cent­uno",
                [401] = "quattro­cent­uno",
                [501] = "cinque­cent­uno",
                [601] = "sei­cent­uno",
                [701] = "sette­cent­uno",
                [801] = "otto­cent­uno",
                [901] = "nove­cent­uno"
            },
            units: new List<object>
            {
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "cento"
                },
                new LanguageUnit
                {
                    Plural = "mila",
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "mille"
                },
                new LanguageUnit
                {
                    Plural = "milioni",
                    Singular = "milione"
                },
                new LanguageUnit
                {
                    Plural = "miliardi",
                    Singular = "miliardo"
                },
                new LanguageUnit
                {
                    Plural = "bilioni",
                    Singular = "bilione"
                },
                new LanguageUnit
                {
                    Plural = "biliardi",
                    Singular = "biliardo"
                },
                new LanguageUnit
                {
                    Plural = "trilioni",
                    Singular = "trilione"
                },
                new LanguageUnit
                {
                    Plural = "triliardi",
                    Singular = "triliardo"
                },
                new LanguageUnit
                {
                    Plural = "quadrilioni",
                    Singular = "quadrilione"
                },
                new LanguageUnit
                {
                    Plural = "quadriliardi",
                    Singular = "quadriliardo"
                }
            })
        {
            UnitExceptions = new Dictionary<double, string>
            {
                [1] = "un"
            },
            GeneralSeparator = "",
            WordSeparator = ""
        };
    }
}