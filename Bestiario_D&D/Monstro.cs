// Classe Monstro

namespace Bestiario_D_D
{
    public class Monstro
    {
        private static readonly Dictionary<double, int> TabelaXP = new()
        {
            [0] = 10,
            [0.125] = 25,
            [0.25] = 50,
            [0.5] = 100,
            [1] = 200,
            [2] = 450,
            [3] = 700,
            [4] = 1100,
            [5] = 1800,
            [6] = 2300,
            [7] = 2900,
            [8] = 3900,
            [9] = 5000,
            [10] = 5900,
            [11] = 7200,
            [12] = 8400,
            [13] = 10000,
            [14] = 11500,
            [15] = 13000,
            [16] = 15000,
            [17] = 18000,
            [18] = 20000,
            [19] = 22000,
            [20] = 25000,
            [21] = 33000,
            [22] = 41000,
            [23] = 50000,
            [24] = 62000,
            [25] = 75000,
            [26] = 90000,
            [27] = 105000,
            [28] = 120000,
            [29] = 135000,
            [30] = 155000
        };

        public string Nome { get; }
        public int ClasseDeArmadura { get; }
        public int PontosDeVida { get; }
        public double Deslocamento { get; }
        public double? DeslocamentoVoo { get; }
        public Atributos Atributos { get; }
        public double NivelDeDesafio { get; }
        public TipoCriatura Tipo { get; }
        public Tamanho Tamanho { get; }
        public int Experiencia => TabelaXP[NivelDeDesafio];

        public Monstro(
            string nome,
            int classeDeArmadura,
            int pontosDeVida,
            double deslocamento,
            Atributos atributos,
            double nivelDeDesafio,
            TipoCriatura tipo,
            Tamanho tamanho,
            double? deslocamentoVoo = null
            )
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do monstro é obrigatório.");
            }

            if (classeDeArmadura <= 0)
            {
                throw new ArgumentException("A Classe de Armadura deve ser maior que zero.");
            }

            if (pontosDeVida <= 0)
            {
                throw new ArgumentException("Os Pontos de Vida devem ser maiores que zero.");
            }

            if (deslocamento < 0)
            {
                throw new ArgumentException("O deslocamento não pode ser negativo.");
            }
            if (deslocamentoVoo is not null && deslocamentoVoo < 0)
            {
                throw new ArgumentException("O deslocamento de voo não pode ser negativo.");
            }

            if (!TabelaXP.ContainsKey(nivelDeDesafio))
            {
                throw new ArgumentException("O Nível de Desafio informado não existe na tabela do livro.");
            }

            Nome = nome;
            ClasseDeArmadura = classeDeArmadura;
            PontosDeVida = pontosDeVida;
            Deslocamento = deslocamento;
            DeslocamentoVoo = deslocamentoVoo;
            Atributos = atributos;
            NivelDeDesafio = nivelDeDesafio;
            Tipo = tipo;
            Tamanho = tamanho;
        }

    }
}