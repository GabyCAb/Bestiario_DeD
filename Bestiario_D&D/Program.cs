Console.WriteLine("Bem-vindo ao Bestiário!");

//Escolha um monstro do Manual dos Monstros e, no Program.cs, crie variáveis para representar parte do bloco de estatísticas dele:
// nome, Classe de Armadura, Pontos de Vida, deslocamento (em metros), o valor de Força e o Nível de Desafio.

string nome = "Magmin";
int classeDeArmadura = 14;
int pontosDeVida = 9;
double deslocamento = 9.0;
int forca = 7;
int destreza = 15;
double  nivelDeDesafio = 0.5;

int CalcularModificador(int valorAtributo)
{
    int modificador = (int)Math.Floor((valorAtributo - 10) / 2.0);
    return modificador;
}

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Classe de Armadura: {classeDeArmadura}");
Console.WriteLine($"Pontos de Vida: {pontosDeVida}");
Console.WriteLine($"Deslocamento: {deslocamento} metros");
Console.WriteLine($"Força: {forca} ({CalcularModificador(forca):+0;-0;0})");
Console.WriteLine($"Destreza: {destreza} ({CalcularModificador(destreza):+0;-0;0})");
Console.WriteLine($"Nível de Desafio: {nivelDeDesafio}");
