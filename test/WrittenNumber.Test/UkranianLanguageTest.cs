using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class UkranianLanguageTest
{
    private readonly Option _option;

    public UkranianLanguageTest()
    {
        _option = new Option
        {
            Lang = "uk"
        };
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_10()
    {
        Assert.Equal("нуль", 0.WrittenNumber(_option));
        Assert.Equal("один", 1.WrittenNumber(_option));
        Assert.Equal("два", 2.WrittenNumber(_option));
        Assert.Equal("три", 3.WrittenNumber(_option));
        Assert.Equal("дев’ять", 9.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_20()
    {
        Assert.Equal("одинадцять", 11.WrittenNumber(_option));
        Assert.Equal("тринадцять", 13.WrittenNumber(_option));
        Assert.Equal("дев’ятнадцять", 19.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_100()
    {
        Assert.Equal("двадцять", 20.WrittenNumber(_option));
        Assert.Equal("двадцять один", 21.WrittenNumber(_option));
        Assert.Equal("двадцять п’ять", 25.WrittenNumber(_option));
        Assert.Equal("сімдесят три", 73.WrittenNumber(_option));
        Assert.Equal("вісімдесят", 80.WrittenNumber(_option));
        Assert.Equal("вісімдесят вісім", 88.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Less_Than_1000()
    {
        Assert.Equal("сто", 100.WrittenNumber(_option));
        Assert.Equal("сто один", 101.WrittenNumber(_option));
        Assert.Equal("сто десять", 110.WrittenNumber(_option));
        Assert.Equal("сто одинадцять", 111.WrittenNumber(_option));
        Assert.Equal("сто сорок шість", 146.WrittenNumber(_option));
        Assert.Equal("двісті", 200.WrittenNumber(_option));
        Assert.Equal("двісті сорок два", 242.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000()
    {
        Assert.Equal("одна тисяча", 1000.WrittenNumber(_option));
        Assert.Equal("дві тисячі", 2000.WrittenNumber(_option));
        Assert.Equal("три тисячі", 3000.WrittenNumber(_option));
        Assert.Equal("чотири тисячі", 4000.WrittenNumber(_option));
        Assert.Equal("п’ять тисяч", 5000.WrittenNumber(_option));
        Assert.Equal("одна тисяча двісті тридцять чотири", 1234.WrittenNumber(_option));
        Assert.Equal("чотири тисячі триста двадцять три", 4323.WrittenNumber(_option));
        Assert.Equal("один мільйон", 1000000.WrittenNumber(_option));
        Assert.Equal("два мільйони", 2000000.WrittenNumber(_option));
        Assert.Equal("два мільйони один", 2000001.WrittenNumber(_option));
        Assert.Equal("п’ять мільйонів", 5000000.WrittenNumber(_option));
        Assert.Equal("двадцять один мільйон", 21000000.WrittenNumber(_option));
        Assert.Equal("сто одинадцять мільйонів", 111000000.WrittenNumber(_option));
        Assert.Equal("двісті чотирнадцять мільйонів п’ятсот шістдесят сім тисяч вісімсот дев’яносто один",
            214567891.WrittenNumber(_option));
    }

    [Fact]
    public void Correctly_Converts_Numbers_Greater_Than_1000000000()
    {
        Assert.Equal("один мільярд", 1000000000.WrittenNumber(_option));
        Assert.Equal("два мільярди п’ятсот вісімдесят мільйонів", 2580000000.WrittenNumber(_option));
        Assert.Equal("один трильйон", 1000000000000.WrittenNumber(_option));
        Assert.Equal("три трильйони шістсот двадцять сім мільярдів", 3627000000000.WrittenNumber(_option));
    }
}