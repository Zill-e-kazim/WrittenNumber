using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class AzerbaijaniLanguageTest
{
    private readonly Option _option;

    public AzerbaijaniLanguageTest()
    {
        _option = new Option
        {
            Lang = "az"
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
        Assert.Equal("on doqquz", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("iyirmi", 20.WrittenNumber(_option));
        Assert.Equal("iyirmi beş", 25.WrittenNumber(_option));
        Assert.Equal("qırx", 40.WrittenNumber(_option));
        Assert.Equal("səksən səkkiz", 88.WrittenNumber(_option));
        Assert.Equal("yetmiş üç", 73.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("iki yüz", 200.WrittenNumber(_option));
        Assert.Equal("iki yüz qırx iki", 242.WrittenNumber(_option));
        Assert.Equal("min iki yüz otuz dörd", 1234.WrittenNumber(_option));
        Assert.Equal("dörd min üç yüz iyirmi üç", 4323.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("dörd milyon üç yüz iyirmi üç min", 4323000.WrittenNumber(_option));
        Assert.Equal("dörd milyon üç yüz iyirmi üç min əlli beş", 4323055.WrittenNumber(_option));
        Assert.Equal("bir milyon beş yüz yetmiş min iyirmi beş", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("bir milyard", "1000000000".WrittenNumber(_option));
        Assert.Equal("iki milyard beş yüz səksən milyon", 2580000000.WrittenNumber(_option));
        Assert.Equal("bir trilyon", 1000000000000.WrittenNumber(_option));
        Assert.Equal("üç trilyon altı yüz iyirmi yeddi milyard", 3627000000000.WrittenNumber(_option));
    }
}