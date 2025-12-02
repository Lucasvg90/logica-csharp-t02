using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace logica13
{
    internal class Carro
    {
        public string Marca { get; set; }

        private string Modelo { get; set; }

        private int _ano;

        public int Ano {
            get { return _ano; }
            set
            {
                if(value > 1900 && value <= DateTime.Now.Year)
                {
                    _ano = value;
                } else
                {
                    Console.WriteLine("Ano inválido");
                }
            }
        }

    }
}