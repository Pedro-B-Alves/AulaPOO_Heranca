using System;
using AulaPOO_Heranca.classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();
            PessoaFisica pessoaFisica = new PessoaFisica();

            // Atribuímos um valor para a propriedade disponível na superclasse
            pf.nome = "Pedro";

            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();
            
            // Mostramos no console o método de saudação da superclasse
            Console.WriteLine( pf.DarBoasVindas(pf.nome) );

            // Mostramos no console o método de validação da subclasse
            Console.WriteLine( pf.ValidarCPF(pf.cpf) );
        }
    }
}
