
namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        public decimal PrecoInicial { get; }
        public decimal PrecoPorHora { get; }

        private readonly List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            if (precoInicial < 0 || precoPorHora < 0)
                throw new ArgumentException("Preços não podem ser negativos.");
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }
            string placa = input.Trim().ToUpper();
            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Este veículo já está estacionado.");
                return;
            }
            veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} estacionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");

            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }
            string placa = input.Trim().ToUpper();
            if (!veiculos.Contains(placa))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                return;
            }

            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            if (!int.TryParse(Console.ReadLine(), out int horas) || horas < 0)
            {
                Console.WriteLine("Quantidade de horas inválida.");
                return;
            }

            decimal valorTotal = CalcularValor(horas);
            veiculos.Remove(placa);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine("- " + veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private decimal CalcularValor(int horas)
        {
            return PrecoInicial + PrecoPorHora * horas;
        }

        public IReadOnlyList<string> ObterVeiculos() => veiculos.AsReadOnly();
    }
}