using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class ArabicLanguageTest
{
    private readonly Option _option;

    public ArabicLanguageTest()
    {
        _option = new Option
        {
            Lang = "ar"
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
        Assert.Equal("صفر", 0.123.WrittenNumber(_option));
        Assert.Equal("واحد", 0.8.WrittenNumber(_option));
        Assert.Equal("ثلاثة", 2.8.WrittenNumber(_option));
        Assert.Equal("", "asdf.8".WrittenNumber(_option));
        Assert.Equal("", "120391938123..".WrittenNumber(_option));
        Assert.Equal("", "1/3".WrittenNumber(_option));
        Assert.Equal("صفر", (1 / 3).WrittenNumber(_option));
        Assert.Equal("", "1/2".WrittenNumber(_option));
        Assert.Equal("", "1.123/2".WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("صفر", 0.WrittenNumber(_option));
        Assert.Equal("ثلاثة", 3.WrittenNumber(_option));
        Assert.Equal("ستة", 6.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("أحد عشر", 11.WrittenNumber(_option));
        Assert.Equal("ثلاثة عشر", 13.WrittenNumber(_option));
        Assert.Equal("تسعة عشر", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("عشرون", 20.WrittenNumber(_option));
        Assert.Equal("خمسة وعشرون", 25.WrittenNumber(_option));
        Assert.Equal("أربعون", 40.WrittenNumber(_option));
        Assert.Equal("ثمانية وثمانون", 88.WrittenNumber(_option));
        Assert.Equal("ثلاثة وسبعون", 73.WrittenNumber(_option));
        Assert.Equal("تسعة وتسعون", 99.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("مائتان", 200.WrittenNumber(_option));
        Assert.Equal("ثلاثمائة وعشرة", 310.WrittenNumber(_option));
        Assert.Equal("مائتان واثنان وأربعون", 242.WrittenNumber(_option));
        Assert.Equal("ألف ومائتان وأربعة وثلاثون", 1234.WrittenNumber(_option));
        Assert.Equal("ثلاثة آلاف", 3000.WrittenNumber(_option));
        Assert.Equal("أربعة آلاف وثلاثمائة وثلاثة وعشرون", 4323.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("عشرة آلاف", 10000.WrittenNumber(_option));
        Assert.Equal("أحد عشر ألف", 11000.WrittenNumber(_option));
        Assert.Equal("أربعة ملايين وثلاثمائة وثلاثة وعشرون ألف", 4323000.WrittenNumber(_option));
        Assert.Equal("أربعة ملايين وثلاثمائة وثلاثة وعشرون ألف وخمسة وخمسون", 4323055.WrittenNumber(_option));
        Assert.Equal("مليون وخمسمائة وسبعون ألف وخمسة وعشرون", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("مليار", "1000000000".WrittenNumber(_option));
        Assert.Equal("ملياران وخمسمائة وثمانون مليون", 2580000000.WrittenNumber(_option));
        Assert.Equal("تريليون", 1000000000000.WrittenNumber(_option));
        Assert.Equal("ثلاثة تريليون وستمائة وسبعة وعشرون مليار", 3627000000000.WrittenNumber(_option));
    }
}