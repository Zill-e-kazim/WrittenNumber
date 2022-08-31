using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class SpanishLanguageTest
{
    private readonly Option _option;

    public SpanishLanguageTest()
    {
        _option = new Option
        {
            Lang = "es"
        };
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("uno", 1.WrittenNumber(_option));
        Assert.Equal("tres", 3.WrittenNumber(_option));
        Assert.Equal("ocho", 8.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("trece", 13.WrittenNumber(_option));
        Assert.Equal("dieciséis", 16.WrittenNumber(_option));
        Assert.Equal("diecinueve", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("veinte", 20.WrittenNumber(_option));
        Assert.Equal("veinticinco", 25.WrittenNumber(_option));
        Assert.Equal("ochenta y ocho", 88.WrittenNumber(_option));
        Assert.Equal("setenta y tres", 73.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("ciento cuarenta y cuatro", 144.WrittenNumber(_option));
        Assert.Equal("doscientos", 200.WrittenNumber(_option));
        Assert.Equal("mil doscientos treinta y cuatro", 1234.WrittenNumber(_option));
        Assert.Equal("cuatro mil trescientos veintitrés", 4323.WrittenNumber(_option));
        Assert.Equal("doscientos cuarenta y dos", 242.WrittenNumber(_option));
        Assert.Equal("dos mil cien", 2100.WrittenNumber(_option));
        Assert.Equal("mil cien", 1100.WrittenNumber(_option));
        Assert.Equal("mil ciento uno", 1101.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("cuatro millones trescientos veintitrés mil", 4323000.WrittenNumber(_option));
        Assert.Equal("cuatro millones trescientos veintitrés mil cincuenta y cinco", 4323055.WrittenNumber(_option));
        Assert.Equal("uno millón quinientos setenta mil veinticinco", 1570025.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("mil millones", 1000000000.WrittenNumber(_option));
        Assert.Equal("dos mil quinientos ochenta millones", 2580000000.WrittenNumber(_option));
        Assert.Equal("un billón", 1000000000000.WrittenNumber(_option));
        Assert.Equal("tres billones seiscientos veintisiete mil millones", 3627000000000.WrittenNumber(_option));
    }
}