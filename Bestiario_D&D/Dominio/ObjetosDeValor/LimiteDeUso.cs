namespace Bestiario_D_D.Dominio.ObjetosDeValor;

public abstract record LimiteDeUso
{
    public abstract override string ToString();
}

public sealed record Recarga : LimiteDeUso
{
    public int Minimo { get; init => field = ValidarMinimo(value); }

    public Recarga(int minimo)
    {
        Minimo = minimo;
    }

    private static int ValidarMinimo(int minimo)
    {
        if (minimo < 2 || minimo > 6)
        {
            throw new ArgumentOutOfRangeException(nameof(minimo),
                "O mínimo da recarga deve ser de 2 a 6 (uma face do d6). Para 'Recarrega 5–6', informe 5.");
        }
        return minimo;
    }

    public override string ToString() => Minimo == 6 ? "Recarrega 6" : $"Recarrega {Minimo}–6";
}

public sealed record UsosPorDia : LimiteDeUso
{
    public int Usos { get; init => field = ValidarUsos(value); }

    public UsosPorDia(int usos)
    {
        Usos = usos;
    }

    private static int ValidarUsos(int usos)
    {
        if (usos < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(usos),
                "Os usos por dia devem ser pelo menos 1. Se a habilidade não tem limite de uso, cadastre-a sem limite.");
        }
        return usos;
    }

    public override string ToString() => $"{Usos}/Dia";
}

public sealed record RecargaAposDescanso(bool ApenasDescansoLongo) : LimiteDeUso
{
    public override string ToString() => ApenasDescansoLongo ? "Recarrega após um Descanso Longo" : "Recarrega após um Descanso Curto ou Longo";
}