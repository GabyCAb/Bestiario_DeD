using Bestiario_D_D.Dominio.ObjetosDeValor;

namespace Bestiario_D_D.Dominio.Habilidades;

public abstract class Habilidade
{
    public string Nome { get; }
    public string Descricao { get; }
    public LimiteDeUso? LimiteDeUso { get; }
    public virtual string Cabecalho => LimiteDeUso is null ? Nome : $"{Nome} ({LimiteDeUso})";

    protected Habilidade(string nome, string descricao, LimiteDeUso? limiteDeUso)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);
        ArgumentException.ThrowIfNullOrWhiteSpace(descricao);

        Nome = nome;
        Descricao = descricao;
        LimiteDeUso = limiteDeUso;
    }

}
