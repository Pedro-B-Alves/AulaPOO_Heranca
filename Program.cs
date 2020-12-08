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
            PessoaJuridica pj = new PessoaJuridica();

            // Atribuímos um valor para a propriedade disponível na superclasse
            Console.WriteLine("Digite seu nome");
            pf.nome = Console.ReadLine();

            // Mostramos no console o método de saudação da superclasse
            Console.WriteLine( pf.DarBoasVindas(pf.nome) );
            bool opcao = true;
            do
            {
                Console.WriteLine("Você é uma pessoa física ou jurídica [f]-física [j]-jurídica");
                string opcao2 = Console.ReadLine();
                switch (opcao2)
                {
                    case "f":
                        Console.WriteLine("Digite seu CPF");
                        pf.cpf = Console.ReadLine();
                    
                        // Mostramos no console o método de validação da subclasse
                        bool cpf = pf.ValidarCPF(pf.cpf);
                        if (cpf == true)
                        {
                            Console.WriteLine("O seu CPF é valido");
                        }else{
                            Console.WriteLine("O seu CPF é inválido");  
                        }
                        opcao = false;
                        break;
                    case "j":
                        Console.WriteLine("Digite seu CNPJ");
                        pj.cnpj = Console.ReadLine();

                        bool cnpj = pj.ValidarCNPJ(pj.cnpj);
                        if (cnpj == true)
                        {
                            Console.WriteLine("O seu CNPJ é valido");
                        }else{
                            Console.WriteLine("O seu CNPJ é inválido");  
                        }
                        opcao = false;
                        break;
                    default:
                        Console.WriteLine("Você digitou uma opção inválida");
                        break;
                }
            } while (opcao != false);
        }
    }
}
