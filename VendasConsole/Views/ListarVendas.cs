using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarVendas
    {

        public static void Renderizar(List<Venda> vendas)
        {
            //subtotal adiciona valores criado, então não há necessidade de atribuir 0
            double subtotal, totalVenda = 0, totalGeral = 0;
            Console.WriteLine("Listar Vendas");

            //Venda
            foreach (Venda vendaCadastrada in vendas)
            {
                Console.WriteLine("Data: " + vendaCadastrada.CriadoEm.ToString("dd/MM/yyyy hh:mm"));
                Console.WriteLine("Cliente: " + vendaCadastrada.Cliente.Nome);
                Console.WriteLine("Vendedor: " + vendaCadastrada.Vendedor.Nome);
                Console.WriteLine("\n Itens da Venda");
                //Itens da Venda
                foreach (ItemVenda itemCadastrado in vendaCadastrada.Produtos)
                {
                    Console.WriteLine("\t" + itemCadastrado.Produto.Nome);

                    subtotal = itemCadastrado.Quantidade * itemCadastrado.Preco;

                    Console.WriteLine("\t" + itemCadastrado.Quantidade + " x "+ 
                        itemCadastrado.Preco.ToString("C2") + " = " + subtotal.ToString("C2"));

                    totalVenda += subtotal;
                }
                Console.WriteLine("\nTotal da venda: " + totalVenda.ToString("C2") +"\n");
                totalGeral += totalVenda;
            }
            Console.WriteLine("\nTotal Geral: " + totalGeral.ToString("C2"));
        }
    }
}
