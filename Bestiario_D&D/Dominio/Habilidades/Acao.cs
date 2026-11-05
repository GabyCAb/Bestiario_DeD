using Bestiario_D_D.Dominio.ObjetosDeValor;

namespace Bestiario_D_D.Dominio.Habilidades;

public sealed class Acao : Habilidade
{
    public Acao(string nome, string descricao, LimiteDeUso? limiteDeUso = null) : base(nome, descricao, limiteDeUso)
    {
    }
}