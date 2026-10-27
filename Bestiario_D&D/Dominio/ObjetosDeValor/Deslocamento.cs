// DESLOCAMENTO 

namespace Bestiario_D_D.Dominio.ObjetosDeValor;

public record Deslocamento
{
    public double Caminhada { get; init => field = ValidarDeslocamento(value, "Caminhada"); }
    public double? Escavacao { get; init => field = ValidarDeslocamento(value, "Escavação"); }
    public double? Escalada { get; init => field = ValidarDeslocamento(value, "Escalada"); }
    public double? Natacao { get; init => field = ValidarDeslocamento(value, "Natação"); }
    public double? Voo { get; init => field = ValidarDeslocamento(value, "Voo"); }

    public Deslocamento(
        double caminhada,
        double? escavacao = null, double? escalada = null, double? natacao = null, double? voo = null
        )
    {
        Caminhada = caminhada;
        Escavacao = escavacao;
        Escalada = escalada;
        Natacao = natacao;
        Voo = voo;
    }

    public override string ToString()
    {
        var partes = new List<string> { $"{Caminhada} m" };
        if (Escavacao is not null) partes.Add($"escavação {Escavacao} m");
        if (Escalada is not null) partes.Add($"escalada {Escalada} m");
        if (Natacao is not null) partes.Add($"natação {Natacao} m");
        if (Voo is not null) partes.Add($"voo {Voo} m");
        return string.Join(", ", partes);
    }

    private static double ValidarDeslocamento(double valor, string modoDeslocamento)
    {
        if (valor < 0)
        {
            throw new ArgumentOutOfRangeException(modoDeslocamento, "O valor do deslocamento não pode ser negativo.");
        }
        return valor;
    }

    private static double? ValidarDeslocamento(double? valor, string modoDeslocamento)
    {
        if (valor is null)
        {
            return null;
        }

        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(
                modoDeslocamento,
                $"O deslocamento de {modoDeslocamento} deve ser maior que zero. Se a criatura não possui esse deslocamento, use null."
                );
        }
        return valor;
    }

}