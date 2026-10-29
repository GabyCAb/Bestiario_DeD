namespace Bestiario_D_D.Dominio.Habilidades;

public abstract class Habilidade
{
    public string Nome { get; }
    public string Descricao { get; }

    protected Habilidade(string nome, string descricao)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);
        ArgumentException.ThrowIfNullOrWhiteSpace(descricao);

        Nome = nome;
        Descricao = descricao;
    }

}
