using System;
using System.Collections.Generic;

namespace SistemaDeEstacionamento
{
    public class Estacionamento
    {
        // 1. As variáveis precisam existir aqui para o cálculo funcionar!
        private decimal valorEntrada = 5m;
        private decimal valorHora = 2m;

        private List<string> veiculos = new List<string>();

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placaVeiculo = Console.ReadLine()?.ToUpper();
            
            if (!string.IsNullOrWhiteSpace(placaVeiculo))
            {
                veiculos.Add(placaVeiculo);
                Console.WriteLine("Veículo adicionado com sucesso.");
            } 
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placaVeiculo = Console.ReadLine()?.ToUpper();
            
            if (placaVeiculo != null && veiculos.Contains(placaVeiculo))
            {
                // Chama o cálculo passando a placa
                CalcularValorEstacionamento(placaVeiculo);

                veiculos.Remove(placaVeiculo);
                Console.WriteLine("Veículo removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida ou veículo não encontrado. Tente novamente.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void CalcularValorEstacionamento(string placaVeiculo)
        {
            // 2. Aqui a gente pede as HORAS, e não a placa (pois a placa já veio lá de cima)
            Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado:");

            try
            {
                decimal totalHoras = Convert.ToDecimal(Console.ReadLine());
                
                // 3. Agora o cálculo funciona, pois as variáveis existem lá no topo da classe
                decimal valorTotal = valorEntrada + (valorHora * totalHoras);
                
                Console.WriteLine($"O valor total do estacionamento para o veículo {placaVeiculo} é: R$ {valorTotal:F2}");
            }
            catch
            {
                Console.WriteLine("Erro ao calcular o valor do estacionamento. Digite apenas números.");
            }
        }
    }
}