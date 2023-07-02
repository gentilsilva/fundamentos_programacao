namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeTres
{
    public static void DivideNumeros()
    {
        double dividendo;
        double divisor;
        double quociente;

        Console.Write("Digite o denominador: ");
        dividendo = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o divisor: ");
        divisor = double.Parse(Console.ReadLine()!);

        quociente = dividendo / divisor;

        Console.WriteLine($"A divisao de {dividendo} por {divisor} = {quociente:F}");
    }
}