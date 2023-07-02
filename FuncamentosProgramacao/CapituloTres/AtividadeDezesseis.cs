namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeDezesseis
{
    public static void CalculaHipotenusa()
    {
        double catetoAdjacente;
        double catetoOposto;
        double hipotenusa;

        Console.Write("Informe o valor do cateto adjacente: ");
        catetoAdjacente = Double.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor do cateto oposto: ");
        catetoOposto = Double.Parse(Console.ReadLine()!);

        hipotenusa = Math.Sqrt(Math.Pow(catetoAdjacente, 2) + Math.Pow(catetoOposto, 2));

        Console.WriteLine($"A hipotenusa do triângulo de cateto adjacente {catetoAdjacente}m " +
                          $"e cateto oposto {catetoOposto}m = {hipotenusa:F}m");
    }
}