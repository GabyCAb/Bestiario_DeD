using Bestiario_D_D.Apresentacao;
using Bestiario_D_D.Dados;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Bem-vindo ao Bestiário!");
Console.WriteLine();

foreach (var monstro in BestiarioDoLivro.Criar())
{
    ExibicaoDeMonstro.Exibir(monstro);
    Console.WriteLine();
}
