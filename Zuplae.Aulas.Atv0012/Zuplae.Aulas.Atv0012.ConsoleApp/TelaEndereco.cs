using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Services;

namespace Zuplae.Aulas.Atv0012.ConsoleApp
{
    internal class TelaEndereco
    {
        private BaseService service = new BaseService();

        public void ExecutarMenu()
        {
            Console.Clear();            
            Console.WriteLine("======= Modulo de Endereço ========");
            Console.WriteLine("Escolha uma das opções do menu abaixo: ");
            Console.WriteLine("\t1-Cadastrar");
            Console.WriteLine("\t2-Editar");
            Console.WriteLine("\t3-Listar");
            Console.WriteLine("\t4-Deletar");
            Console.WriteLine("\t5-Voltar Ao Menu Principal");

            Console.Write("Digite a opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    this.Cadastrar();
                    break;
                case 2:
                    Console.WriteLine("Editar um endereço");                    
                    break;
                case 3:
                    Console.WriteLine("Listar endereços.");
                    break;
                case 4:
                    Console.WriteLine("Deletar um endereço.");
                    break;
                case 5:
                    Console.WriteLine("Voltando ao menu principal.");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

        private void Cadastrar()
        {
            Console.WriteLine("Cadastrar um novo endereço");
            Console.Write("Logradouro: ");
            string logradouro = Console.ReadLine();
            Console.Write("Número: ");
            string numero = Console.ReadLine();
            Console.Write("Complemento: ");
            string complemento = Console.ReadLine();
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();
            Console.Write("Estado: ");
            string estado = Console.ReadLine();
            Console.Write("CEP: ");
            string cep = Console.ReadLine();
            service.Cadastrar(logradouro, numero, complemento, bairro, cidade, estado, cep);
        }
    }
}
