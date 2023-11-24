using CalculadoraSimplesAPI.Services.Interfaces;

namespace CalculadoraSimplesAPI.Services;

public class CalculadoraService : ICalculadoraService
{
    public double somar(double valor1, double valor2)
    {
        return valor1 + valor2;
    }

    public double subtrair(double valor1, double valor2)
    {
        return valor1 - valor2;
    }

    public double multiplicar(double valor1, double valor2)
    {
        return valor1 * valor2;
    }

    public double dividir(double valor1, double valor2)
    {
        return valor1 / valor2;
    }

    public double potencializar(double valor1, double valor2)
    {
        return Math.Pow(valor1, valor2);
    }

    public double radicionalizar(double valor1, double valor2)
    {
        return Math.Pow(valor1, (1 / valor2));
    }

    public double percentualizar(double valor1, double valor2)
    {
        return (valor1 / valor2) * 100;
    }
}
