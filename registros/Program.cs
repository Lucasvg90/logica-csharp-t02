using System;
using System.IO;
using static System.Console;

namespace AulaRegistrosArquivos
{
    public struct Piloto
    {
        public string Nome;
        public string Transporte;
        public int TempoExp;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Piloto piloto1;
            piloto1.Nome = "Luis";
            piloto1.Transporte = "Avião";
            piloto1.TempoExp = 5;

            WriteLine($"===Mano 1===\n" +
                $"Nome: {piloto1.Nome}\n"
                + $"Transporte:{piloto1.Transporte} \n"
                + $"Tempo de Experiência: {piloto1.TempoExp}\n");

            Piloto piloto2;
            piloto2.Nome = "Eduarda";
            piloto2.Transporte = "Carro";
            piloto2.TempoExp = 25;

            WriteLine($"===Mano 1===\n" +
                $"Nome: {piloto2.Nome}\n"
                + $"Transporte:{piloto2.Transporte} \n"
                + $"Tempo de Experiência: {piloto2.TempoExp}\n");

            Piloto[] pilotos = new Piloto[2];
            pilotos[0].Nome = "Edmilson";
            pilotos[0].Transporte = "Barco";
            pilotos[0].TempoExp = 4;
            pilotos[1].Nome = "Perebilson";
            pilotos[1].Transporte = "Jangada";
            pilotos[1].TempoExp = 7;

            foreach (Piloto piloto in pilotos)
            {
                WriteLine($"Nome: {piloto.Nome}\n"
                    + $"Transporte: {piloto.Transporte}\n"
                    + $"Tempo de Experiência: {piloto.TempoExp}\n\n");


            }

            Piloto piloto3;

            piloto3.Nome = "Ferdinando";
            piloto3.Transporte = "Bicicleta";
            piloto3.TempoExp = 2;

            string caminhoArquivo = "pilotos.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine(
            } 

        }
    }
}

