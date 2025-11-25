using static System.Console;

int[] num = { 10, 20, 1001 };
String[] xingamentos = { "boboca", "bobalhão", "paspalho", "salafrário", "celerado", "vilão" };

WriteLine("Ó o vetor de números (usando for):\n");
    for(int i = 0; i < num.Length; i++)
    {
    WriteLine(num[i]);
    }
    WriteLine("\n\n");

WriteLine("Ó o vetor de xingamentos:\n");
foreach (var insulto in xingamentos) {
    WriteLine(insulto);
}

int valorProcurado = 10;
int posicaoSequencial = PesquisaSequencial(num, valorProcurado);

if(posicaoSequencial != -1)
{
    WriteLine($"\nPesquisa Sequencial: Valor {valorProcurado} encontrado na posicao {posicaoSequencial}");

} else {
    WriteLine($"\nPesquisa Sequencial: Paizao, não achei o valor {valorProcurado}");
}

static int PesquisaSequencial(int [] vetor, int valor){

for (int i = 0; i < vetor.Length; i++){
    if (vetor[i] == valor)
    {
        return i;
    }
}
return -1;

    }


int posicaoBinaria = Array.BinarySearch(num, valorProcurado);
if( posicaoBinaria >=0)
    {
    Console.WriteLine($"Pesquisa Binária: Valor {valorProcurado} encontrado na posição {posicaoBinaria}. ");
    
}

else
{
    WriteLine($"Pesquisa Binária: O valor {valorProcurado} não foi encontrado não, man");
}

int[,] matrinho = new int[3, 2]
{
    {1,2},
    {3,4},
    {4,5}
};

WriteLine("\nExibindo matriz 3x2");

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j <2; j++)
    {
        WriteLine(matrinho[i, j] + "\t");
    }
    WriteLine();
}
for(int i = 0; i < 3; i++)
{
    for(int j = 0; j <2; j++)
    {
        matrinho[i, j] += 10;
        WriteLine(matrinho[i, j] + "\t");
    }
    WriteLine();
}



