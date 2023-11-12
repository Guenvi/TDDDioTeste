using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calc;

    public CalculadoraImplementacao construirClasse()
    {
        string data = "12/11/2023";
        CalculadoraImplementacao calc = new CalculadoraImplementacao(data);

        return calc;
    }

    //  public CalculadoraTests()
    // {
    //     _calc = new CalculadoraImplementacao(data);
    // }
    
    // [Fact]
    // public void DeveSomar5Com10Retornar15()
    // {
    //     // Arrange - Montar o cenário
    //     int num1 = 5;
    //     int num2 = 10;

    //     // Act - Execução da ação
    //     int resultado = _calc.Somar(num1, num2);

    //     // Assert - Validação do teste
    //     Assert.Equal(15, resultado);
    // }
    //  [Fact]
    // public void DeveSomar5Com10Retornar20()
    // {
    //     // Arrange - Montar o cenário
    //     int num1 = 10;
    //     int num2 = 10;

    //     // Act - Execução da ação
    //     int resultado = _calc.Somar(num1, num2);

    //     // Assert - Validação do teste
    //     Assert.Equal(20, resultado);
    // }

    // [Fact]
    // public void DeveVerifgicar4Par()
    // {
    //     //Arrange
    //     int numero =4;

    //     //Act
    //     bool resultado = _calc.EhPar(numero);
        
    //     // Assert
    //     Assert.True(resultado);
    // }

    // [Theory]
    // [InlineData(new int[ ] { 2, 4, 6, 8, 10})]

    // public void VerificarNumerosPares(int[ ] numeros)
    // {
    //     //Act
    //     Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    // }

    // [Theory]
    // [InlineData(1, 2, 3)]
    // public void TestSomar(int val1, int val2, int resultado)
    // {       
    //     // Act
    //     CalculadoraImplementacao calc = construirClasse();
    //     int resultadoCalculadora = calc.Somar(val1, val2);

    //     // Assert
    //     Assert.Equal(resultado, resultadoCalculadora);
    // }

    [Theory]
    [InlineData(2, 1, 1)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {       
        // Act
        CalculadoraImplementacao calc = construirClasse();
        int resultadoCalculadora = calc.Subtrair(val1, val2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {       
        // Act
        CalculadoraImplementacao calc = construirClasse();
        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }


    [Theory]
    [InlineData(2, 1, 2)]
    public void TestDividir(int val1, int val2, int resultado)
    {       
        // Act
        CalculadoraImplementacao calc = construirClasse();
        int resultadoCalculadora = calc.Dividir(val1, val2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        CalculadoraImplementacao calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraImplementacao calc = construirClasse();

        calc.Somar(1,2);
        calc.Somar(2,2);
        calc.Somar(5,2);
        calc.Somar(8,2);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}