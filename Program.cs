using System;

namespace SistemaHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma pessoa chamada "Fulano"
            Pessoa hospede = new Pessoa("Fulao de Tal");

            // Criação de uma suíte com 2 hóspedes e valor de diária R$ 150,00
            Suíte suite = new Suíte(2, 150.00);

            // Criação de uma reserva associando o hóspede e a suíte por quantidade de dias
            Reserva reserva = new Reserva(hospede, suite, 11);

            // Exibição das informações da reserva
            Console.WriteLine();
            Console.WriteLine("Reserva");
            Console.WriteLine();
            Console.WriteLine("Hóspede: " + reserva.Hospede.Nome);
            Console.WriteLine("Valor da diária: R$ {0:F2}", + reserva.Suite.ValorDiaria);
            Console.WriteLine("Quantidade de hóspedes: " + reserva.Suite.QuantidadeHospedes);
            Console.WriteLine("Total da reserva para " + reserva.QuantidadeDias + " dias: R$ {0:F2}", + reserva.CalcularTotal());

            Console.ReadLine();
        }
    }

    // Classe que representa uma pessoa
    class Pessoa
    {
        public string Nome { get; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    // Classe que representa uma suíte de hotel
    class Suíte
    {
        public int QuantidadeHospedes { get; }
        public double ValorDiaria { get; }

        public Suíte(int quantidadeHospedes, double valorDiaria)
        {
            QuantidadeHospedes = quantidadeHospedes;
            ValorDiaria = valorDiaria;
        }
    }

    // Classe que representa uma reserva
    class Reserva
    {
        public Pessoa Hospede { get; }
        public Suíte Suite { get; }
        public int QuantidadeDias { get; }

        public Reserva(Pessoa hospede, Suíte suite, int quantidadeDias)
        {
            Hospede = hospede;
            Suite = suite;
            QuantidadeDias = quantidadeDias;
        }

        public double CalcularTotal()
        {
            // Cálculo do valor total da reserva
            double total = QuantidadeDias * Suite.ValorDiaria;

            // Aplica um desconto de 10% caso a reserva seja para mais de 10 dias
            if (QuantidadeDias > 10)
            {
                total *= 0.9;
            }

            return total;
        }
    }
}