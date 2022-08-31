namespace WrittenNumber.Models;

public static class RussianLanguage
{
    public static Language Get()
    {
        return new Language(
            false,
            " ",
            "",
            new Dictionary<double, string>
            {
                [0] = "ноль",
                [1] = "один",
                [2] = "два",
                [3] = "три",
                [4] = "четыре",
                [5] = "пять",
                [6] = "шесть",
                [7] = "семь",
                [8] = "восемь",
                [9] = "девять",
                [10] = "десять",
                [11] = "одинадцать",
                [12] = "двенадцать",
                [13] = "тринадцать",
                [14] = "четырнадцать",
                [15] = "пятнадцать",
                [16] = "шестнадцать",
                [17] = "семнадцать",
                [18] = "восемнадцать",
                [19] = "девятнадцать",
                [20] = "двадцать",
                [30] = "тридцать",
                [40] = "сорок",
                [50] = "пятьдесят",
                [60] = "шестьдесят",
                [70] = "семьдесят",
                [80] = "восемьдесят",
                [90] = "девяносто",
                [100] = "сто",
                [200] = "двести",
                [300] = "триста",
                [400] = "четыреста",
                [500] = "пятьсот",
                [600] = "шестьсот",
                [700] = "семьсот",
                [800] = "восемьсот",
                [900] = "девятьсот"
            },
            alternativeBase: new Dictionary<string, Dictionary<double, string>>
            {
                ["feminine"] = new()
                {
                    [1] = "одна",
                    [2] = "дві"
                }
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
                    Few = "тысячи",
                    Plural = "тысяч",
                    UseAlternativeBase = "feminine",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "тысяча"
                },
                new LanguageUnit
                {
                    Few = "миллиона",
                    Plural = "миллионов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "миллион"
                },
                new LanguageUnit
                {
                    Few = "миллиарда",
                    Plural = "миллиардов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "миллиард"
                },
                new LanguageUnit
                {
                    Few = "триллиона",
                    Plural = "триллионов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "триллион"
                },
                new LanguageUnit
                {
                    Few = "квадриллион",
                    Plural = "квадрилон",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "квадрильон"
                },
                new LanguageUnit
                {
                    Few = "секстильона",
                    Plural = "секстиллионов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "секстиллионов"
                },
                new LanguageUnit
                {
                    Few = "септиллиона",
                    Plural = "септиллионов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "септиллион"
                },
                new LanguageUnit
                {
                    Few = "октиллиона",
                    Plural = "октиллионов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "октиллион"
                },
                new LanguageUnit
                {
                    Few = "нониллиона",
                    Plural = "нониллионов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "нониллион"
                },
                new LanguageUnit
                {
                    Few = "дециллиона",
                    Plural = "дециллионов",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "дециллион"
                },
                new LanguageUnit
                {
                    Few = "ундециллиона",
                    Plural = "ундециллионив",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "ундециллион"
                },
                new LanguageUnit
                {
                    Few = "дуодециллиона",
                    Plural = "дуодециллионив",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "дуодециллион"
                },
                new LanguageUnit
                {
                    Few = "тредециллиона",
                    Plural = "тредециллионив",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "тредециллион"
                },
                new LanguageUnit
                {
                    Few = "кватуордециллиона",
                    Plural = "кватуордециллионив",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "кватуордециллион"
                },
                new LanguageUnit
                {
                    Few = "квиндециллиона",
                    Plural = "квиндециллионив",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "квиндециллион"
                }
            })
        {
            UnitExceptions = new Dictionary<double, string>()
        };
    }
}