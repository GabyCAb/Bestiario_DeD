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
            Cavaleiro(),
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
            acoes:
            [
                new Acao("Mordida", "Ataque Corpo-a-Corpo com Arma: +5 para atingir, alcance 1,5 m, um alvo. Acerto: 7 (1d8 + 3) de dano perfurante mais 7 (2d6) de dano de fogo."),
                // TODO 2.3c: limite de uso (Recarrega 5–6)
                new Acao("Sopro de Fogo", "O cão expele fogo num cone de 4,5 metros. Cada criatura na área deve realizar um teste de resistência de Destreza CD 12, sofrendo 21 (6d6) de dano de fogo se falhar na resistência, ou metade desse dano se obtiver sucesso.")
            ],
            nivelDeDesafio: new NivelDeDesafio(3),
            tipo: TipoCriatura.Corruptor,
            tamanho: Tamanho.Medio
        );
    }

    private static Monstro Cavaleiro()
    {
        return new Monstro(
            nome: "Cavaleiro",
            classeDeArmadura: 18,
            dadosDeVida: new ExpressaoDeDados(8, 8, 16),
            deslocamento: new Deslocamento(9.0),
            atributos: new Atributos(
                forca: 16,
                destreza: 11,
                constituicao: 14,
                inteligencia: 11,
                sabedoria: 11,
                carisma: 15),
            testesDeResistencia: [new TesteDeResistencia(TipoAtributo.Constituicao, 4),
                new TesteDeResistencia(TipoAtributo.Sabedoria, 2)],
            idiomas: [new Idioma("Um idioma qualquer (geralmente Comum)")],
            tracos:
            [
                new Traco("Bravura", "O cavaleiro tem vantagem em testes de resistência para não ser amedrontado.")
            ],
            acoes:
            [
                new Acao("Ataques Múltiplos", "O cavaleiro realiza dois ataques corpo-a-corpo."),
                new Acao("Espada Grande", "Ataque Corpo-a-Corpo com Arma: +5 para atingir, alcance 1,5 m, um alvo. Acerto: 10 (2d6 + 3) de dano cortante."),
                new Acao("Besta Pesada", "Ataque à Distância com Arma: +2 para atingir, distância 30/120 m, um alvo. Acerto: 5 (1d10) de dano perfurante."),
                // TODO 2.3c: limite de uso (Recarrega após um Descanso Curto ou Longo)
                new Acao("Liderança", "Por 1 minuto, o cavaleiro pode proferir um comando ou aviso especial para que qualquer criatura não-hostil que ele possa ver, a até 9 metros dele, realize uma jogada de ataque ou um teste de resistência. A criatura pode adicionar um d4 à jogada, considerando que ela possa ouvir e compreender o cavaleiro. Uma criatura pode ser beneficiada por apenas um dado de Liderança por vez. Esse efeito termina se o cavaleiro estiver incapacitado.")
            ],
            reacoes:
            [
                new Reacao("Aparar", "O cavaleiro adiciona 2 à sua CA contra um ataque corpo-a-corpo que poderia atingi-lo. Para tanto, o cavaleiro deve poder ver o atacante e estar empunhando uma arma corpo-a-corpo.")
            ],
            nivelDeDesafio: new NivelDeDesafio(3),
            tipo: TipoCriatura.Humanoide,
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
            acoes:
            [
                new Acao("Ataques Múltiplos", "O centauro realiza dois ataques: um com sua lança montada e outro com seus cascos ou dois com o arco longo."),
                new Acao("Lança Montada", "Ataque Corpo-a-Corpo com Arma: +6 para atingir, alcance 3 m, um alvo. Acerto: 9 (1d10 + 4) de dano perfurante."),
                new Acao("Cascos", "Ataque Corpo-a-Corpo com Arma: +6 para atingir, alcance 1,5 m, um alvo. Acerto: 11 (2d6 + 4) de dano de concussão."),
                new Acao("Arco Longo", "Ataque à Distância com Arma: +4 para atingir, distância 45/180 m, um alvo. Acerto: 6 (1d8 + 2) de dano perfurante.")
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
            acoes:
            [
                new Acao("Garras", "Ataque Corpo-a-Corpo com Arma: +3 para atingir, alcance 1,5 m, um alvo. Acerto: 1 de dano cortante.")
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
            acoes:
            [
                new Acao("Ataques Múltiplos", "O dragão pode usar sua Presença Aterradora, ele pode então, realizar três ataques: um com sua mordida e dois com suas garras."),
                new Acao("Mordida", "Ataque Corpo-a-Corpo com Arma: +16 para atingir, alcance 4,5 m, um alvo. Acerto: 20 (2d10 + 9) de dano perfurante mais 11 (2d10) de dano elétrico."),
                new Acao("Garra", "Ataque Corpo-a-Corpo com Arma: +16 para atingir, alcance 3 m, um alvo. Acerto: 16 (2d6 + 9) de dano cortante."),
                new Acao("Cauda", "Ataque Corpo-a-Corpo com Arma: +16 para atingir, alcance 6 m, um alvo. Acerto: 18 (2d8 + 9) de dano de concussão."),
                new Acao("Presença Aterradora", "Cada criatura, à escolha do dragão, que esteja a até 36 metros do dragão e esteja ciente disso, deve ser bem sucedida num teste de resistência de Sabedoria CD 20 ou ficará amedrontada por 1 minuto. Uma criatura pode repetir o teste de resistência no final de cada um dos turnos dela, terminando o efeito sobre si, caso obtenha sucesso. Se o teste de resistência de uma criatura for bem sucedido ou caso o efeito termine sobre ela, a criatura ficará imune a Presença Aterradora do dragão pelas próximas 24 horas."),
                // TODO 2.3c: limite de uso (Recarrega 5–6)
                new Acao("Sopro Elétrico", "O dragão pode expelir eletricidade em uma linha com 36 metros de comprimento e 3 metros de largura. Cada criatura na linha deve ser bem sucedida num teste de resistência de Destreza CD 23, sofrendo 88 (16d10) de dano elétrico se falhar na resistência, ou metade desse dano caso obtenha sucesso.")
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
            acoes:
            [
                new Acao("Ataques Múltiplos", "O hipogrifo realiza dois ataques: um com seu bico e um com suas garras."),
                new Acao("Bico", "Ataque Corpo-a-Corpo com Arma: +5 para atingir, alcance 1,5 m, um alvo. Acerto: 8 (1d10 + 3) de dano perfurante."),
                new Acao("Garras", "Ataque Corpo-a-Corpo com Arma: +5 para atingir, alcance 1,5 m, um alvo. Acerto: 10 (2d6 + 3) de dano cortante.")
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
            acoes:
            [
                new Acao("Toque", "Ataque Corpo-a-Corpo com Arma: +4 para atingir, alcance 1,5 m, um alvo. Acerto: 7 (2d6) de dano de fogo. Se o alvo for uma criatura ou um objeto inflamável, ele se incendeia. Até uma criatura usar uma ação para extinguir o fogo, o alvo sofre 3 (1d6) de dano de fogo no final de cada um dos turnos dele.")
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
            acoes:
            [
                new Acao("Mordida", "Ataque Corpo-a-Corpo com Arma: +11 para atingir, alcance 3 m, um alvo. Acerto: 40 (6d10 + 7) de dano perfurante mais 10 (3d6) de dano de fogo. Se o alvo for uma criatura, ela fica agarrada (CD 17 para escapar). Até o agarrão acabar, o alvo fica impedido e o remorhaz não pode morder outro alvo."),
                new Acao("Engolir", "O remorhaz realiza um ataque de mordida contra um alvo Médio ou menor que esteja agarrando. Se o ataque atingir, a criatura sofre o dano da mordida, é engolida e o agarrão termina. Enquanto estiver engolido, o alvo estará cego e impedido, ele terá cobertura total contra ataques e outros efeitos de fora do remorhaz e sofre 21 (6d6) de dano ácido no começo de cada turno do remorhaz.\nSe o remorhaz sofrer 30 de dano ou mais em um único turno por uma criatura engolida, o remorhaz deve ser bem sucedido num teste de resistência de Constituição CD 15 no final desse turno ou regurgitará todas as criaturas engolidas, que cairão em um espaço a até 3 metros do remorhaz. Se o remorhaz morrer, uma criatura engolida não estará mais impedida por ele e poderá escapar do corpo usando 4,5 metros de movimento, estando caída ao sair.")
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
            acoes:
            [
                new Acao("Ataques Múltiplos", "O senhor das múmias pode usar seu Olhar Desesperador e realiza um ataque com seu punho pútrido."),
                new Acao("Punho Pútrido", "Ataque Corpo-a-Corpo com Arma: +9 para atingir, alcance 1,5 m, um alvo. Acerto: 14 (3d6 + 4) de dano de concussão mais 21 (6d6) de dano necrótico. Se o alvo for uma criatura, ele deve ser bem sucedido num teste de resistência de Constituição CD 16 ou será amaldiçoado com a podridão da múmia. O alvo amaldiçoado não pode recuperar pontos de vida e seu máximo de pontos de vida é reduzido em 10 (3d6) a cada 24 horas passadas. Se a maldição reduzir o máximo de pontos de vida do alvo a 0, ele morre e seu corpo se torna pó. A maldição dura até ser removida pela magia remover maldição ou mágica similar."),
                new Acao("Olhar Desesperador", "O senhor das múmias afeta uma criatura que ele possa ver, a até 18 metros dele. Se o alvo puder ver a múmia, ele deve ser bem sucedido num teste de resistência de Sabedoria CD 16 contra essa magia, ou ficará amedrontado até o final do próximo turno da múmia. Se o alvo fracassar no teste de resistência por 5 ou mais, ele também fica paralisado pelo mesmo tempo. Um alvo que seja bem sucedido no teste de resistência fica imune ao Olhar Desesperador de todas as múmias e senhores das múmias pelas próximas 24 horas.")
            ],
            nivelDeDesafio: new NivelDeDesafio(15),
            tipo: TipoCriatura.MortoVivo,
            tamanho: Tamanho.Medio
        );
    }
}
