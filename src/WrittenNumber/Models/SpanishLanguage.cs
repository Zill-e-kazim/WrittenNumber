namespace WrittenNumber.Models;

public static class SpanishLanguage
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: true,
            baseSeparator: " y ",
            unitSeparator: "",
            @base: new Dictionary<double, string>
            {
                [0] = "cero",
                [1] = "uno",
                [2] = "dos",
                [3] = "tres",
                [4] = "cuatro",
                [5] = "cinco",
                [6] = "seis",
                [7] = "siete",
                [8] = "ocho",
                [9] = "nueve",
                [10] = "diez",
                [11] = "once",
                [12] = "doce",
                [13] = "trece",
                [14] = "catorce",
                [15] = "quince",
                [16] = "dieciséis",
                [17] = "diecisiete",
                [18] = "dieciocho",
                [19] = "diecinueve",
                [20] = "veinte",
                [21] = "veintiuno",
                [22] = "veintidós",
                [23] = "veintitrés",
                [24] = "veinticuatro",
                [25] = "veinticinco",
                [26] = "veintiséis",
                [27] = "veintisiete",
                [28] = "veintiocho",
                [29] = "veintinueve",
                [30] = "treinta",
                [40] = "cuarenta",
                [50] = "cincuenta",
                [60] = "sesenta",
                [70] = "setenta",
                [80] = "ochenta",
                [90] = "noventa",
                [100] = "cien",
                [200] = "doscientos",
                [300] = "trescientos",
                [400] = "cuatrocientos",
                [500] = "quinientos",
                [600] = "seiscientos",
                [700] = "setecientos",
                [800] = "ochocientos",
                [900] = "novecientos",
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
                    Singular = "ciento"
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
                    Plural = "millones",
                    Singular = "millón"
                },
                new LanguageUnit
                {
                    Plural = "billones",
                    Singular = "billón"
                },
                new LanguageUnit
                {
                    Plural = "trillones",
                    Singular = "trillón"
                },
                new LanguageUnit
                {
                    Plural = "cuatrillones",
                    Singular = "cuatrillón"
                },
                new LanguageUnit
                {
                    Plural = "quintillones",
                    Singular = "quintillón"
                },
                new LanguageUnit
                {
                    Plural = "sextillones",
                    Singular = "sextillón"
                },
                new LanguageUnit
                {
                    Plural = "septillones",
                    Singular = "septillón"
                },
                new LanguageUnit
                {
                    Plural = "octillones",
                    Singular = "octillón"
                },
                new LanguageUnit
                {
                    Plural = "nonillones",
                    Singular = "nonillón"
                },
                new LanguageUnit
                {
                    Plural = "decillones",
                    Singular = "decillón"
                },
                new LanguageUnit
                {
                    Plural = "undecillones",
                    Singular = "undecillón"
                },
                new LanguageUnit
                {
                    Plural = "duodecillones",
                    Singular = "duodecillón"
                },
                new LanguageUnit
                {
                    Plural = "tredecillones",
                    Singular = "tredecillón"
                },
                new LanguageUnit
                {
                    Plural = "cuatrodecillones",
                    Singular = "cuatrodecillón"
                },
                new LanguageUnit
                {
                    Plural = "quindecillones",
                    Singular = "quindecillón"
                }
            })
        {
            UnitExceptions = new Dictionary<double, string>
            {
                [1000000] = "un millón",
                [1000000000000] = "un billón",
                [1000000000000000000] = "un trillón",
                [1000000000000000000000000d] = "un cuatrillones",
                [1000000000000000000000000000000d] = "un quintillón",
                [1000000000000000000000000000000000000d] = "un sextillón",
                [1000000000000000000000000000000000000000000d] = "un septillón ",
                [1000000000000000000000000000000000000000000000000d] = "un octillón",
                [1000000000000000000000000000000000000000000000000000000d] = "un nonillón",
                [1000000000000000000000000000000000000000000000000000000000000d] = "un decillón",
                [1000000000000000000000000000000000000000000000000000000000000000000d] = "un undecillón",
                [1000000000000000000000000000000000000000000000000000000000000000000000000d] = "un duodecillón",
                [1000000000000000000000000000000000000000000000000000000000000000000000000000000d] = "un tredecillón",
                [1000000000000000000000000000000000000000000000000000000000000000000000000000000000000d] =
                    "un cuatordecillón",
                [1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000d] =
                    "un quindecillón"
            }
        };
    }
}