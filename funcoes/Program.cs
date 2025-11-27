using System;
using static System.Console;

class program
{
    static void Main()
    {
        //Chama uma função simples que imprime uma mensagem
        ImprimirMensagem();

        //Exemplo de funções para cálculo de áreas (modularização)
        Console.WriteLine("\n ---- Áreas ----");
        Console.WriteLine("Quadrado: " + CalcularAreaQuadrado(4));
        Console.WriteLine("Círculo: " + CalcularAreaCirculo(3));

        WriteLine("\n Ó a média das notas, fi\n");
        double[] notas = EntrarNotas(4);

        WriteLine($"Média: {CalcularMedia(notas)}");

        int j = 7, k = 5, m = 8, result;

        result = j - k % 3 * m;

        WriteLine(result);




    }

    // Função simples que exibe uma mensagem no console
    static void ImprimirMensagem() => Console.WriteLine("Olá, mundo!");

    // Função que calcula a área de um quadrado
    static double CalcularAreaQuadrado(double lado) => lado * lado;

    //Função que calcula a área de um círculo
    static double CalcularAreaCirculo(double raio) => Math.PI * raio * raio;

    static double[] EntrarNotas (int qtd)
    {
        double[] notas = new double[qtd];

        for (int i = 0; i < qtd; i++)
        {
            WriteLine($"Nota {(i + 1)} :");
            notas[i] = double.Parse(ReadLine());

        }
        return notas;
    }

    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double num in notas) soma += num;
        return soma / notas.Length;
    }


}