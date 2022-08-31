using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class pt_PotugueseLanguageTest
{
    private readonly Option _option;

    public pt_PotugueseLanguageTest()
    {
        _option = new Option
        {
            Lang = "pt"
        };
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("três", 3.WrittenNumber(_option));
        Assert.Equal("oito", 8.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("treze", 13.WrittenNumber(_option));
        Assert.Equal("dezenove", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("vinte", 20.WrittenNumber(_option));
        Assert.Equal("vinte e cinco", 25.WrittenNumber(_option));
        Assert.Equal("oitenta e oito", 88.WrittenNumber(_option));
        Assert.Equal("setenta e três", 73.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("cento e quarenta e quatro", 144.WrittenNumber(_option));
        Assert.Equal("duzentos", 200.WrittenNumber(_option));
        Assert.Equal("mil duzentos e trinta e quatro", 1234.WrittenNumber(_option));
        Assert.Equal("quatro mil trezentos e vinte e três", 4323.WrittenNumber(_option));
        Assert.Equal("duzentos e quarenta e dois", 242.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("quatro milhões trezentos e vinte e três mil", 4323000.WrittenNumber(_option));
        Assert.Equal("quatro milhões trezentos e vinte e três mil e cinquenta e cinco", 4323055.WrittenNumber(_option));
        Assert.Equal("um milhão quinhentos e setenta mil e vinte e cinco", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("um bilhão", 1000000000.WrittenNumber(_option));
        Assert.Equal("dois bilhões quinhentos e oitenta milhões", 2580000000.WrittenNumber(_option));
        Assert.Equal("um quadrilhão", 1000000000000000.WrittenNumber(_option));
        Assert.Equal("três trilhões seiscentos e vinte e sete bilhões", 3627000000000.WrittenNumber(_option));
    }

    [Fact]
    public void Git_Issues()
    {
        Assert.Equal("catorze mil cento e um", 14101.WrittenNumber(_option));
        Assert.Equal("catorze mil duzentos e um", 14201.WrittenNumber(_option));
        Assert.Equal("um milhão e mil", 1001000.WrittenNumber(_option));
        Assert.Equal("um milhão mil e duzentos", 1001200.WrittenNumber(_option));
        Assert.Equal("catorze mil e duzentos", 14200.WrittenNumber(_option));
        Assert.Equal("catorze mil e cem", 14100.WrittenNumber(_option));
    }
}