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





