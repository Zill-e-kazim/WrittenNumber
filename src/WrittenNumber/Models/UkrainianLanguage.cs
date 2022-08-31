namespace WrittenNumber.Models;

public static class UkrainianLanguage
{
    public static Language Get()
    {
        return new Language(
            false,
            " ",
            "",
            new Dictionary<double, string>
            {
                [0] = "нуль",
                [1] = "один",
                [2] = "два",
                [3] = "три",
                [4] = "чотири",
                [5] = "п’ять",
                [6] = "шість",
                [7] = "сім",
                [8] = "вісім",
                [9] = "дев’ять",
                [10] = "десять",
                [11] = "одинадцять",
                [12] = "дванадцять",
                [13] = "тринадцять",
                [14] = "чотирнадцять",
                [15] = "п’ятнадцять",
                [16] = "шістнадцять",
                [17] = "сімнадцять",
                [18] = "вісімнадцять",
                [19] = "дев’ятнадцять",
                [20] = "двадцять",
                [30] = "тридцять",
                [40] = "сорок",
                [50] = "п’ятдесят",
                [60] = "шістдесят",
                [70] = "сімдесят",
                [80] = "вісімдесят",
                [90] = "дев’яносто",
                [100] = "сто",
                [200] = "двісті",
                [300] = "триста",
                [400] = "чотириста",
                [500] = "п’ятсот",
                [600] = "шістсот",
                [700] = "сімсот",
                [800] = "вісімсот",
                [900] = "дев’ятсот"
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
                    Few = "тисячі",
                    Plural = "тисяч",
                    UseAlternativeBase = "feminine",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "тисяча"
                },
                new LanguageUnit
                {
                    Few = "мільйони",
                    Plural = "мільйонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "мільйон"
                },
                new LanguageUnit
                {
                    Few = "мільярди",
                    Plural = "мільярдів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "мільярд"
                },
                new LanguageUnit
                {
                    Few = "трильйони",
                    Plural = "трильйонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "трильйон"
                },
                new LanguageUnit
                {
                    Few = "квадрильйони",
                    Plural = "квадрильйонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "квадрильйон"
                },
                new LanguageUnit
                {
                    Few = "квінтильйони",
                    Plural = "квінтильйонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "квінтильйон"
                },
                new LanguageUnit
                {
                    Few = "секстильйони",
                    Plural = "секстильйонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "секстильйон"
                },
                new LanguageUnit
                {
                    Few = "септілліони",
                    Plural = "септілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "септілліон"
                },
                new LanguageUnit
                {
                    Few = "октілліони",
                    Plural = "октілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "октілліон"
                },
                new LanguageUnit
                {
                    Few = "нонілліони",
                    Plural = "нонілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "нонілліон"
                },
                new LanguageUnit
                {
                    Few = "децілліони",
                    Plural = "децілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "децілліон"
                },
                new LanguageUnit
                {
                    Few = "ундецілліони",
                    Plural = "ундецілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "ундецілліон"
                },
                new LanguageUnit
                {
                    Few = "дуодецілліони",
                    Plural = "дуодецілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "дуодецілліон"
                },
                new LanguageUnit
                {
                    Few = "тредецілліони",
                    Plural = "тредецілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "тредецілліон"
                },
                new LanguageUnit
                {
                    Few = "кватуордецілліони",
                    Plural = "кватуордецілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "кватуордецілліон"
                },
                new LanguageUnit
                {
                    Few = "квіндецілліони",
                    Plural = "квіндецілліонів",
                    UseSingularEnding = true,
                    UseFewEnding = true,
                    AvoidEndingRules = new List<double>
                    {
                        11, 12, 13, 14, 111, 112, 113, 114, 211, 212, 213, 214, 311, 312, 313, 314, 411, 412, 413, 414,
                        511, 512, 513, 514, 611, 612, 613, 614, 711, 712, 713, 714, 811, 812, 813, 814, 911, 912, 913,
                        914
                    },
                    Singular = "квіндецілліон"
                }
            });
    }
}