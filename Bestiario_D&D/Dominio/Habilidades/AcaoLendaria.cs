using Bestiario_D_D.Dominio.ObjetosDeValor;

namespace Bestiario_D_D.Dominio.Habilidades;

public sealed class AcaoLendaria : Habilidade
{
    public int Custo { get; }

    public override string Cabecalho => Custo > 1 ? $"{base.Cabecalho} (Custa {Custo} Ações)" : base.Cabecalho;

    public AcaoLendaria(string nome, string descricao, int custo = 1, LimiteDeUso? limiteDeUso = null) 
        : base(nome, descricao, limiteDeUso)
    {
        if (custo < 1 || custo > 3)
        {
            throw new ArgumentOutOfRangeException(nameof(custo),
                "O custo de uma ação lendária deve ser de 1 a 3 ações. Para 'Custa 2 Ações', informe 2; " +
                "se o livro não indica custo, não informe (o padrão é 1).");
        }
        Custo = custo;
    }
}