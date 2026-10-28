// Classe Monstro

using Bestiario_D_D.Dominio.Enums;
using Bestiario_D_D.Dominio.ObjetosDeValor;

namespace Bestiario_D_D.Dominio;

public class Monstro
{
    // Propriedades
    public string Nome { get; }
    public int ClasseDeArmadura { get; }
    public ExpressaoDeDados DadosDeVida { get; }
    public int PontosDeVida => DadosDeVida.Media;
    public Deslocamento Deslocamento { get; }
    public Atributos Atributos { get; }
    public NivelDeDesafio NivelDeDesafio { get; }
    public TipoCriatura Tipo { get; }
    public Tamanho Tamanho { get; }
    public int Experiencia => NivelDeDesafio.Experiencia;
    public IReadOnlyList<Pericia> Pericias { get; }
    public IReadOnlyList<Sentido> Sentidos { get; }

    public int PercepcaoPassiva
    {
        get
        {
            var percepcao = Pericias.FirstOrDefault(p => p.Tipo == TipoPericia.Percepcao);

            if (percepcao is not null)
            {
                return 10 + percepcao.Bonus;
            }

            return 10 + Atributos.ModificadorSabedoria;
        }
    }

    // Construtor
    public Monstro(
        string nome,
        int classeDeArmadura,
        ExpressaoDeDados dadosDeVida,
        Deslocamento deslocamento,
        Atributos atributos,
        NivelDeDesafio nivelDeDesafio,
        TipoCriatura tipo,
        Tamanho tamanho,
        IReadOnlyList<Pericia>? pericias = null,
        IReadOnlyList<Sentido>? sentidos = null
        )
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do monstro é obrigatório.");
        }

        if (classeDeArmadura <= 0)
        {
            throw new ArgumentException("A Classe de Armadura deve ser maior que zero.");
        }

        ArgumentNullException.ThrowIfNull(dadosDeVida);

        if (dadosDeVida.Media < 1)
        {
            throw new ArgumentException("Os Pontos de Vida médios devem ser de pelo menos 1.");
        }

        ArgumentNullException.ThrowIfNull(deslocamento);
        ArgumentNullException.ThrowIfNull(atributos);
        ArgumentNullException.ThrowIfNull(nivelDeDesafio);

        // Atribuições
        Nome = nome;
        ClasseDeArmadura = classeDeArmadura;
        DadosDeVida = dadosDeVida;
        Deslocamento = deslocamento;
        Atributos = atributos;
        NivelDeDesafio = nivelDeDesafio;
        Tipo = tipo;
        Tamanho = tamanho;
        Pericias = (pericias ?? []).ToList();
        Sentidos = (sentidos ?? []).ToList();

        // Regras que envolvem várias partes
        if (Sentidos.GroupBy(s => s.Tipo).Any(grupo => grupo.Count() > 1))
        {
            throw new ArgumentException("Um monstro não pode ter o mesmo sentido mais de uma vez.");
        }
    }
}
