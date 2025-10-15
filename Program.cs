using System;
using System.Collections.Generic;

namespace GerenciamentoDeEstoque
{
    internal class Program
    {
        // Declaração da Lista de Produtos
        static List<string> listaDeProdutos = new List<string>();

        // Imput inicial do programa
        static void Main(string[] args)
        {
            Opcao();
        }

        // Método das opções
        static public void Opcao()
        {
            
            Console.WriteLine("Opções:\n1- Adicionar Produto\n2- Deletar Produto\n3- Listar Produtos\n4- Encerrar Programa");
            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Adicionar();
                    break;
                case "2":
                    Deletar();
                    break;
                case "3":
                    ListarProdutos();
                    break;
                case "4":
                    Console.WriteLine("Programa Encerrado"); // Comando para fechar o programa
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }
        }

        // Método para adicionar produtos
        static public void Adicionar()
        {
            Console.WriteLine("Digite os produtos (Use vírgulas para separar os produtos)");
            string produtos = Console.ReadLine();
            string[] lista = produtos.Split(','); // Todos os itens da array é separado por vírgulas

            if(String.IsNullOrEmpty(produtos)) // Checando se a lista dos produtos está fazia
            {
                Console.WriteLine("Você não digitou nenhum produto!");
            }else
            {
                foreach(string produto in lista)
                {
                    string produtoS = produto.Trim(); // Remover espaços em branco

                    if(!string.IsNullOrEmpty(produtoS))
                    {
                        listaDeProdutos.Add(produtoS); // Adicionando os produtos na lista
                    }
                }
            }

            Opcao(); // Retornando para opções
        }

        // Método para deletar produtos
        static public void Deletar()
        {
            Console.WriteLine("Digite o produto que deseja deletar: ");
            string produtoD = Console.ReadLine().Trim();

            if(listaDeProdutos.Contains(produtoD)) // Checando se na lista possui o produto digitado
            {
                listaDeProdutos.Remove(produtoD);
                Console.WriteLine($"Produto '{produtoD}' removido com sucesso!");
            }else
            {
                Console.WriteLine("Produto não encontrado");
            }

            Opcao(); // Retorna para opções
        }

        // Método para listar os produtos da lista
        static public void ListarProdutos()
        {
            if(listaDeProdutos.Count == 0) // Checando se a lista está vazia
            {
                Console.WriteLine("Nenhum produto cadastrado");
            }else
            {
                Console.WriteLine("Lista de Produtos: ");

                foreach(string produto in listaDeProdutos)
                {
                    Console.WriteLine($"- {produto}");
                }

                Opcao(); // Retorna para opções
            }
        }
    }
}