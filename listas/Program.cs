using System;
using static System.Console;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> carros = new List<string> { "Vectra", "Ferrari", "Palio", "Fiat Uno" };
        carros.Add("Sandero");

        WriteLine("\nLista após a adição");
        foreach (string carro in carros)
        {
            WriteLine(carro);
        }

        carros.Remove("Sandero");

        WriteLine("\nLista após remover a Sandero");

        foreach (string carro in carros) {
            WriteLine(carro);
        }

        carros.RemoveAt(2);

        WriteLine("\nRemovi mais umkk");
        foreach (string carro in carros) { 
            WriteLine(carro); 
        }

        carros.Clear();

        WriteLine($"\nLista após Clear(): " +
            $"Quantidade de elementos {carros.Count}");





        

    }
}