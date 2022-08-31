using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class IndoneisanLanguageTest
{
    private readonly Option _option;

    public IndoneisanLanguageTest()
    {
        _option = new Option
        {
            Lang = "id"
        };
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("satu", 1.WrittenNumber(_option));
        Assert.Equal("tiga", 3.WrittenNumber(_option));
        Assert.Equal("delapan", 8.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("sebelas", 11.WrittenNumber(_option));
        Assert.Equal("tiga belas", 13.WrittenNumber(_option));
        Assert.Equal("sembilan belas", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("dua puluh", 20.WrittenNumber(_option));
        Assert.Equal("dua puluh lima", 25.WrittenNumber(_option));
        Assert.Equal("delapan puluh delapan", 88.WrittenNumber(_option));
        Assert.Equal("tujuh puluh tiga", 73.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("seratus empat puluh empat", 144.WrittenNumber(_option));
        Assert.Equal("dua ratus", 200.WrittenNumber(_option));
        Assert.Equal("dua ratus empat puluh dua", 242.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("seribu seratus sebelas", 1111.WrittenNumber(_option));
        Assert.Equal("seribu dua ratus tiga puluh empat", 1234.WrittenNumber(_option));
        Assert.Equal("seratus sebelas ribu dua ratus tiga puluh empat", 111234.WrittenNumber(_option));
        Assert.Equal("empat ratus tiga puluh dua ribu lima puluh lima", 432055.WrittenNumber(_option));
        Assert.Equal("satu juta seratus sebelas ribu dua ratus tiga puluh empat", 1111234.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("satu miliar", "1000000000".WrittenNumber(_option));
        Assert.Equal("dua miliar lima ratus delapan puluh juta", 2580000000.WrittenNumber(_option));
        Assert.Equal("satu triliun", 1000000000000.WrittenNumber(_option));
        Assert.Equal("tiga triliun enam ratus dua puluh tujuh miliar", 3627000000000.WrittenNumber(_option));
    }
}