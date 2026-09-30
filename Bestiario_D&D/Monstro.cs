// Classe Monstro

namespace Bestiario_D_D
{
    public class Monstro
    {
        public string Nome { get; set; }
        public int ClasseDeArmadura { get; set; }
        public int PontosDeVida { get; set; }
        public double Deslocamento { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public double NivelDeDesafio { get; set; }
        public TipoCriatura Tipo { get; set; }
        public Tamanho Tamanho { get; set; }

        public int CalcularModificador(int valorAtributo)
        {
            int modificador = (int)Math.Floor((valorAtributo - 10) / 2.0);
            return modificador;
        }

    }
}
