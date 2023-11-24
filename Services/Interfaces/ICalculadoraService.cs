namespace CalculadoraSimplesAPI.Services.Interfaces;

public interface ICalculadoraService
{
    double somar(double valor1, double valor2);

    double subtrair(double valor1, double valor2);

    double multiplicar(double valor1, double valor2);

    double dividir(double valor1, double valor2);

    double potencializar(double valor1, double valor2);

    double radicionalizar(double valor1, double valor2);

    double percentualizar(double valor1, double valor2);
}
