using Bestiario_D_D;

Console.WriteLine("Bem-vindo ao Bestiário!");
Console.WriteLine();

var magmin = new Monstro
{
    Nome = "Magmin",
    ClasseDeArmadura = 14,
    PontosDeVida = 9,
    Deslocamento = 9.0,
    Forca = 7,
    Destreza = 15,
    NivelDeDesafio = 0.5
};

var senhorDasMumias = new Monstro
{
    Nome = "Senhor das Múmias",
    ClasseDeArmadura = 17,
    PontosDeVida = 97,
    Deslocamento = 6.0,
    Forca = 18,
    Destreza = 10,
    NivelDeDesafio = 15.0
};

void ExibirMonstro(Monstro monstro)
{
    Console.WriteLine($"Nome: {monstro.Nome}");
    Console.WriteLine($"Classe de Armadura: {monstro.ClasseDeArmadura}");
    Console.WriteLine($"Pontos de Vida: {monstro.PontosDeVida}");
    Console.WriteLine($"Deslocamento: {monstro.Deslocamento} metros");
    Console.WriteLine($"Força: {monstro.Forca} (Modificador: {monstro.CalcularModificador(monstro.Forca)})");
    Console.WriteLine($"Destreza: {monstro.Destreza} (Modificador: {monstro.CalcularModificador(monstro.Destreza)})");
    Console.WriteLine($"Nível de Desafio: {monstro.NivelDeDesafio}");
}

ExibirMonstro(magmin);
Console.WriteLine();
ExibirMonstro(senhorDasMumias);

