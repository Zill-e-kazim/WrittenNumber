namespace WrittenNumber.Models;

public class Language
{
    public Language(
        bool useLongScale,
        string baseSeparator,
        string unitSeparator,
        Dictionary<double, string> @base,
        object units,
        Dictionary<string, Dictionary<double, string>>? alternativeBase)
    {
        UseLongScale = useLongScale;
        BaseSeparator = baseSeparator;
        UnitSeparator = unitSeparator;
        Base = @base;
        Units = units;
        AlternativeBase = alternativeBase;
    }

    public bool? AndException { get; set; }
    public bool UseLongScale { get; }
    public bool? AndWhenTrailing { get; set; }
    public string BaseSeparator { get; }
    public string UnitSeparator { get; }
    public string? AllSeparator { get; set; }
    public Dictionary<double, string> Base { get; }
    public object Units { get; }
    public Dictionary<double, string>? UnitExceptions { get; set; }
    public Dictionary<string, Dictionary<double, string>>? AlternativeBase { get; set; }
    public string? GeneralSeparator { get; set; }
    public string? WordSeparator { get; set; }
}