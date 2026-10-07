//ATRIBUTOS

public record Atributos(
    int Forca,
    int Destreza,
    int Constituicao,
    int Inteligencia,
    int Sabedoria,
    int Carisma)
{
    public int ModificadorForca => CalcularModificador(Forca);
    public int ModificadorDestreza => CalcularModificador(Destreza);
    public int ModificadorConstituicao => CalcularModificador(Constituicao);
    public int ModificadorInteligencia => CalcularModificador(Inteligencia);
    public int ModificadorSabedoria => CalcularModificador(Sabedoria);
    public int ModificadorCarisma => CalcularModificador(Carisma);
    private static int CalcularModificador(int atributo)
    {
        int modificador = (int)Math.Floor((atributo - 10) / 2.0);
        return modificador;
    }
}