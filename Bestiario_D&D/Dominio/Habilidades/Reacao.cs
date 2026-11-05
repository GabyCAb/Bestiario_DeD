using Bestiario_D_D.Dominio.ObjetosDeValor;

namespace Bestiario_D_D.Dominio.Habilidades;

public sealed class Reacao : Habilidade
{
    public Reacao(string nome, string descricao, LimiteDeUso? limiteDeUso = null) : base(nome, descricao, limiteDeUso)
    {
    }
}