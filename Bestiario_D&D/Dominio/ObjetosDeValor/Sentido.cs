using Bestiario_D_D.Dominio.Enums;

namespace Bestiario_D_D.Dominio.ObjetosDeValor;

public record Sentido
{
    public TipoSentido Tipo { get; init; }
    public double Alcance { get; init => field = ValidarAlcance(value); }

    public Sentido(TipoSentido tipo, double alcance)
    {
        Tipo = tipo;
        Alcance = alcance;
    }

    private static double ValidarAlcance(double alcance)
    {
        if (alcance <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(alcance),
                "O alcance do sentido deve ser maior que zero. Se a criatura não possui esse sentido, não o cadastre.");
        }

        return alcance;
    }
}