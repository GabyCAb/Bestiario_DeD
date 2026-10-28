// IDIOMA

namespace Bestiario_D_D.Dominio.ObjetosDeValor;

public record Idioma
{
    public string Nome { get; init => field = ValidarNome(value); }
    public bool ApenasCompreende { get; init; }

    public Idioma(string nome, bool apenasCompreende = false)
    {
        Nome = nome;
        ApenasCompreende = apenasCompreende;
    }

    private static string ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do idioma é obrigatório.", nameof(nome));
        }

        return nome;
    }
}