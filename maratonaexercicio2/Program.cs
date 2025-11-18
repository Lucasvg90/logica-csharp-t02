using static System.Console;





/*  1.Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários 
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. Se a 
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor, 
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.". */

WriteLine("Informa o estoque do item aí, mano");
int estoque = Convert.ToInt16(ReadLine());

if (estoque > 5)
{
    WriteLine("Alerta: Estoque baixíssimo, mano\nVai lá reabastecer, namoral");
}
else
{
    WriteLine("É, tem o suficiente");
}


/* 2. Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte 
de uma promoção de vendas. Escreva um código que determine o valor total da 
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um 
desconto de 10% e exiba: "Desconto de 10% aplicado!".Se o valor total for R$ 
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um 
desconto de 10%.". */


WriteLine("Quantos itens você vai querer comprar, man?");
int quant = Convert.ToInt16(ReadLine());
double total;

WriteLine("Ok, e qual é o preço de cada um deles?");
    for(int i = 0; i < quant; i++) {
        double valor = Convert.ToInt64(ReadLine());
        total =+ valor;
    
    if (total < 200)
{
    WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10%.");
} else
{
    WriteLine("Desconto de 10% aplicado!");
}

}



    /* 1.Faça um programa que determine o dia da semana
    O programa deve receber um número de 1 a 7, representando um dia da semana,
    e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 = 
    "Segunda-feira", etc.). */


    int semana = Convert.ToInt16(ReadLine());

switch (semana)
{
    case 1:
        WriteLine("Segunda, pai");
        break;
    case 2:
        WriteLine("Terça-Feira, man");
        break;
    case 3:
        WriteLine("Quarta-Feira, man");
        break;
    case 4:
        WriteLine("Quinta-Feira, man");
        break;
    case 5:
        WriteLine("Sexta-Feira, man");
        break;
    case 6:
        WriteLine("Sabado, paizao, aí sim");
        break;
    case 7:
        WriteLine("Domingo à noite...");
        break;
    default:
        WriteLine("Mano, acho que isso daí não é dia nãokk");
        break;
}


/* 2. Faça um programa que calcule o preço final de um produto com base em um 
código de desconto
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto 
correspondente ao preço do produto.
o Código 1: 10 % de desconto
o Código 2: 20 % de desconto
o Código 3: 30 % de desconto
o Se o código for inválido, deve mostrar uma mensagem de erro */

int codigo = int.Parse(ReadLine());
double desconto, preco = 10;

switch (codigo)
{
    case 1:
        desconto = .1;
        WriteLine("Boa, deu 10% de desconto");
        break;

    case 2:
        desconto = .2;
        WriteLine("Boa, deu 20% de desconto");
        break;
        
    case 3:
        desconto = .3;
        WriteLine("Boa, deu 30% de desconto");
        break;

    default:
        WriteLine("tá errado, sem desconto aplicado");
        desconto = 0;
        break;

        
       

}
    double precoAtual = preco - (preco * desconto);
        WriteLine($"O valor atual com desconto é de: {precoAtual}");



//  Switch: Ex 1

/* 1.Faça um programa de tabuada de multiplicação 
O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 = 
"Segunda-feira", etc.). */




for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"7 x {i} = {7 * i}");

}


/* 2. Faça um programa para calcular a média
    Crie um programa que receba 10 números inteiros e calcule a média desses 
    números. Utilize o laço for para ler os números e calcular a média */

int soma = 0;

for(int i = 0; i< 10; i++)
{
    int numero = Convert.ToInt16(ReadLine());
    soma += numero;
}
WriteLine($"A média dos 10 números é {soma / 10}");


/* 1.Faça um programa contador de visitantes
   Desenvolva um código que simula a entrada X visitantes aleatoriamente no 
   museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar" 
   cada visitante até que a capacidade máxima seja atingida. A cada visitante 
   adicional, exiba o número total de visitantes até o momento. */

int visitantes = 0;

WriteLine("Mim dê quantos visitantes tem, no máximo: ");
int max = Convert.ToInt16(ReadLine());

while(visitantes != (max+1))
{
    WriteLine($"O número atual de visitantes é de: {visitantes}");
    visitantes++;
}



/* 2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo 
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O 
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha 
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de 
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas." */

String senhaCorreta = "senha123";
int tentativas = 0;

WriteLine("Informe a senha correta");

while(tentativas != 3)
{
    WriteLine("Mim dê a senha");

    String senha = ReadLine();
    
    if (senha == senhaCorreta)
    {
        WriteLine("Boa, tá logado, fi");
        Environment.Exit(0);
        break;
    }
    tentativas++;

}
WriteLine("Conta bloqueada por excesso de tentativas, cabou procê");
