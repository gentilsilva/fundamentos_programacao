namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeOnze
{
    public static void CalculaAreaLosango()
    {
        double diagonalMaior;
        double diagonalMenor;
        double areaLosango;

        Console.Write("Informe o valor da diagonal maior: ");
        diagonalMaior = Double.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor da diagonal menor: ");
        diagonalMenor = double.Parse(Console.ReadLine()!);

        areaLosango = (diagonalMaior * diagonalMenor) / 2;

        Console.WriteLine($"A área do losando de diagonal maior {diagonalMaior}m e diagonal menor {diagonalMenor}m " +
                          $"é: {areaLosango:F}m²");
    }
}