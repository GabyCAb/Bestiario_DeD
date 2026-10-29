// Monstros cadastrados a partir do Manual dos Monstros

using Bestiario_D_D.Dominio;
using Bestiario_D_D.Dominio.Enums;
using Bestiario_D_D.Dominio.Habilidades;
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
            idiomas: [new Idioma("Infernal", apenasCompreende: true)],
            tracos:
            [
                new Traco("Audição e Faro Aguçados", "O cão tem vantagem em testes de Sabedoria (Percepção) relacionados à audição e ao olfato."),
                new Traco("Táticas de Matilha", "O cão tem vantagem nas jogadas de ataque contra uma criatura se, pelo menos, um dos aliados do cão estiver a 1,5 metro da criatura e não estiver incapacitado.")
            ],
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
            idiomas: [new Idioma("Élfico"), new Idioma("Silvestre")],
            tracos:
            [
                new Traco("Investida", "Se o centauro se mover, pelo menos, 9 metros em linha reta até um alvo e então atingi-lo com um ataque de lança montada no mesmo turno, o alvo sofre 10 (3d6) de dano perfurante extra.")
            ],
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
            tracos:
            [
                new Traco("Sobrevoo", "A coruja não provoca ataques de oportunidade quando voa para fora do alcance de um inimigo."),
                new Traco("Visão e Audição Aguçadas", "A coruja tem vantagem em testes de Sabedoria (Percepção) relacionados à visão e à audição.")
            ],
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
            idiomas: [new Idioma("Comum"), new Idioma("Dracônico")],
            tracos:
            [
                // TODO 2.3c: limite de uso (3/Dia)
                new Traco("Resistência Lendária", "Se o dragão falhar em um teste de resistência, ele pode escolher obter sucesso, no lugar.")
            ],
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
            tracos:
            [
                new Traco("Visão Aguçada", "O hipogrifo tem vantagem em testes de Sabedoria (Percepção) relacionados à visão.")
            ],
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
            idiomas: [new Idioma("Ignan")],
            tracos:
            [
                new Traco("Explosão da Morte", "Quando o magmin morre, ele explode numa erupção de fogo e magma. Cada criatura a até 3 metros dele deve realizar um teste de resistência de Destreza CD 11, sofrendo 7 (2d6) de dano de fogo numa falha na resistência, ou metade desse dano num sucesso. Objetos inflamáveis que não estejam sendo vestidos ou carregados na área são incendiados."),
                new Traco("Iluminação Inflamável", "Com uma ação bônus, o magmin pode se incendiar ou extinguir suas chamas. Enquanto estiver em chamas, o magmin emite luz plena num raio de 3 metros e penumbra por mais 3 metros adicionais.")
            ],
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
            tracos:
            [
                new Traco("Corpo Aquecido", "Uma criatura que toque o remorhaz ou atinja-o com um ataque corpo-a-corpo a 1,5 metro dele sofre 10 (3d6) de dano de fogo.")
            ],
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
            idiomas: [new Idioma("Os idiomas que conhecia em vida")],
            tracos:
            [
                new Traco("Conjuração", "O senhor das múmias é um conjurador de 10° nível. Sua habilidade de conjuração é Sabedoria (CD de resistência de magia 17, +9 para atingir com ataques com magia). Ele possui as seguintes magias de clérigo preparadas:\nTruques (à vontade): chama sagrada, taumaturgia\n1° nível (4 espaços): comando, escudo da fé, raio teleguiado\n2° nível (3 espaços): arma espiritual, imobilizar pessoa, silêncio\n3° nível (3 espaços): animar mortos, dissipar magia\n4° nível (3 espaços): adivinhação, guardião da fé\n5° nível (2 espaços): praga, praga de insetos\n6° nível (1 espaço): ferimento pleno"),
                new Traco("Rejuvenescimento", "Um senhor das múmias destruído adquire um novo corpo em 24 horas, se seu coração estiver intacto, recuperando todos os seus pontos de vida e se tornando ativo novamente. O novo corpo aparece a 1,5 metro do coração do senhor das múmias."),
                new Traco("Resistência à Magia", "O senhor das múmias tem vantagem em testes de resistência contra magias e outros efeitos mágicos.")
            ],
            nivelDeDesafio: new NivelDeDesafio(15),
            tipo: TipoCriatura.MortoVivo,
            tamanho: Tamanho.Medio
        );
    }
}
