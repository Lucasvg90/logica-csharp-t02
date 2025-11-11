using static System.Console;

WriteLine("\n--- Exercicio 01 ---\n");

WriteLine("Qual é o seu nome, dog?");

string nome = ReadLine();

WriteLine($"Olá, {nome}! Bem vindo ao nosso site! ");

WriteLine("Olá, " + nome + "! Bem vindo ao nosso site!");





WriteLine("\n--- Exercicio 02 ---\n");

WriteLine("Digite a temperatura em Celsius: ");

double celsius = Convert.ToDouble(ReadLine());

double fahrenheit = (celsius * (9 / 5)) + 32;

WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");




WriteLine("\n--- Exercicio 03 ---\n");

WriteLine("Qual é o teu nome, paizao?");

String nome3 = ReadLine();

WriteLine("E quantos anos tem?");

int idade = Convert.ToInt32(Console.ReadLine());

WriteLine("E qual é a tua cidade, meu rei?");

String cidade = ReadLine();

WriteLine($"\nMeu nome é {nome3}\nTenho {idade} anos e moro lá em {cidade}");
WriteLine($"\nMeu nome é " + nome3 + "\nTenho " + idade + " anos e moro lá em " + cidade);





WriteLine("\n--- Exercicio 04 ---\n");

WriteLine("Manda o valor total do seu empréstimo, dog");

double emprestimo = Convert.ToDouble(Console.ReadLine());   
    
WriteLine("Em quantas parcelas você vai querer pagar por isso aí?");
int parcelas = Convert.ToInt16(Console.ReadLine());   

WriteLine("E qual a taxa de juros?");
double juros = Convert.ToDouble(Console.ReadLine()) /100;

double valorParcela = emprestimo * (1 + juros) / parcelas;

WriteLine($"O valor a ser pago por parcela é:\n {valorParcela}");




WriteLine("\n--- Exercicio 05 ---\n");

WriteLine("Informe quantos reais gostaria de converter: ");

double real = Convert.ToDouble(Console.ReadLine());

WriteLine("Informe a cotação atual do Dólar: ");

double dolar = Convert.ToDouble(ReadLine());

double conversao = real * dolar;

WriteLine($"A sua conversão deu: ${Math.Round(conversao,2)}");




WriteLine("\n--- Exercicio 06 ---\n");

WriteLine("\nInforme o valor do produto: ");

double produto = Convert.ToDouble(ReadLine());

WriteLine("\nInforme seu desconto em %: ");

double desconto = (Convert.ToDouble(ReadLine()) /100);


double precoTotal = produto - (produto * desconto);

WriteLine($"Seu preço total foi de: \nR${Math.Round(precoTotal,2)}");