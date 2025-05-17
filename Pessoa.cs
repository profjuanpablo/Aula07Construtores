using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Construtores
{
    class Pessoa
    {

        //declaração de propriedades da classe Pessoa

        public string? Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        //COnstrutor declarado pelo programador onde passamos os
        //parâmetros para a instanciação do objeto pessoa.

        public Pessoa(double peso, double altura) {
            Peso = peso;
            Altura = altura;
        }

        public Pessoa(string nome, double peso, double altura): this(peso,altura)
        {
            Nome = nome;
         }


        public Pessoa(string nome, int idade, double peso, double altura): this(nome,peso,altura)
        {
            Idade = idade;
        }


        //Destrutor
        ~Pessoa()
        {
            Console.WriteLine("Objeto  finalizado");
            Console.ReadKey();
        }

        public void GetPessoa() { 
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}" +
                    $"\nPeso: {Peso}\nAltura: {Altura}");
        }

    }
}
