namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeNove
{
    public static void CalculaAreaTrapezio()
    {
        double baseMaior;
        double baseMenor;
        double altura;
        double areaTrapezio;

        Console.Write("Informe o valor da base maior: ");
        baseMaior = double.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor da base menor: ");
        baseMenor = double.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor da altura: ");
        altura = double.Parse(Console.ReadLine()!);

        areaTrapezio = ((baseMaior + baseMenor) * altura) / 2;

        Console.WriteLine($"A área do trapézio de base maior {baseMaior}m, base menor {baseMenor}m e altura {altura}m " +
                          $"é: {areaTrapezio:F}m²");
    }
}