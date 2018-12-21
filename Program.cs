using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Maria", 14, new Endereco("Rua 123", "123","casa verde"));
            Console.WriteLine("ABCD" + p._Endereco.Logradouro);
            

        }
    }
}
