using newtalents;

namespace newtalentstest;

public class UnitTest1
{
    public Calculadora Init()
    {
        return new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void SomaTest(int num, int num2, int resultadoEsperado)
    {
        var calc = Init();
        var result = calc.Soma(num, num2);

        Assert.Equal(resultadoEsperado, result);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void MultiplicarTest(int num, int num2, int resultadoEsperado)
    {
        var calc = Init();
        var result = calc.Multiplicacao(num, num2);

        Assert.Equal(resultadoEsperado, result);
    }

    [Theory]
    [InlineData(12, 2, 6)]
    [InlineData(5, 1, 5)]
    public void DivisaoTest(int num, int num2, int resultadoEsperado)
    {
        var calc = Init();
        var result = calc.Divisao(num, num2);

        Assert.Equal(resultadoEsperado, result);
    }

    [Fact]
    public void DivisaoPorZeroTest()
    {
        var calc = Init();
        Assert.Throws<DivideByZeroException>(() => calc.Divisao(3, 0));
    }

    [Theory]
    [InlineData(12, 2, 10)]
    [InlineData(5, 1, 4)]
    public void SubtracaoTest(int num, int num2, int resultadoEsperado)
    {
        var calc = Init();
        var result = calc.Subtracao(num, num2);

        Assert.Equal(resultadoEsperado, result);
    }

    [Fact]
    public void TestandoHistorico()
    {
        var calc = Init();

        calc.Soma(1,2);
        calc.Soma(3,2);
        calc.Soma(5,2);

        var lista = calc.Historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}