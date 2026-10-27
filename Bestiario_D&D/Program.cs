using Bestiario_D_D;

Console.WriteLine("Bem-vindo ao Bestiário!");
Console.WriteLine();

var caoInfernal = new Monstro(
    nome: "Cão Infernal",
    classeDeArmadura: 15,
    pontosDeVida: 45,
    deslocamento: new Deslocamento(15.0),
    atributos: new Atributos(
        forca: 17,
        destreza: 12,
        constituicao: 14,
        inteligencia: 6,
        sabedoria: 13,
        carisma: 6),
    nivelDeDesafio: new NivelDeDesafio(3),
    tipo: TipoCriatura.Corruptor,
    tamanho: Tamanho.Medio
);

var centauro = new Monstro(
    nome: "Centauro",
    classeDeArmadura: 12,
    pontosDeVida: 45,
    deslocamento: new Deslocamento(15.0),
    atributos: new Atributos(
        forca: 18,
        destreza: 14,
        constituicao: 14,
        inteligencia: 9,
        sabedoria: 13,
        carisma: 11),
    nivelDeDesafio: new NivelDeDesafio(2),
    tipo: TipoCriatura.Monstruosidade,
    tamanho: Tamanho.Grande
);

var coruja = new Monstro(
    nome: "Coruja",
    classeDeArmadura: 11,
    pontosDeVida: 1,
    deslocamento: new Deslocamento(1.5, voo: 18.0),
    atributos: new Atributos(
        forca: 3,
        destreza: 13,
        constituicao: 8,
        inteligencia: 2,
        sabedoria: 14,
        carisma: 7),
    nivelDeDesafio: new NivelDeDesafio(0),
    tipo: TipoCriatura.Besta,
    tamanho: Tamanho.Miudo
);

var dragaoAzulAnciao = new Monstro(
    nome: "Dragão Azul Ancião",
    classeDeArmadura: 22,
    pontosDeVida: 481,
    deslocamento: new Deslocamento(12.0, escavacao: 12.0, voo: 24.0),
    atributos: new Atributos(
        forca: 29,
        destreza: 10,
        constituicao: 27,
        inteligencia: 18,
        sabedoria: 17,
        carisma: 21),
    nivelDeDesafio: new NivelDeDesafio(23),
    tipo: TipoCriatura.Dragao,
    tamanho: Tamanho.Imenso
);

var hipogrifo = new Monstro(
    nome: "Hipogrifo",
    classeDeArmadura: 11,
    pontosDeVida: 19,
    deslocamento: new Deslocamento(12.0, voo: 18.0),
    atributos: new Atributos(
        forca: 17,
        destreza: 13,
        constituicao: 13,
        inteligencia: 2,
        sabedoria: 12,
        carisma: 8),
    nivelDeDesafio: new NivelDeDesafio(1),
    tipo: TipoCriatura.Monstruosidade,
    tamanho: Tamanho.Grande
);

var magmin = new Monstro(
    nome: "Magmin",
    classeDeArmadura: 14,
    pontosDeVida: 9,
    deslocamento: new Deslocamento(9.0),
    atributos: new Atributos(
        forca: 7,
        destreza: 15,
        constituicao: 12,
        inteligencia: 8,
        sabedoria: 11,
        carisma: 10),
    nivelDeDesafio: new NivelDeDesafio(0.5),
    tipo: TipoCriatura.Elemental,
    tamanho: Tamanho.Pequeno
);

var remorhaz = new Monstro(
    nome: "Remorhaz",
    classeDeArmadura: 17,
    pontosDeVida: 195,
    deslocamento: new Deslocamento(9.0, escavacao: 6.0),
    atributos: new Atributos(
        forca: 24,
        destreza: 13,
        constituicao: 21,
        inteligencia: 4,
        sabedoria: 10,
        carisma: 5),
    nivelDeDesafio: new NivelDeDesafio(11),
    tipo: TipoCriatura.Monstruosidade,
    tamanho: Tamanho.Enorme
);

var senhorDasMumias = new Monstro(
    nome: "Senhor das Múmias",
    classeDeArmadura: 17,
    pontosDeVida: 97,
    deslocamento: new Deslocamento(6.0),
    atributos: new Atributos(
        forca: 18,
        destreza: 10,
        constituicao: 17,
        inteligencia: 11,
        sabedoria: 18,
        carisma: 16),
    nivelDeDesafio: new NivelDeDesafio(15),
    tipo: TipoCriatura.MortoVivo,
    tamanho: Tamanho.Medio
);

var bestiario = new List<Monstro>();
bestiario.Add(caoInfernal);
bestiario.Add(centauro);
bestiario.Add(coruja);
bestiario.Add(dragaoAzulAnciao);
bestiario.Add(hipogrifo);
bestiario.Add(magmin);
bestiario.Add(remorhaz);
bestiario.Add(senhorDasMumias);

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
    Console.WriteLine($"Deslocamento: {monstro.Deslocamento}");
    Console.WriteLine($"Força: {monstro.Atributos.Forca} ({monstro.Atributos.ModificadorForca:+0;-0;+0})");
    Console.WriteLine($"Destreza: {monstro.Atributos.Destreza} ({monstro.Atributos.ModificadorDestreza:+0;-0;+0})");
    Console.WriteLine($"Constituição: {monstro.Atributos.Constituicao} ({monstro.Atributos.ModificadorConstituicao:+0;-0;+0})");
    Console.WriteLine($"Inteligência: {monstro.Atributos.Inteligencia} ({monstro.Atributos.ModificadorInteligencia:+0;-0;+0})");
    Console.WriteLine($"Sabedoria: {monstro.Atributos.Sabedoria} ({monstro.Atributos.ModificadorSabedoria:+0;-0;+0})");
    Console.WriteLine($"Carisma: {monstro.Atributos.Carisma} ({monstro.Atributos.ModificadorCarisma:+0;-0;+0})");
    Console.WriteLine($"Nível de Desafio: {monstro.NivelDeDesafio} ({monstro.Experiencia:N0} XP)");
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

Console.WriteLine(new ExpressaoDeDados(7, 8, 14));      // Cão Infernal: 7d8 + 14
Console.WriteLine(new ExpressaoDeDados(1, 4, -1));      // Coruja: 1d4 – 1
Console.WriteLine(new ExpressaoDeDados(2, 8));          // exemplo do livro: 2d8
Console.WriteLine(new ExpressaoDeDados(26, 20, 208));   // Dragão Azul Ancião: 26d20 + 208
Console.WriteLine(new ExpressaoDeDados(2, 6, 2) == new ExpressaoDeDados(2, 6, 2)); // True

try
{
    var dadoInexistente = new ExpressaoDeDados(2, 7);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    var semDados = new ExpressaoDeDados(0, 8);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}