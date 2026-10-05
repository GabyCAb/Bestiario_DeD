// Classe Monstro

namespace Bestiario_D_D
{
    public class Monstro
    {
        public string Nome { get; }
        public int ClasseDeArmadura { get; }
        public int PontosDeVida { get; }
        public double Deslocamento { get; }
        public int Forca { get; }
        public int Destreza { get; }
        public double NivelDeDesafio { get; }
        public TipoCriatura Tipo { get; }
        public Tamanho Tamanho { get; }

        public Monstro(
            string nome,
            int classeDeArmadura,
            int pontosDeVida,
            double deslocamento,
            int forca,
            int destreza,
            double nivelDeDesafio,
            TipoCriatura tipo,
            Tamanho tamanho)
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

            if (forca < 1 || forca > 30)
            {
                throw new ArgumentException("A Força deve estar entre 1 e 30.");
            }

            if (destreza < 1 || destreza > 30)
            {
                throw new ArgumentException("A Destreza deve estar entre 1 e 30.");
            }

            if (nivelDeDesafio < 0)
            {
                throw new ArgumentException("O Nível de Desafio não pode ser negativo.");
            }

            Nome = nome;
            ClasseDeArmadura = classeDeArmadura;
            PontosDeVida = pontosDeVida;
            Deslocamento = deslocamento;
            Forca = forca;
            Destreza = destreza;
            NivelDeDesafio = nivelDeDesafio;
            Tipo = tipo;
            Tamanho = tamanho;
        }

        public int CalcularModificador(int valorAtributo)
        {
            int modificador = (int)Math.Floor((valorAtributo - 10) / 2.0);
            return modificador;
        }
    }
}