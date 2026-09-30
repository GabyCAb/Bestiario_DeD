// Classe Monstro

namespace Bestiario_D_D
{
    public class Monstro
    {
        public required string Nome { get; init; }
        public required int ClasseDeArmadura { get; init; }
        public required int PontosDeVida { get; init; }
        public required double Deslocamento { get; init; }
        public required int Forca { get; init; }
        public required int Destreza { get; init; }
        public required double NivelDeDesafio { get; init; }
        public required TipoCriatura Tipo { get; init; }
        public required Tamanho Tamanho { get; init; }

        public int CalcularModificador(int valorAtributo)
        {
            int modificador = (int)Math.Floor((valorAtributo - 10) / 2.0);
            return modificador;
        }

    }
}
