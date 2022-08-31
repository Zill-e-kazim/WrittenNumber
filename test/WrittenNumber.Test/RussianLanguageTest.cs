using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class RussianLanguageTest
{
    private readonly Option _option;

    public RussianLanguageTest()
    {
        _option = new Option
        {
            Lang = "ru"
        };
    }

    [Fact]
    public void Negative_Numbers_Return()
    {
        Assert.Equal("", (-3).WrittenNumber(_option));
        Assert.Equal("", (-5).WrittenNumber(_option));
    }

    [Fact]
    public void Doesnt_Blow_Up_Weirdly_With_Invalid_Input()
    {
        Assert.Equal("", "asdfasdfasdf".WrittenNumber(_option));
        Assert.Equal("", "0.as".WrittenNumber(_option));
        Assert.Equal("ноль", 0.123.WrittenNumber(_option));
        Assert.Equal("один", 0.8.WrittenNumber(_option));
        Assert.Equal("три", 2.8.WrittenNumber(_option));
        Assert.Equal("", "asdf.8".WrittenNumber(_option));
        Assert.Equal("", "120391938123..".WrittenNumber(_option));
        Assert.Equal("один миллиард", 1000000000.123.WrittenNumber(_option));
        Assert.Equal("", "1/3".WrittenNumber(_option));
        Assert.Equal("ноль", (1 / 3).WrittenNumber(_option));
        Assert.Equal("", "1/2".WrittenNumber(_option));
        Assert.Equal("", "1.123/2".WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("один миллиард", 1000000000.WrittenNumber(_option));
        Assert.Equal("три", 3.WrittenNumber(_option));
        Assert.Equal("восемь", 8.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("тринадцать", 13.WrittenNumber(_option));
        Assert.Equal("девятнадцать", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("двадцать", 20.WrittenNumber(_option));
        Assert.Equal("двадцать пять", 25.WrittenNumber(_option));
        Assert.Equal("восемьдесят восемь", 88.WrittenNumber(_option));
        Assert.Equal("семьдесят три", 73.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("двести", 200.WrittenNumber(_option));
        Assert.Equal("двести сорок два", 242.WrittenNumber(_option));
        Assert.Equal("одна тысяча двести тридцать четыре", 1234.WrittenNumber(_option));
        Assert.Equal("четыре тысячи триста двадцать три", 4323.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("четыре миллиона триста двадцать три тысячи", 4323000.WrittenNumber(_option));
        Assert.Equal("четыре миллиона триста двадцать три тысячи пятьдесят пять", 4323055.WrittenNumber(_option));
        Assert.Equal("один миллион пятьсот семьдесят тысяч двадцать пять", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("один миллиард", "1000000000".WrittenNumber(_option));
        Assert.Equal("два миллиарда пятьсот восемьдесят миллионов", 2580000000.WrittenNumber(_option));
        Assert.Equal("один триллион", 1000000000000.WrittenNumber(_option));
        Assert.Equal("три триллиона шестьсот двадцать семь миллиардов", 3627000000000.WrittenNumber(_option));
    }
}