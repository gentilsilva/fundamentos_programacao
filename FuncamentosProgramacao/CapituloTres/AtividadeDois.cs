namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeDois
{
    public static void MultiplicaNumeros()
    {
        double numeroUm;
        double numeroDois;
        double numeroTres;
        double multiplicacao;

        Console.Write("Digite o valor do primeiro número: ");
        numeroUm = Double.Parse(Console.ReadLine()!);
        Console.Write("Digite o valor do segundo número: ");
        numeroDois = Double.Parse(Console.ReadLine()!);
        Console.Write("Digite o valor do terceiro número: ");
        numeroTres = Double.Parse(Console.ReadLine()!);

        multiplicacao = numeroUm * numeroDois * numeroTres;

        Console.WriteLine($"A multiplicação dos números -> {numeroUm}, {numeroDois}, {numeroTres} = {multiplicacao}");
    }
}