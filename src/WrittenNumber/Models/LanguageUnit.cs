namespace WrittenNumber.Models;

public class LanguageUnit
{
    public string? Singular { get; set; }
    public bool? UseBaseInstead { get; set; }
    public List<double>? UseBaseException { get; set; }
    public string? Dual { get; set; }
    public string? Plural { get; set; }
    public bool? RestrictedPlural { get; set; }
    public List<double>? AvoidPrefixException { get; set; }
    public bool? UseBaseExceptionWhenNoTrailingNumbers { get; set; }
    public List<double>? AvoidEndingRules { get; set; }
    public bool? UseFewEnding { get; set; }
    public bool? UseSingularEnding { get; set; }
    public string? Few { get; set; }
    public bool? AvoidInNumberPlural { get; set; }
    public bool? AndException { get; set; }
    public List<double>? UsePrefixException { get; set; }
    public string? UseAlternativeBase { get; set; }
}