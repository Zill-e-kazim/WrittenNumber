﻿namespace WrittenNumber.Models;

public static class IndonesianLanguage
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
                [0] = "nol",
                [1] = "satu",
                [2] = "dua",
                [3] = "tiga",
                [4] = "empat",
                [5] = "lima",
                [6] = "enam",
                [7] = "tujuh",
                [8] = "delapan",
                [9] = "sembilan",
                [10] = "sepuluh",
                [11] = "sebelas",
                [12] = "dua belas",
                [13] = "tiga belas",
                [14] = "empat belas",
                [15] = "lima belas",
                [16] = "enam belas",
                [17] = "tujuh belas",
                [18] = "delapan belas",
                [19] = "sembilan belas",
                [20] = "dua puluh",
                [30] = "tiga puluh",
                [40] = "empat puluh",
                [50] = "lima puluh",
                [60] = "enam puluh",
                [70] = "tujuh puluh",
                [80] = "delapan puluh",
                [90] = "sembilan puluh"
            },
            units: new List<object>
            {
                new LanguageUnit
                {
                    Plural = "ratus",
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "seratus"
                },
                new LanguageUnit
                {
                    Plural = "ribu",
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "seribu"
                },
                "juta",
                "miliar",
                "triliun",
                "kuadiliun"
            });
    }
}