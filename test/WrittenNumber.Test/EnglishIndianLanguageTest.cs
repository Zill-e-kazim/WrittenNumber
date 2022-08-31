using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class EnglishIndianLanguageTest
{
    private readonly Option _option;

    public EnglishIndianLanguageTest()
    {
        _option = new Option
        {
            Lang = "enIndian"
        };
    }

    [Fact]
    public void Doesnt_Blow_Up_Weirdly_With_Invalid_Input()
    {
        Assert.Equal("", "asdfasdfasdf".WrittenNumber(_option));
        Assert.Equal("", "0.as".WrittenNumber(_option));
        Assert.Equal("zero", 0.123.WrittenNumber(_option));
        Assert.Equal("one", 0.8.WrittenNumber(_option));
        Assert.Equal("three", 2.8.WrittenNumber(_option));
        Assert.Equal("", "asdf.8".WrittenNumber(_option));
        Assert.Equal("", "120391938123..".WrittenNumber(_option));
        Assert.Equal("one hundred crore", 1000000000.123.WrittenNumber(_option));
        Assert.Equal("", "1/3".WrittenNumber(_option));
        Assert.Equal("zero", (1 / 3).WrittenNumber(_option));
        Assert.Equal("", "1/2".WrittenNumber(_option));
        Assert.Equal("", "1.123/2".WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("one hundred crore", 1000000000.WrittenNumber(_option));
        Assert.Equal("three", 3.WrittenNumber(_option));
        Assert.Equal("eight", 8.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("thirteen", 13.WrittenNumber(_option));
        Assert.Equal("nineteen", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("twenty", 20.WrittenNumber(_option));
        Assert.Equal("twenty-five", 25.WrittenNumber(_option));
        Assert.Equal("eighty-eight", 88.WrittenNumber(_option));
        Assert.Equal("seventy-three", 73.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("two hundred", 200.WrittenNumber(_option));
        Assert.Equal("two hundred and forty-two", 242.WrittenNumber(_option));
        Assert.Equal("one thousand two hundred and thirty-four", 1234.WrittenNumber(_option));
        Assert.Equal("four thousand three hundred and twenty-three", 4323.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("forty-three lakh twenty-three thousand", 4323000.WrittenNumber(_option));
        Assert.Equal("forty-three lakh twenty-three thousand and fifty-five", 4323055.WrittenNumber(_option));
        Assert.Equal("fifteen lakh seventy thousand and twenty-five", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("one hundred crore", "1000000000".WrittenNumber(_option));
        Assert.Equal("two hundred fifty-eight crore", 2580000000.WrittenNumber(_option));
        Assert.Equal("one lakh crore", 1000000000000.WrittenNumber(_option));
        Assert.Equal("three lakh sixty-two thousand seven hundred crore", 3627000000000.WrittenNumber(_option));
    }
}