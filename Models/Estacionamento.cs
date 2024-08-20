using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial { get; set; }
        private decimal PrecoPorHora { get; set; }
        private List<string> Veiculos = [];

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }

        public void CadastrarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para cadastrar no sistema:");
            string placa = Console.ReadLine()!;

            Veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover do sistema:");

            string placa = Console.ReadLine()!;

            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = PrecoInicial + (PrecoPorHora * horas);

                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} for removido e o preço total é R$ {valorTotal}");
            } else {
                Console.WriteLine("Veículo não cadastrado no sistema. Verifique se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos cadastrados são:");
                foreach (string veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            } else {
                Console.WriteLine("Não há veículos cadastrados.");
            }
        }
    }
}