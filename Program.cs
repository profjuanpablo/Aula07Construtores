namespace Aula07_Construtores;

internal class Program
{
    static void Main(string[] args)
    {
        //instanciar um objeto Pessoa
        Pessoa pessoa = new Pessoa("Pedro Henrique",80,1.86);
        Pessoa pessoa2 = new Pessoa("Juan Pablo",105,1.87);
       
        //pessoa.Nome = "Juan Pablo";
        //pessoa.Idade = 49;
        //pessoa.Peso = 105;
        //pessoa.Altura = 1.87;

        

        pessoa.GetPessoa();
        Console.WriteLine(new string('-', 20));
       

        Console.ReadKey();
    }
}
