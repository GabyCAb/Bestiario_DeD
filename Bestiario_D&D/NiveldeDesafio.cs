// NIVEL DE DESAFIO

namespace Bestiario_D_D;

public record NivelDeDesafio
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

    public double Valor { get; init => field = ValidarND(value); }

    public int Experiencia => TabelaXP[Valor];

    public int BonusDeProficiencia => Valor switch
    {
        0 => 2,
        0.125 => 2,
        0.25 => 2,
        0.5 => 2,
        <= 4 => 2,
        <= 8 => 3,
        <= 12 => 4,
        <= 16 => 5,
        <= 20 => 6,
        <= 24 => 7,
        <= 28 => 8,
        _ => 9
    };

    public NivelDeDesafio(double valor)
    {
        Valor = valor;
    }

    public override string ToString()
    {
        return Valor switch
        {
            0 => "0",
            0.125 => "1/8",
            0.25 => "1/4",
            0.5 => "1/2",
            _ => Valor.ToString()
        };
    }

    private static double ValidarND(double valor)
    {
        if (!TabelaXP.ContainsKey(valor))
        {
            throw new ArgumentOutOfRangeException(nameof(valor),
                $"O Nível de Desafio {valor} não existe na tabela do livro. Valores válidos: 0, 1/8, 1/4, 1/2 e de 1 a 30.");
        }
        return valor;
    }

};