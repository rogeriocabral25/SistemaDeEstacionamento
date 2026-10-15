using System;
using SistemaDeEstacionamento;

class Program
{
    static void Main()
    {
        // 1. Criamos o estacionamento UMA ÚNICA VEZ fora do loop
        // Assim ele guarda a lista de veículos na memória
        Estacionamento estacionamento = new Estacionamento();
        
        bool exibirMenu = true;

        // 2. O laço while mantém o programa rodando até escolher a opção 4
        while (exibirMenu)
        {
            Console.Clear(); // Limpa a tela para o menu ficar organizado
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Sair");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // Usamos o estacionamento que já existe na memória
                    estacionamento.AdicionarVeiculo();
                    break;
                case "2":
                    estacionamento.RemoverVeiculo();
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    Console.WriteLine("Saindo do programa...");
                    exibirMenu = false; // Isso faz o loop while parar
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            // Pausa para o usuário ler o resultado antes de limpar a tela e mostrar o menu de novo
            if (exibirMenu)
            {
                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}