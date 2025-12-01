using System;
using System.IO;

using static System.Console;

namespace maratonaexercicios3 {
    class Program
    {
    public struct Gato
    {
        public string nome;
        public string raca;
        public int idade;
        public string cor;
    }
        static void Main(string[] args)
        {
            /*Ex 01
             Crie um programa que tenha um array de nomes de 10 peças de carro e imprima 
            todos os nomes em uma lista. */


            string[] pecas = { "Carburador", "Roda", "Carcaça", 
                "volante", "Aro", "peça6", "peça7", "peça8", 
                "peça9", "peça10" };

            foreach(string peca in pecas)
            {
                Console.WriteLine(peca);
            }

        /*Ex 02
            Crie um programa que tenha um array associativo com dados de um gato que 
            chegou no petshop, como chave e seu valor. Utilize o foreach para imprimir os 
            nomes dos dados do gato.*/


            Gato[] gatos = new Gato[2];
            gatos[0].nome = "Mingau";
            gatos[0].raca = "Siamês";
            gatos[0].idade = 3;
            gatos[0].cor = "Branco";
            gatos[1].nome = "Garfield";
            gatos[1].raca = "Laranja";
            gatos[1].idade = 7;
            gatos[1].cor = "Laranja";


            foreach (Gato animal in gatos)
            {
            WriteLine("\nDados do gato:");
            WriteLine($"\nNome: {animal.nome}");
            WriteLine($"Raça: {animal.raca}");
            WriteLine($"Idade: {animal.idade} anos");
            WriteLine($"Cor: {animal.cor}\n");


            }

        
        
        
        
          /*Ex 03 
          O programa pergunta se o usuário quer continuar digitando. 
          Enquanto ele responder “s”, o programa repete.*/

        Boolean digito = true;
        while(digito == true)
        {
            WriteLine("Quer continuar digitando mesmo, mano? (s/n)");
                string resposta = ReadLine();
            if (resposta != "s" && resposta != "sim") {
                WriteLine("Fechou, falou aí\n");
                digito = false;
            }
        }

            /*Ex 04 
    Crie um programa em C# que mostre a tabuada do número 3 de 1 a 10.
    Use a estrutura do...while e declare a variável do contador já na mesma linha em 
    que ela é criada.
    O programa deve exibir o resultado da multiplicação a cada repetição
    */

            int contador = 1;
            do
            {
                WriteLine($"3 x {contador} = {3 * contador}");
                contador++;
            } while (contador <= 10);

        }
    }



}













