// Monstros cadastrados a partir do Manual dos Monstros

using Bestiario_D_D.Dominio;
using Bestiario_D_D.Dominio.Enums;
using Bestiario_D_D.Dominio.ObjetosDeValor;

namespace Bestiario_D_D.Dados;

public static class BestiarioDoLivro
{
    public static IReadOnlyList<Monstro> Criar()
    {
        return
        [
            CaoInfernal(),
            Centauro(),
            Coruja(),
            DragaoAzulAnciao(),
            Hipogrifo(),
            Magmin(),
            Remorhaz(),
            SenhorDasMumias()
        ];
    }

    private static Monstro CaoInfernal()
    {
        return new Monstro(
            nome: "Cão Infernal",
            classeDeArmadura: 15,
            dadosDeVida: new ExpressaoDeDados(7, 8, 14),
            deslocamento: new Deslocamento(15.0),
            atributos: new Atributos(
                forca: 17,
                destreza: 12,
                constituicao: 14,
                inteligencia: 6,
                sabedoria: 13,
                carisma: 6),
            pericias: [new Pericia(TipoPericia.Percepcao, 5)],
            sentidos: [new Sentido(TipoSentido.VisaoNoEscuro, 18)],
            nivelDeDesafio: new NivelDeDesafio(3),
            tipo: TipoCriatura.Corruptor,
            tamanho: Tamanho.Medio
        );
    }

    private static Monstro Centauro()
    {
        return new Monstro(
            nome: "Centauro",
            classeDeArmadura: 12,
            dadosDeVida: new ExpressaoDeDados(6, 10, 12),
            deslocamento: new Deslocamento(15.0),
            atributos: new Atributos(
                forca: 18,
                destreza: 14,
                constituicao: 14,
                inteligencia: 9,
                sabedoria: 13,
                carisma: 11),
            pericias: [new Pericia(TipoPericia.Atletismo, 6),
                new Pericia(TipoPericia.Percepcao, 3),
                new Pericia(TipoPericia.Sobrevivencia, 3)],
            nivelDeDesafio: new NivelDeDesafio(2),
            tipo: TipoCriatura.Monstruosidade,
            tamanho: Tamanho.Grande
        );
    }

    private static Monstro Coruja()
    {
        return new Monstro(
            nome: "Coruja",
            classeDeArmadura: 11,
            dadosDeVida: new ExpressaoDeDados(1, 4, -1),
            deslocamento: new Deslocamento(1.5, voo: 18.0),
            atributos: new Atributos(
                forca: 3,
                destreza: 13,
                constituicao: 8,
                inteligencia: 2,
                sabedoria: 14,
                carisma: 7),
            pericias: [new Pericia(TipoPericia.Furtividade, 3),
                new Pericia(TipoPericia.Percepcao, 4)],
            sentidos: [new Sentido(TipoSentido.VisaoNoEscuro, 36)],
            nivelDeDesafio: new NivelDeDesafio(0),
            tipo: TipoCriatura.Besta,
            tamanho: Tamanho.Miudo
        );
    }

    private static Monstro DragaoAzulAnciao()
    {
        return new Monstro(
            nome: "Dragão Azul Ancião",
            classeDeArmadura: 22,
            dadosDeVida: new ExpressaoDeDados(26, 20, 208),
            deslocamento: new Deslocamento(12.0, escavacao: 12.0, voo: 24.0),
            atributos: new Atributos(
                forca: 29,
                destreza: 10,
                constituicao: 27,
                inteligencia: 18,
                sabedoria: 17,
                carisma: 21),
            testesDeResistencia: [new TesteDeResistencia(TipoAtributo.Destreza, 7),
                new TesteDeResistencia(TipoAtributo.Constituicao, 15),
                new TesteDeResistencia(TipoAtributo.Sabedoria, 10),
                new TesteDeResistencia(TipoAtributo.Carisma, 12)],
            pericias: [new Pericia(TipoPericia.Furtividade, 7),
                new Pericia(TipoPericia.Percepcao, 17)],
            sentidos: [new Sentido(TipoSentido.PercepcaoAsCegas, 18),
                new Sentido(TipoSentido.VisaoNoEscuro, 36)],
            nivelDeDesafio: new NivelDeDesafio(23),
            tipo: TipoCriatura.Dragao,
            tamanho: Tamanho.Imenso
        );
    }

    private static Monstro Hipogrifo()
    {
        return new Monstro(
            nome: "Hipogrifo",
            classeDeArmadura: 11,
            dadosDeVida: new ExpressaoDeDados(3, 10, 3),
            deslocamento: new Deslocamento(12.0, voo: 18.0),
            atributos: new Atributos(
                forca: 17,
                destreza: 13,
                constituicao: 13,
                inteligencia: 2,
                sabedoria: 12,
                carisma: 8),
            pericias: [new Pericia(TipoPericia.Percepcao, 5)],
            nivelDeDesafio: new NivelDeDesafio(1),
            tipo: TipoCriatura.Monstruosidade,
            tamanho: Tamanho.Grande
        );
    }

    private static Monstro Magmin()
    {
        return new Monstro(
            nome: "Magmin",
            classeDeArmadura: 14,
            dadosDeVida: new ExpressaoDeDados(2, 6, 2),
            deslocamento: new Deslocamento(9.0),
            atributos: new Atributos(
                forca: 7,
                destreza: 15,
                constituicao: 12,
                inteligencia: 8,
                sabedoria: 11,
                carisma: 10),
            sentidos: [new Sentido(TipoSentido.VisaoNoEscuro, 18)],
            nivelDeDesafio: new NivelDeDesafio(0.5),
            tipo: TipoCriatura.Elemental,
            tamanho: Tamanho.Pequeno
        );
    }

    private static Monstro Remorhaz()
    {
        return new Monstro(
            nome: "Remorhaz",
            classeDeArmadura: 17,
            dadosDeVida: new ExpressaoDeDados(17, 12, 85),
            deslocamento: new Deslocamento(9.0, escavacao: 6.0),
            atributos: new Atributos(
                forca: 24,
                destreza: 13,
                constituicao: 21,
                inteligencia: 4,
                sabedoria: 10,
                carisma: 5),
            sentidos: [new Sentido(TipoSentido.VisaoNoEscuro, 18), 
                new Sentido(TipoSentido.SentidoSismico, 18)],
            nivelDeDesafio: new NivelDeDesafio(11),
            tipo: TipoCriatura.Monstruosidade,
            tamanho: Tamanho.Enorme
        );
    }

    private static Monstro SenhorDasMumias()
    {
        return new Monstro(
            nome: "Senhor das Múmias",
            classeDeArmadura: 17,
            dadosDeVida: new ExpressaoDeDados(13, 8, 39),
            deslocamento: new Deslocamento(6.0),
            atributos: new Atributos(
                forca: 18,
                destreza: 10,
                constituicao: 17,
                inteligencia: 11,
                sabedoria: 18,
                carisma: 16),
            testesDeResistencia: [new TesteDeResistencia(TipoAtributo.Constituicao, 8),
                new TesteDeResistencia(TipoAtributo.Inteligencia, 5),
                new TesteDeResistencia(TipoAtributo.Sabedoria, 9),
                new TesteDeResistencia(TipoAtributo.Carisma, 8)],
            pericias: [new Pericia(TipoPericia.Historia, 5),
                new Pericia(TipoPericia.Religiao, 5)],
            sentidos: [new Sentido(TipoSentido.VisaoNoEscuro, 18)],
            nivelDeDesafio: new NivelDeDesafio(15),
            tipo: TipoCriatura.MortoVivo,
            tamanho: Tamanho.Medio
        );
    }
}
