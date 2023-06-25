using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Listar contatos");
                Console.WriteLine("3 - Atualizar contato");
                Console.WriteLine("4 - Remover contato");
                Console.WriteLine("5 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do contato:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o telefone do contato:");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Digite o email do contato:");
                        string email = Console.ReadLine();

                        Contato novoContato = new Contato(nome, telefone, email);
                        agenda.AdicionarContato(novoContato);
                        break;

                    case "2":
                        agenda.ListarContatos();
                        break;

                    case "3":
                        Console.WriteLine("Digite o nome do contato a ser atualizado:");
                        string nomeAtualizar = Console.ReadLine();

                        Console.WriteLine("Digite o novo nome do contato:");
                        string novoNome = Console.ReadLine();
                        Console.WriteLine("Digite o novo telefone do contato:");
                        string novoTelefone = Console.ReadLine();
                        Console.WriteLine("Digite o novo email do contato:");
                        string novoEmail = Console.ReadLine();

                        Contato contatoAtualizado = new Contato(novoNome, novoTelefone, novoEmail);
                        agenda.AtualizarContato(nomeAtualizar, contatoAtualizado);
                        break;

                    case "4":
                        Console.WriteLine("Digite o nome do contato a ser removido:");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover);
                        break;

                    case "5":
                        Console.WriteLine("Saindo do programa...\n\nPressione Enter para fechar");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.ReadLine();
                return;
            }
        }


    }
}
