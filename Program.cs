using System;

class CalculadoraDeIMC
{
    public static double CalcularIMC(double peso, double altura)
    {
        double imc = peso / (altura * altura);
        return imc;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o peso (em kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc  = CalculadoraDeIMC.CalcularIMC(peso, altura);

        Console.WriteLine($"O seu IMC é: {imc:F2}");
    }
}