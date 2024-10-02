using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Criando o pedido e adicionando os monitores de produção e montagem
        Pedido meuPedido = new Pedido("Pedido do Cliente");

        MonitorProducao producao = new MonitorProducao();
        MonitorMontagem montagem = new MonitorMontagem();

        meuPedido.AdicionarObservador(producao);
        meuPedido.AdicionarObservador(montagem);

        meuPedido.NotificarObservadores();

        // Criando o hambúrguer base
        IHamburguer hamburguer = EscolherHamburguerBase();

        // Menu para adicionar ingredientes ou itens adicionais
        bool adicionandoItens = true;
        while (adicionandoItens)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar Ingredientes ao Hambúrguer");
            Console.WriteLine("2. Adicionar Itens Adicionais (Bebidas, Batata Frita)");
            Console.WriteLine("3. Finalizar Pedido");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarIngredientes(ref hamburguer);
                    break;
                case 2:
                    AdicionarItensAdicionais(meuPedido);
                    break;
                case 3:
                    adicionandoItens = false;
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }

        // Adicionando o hambúrguer decorado ao pedido
        meuPedido.AdicionarItem(new ItemPedido(hamburguer.GetDescricao(), hamburguer.GetCusto()));

        // Exibir o resumo completo do pedido, incluindo todos os itens
        meuPedido.ExibirResumoPedido();

        // Atualizar o status do pedido
        meuPedido.AtualizarStatus("Pronto para montagem");
        meuPedido.AtualizarStatus("Entregue ao cliente");
    }

    private static IHamburguer EscolherHamburguerBase()
    {
        Console.WriteLine("Escolha o hambúrguer base:");
        Console.WriteLine("1. Hambúrguer Simples (R$5,00)");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Hambúrguer Simples escolhido.");
                return new HamburguerSimples();
            default:
                Console.WriteLine("Escolha inválida, selecionando Hambúrguer Simples.");
                return new HamburguerSimples();
        }
    }

    private static void AdicionarIngredientes(ref IHamburguer hamburguer)
    {
        bool adicionandoIngredientes = true;
        while (adicionandoIngredientes)
        {
            Console.WriteLine("\nEscolha um ingrediente para adicionar:");
            Console.WriteLine("1. Bacon (+ R$2,00)");
            Console.WriteLine("2. Queijo (+ R$1,50)");
            Console.WriteLine("3. Alface (+ R$1,00)");
            Console.WriteLine("4. Tomate (+ R$1,00)");
            Console.WriteLine("5. Voltar");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    hamburguer = new Bacon(hamburguer);
                    Console.WriteLine("Bacon adicionado.");
                    break;
                case 2:
                    hamburguer = new Queijo(hamburguer);
                    Console.WriteLine("Queijo adicionado.");
                    break;
                case 3:
                    hamburguer = new Alface(hamburguer);
                    Console.WriteLine("Alface adicionado.");
                    break;
                case 4:
                    hamburguer = new Tomate(hamburguer);
                    Console.WriteLine("Tomate adicionado.");
                    break;
                case 5:
                    adicionandoIngredientes = false;
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }

    private static void AdicionarItensAdicionais(Pedido pedido)
    {
        bool adicionandoItens = true;
        while (adicionandoItens)
        {
            Console.WriteLine("\nEscolha um item adicional para adicionar ao pedido:");
            Console.WriteLine("1. Refrigerante (+ R$2,50)");
            Console.WriteLine("2. Batata Frita (+ R$3,00)");
            Console.WriteLine("3. Sobremesa (+ R$4,00)");
            Console.WriteLine("4. Voltar");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    pedido.AdicionarItem(new ItemPedido("Refrigerante", 2.50));
                    Console.WriteLine("Refrigerante adicionado.");
                    break;
                case 2:
                    pedido.AdicionarItem(new ItemPedido("Batata Frita", 3.00));
                    Console.WriteLine("Batata Frita adicionada.");
                    break;
                case 3:
                    pedido.AdicionarItem(new ItemPedido("Sobremesa", 4.00));
                    Console.WriteLine("Sobremesa adicionada.");
                    break;
                case 4:
                    adicionandoItens = false;
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }
}
