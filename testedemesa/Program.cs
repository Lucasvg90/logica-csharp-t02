using static System.Console;

double[] notas = { 7.5, 8, 6.5, 9, 7 };
double soma = 0;

WriteLine("=== Teste de Mesa ===");
WriteLine("Passo  |   i   |  notas[i]  | soma antes  | soma depois");
WriteLine("-------------------------------------------------------");

for (int i = 0; i < notas.Length; i++)
{
    double somaAntes = soma;
    soma += notas[i];
    double somaDepois = soma;

    WriteLine(
        $"{i + 1,5} | {1,5}  |  {notas[i],8}  | {somaAntes,10}  | {somaDepois,11}");
}

WriteLine("-------------------------------------------------------");

double media = soma / notas.Length;

WriteLine("A média das notas é: " + media);
WriteLine();
