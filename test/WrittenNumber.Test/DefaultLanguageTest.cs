using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class DefaultLanguageTest
{
    private readonly Option _option;

    public DefaultLanguageTest()
    {
        _option = new Option
        {
            Lang = "zzz"
        };
    }

    [Fact]
    public void Defaults_To_English_On_Wrong_Language()
    {
        Assert.Equal("one", 1.WrittenNumber(_option));
    }
}