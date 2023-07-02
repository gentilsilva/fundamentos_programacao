namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeDez
{
    public static void CalculaAreaQuadrado()
    {
        double ladoQuadrado;
        double areaQuadrado;

        Console.Write("Informe o valor do lado do quadrado: ");
        ladoQuadrado = Double.Parse(Console.ReadLine()!);

        areaQuadrado = Math.Pow(ladoQuadrado, 2);

        Console.WriteLine($"A área do quadrado de lado {ladoQuadrado}m é: {areaQuadrado:F}m²");
    } 
}