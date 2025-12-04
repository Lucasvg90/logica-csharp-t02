using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica14
{
    //Classe base (superclasse)
    internal class Animal
    {
        //Propriedade da classe Animal
        public string Nome { get; set; }

        //Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

    //Classe derivada (subclasse)
    internal class Cachorro : Animal
    {
        //Sobrscrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }
    }

    //Outra classe derivada
    internal class Gato : Animal
    {
        //Sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miaauu!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando instâncias das classes derivadas
            Animal meuCachorro = new Cachorro { Nome = "Isnupi" };
            Animal meuGato = new Gato { Nome = "Felix" };
            Animal meuCoelho = new Animal { Nome = "Lulu" };


            //Chamando o método EmitirSom para cada animal
            meuCachorro.EmitirSom();   //Sainda: Rex late: Au Au!
            meuGato.EmitirSom();      //Saida: Felix mia: miaauu!
            meuCoelho.EmitirSom();

            Animal[] animais = {meuCoelho, meuCachorro, meuGato};

            foreach (var animal in animais) 
            {
                animal.EmitirSom();
            }
        }
    }
}