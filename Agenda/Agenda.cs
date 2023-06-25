using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Agenda
    {
        private List<Contato> contatos;

        public Agenda()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        public void ListarContatos()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("A agenda está vazia.");
            }
            else
            {
                Console.WriteLine("Lista de contatos:");
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
                }
            }
        }

        public void AtualizarContato(string nome, Contato novoContato)
        {
            int indice = contatos.FindIndex(c => c.Nome == nome);
            if (indice >= 0)
            {
                contatos[indice] = novoContato;
                Console.WriteLine("Contato atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado na agenda.");
            }
        }

        public void RemoverContato(string nome)
        {
            int indice = contatos.FindIndex(c => c.Nome == nome);
            if (indice >= 0)
            {
                contatos.RemoveAt(indice);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado na agenda.");
            }
        }
    }
}
