namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeOito
{
    public static void CalculeEmGramas()
    {
        double pesoPessoaQuilo;
        double pesoPessoaGrama;

        Console.Write("Informe o pesso em quilos: ");
        pesoPessoaQuilo = Double.Parse(Console.ReadLine()!);

        pesoPessoaGrama = pesoPessoaQuilo * 1000;

        Console.WriteLine($"Uma pessoa com peso de {pesoPessoaQuilo}KG tem em gramas o peso de {pesoPessoaGrama:F}g");
    }
}