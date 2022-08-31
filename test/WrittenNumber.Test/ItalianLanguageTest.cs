using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class ItalianLanguageTest
{
    private readonly Option _option;

    public ItalianLanguageTest()
    {
        _option = new Option
        {
            Lang = "it"
        };
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("tre", 3.WrittenNumber(_option));
        Assert.Equal("otto", 8.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("tredici", 13.WrittenNumber(_option));
        Assert.Equal("diciannove", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("venti", 20.WrittenNumber(_option));
        Assert.Equal("ventitré", 23.WrittenNumber(_option));
        Assert.Equal("settantatré", 73.WrittenNumber(_option));
        Assert.Equal("ottanta", 80.WrittenNumber(_option));
        Assert.Equal("ottantotto", 88.WrittenNumber(_option));
        Assert.Equal("novanta", 90.WrittenNumber(_option));
        Assert.Equal("novantuno", 91.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("cento", 100.WrittenNumber(_option));
        Assert.Equal("centuno", 101.WrittenNumber(_option));
        Assert.Equal("duecentuno", 201.WrittenNumber(_option));
        Assert.Equal("due cento quarantadue", 242.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("mille due cento trentaquattro", "1234".WrittenNumber(_option));
        Assert.Equal("quattro mila", "4000".WrittenNumber(_option));
        Assert.Equal("quattro mila tre cento ventitré", "4323".WrittenNumber(_option));
        Assert.Equal("un milione", "1000000".WrittenNumber(_option));
        Assert.Equal("due milioni", "2000000".WrittenNumber(_option));
        Assert.Equal("due milioni un", "2000001".WrittenNumber(_option));
        Assert.Equal("quattro milioni tre cento ventitré mila", "4323000".WrittenNumber(_option));
        Assert.Equal("quattro milioni tre cento ventitré mila cinquantacinque", "4323055".WrittenNumber(_option));
        Assert.Equal("un milione cinque cento settanta mila venticinque", "1570025".WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("un miliardo", "1000000000".WrittenNumber(_option));
        Assert.Equal("due miliardi cinque cento ottanta milioni", "2580000000".WrittenNumber(_option));
        Assert.Equal("un bilione", "1000000000000".WrittenNumber(_option));
        Assert.Equal("tre bilioni sei cento ventisette miliardi", "3627000000000".WrittenNumber(_option));
    }
}