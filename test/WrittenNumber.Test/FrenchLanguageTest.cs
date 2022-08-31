using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class FrenchLanguageTest
{
    private readonly Option _option;

    public FrenchLanguageTest()
    {
        _option = new Option
        {
            Lang = "fr"
        };
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("zéro", 0.WrittenNumber(_option));
        Assert.Equal("trois", 3.WrittenNumber(_option));
        Assert.Equal("huit", 8.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("treize", 13.WrittenNumber(_option));
        Assert.Equal("dix-neuf", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("vingt", 20.WrittenNumber(_option));
        Assert.Equal("vingt-cinq", 25.WrittenNumber(_option));
        Assert.Equal("soixante-treize", 73.WrittenNumber(_option));
        Assert.Equal("quatre-vingts", 80.WrittenNumber(_option));
        Assert.Equal("quatre-vingt-huit", 88.WrittenNumber(_option));
        Assert.Equal("quatre-vingt-dix", 90.WrittenNumber(_option));
        Assert.Equal("quatre-vingt-onze", 91.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("cent", 100.WrittenNumber(_option));
        Assert.Equal("cent dix", 110.WrittenNumber(_option));
        Assert.Equal("deux cents", 200.WrittenNumber(_option));
        Assert.Equal("deux cent quarante-deux", 242.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("mille deux cent trente-quatre", 1234.WrittenNumber(_option));
        Assert.Equal("quatre mille", 4000.WrittenNumber(_option));
        Assert.Equal("quatre mille trois cent vingt-trois", 4323.WrittenNumber(_option));
        Assert.Equal("un million", 1000000.WrittenNumber(_option));
        Assert.Equal("deux millions", 2000000.WrittenNumber(_option));
        Assert.Equal("deux millions un", 2000001.WrittenNumber(_option));
        Assert.Equal("quatre millions trois cent vingt-trois mille", 4323000.WrittenNumber(_option));
        Assert.Equal("quatre millions trois cent vingt-trois mille cinquante-cinq", 4323055.WrittenNumber(_option));
        Assert.Equal("un million cinq cent soixante-dix mille vingt-cinq", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("un milliard", 1000000000.WrittenNumber(_option));
        Assert.Equal("deux milliards cinq cent quatre-vingts millions", 2580000000.WrittenNumber(_option));
        Assert.Equal("un billion", "1000000000000".WrittenNumber(_option));
        Assert.Equal("trois billions six cent vingt-sept milliards", 3627000000000.WrittenNumber(_option));
    }
}