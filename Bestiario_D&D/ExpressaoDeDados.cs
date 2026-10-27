namespace Bestiario_D_D;

public record ExpressaoDeDados
{
    private static readonly int[] FacesValidas = [4, 6, 8, 10, 12, 20];

    public int Quantidade { get; init => field = ValidarQuantidade(value); }
    public int Faces { get; init => field = ValidarFaces(value); }
    public int Bonus { get; init; }
    public int Media => (int)Math.Floor(Quantidade * (Faces + 1) / 2.0 + Bonus);

    public ExpressaoDeDados(int quantidade, int faces, int bonus = 0)
    {
        Quantidade = quantidade;
        Faces = faces;
        Bonus = bonus;
    }

    public override string ToString()
    {
        if (Bonus > 0)
        {
            return $"{Quantidade}d{Faces}+{Bonus}";
        }
        else if (Bonus < 0)
        {
            return $"{Quantidade}d{Faces}{Bonus}";
        }
        else
        {
            return $"{Quantidade}d{Faces}";
        }

    }

    private static int ValidarQuantidade(int quantidade)
    {
        if (quantidade < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(quantidade), "A quantidade de dados deve ser maior que zero.");
        }
        return quantidade;
    }

    private static int ValidarFaces(int faces)
    {
        if (!FacesValidas.Contains(faces))
        {
            throw new ArgumentOutOfRangeException(nameof(faces), $"Não existe dado com {faces} faces.");
        }
        return faces;
    }

}
