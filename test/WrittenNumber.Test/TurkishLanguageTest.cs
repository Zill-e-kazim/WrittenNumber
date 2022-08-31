using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class TurkishLanguageTest
{
    private readonly Option _option;

    public TurkishLanguageTest()
    {
        _option = new Option
        {
            Lang = "tr"
        };
    }

    [Fact]
    public void Doesnt_Blow_Up_Weirdly_With_Invalid_Input()
    {
        Assert.Equal("", "asdfasdfasdf".WrittenNumber(_option));
        Assert.Equal("", "0.as".WrittenNumber(_option));
        Assert.Equal("sıfır", 0.123.WrittenNumber(_option));
        Assert.Equal("bir", 0.8.WrittenNumber(_option));
        Assert.Equal("üç", 2.8.WrittenNumber(_option));
        Assert.Equal("", "asdf.8".WrittenNumber(_option));
        Assert.Equal("", "120391938123..".WrittenNumber(_option));
        Assert.Equal("", "1/3".WrittenNumber(_option));
        Assert.Equal("sıfır", (1 / 3).WrittenNumber(_option));
        Assert.Equal("", "1/2".WrittenNumber(_option));
        Assert.Equal("", "1.123/2".WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("sıfır", 0.WrittenNumber(_option));
        Assert.Equal("üç", 3.WrittenNumber(_option));
        Assert.Equal("altı", 6.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("on üç", 13.WrittenNumber(_option));
        Assert.Equal("on dokuz", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("yirmi", 20.WrittenNumber(_option));
        Assert.Equal("yirmi beş", 25.WrittenNumber(_option));
        Assert.Equal("kırk", 40.WrittenNumber(_option));
        Assert.Equal("seksen sekiz", 88.WrittenNumber(_option));
        Assert.Equal("yetmiş üç", 73.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("iki yüz", 200.WrittenNumber(_option));
        Assert.Equal("iki yüz kırk iki", 242.WrittenNumber(_option));
        Assert.Equal("bin iki yüz otuz dört", 1234.WrittenNumber(_option));
        Assert.Equal("dört bin üç yüz yirmi üç", 4323.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("dört milyon üç yüz yirmi üç bin", 4323000.WrittenNumber(_option));
        Assert.Equal("dört milyon üç yüz yirmi üç bin elli beş", 4323055.WrittenNumber(_option));
        Assert.Equal("bir milyon beş yüz yetmiş bin yirmi beş", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("bir milyar", "1000000000".WrittenNumber(_option));
        Assert.Equal("iki milyar beş yüz seksen milyon", 2580000000.WrittenNumber(_option));
        Assert.Equal("bir trilyon", 1000000000000.WrittenNumber(_option));
        Assert.Equal("üç trilyon altı yüz yirmi yedi milyar", 3627000000000.WrittenNumber(_option));
    }
}