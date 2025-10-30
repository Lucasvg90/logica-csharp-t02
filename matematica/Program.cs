using static System.Console;

const int n1 = 10;
const int n2 = 569;
int soma = n1 + n2;

Console.WriteLine("Soma: "+ n1 + " + " + n2 + " = " + soma);

int subtracao = n1 - n2;

Console.WriteLine($"Subtração: {n1} - {n2} = {subtracao}" );


int multiplicacao = n1 * n2;

Console.WriteLine($"Multiplicação: {n1} * {n2} = {multiplicacao}" );


double divisao = (float) n1 / (float)n2;


Console.WriteLine($"Divisão: {n1} / {n2} = {Math.Round(divisao,2)}" );

int result1 = 8 / 4 + 3, result3 = 10 + 5 * 5, result4 = (10 + 5) * 5;
double result2 = 8.0 / (4 + 3);

WriteLine($"\nContas aleatórias\n" +
          $"Resultado 1: 8 / 4 + 3 = {result1}\n" +
          $"Resultado 1: 8 / ( 4 + 3 ) = {Math.Round(result2,2)}\n" +
          $"Resultado 1: 10 + 5 * 5 = {result3}\n" +
          $"Resultado 1: (10 + 5) * 5 = {result4}\n");