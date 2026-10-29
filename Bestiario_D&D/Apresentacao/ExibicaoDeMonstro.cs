// Exibição dos monstros no formato do bloco de estatísticas

using Bestiario_D_D.Dominio;
using Bestiario_D_D.Dominio.Enums;

namespace Bestiario_D_D.Apresentacao;

public static class ExibicaoDeMonstro
{
    public static void Exibir(Monstro monstro)
    {
        Console.WriteLine($"Nome: {monstro.Nome}");
        Console.WriteLine($"Classe de Armadura: {monstro.ClasseDeArmadura}");
        Console.WriteLine($"Pontos de Vida: {monstro.PontosDeVida} ({monstro.DadosDeVida})");
        Console.WriteLine($"Deslocamento: {monstro.Deslocamento}");
        Console.WriteLine($"Força: {monstro.Atributos.Forca} ({monstro.Atributos.ModificadorForca:+0;-0;+0})");
        Console.WriteLine($"Destreza: {monstro.Atributos.Destreza} ({monstro.Atributos.ModificadorDestreza:+0;-0;+0})");
        Console.WriteLine($"Constituição: {monstro.Atributos.Constituicao} ({monstro.Atributos.ModificadorConstituicao:+0;-0;+0})");
        Console.WriteLine($"Inteligência: {monstro.Atributos.Inteligencia} ({monstro.Atributos.ModificadorInteligencia:+0;-0;+0})");
        Console.WriteLine($"Sabedoria: {monstro.Atributos.Sabedoria} ({monstro.Atributos.ModificadorSabedoria:+0;-0;+0})");
        Console.WriteLine($"Carisma: {monstro.Atributos.Carisma} ({monstro.Atributos.ModificadorCarisma:+0;-0;+0})");

        if (monstro.TestesDeResistencia.Any())
        {
            var textoTestes = string.Join(", ", monstro.TestesDeResistencia.Select(t => $"{AbreviarAtributo(t.Atributo)} {t.Bonus:+0;-0;+0}"));
            Console.WriteLine($"Testes de Resistência: {textoTestes}");
        }

        if (monstro.Pericias.Any())
        {
            var textoPericias = string.Join(", ", monstro.Pericias.Select(p => $"{TraduzirPericia(p.Tipo)} {p.Bonus:+0;-0;+0}"));
            Console.WriteLine($"Perícias: {textoPericias}");
        }

        var partesSentidos = monstro.Sentidos.Select(s => $"{TraduzirSentido(s.Tipo)} {s.Alcance} m").ToList();
        partesSentidos.Add($"Percepção passiva {monstro.PercepcaoPassiva}");
        Console.WriteLine($"Sentidos: {string.Join(", ", partesSentidos)}");

        var falados = monstro.Idiomas.Where(i => !i.ApenasCompreende).Select(i => i.Nome).ToList();
        var compreendidos = monstro.Idiomas.Where(i => i.ApenasCompreende).Select(i => i.Nome).ToList();

        var partesIdiomas = new List<string>(falados);
        if (compreendidos.Any())
        {
            partesIdiomas.Add($"compreende {string.Join(", ", compreendidos)} mas não pode falar");
        }

        var textoIdiomas = partesIdiomas.Any() ? string.Join(", ", partesIdiomas) : "–";
        Console.WriteLine($"Idiomas: {textoIdiomas}");

        Console.WriteLine($"Nível de Desafio: {monstro.NivelDeDesafio} ({monstro.Experiencia:N0} XP)");
        Console.WriteLine($"{TraduzirTipo(monstro.Tipo)} {TraduzirTamanho(monstro.Tamanho)}");

        if (monstro.Tracos.Any())
        {
            Console.WriteLine("Traços:");
            foreach (var traco in monstro.Tracos)
            {
                Console.WriteLine($"- {traco.Nome}: {traco.Descricao}");
            }
        }
    }

    // função para converter o tipo de criatura em uma string amigável
    private static string TraduzirTipo(TipoCriatura tipo)
    {
        return tipo switch
        {
            TipoCriatura.Aberracao => "Aberração",
            TipoCriatura.Dragao => "Dragão",
            TipoCriatura.MortoVivo => "Morto-Vivo",
            _ => tipo.ToString()
        };
    }

    // função para converter o tamanho em uma string amigável
    private static string TraduzirTamanho(Tamanho tamanho)
    {
        return tamanho switch
        {
            Tamanho.Miudo => "Miúdo",
            Tamanho.Medio => "Médio",
            _ => tamanho.ToString()
        };
    }

    // função para converter o tipo de perícia em uma string amigável
    private static string TraduzirPericia(TipoPericia tipo)
    {
        return tipo switch
        {
            TipoPericia.Atuacao => "Atuação",
            TipoPericia.Enganacao => "Enganação",
            TipoPericia.Historia => "História",
            TipoPericia.Intimidacao => "Intimidação",
            TipoPericia.Intuicao => "Intuição",
            TipoPericia.Investigacao => "Investigação",
            TipoPericia.LidarComAnimais => "Lidar com Animais",
            TipoPericia.Percepcao => "Percepção",
            TipoPericia.Persuasao => "Persuasão",
            TipoPericia.Prestidigitacao => "Prestidigitação",
            TipoPericia.Religiao => "Religião",
            TipoPericia.Sobrevivencia => "Sobrevivência",
            _ => tipo.ToString()
        };
    }

    // função para converter o tipo de sentido em uma string amigável
    private static string TraduzirSentido(TipoSentido tipo)
    {
        return tipo switch
        {
            TipoSentido.PercepcaoAsCegas => "Percepção às Cegas",
            TipoSentido.SentidoSismico => "Sentido Sísmico",
            TipoSentido.VisaoNoEscuro => "Visão no Escuro",
            TipoSentido.VisaoVerdadeira => "Visão Verdadeira",
            _ => tipo.ToString()
        };
    }

    // função para abreviação de atributos
    private static string AbreviarAtributo(TipoAtributo atributo)
    {
        return atributo switch
        {
            TipoAtributo.Forca => "FOR",
            TipoAtributo.Destreza => "DES",
            TipoAtributo.Constituicao => "CON",
            TipoAtributo.Inteligencia => "INT",
            TipoAtributo.Sabedoria => "SAB",
            TipoAtributo.Carisma => "CAR",
            _ => atributo.ToString()
        };
    }
}
