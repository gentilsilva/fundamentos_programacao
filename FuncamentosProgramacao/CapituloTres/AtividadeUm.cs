namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeUm
{
    public static void SomaNumeros()
    {
        double numeroUm;
        double numeroDois;
        double soma;

        Console.Write("Digite o primeiro valor: ");
        numeroUm = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo valor: ");
        numeroDois = double.Parse(Console.ReadLine()!);

        soma = numeroUm + numeroDois;
        
        Console.WriteLine($"A soma de {numeroUm} com {numeroDois} = {soma}");
    }
}