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
    nivelDeDesafio: 3.0,
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
    nivelDeDesafio: 2.0,
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
    nivelDeDesafio: 0.0,
    tipo: TipoCriatura.Besta,
    tamanho: Tamanho.Miudo
);

var dragaoAzulAnciao = new Monstro(
    nome: "Dragão Azul Ancião",
    classeDeArmadura: 22,
    pontosDeVida: 481,
    deslocamento: new Deslocamento(12.0, voo: 24.0),
    atributos: new Atributos(
        forca: 29,
        destreza: 10,
        constituicao: 27,
        inteligencia: 18,
        sabedoria: 17,
        carisma: 21),
    nivelDeDesafio: 23.0,
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
    nivelDeDesafio: 1.0,
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
    nivelDeDesafio: 0.5,
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
    nivelDeDesafio: 11.0,
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
    nivelDeDesafio: 15.0,
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

Console.WriteLine(new NivelDeDesafio(0.125));   // esperado: 1/8
Console.WriteLine(new NivelDeDesafio(0.5));     // esperado: 1/2
Console.WriteLine(new NivelDeDesafio(0));       // esperado: 0
Console.WriteLine(new NivelDeDesafio(23));      // esperado: 23
Console.WriteLine(new NivelDeDesafio(0.5) == new NivelDeDesafio(0.5)); // esperado: True

try
{
    var invalido = new NivelDeDesafio(7.5);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

var nd = new NivelDeDesafio(3);
Console.WriteLine($"ND {nd}: {nd.Experiencia} XP, proficiência +{nd.BonusDeProficiencia}");

Console.WriteLine(new NivelDeDesafio(0.5).BonusDeProficiencia);   // esperado: 2
Console.WriteLine(new NivelDeDesafio(4).BonusDeProficiencia);     // esperado: 2  (limite!)
Console.WriteLine(new NivelDeDesafio(5).BonusDeProficiencia);     // esperado: 3  (limite!)
Console.WriteLine(new NivelDeDesafio(15).BonusDeProficiencia);    // esperado: 5
Console.WriteLine(new NivelDeDesafio(23).BonusDeProficiencia);    // esperado: 7
Console.WriteLine(new NivelDeDesafio(30).BonusDeProficiencia);    // esperado: 9
Console.WriteLine(new NivelDeDesafio(23).Experiencia);            // esperado: 50000
