using Bestiario_D_D;

Console.WriteLine("Bem-vindo ao Bestiário!");
Console.WriteLine();

var magmin = new Monstro(
    "Magmin",
    14,
    9,
    9.0,
    7,
    15,
    0.5,
    TipoCriatura.Elemental,
    Tamanho.Pequeno
);

var senhorDasMumias = new Monstro(
    "Senhor das Múmias",
    17,
    97,
    6.0,
    18,
    10,
    15.0,
    TipoCriatura.MortoVivo,
    Tamanho.Medio
);

void ExibirMonstro(Monstro monstro)
{
    Console.WriteLine($"Nome: {monstro.Nome}");
    Console.WriteLine($"Classe de Armadura: {monstro.ClasseDeArmadura}");
    Console.WriteLine($"Pontos de Vida: {monstro.PontosDeVida}");
    Console.WriteLine($"Deslocamento: {monstro.Deslocamento} metros");
    Console.WriteLine($"Força: {monstro.Forca} ({monstro.CalcularModificador(monstro.Forca):+0;-0;0})");
    Console.WriteLine($"Destreza: {monstro.Destreza} ({monstro.CalcularModificador(monstro.Destreza):+0;-0;0})");
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

