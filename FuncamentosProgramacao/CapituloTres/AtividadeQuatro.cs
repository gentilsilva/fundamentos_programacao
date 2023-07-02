namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeQuatro
{
    public static void CalculaMedia()
    {
        double notaUm;
        double notaDois;
        double mediaPonderada;

        Console.Write("Digite o valor da primeira nota: ");
        notaUm = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o valor da segunda nota: ");
        notaDois = double.Parse(Console.ReadLine()!);

        mediaPonderada = ((notaUm * 2) + (notaDois * 3)) / 5;

        Console.WriteLine($"A média ponderada das notas {notaUm} e {notaDois} = {mediaPonderada:F}");
    }
}