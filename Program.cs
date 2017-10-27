using System;
using CadastroVendasPoo.classes;

namespace CadastroVendasPoo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("######################################################");
            Console.WriteLine("#                                                    #");
            Console.WriteLine("#              Prodgrama de Vendas                   #");
            Console.WriteLine("#                                                    #");
            Console.WriteLine("######################################################");

            int opcao =0;
            while(opcao != 9){

                Console.WriteLine("Digite: \n1-Para cadastro de cliente\n2-Para cadastro de produto\n3-Para cadastro de venda\n4-Para extrato do cliente\n9-Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o email do cliente: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do cliente: ");
                        string cpf = Console.ReadLine();
                        Cliente cl = new Cliente(nome, email, cpf, DateTime.Now.Date);
                        Console.Clear();
                        // Salvando cliente diretamente na linha e já chamando o objeto no método
                        Console.WriteLine(new SalvarCliente().Salvar(cl));                        
                    break;

                    case 2:
                        Console.WriteLine("Digite o código do produto: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do produto: ");
                        string nomedoproduto = Console.ReadLine();
                        Console.WriteLine("Digite a descrição do produto: ");
                        string descricao = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto: ");
                        double preco = double.Parse(Console.ReadLine());

                        Produto produto = new Produto(id,nomedoproduto, descricao, preco);
                        Console.Clear();
                        // Salvando cliente diretamente na linha e já chamando o objeto no método
                        Console.WriteLine(new SalvarProduto().Salvar(produto));                        
                    break;

                    case 3:
                        Console.WriteLine("Digite o código do produto: ");
                        int idp = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Cpf do cliente: ");
                        string cpfc = Console.ReadLine();

                        Venda venda = new Venda(cpfc, idp, DateTime.Now.Date);
                        Console.Clear();
                        // Salvando cliente diretamente na linha e já chamando o objeto no método
                        Console.WriteLine(new SalvarVenda().Salvar(venda));                        
                    break;


                
                    

                }

            }

        }
    }
}
