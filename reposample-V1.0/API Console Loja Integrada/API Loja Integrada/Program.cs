using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace API_Loja_Integrada
{
    internal class Program
    {
        // Função Principal "Main", Interface Principal.
        static void Main(string[] args)
        {
            // Variáveis que definem o número de produtos comprados.
            byte carro = 0;
            byte moto = 0;
            byte van = 0;


            float subtotal = 0;

            // Menu Dinâmico para alterar o valor independentemente durante o programa.
            dynamic menu = "";

            // Quantidade de Itens no Carrinho.
            int carrinho = 0;

            // Loop que fecha o menu apenas quando o usuário inserir o valor de saída do sistema (d).
            while (menu != "d")
            {
                // Interface do Sistema.
                Console.WriteLine("------------------------------------");
                Console.WriteLine(" API Loja Integrada\n (Carrinho de Compras) ");
                Console.WriteLine("------------------------------------\n");

                // Lista de Itens do Carrinho.
                Console.WriteLine("Itens do Carrinho:");
                Console.WriteLine(carro + " carro(s).");
                Console.WriteLine(moto + " moto(s)");
                Console.WriteLine(van + " van(s)\n");
                Console.WriteLine("Subtotal:\n" + subtotal + "\n");
                Console.WriteLine("Há " + carrinho + " itens no seu carrinho.\n");

                // Sistema de Menu para o Usuário.
                Console.WriteLine("-----------------------------------|");
                Console.WriteLine("a. -> Adicionar Item ao Carrinho.");
                Console.WriteLine("b. -> Remover Item do Carrinho");
                Console.WriteLine("c. -> Comprar Agora");
                Console.WriteLine("d. -> Sair");
                Console.WriteLine("-----------------------------------|");

                // Leitura do Valor de Entrada do Usuário.
                menu = Console.ReadLine();

                // Condições do Menu que encaminham o sistema para cada função do sistema.
                if (string.Equals(menu, "a", StringComparison.OrdinalIgnoreCase))
                {
                    AdicionarItem(ref subtotal, ref carrinho, ref carro, ref moto, ref van);
                    menu = "";
                };

                if (string.Equals(menu, "b", StringComparison.OrdinalIgnoreCase))
                {
                    RemoverItem(ref subtotal, ref carrinho, ref carro, ref moto, ref van);
                    menu = "";
                };

                if (string.Equals(menu, "c", StringComparison.OrdinalIgnoreCase))
                {
                    Pagamento(ref subtotal, ref carrinho, ref carro, ref moto, ref van);
                    menu = "";
                };

                if (string.Equals(menu, "d", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Fechando o Sistema...");
                };
            };

        }

        // Função que adiciona itens ao carrinho e acrescenta ao subtotal.
        static void AdicionarItem(ref float subtotal, ref int carrinho, ref byte carro, ref byte moto, ref byte van)
        {
            // Valores Constantes dos Produtos.
            const int carro_preco = 30000;
            const int moto_preco = 10000;
            const int van_preco = 50000;

            // Menu Dinâmico.
            dynamic menu = "";

            // Loop do Menu
            while (menu != "d")
            {
                // Interface do Sistema.
                Console.WriteLine("------------------------------------");
                Console.WriteLine(" Lista de Itens ");
                Console.WriteLine("------------------------------------");

                // Lista de Itens do Carrinho.
                Console.WriteLine("Há " + carrinho + " itens no seu carrinho.\n");
                Console.WriteLine("Itens do Carrinho:");
                Console.WriteLine(carro + " carro(s).");
                Console.WriteLine(moto + " moto(s)");
                Console.WriteLine(van + " van(s)\n");
                Console.WriteLine("Subtotal:\n" + subtotal + "\n");

                // Sistema de Menu para o Usuário.
                Console.WriteLine("a. -> Carro (R$ 30.000,00)");
                Console.WriteLine("b. -> Moto (R$ 10.000,00)");
                Console.WriteLine("c. -> Van (R$ 50.000,00)");
                Console.WriteLine("d. -> Adicionar ao carrinho");
                Console.WriteLine("-----------------------------------|");

                // Leitura do Valor do Usuário.
                menu = Console.ReadLine();

                // Opções do Menu que adicionam itens e seus respectivos valores ao carrinho, além de incrementar o subtotal.
                if ((string.Equals(menu, "a", StringComparison.OrdinalIgnoreCase)))
                {

                    subtotal += carro_preco;
                    carrinho++;
                    carro++;
                }
                else if ((string.Equals(menu, "b", StringComparison.OrdinalIgnoreCase)))
                {
                    subtotal += moto_preco;
                    carrinho++;
                    moto++;
                }
                else if ((string.Equals(menu, "c", StringComparison.OrdinalIgnoreCase)))
                {
                    subtotal += van_preco;
                    carrinho++;
                    van++;
                }

                // Mensagem enviada ao finalizar a função e retornar ao menu principal.
                else if ((string.Equals(menu, "d", StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Adicionando ao Carrinho...");
                }

                // Mensagem de Erro.
                else
                {
                    Console.WriteLine("Valor Inválido!");
                }
            }
        }

        // Função que remove itens do carrinho e subtrai do subtotal.
        static void RemoverItem(ref float subtotal, ref int carrinho, ref byte carro, ref byte moto, ref byte van)
        {
            // Valores Constantes dos Produtos.
            const int carro_preco = 30000;
            const int moto_preco = 10000;
            const int van_preco = 50000;

            // Menu Dinâmico.
            dynamic menu = "";

            // Loop do Menu
            while (menu != "c")
            {
                // Interface do Sistema.
                Console.WriteLine("------------------------------------");
                Console.WriteLine(" Carrinho ");
                Console.WriteLine("------------------------------------\n");

                // Lista de Itens do Carrinho.
                Console.WriteLine("Subtotal:\n" + subtotal + "\n");
                Console.WriteLine("Há " + carrinho + " itens no seu carrinho.\n");
                Console.WriteLine("Itens do Carrinho:");
                Console.WriteLine(carro + " carro(s).");
                Console.WriteLine(moto + " moto(s)");
                Console.WriteLine(van + " van(s)\n");

                // Sistema de Menu do Usuário.
                Console.WriteLine("a. -> Remover Item do Carrinho");
                Console.WriteLine("b. -> Limpar Carrinho");
                Console.WriteLine("c. -> Atualizar Carrinho");
                Console.WriteLine("-----------------------------------|");

                // Leitura do Valor do Usuário.
                menu = Console.ReadLine();

                // Sistema de Remoção de Itens caso o usuário escolha a opção (a)
                if ((string.Equals(menu, "a", StringComparison.OrdinalIgnoreCase)))
                {
                    // Loop do Menu
                    while (menu != "d")
                    {
                        // Lista de Itens do Carrinho.
                        Console.WriteLine("Itens do Carrinho:");
                        Console.WriteLine(carro + " carro(s).");
                        Console.WriteLine(moto + " moto(s)");
                        Console.WriteLine(van + " van(s)\n");

                        // Opções do Usuário para remover os Itens do Carrinho.
                        if (carro > 0)
                        {
                            Console.WriteLine("a. -> Remover (1) Carro do Carrinho");
                        }
                        if (moto > 0)
                        {
                            Console.WriteLine("b. -> Remover (1) Moto do Carrinho");
                        }
                        if (van > 0)
                        {
                            Console.WriteLine("c. -> Remover (1) Van do Carrinho");
                        }
                        if (carro == 0 && moto == 0 && van == 0)
                        {
                            Console.WriteLine("Seu Carrinho está Vazio.");
                        }

                        // Opção de Voltar ao Menu de Remoção de Itens.
                        Console.WriteLine("d. -> Salvar e Sair.");
                        Console.WriteLine("-----------------------------------|");

                        // Leitura do Valor do Usuário.
                        menu = Console.ReadLine();

                        // Remoção dos itens do carrinho do usuário e decremento do subtotal.
                        if ((string.Equals(menu, "a", StringComparison.OrdinalIgnoreCase)) && carro > 0)
                        {
                            carro--;
                            subtotal -= carro_preco;
                        }
                        else if ((string.Equals(menu, "b", StringComparison.OrdinalIgnoreCase)) && moto > 0)
                        {
                            moto--;
                            subtotal -= moto_preco;
                        }
                        else if ((string.Equals(menu, "c", StringComparison.OrdinalIgnoreCase)) && van > 0)
                        {
                            van--;
                            subtotal -= van_preco;
                        }

                        // Mensagem enviada ao finalizar a função e retornar ao menu de remoção.
                        else if ((string.Equals(menu, "d", StringComparison.OrdinalIgnoreCase)))
                        {
                            Console.WriteLine("Salvando Itens do Carrinho...");
                        }
                        // Mensagem de Erro.
                        else
                        {
                            Console.WriteLine("Erro de Entrada...");
                        }
                    }
                }

                // Sistema de Limpeza do Carrinho ao escolher a opção (b).
                if ((string.Equals(menu, "b", StringComparison.OrdinalIgnoreCase)))
                {
                    // Mensagem de Confirmação do Procedimento.
                    Console.WriteLine("Tem certeza que deseja limpar seu carrinho?");
                    Console.Write("(S) ou (N)? ");

                    // Leitura do Valor do Usuário.
                    menu = Console.ReadLine();

                    // Limpeza das Variáveis.
                    if ((string.Equals(menu, "s", StringComparison.OrdinalIgnoreCase)))
                    {
                        carro = 0;
                        moto = 0;
                        van = 0;
                        subtotal = 0;
                        carrinho = 0;
                    }

                    // Mensagem de Cancelamento.
                    else
                    {
                        Console.WriteLine("Cancelando Limpeza de Carrinho...");
                    }
                }

                // Mensagem enviada ao finalizar a função e retornar ao menu principal.
                if ((string.Equals(menu, "c", StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Atualizando o Carrinho...");
                }
            }
        }

        // Função que extrai o valor dos itens do carrinho e acrescenta o total a ser pago.
        // Realiza a leitura da forma de pagamento.
        // Acrescenta a possibilidade de cupom de desconto.
        static void Pagamento(ref float subtotal, ref int carrinho, ref byte carro, ref byte moto, ref byte van)
        {
            // Valores Padrão de Menu e Forma de Pagamento.
            dynamic menu = "";
            string forma_pagamento = "Não Selecionado";

            while (menu != "c")
            {
                // Interface do Usuário
                Console.WriteLine("------------------------------------");
                Console.WriteLine(" Central de Pagamento ");
                Console.WriteLine("------------------------------------\n");

                // Lista de Itens do Carrinho
                Console.WriteLine("Subtotal:\n" + subtotal + "\n");
                Console.WriteLine("Há " + carrinho + " itens no seu carrinho.\n");
                Console.WriteLine("Itens do Carrinho:");
                Console.WriteLine(carro + " carro(s).");
                Console.WriteLine(moto + " moto(s)");
                Console.WriteLine(van + " van(s)\n");

                // Menu de Opções do Usuário
                Console.WriteLine("a. -> Selecionar Forma de Pagamento");
                Console.WriteLine("b. -> Inserir Cupom de Desconto");
                Console.WriteLine("c. -> Atualizar Carrinho");
                Console.WriteLine("-----------------------------------|");

                // Leitura do Valor do Usuário.
                menu = Console.ReadLine();

                if (string.Equals(menu, "a", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("a. -> Cartão de Crédito");
                    Console.WriteLine("b. -> Cartão de Débito");
                    Console.WriteLine("c. -> Boleto Bancário\n");
                    Console.WriteLine("-----------------------------------|");

                    menu = Console.ReadLine();

                    if (string.Equals(menu, "a", StringComparison.OrdinalIgnoreCase))
                    {
                        forma_pagamento = "Cartão de Crédito";
                    }
                    else if (string.Equals(menu, "b", StringComparison.OrdinalIgnoreCase))
                    {
                        forma_pagamento = "Cartão de Débito";
                    }
                    else if (string.Equals(menu, "c", StringComparison.OrdinalIgnoreCase))
                    {
                        forma_pagamento = "Boleto Bancário";
                    }
                    else
                    {
                        Console.WriteLine("Valor Inválido");
                    }
                }

                if (string.Equals(menu, "b", StringComparison.OrdinalIgnoreCase))
                {
                    float desconto = subtotal / 10;
                    const string cupom = "Desafio Loja Integrada";
                    float total = subtotal;

                    Console.WriteLine("-----------------------------------|");
                    Console.WriteLine("Insira o Cupom de Desconto Abaixo: ");

                    menu = Console.ReadLine();

                    if (string.Equals(menu, cupom, StringComparison.OrdinalIgnoreCase))
                    {
                        total = subtotal - desconto;
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Forma de Pagamento: " + forma_pagamento);
                        Console.WriteLine("\nSubtotal:\n" + subtotal + "\n");
                        Console.WriteLine("Desconto de -" + desconto);
                        Console.WriteLine("Total a Pagar = " + total);
                        Console.WriteLine("-----------------------------------|");

                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Cupom Inválido\n");
                        Console.WriteLine("Forma de Pagamento: " + forma_pagamento);
                        Console.WriteLine("\nSubtotal:\n" + subtotal + "\n");
                        Console.WriteLine("Total a Pagar = " + total);
                        Console.WriteLine("-----------------------------------|");

                        Console.ReadLine();
                    }
                }

                if (string.Equals(menu, "c", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Atualizando Carrinho");
                }
            }
        }
    }
}
