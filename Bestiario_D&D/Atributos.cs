//ATRIBUTOS

public record Atributos
{

    public int Forca { get; init => field = ValidarAtributo(value, "A Força"); }
    public int Destreza { get; init => field = ValidarAtributo(value, "A Destreza"); }
    public int Constituicao { get; init => field = ValidarAtributo(value, "A Constituição"); }
    public int Inteligencia { get; init => field = ValidarAtributo(value, "A Inteligência"); }
    public int Sabedoria { get; init => field = ValidarAtributo(value, "A Sabedoria"); }
    public int Carisma { get; init => field = ValidarAtributo(value, "O Carisma"); }

    public int ModificadorForca => CalcularModificador(Forca);
    public int ModificadorDestreza => CalcularModificador(Destreza);
    public int ModificadorConstituicao => CalcularModificador(Constituicao);
    public int ModificadorInteligencia => CalcularModificador(Inteligencia);
    public int ModificadorSabedoria => CalcularModificador(Sabedoria);
    public int ModificadorCarisma => CalcularModificador(Carisma);

    public Atributos(
        int forca,
        int destreza,
        int constituicao,
        int inteligencia,
        int sabedoria,
        int carisma)
    {
        Forca = forca;
        Destreza = destreza;
        Constituicao = constituicao;
        Inteligencia = inteligencia;
        Sabedoria = sabedoria;
        Carisma = carisma;
    }
    
    private static int CalcularModificador(int atributo)
    {
        int modificador = (int)Math.Floor((atributo - 10) / 2.0);
        return modificador;
    }

    private static int ValidarAtributo(int valor, string atributo)
    {
        if (valor < 1 || valor > 30)
        {
            throw new ArgumentOutOfRangeException(atributo, "O valor do atributo deve estar entre 1 e 30.");
        }
        return valor;
    }
}