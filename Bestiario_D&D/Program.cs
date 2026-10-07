using Bestiario_D_D;

Console.WriteLine("Bem-vindo ao Bestiário!");
Console.WriteLine();

var magmin = new Monstro(
    nome: "Magmin",
    classeDeArmadura: 14,
    pontosDeVida: 9,
    deslocamento: 9.0,
    atributos: new Atributos(
        forca: 7,
        destreza: 15,
        constituicao: 12,
        inteligencia: 8,
        sabedoria: 11,
        carisma: 10),
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
        forca: 18,
        destreza: 10,
        constituicao: 17,
        inteligencia: 11,
        sabedoria: 18,
        carisma: 16),
    nivelDeDesafio: 15.0,
    tipo: TipoCriatura.MortoVivo,
    tamanho: Tamanho.Medio
    );

var hipogrifo = new Monstro(
    nome: "Hipogrifo",
    classeDeArmadura: 11,
    pontosDeVida: 19,
    deslocamento: 12.0,
    atributos: new Atributos(
        forca: 17,
        destreza: 13,
        constituicao: 13,
        inteligencia: 2,
        sabedoria: 12,
        carisma: 8),
    nivelDeDesafio: 1.0,
    tipo: TipoCriatura.Monstruosidade,
    tamanho: Tamanho.Grande
);

var bestiario = new List<Monstro>();
bestiario.Add(magmin);
bestiario.Add(senhorDasMumias);
bestiario.Add(hipogrifo);

foreach (var monstro in bestiario)
{
    ExibirMonstro(monstro);
    Console.WriteLine();
}

// FUNÇOES
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

//TESTES

Console.WriteLine($"O bestiário tem {bestiario.Count} monstros.");
Console.WriteLine();

Console.WriteLine(bestiario[5].Nome); // Deve lançar uma exceção de índice fora do intervalo