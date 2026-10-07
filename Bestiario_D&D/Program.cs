using Bestiario_D_D;

Console.WriteLine("Bem-vindo ao Bestiário!");
Console.WriteLine();

var magmin = new Monstro(
    nome: "Magmin",
    classeDeArmadura: 14,
    pontosDeVida: 9,
    deslocamento: 9.0,
    atributos: new Atributos(
        Forca: 7,
        Destreza: 15,
        Constituicao: 12,
        Inteligencia: 8,
        Sabedoria: 11,
        Carisma: 10),
    nivelDeDesafio: 0.5,
    tipo: TipoCriatura.Elemental,
    tamanho: Tamanho.Pequeno
);

var senhorDasMumias = new Monstro(
    nome: "Senhor das Múmias",
    classeDeArmadura: 17,
    pontosDeVida: 97,
    deslocamento: 6.0,
    atributos: new Atributos(
        Forca: 18,
        Destreza: 10,
        Constituicao: 17,
        Inteligencia: 11,
        Sabedoria: 18,
        Carisma: 16),
    nivelDeDesafio: 15.0,
    tipo: TipoCriatura.MortoVivo,
    tamanho: Tamanho.Medio
    );

void ExibirMonstro(Monstro monstro)
{
    Console.WriteLine($"Nome: {monstro.Nome}");
    Console.WriteLine($"Classe de Armadura: {monstro.ClasseDeArmadura}");
    Console.WriteLine($"Pontos de Vida: {monstro.PontosDeVida}");
    Console.WriteLine($"Deslocamento: {monstro.Deslocamento} metros");
    Console.WriteLine($"Força: {monstro.Atributos.Forca} ({monstro.Atributos.ModificadorForca:+0;-0;0})");
    Console.WriteLine($"Destreza: {monstro.Atributos.Destreza} ({monstro.Atributos.ModificadorDestreza:+0;-0;0})");
    Console.WriteLine($"Constituição: {monstro.Atributos.Constituicao} ({monstro.Atributos.ModificadorConstituicao:+0;-0;0})");
    Console.WriteLine($"Inteligência: {monstro.Atributos.Inteligencia} ({monstro.Atributos.ModificadorInteligencia:+0;-0;0})");
    Console.WriteLine($"Sabedoria: {monstro.Atributos.Sabedoria} ({monstro.Atributos.ModificadorSabedoria:+0;-0;0})");
    Console.WriteLine($"Carisma: {monstro.Atributos.Carisma} ({monstro.Atributos.ModificadorCarisma:+0;-0;0})");
    Console.WriteLine($"Nível de Desafio: {monstro.NivelDeDesafio}");
    Console.WriteLine($"{TraduzirTipo(monstro.Tipo)} {TraduzirTamanho(monstro.Tamanho)}");
}

//funçao para converter o tipo de criatura em uma string amigável
string TraduzirTipo(TipoCriatura tipo)
{
    return tipo switch
    {
        TipoCriatura.Aberracao => "Aberração",
        TipoCriatura.Dragao => "Dragão",
        TipoCriatura.MortoVivo => "Morto-Vivo",
        _ => tipo.ToString()
    };
}

//função para converter o tamanho em uma string amigável
string TraduzirTamanho(Tamanho tamanho)
{
    return tamanho switch
    {
        Tamanho.Miudo => "Miúdo",
        Tamanho.Medio => "Médio",
        _ => tamanho.ToString()
    };
}

ExibirMonstro(magmin);
Console.WriteLine();
ExibirMonstro(senhorDasMumias);

Console.WriteLine();
Console.WriteLine("=== Experimentos ===");

// 1. Exibição automática
Console.WriteLine(magmin.Atributos);

// 2. Igualdade por valor
var a1 = new Atributos(10, 10, 10, 10, 10, 10);
var a2 = new Atributos(10, 10, 10, 10, 10, 10);
Console.WriteLine(a1 == a2);

// 3. Cópia com alteração
var magminForte = magmin.Atributos with { Forca = 10 };
Console.WriteLine(magminForte);
Console.WriteLine(magmin.Atributos.Forca);