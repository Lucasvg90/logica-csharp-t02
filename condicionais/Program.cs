using static System.Console;

//Exemplo


string nome = "Pablo Escobar";

if (nome == "Ana")
{
    WriteLine("Fala, fi");
} else if (nome == "Pablo Escobar")
{
    WriteLine("Epa, perai...");
} else if(string.IsNullOrEmpty(nome))
{
    WriteLine("Falar o nome ninguém quer, né");

} else 
{
    WriteLine("Mano, nem te conheço, o que você está fazendo na minha casa?");
}

//Exemplo 2

WriteLine("\nE a renda, man? Tá como?");

int renda = Convert.ToInt16(ReadLine());

if (renda >= 1000)
{
    WriteLine("Tá podendo almossar");
}
else
{
    WriteLine("Não tá podeno almossar");
}

// Exemplo 3 
WriteLine("\nMim dê numero");

int numero = Convert.ToInt16(ReadLine());

if(numero % 2 == 0)
{
    WriteLine("Pelo visto, é par");
}
else
{
    WriteLine("Ao que vejo, é ímpar");
}


// Exemplo 4
WriteLine("\nQue nota?");
double nota = Convert.ToDouble(ReadLine());

if (nota > 8.5)
{
    WriteLine("Você é o bichão mesmo, hein doido");
} else if (nota >= 6)
{
    WriteLine("Deu para passar, né");
}
else if(nota >= 3)
{
    WriteLine("Vish, não tá dando para passar, \nvocê tá de recuperação mas tem chance ainda");
    
} else
{
    WriteLine("Lascou");
}


// Exemplo 5

double pontuacao = 9.9;

int result = (int)Math.Round(pontuacao);

Console.WriteLine(result);

switch (result)
{
    case 10:
        WriteLine("Aí sim, hein");
        break;

    case >= 7:
        WriteLine("Tá bom");
        break;

    case >= 6:
        WriteLine("Tá de rec, man");
        break;
    case >= 3:
        WriteLine("Tá pra reprovar, pai");
        break;

    default: 
        WriteLine("Foi reprovado, fi, receba");
        break;
}