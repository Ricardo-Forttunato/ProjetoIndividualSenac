using System;
using System.Collections.Generic;
using System.Globalization;

public abstract class Veiculo{
    protected double taxaDiaria{get; set;}

    public abstract double CalcularValorTotal(int numDiarias);
}

public class Carro : Veiculo
{
    public Carro()
    {
        taxaDiaria = 50;
    }

    public override double CalcularValorTotal(int numDiarias)
    {
        return numDiarias * taxaDiaria;
    }
}

public class Moto : Veiculo
{
    public Moto()
    {
        taxaDiaria = 25;
    }

    public override double CalcularValorTotal(int numDiarias)
    {
        return numDiarias * taxaDiaria;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();
        Console.WriteLine("Digite a quantidade de diárias do carro: ");
        int diariasCarro;
        int.TryParse(Console.ReadLine(), out diariasCarro);
        double valorTotalCarro = carro.CalcularValorTotal(diariasCarro);

        Moto moto = new Moto();
        Console.WriteLine("Digite a quantidade de diárias da Moto: ");
        int diariasMoto;
        int.TryParse(Console.ReadLine(), out diariasMoto);
        double valorTotalMoto = moto.CalcularValorTotal(diariasMoto);

        Console.WriteLine($"Valor total para {diariasCarro} diárias de Carro: {valorTotalCarro}");
        Console.WriteLine($"Valor total para {diariasMoto} diárias de Moto: {valorTotalMoto}");
    }
}