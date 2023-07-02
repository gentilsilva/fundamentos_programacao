namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeQuinze
{
    public static void CalculaRestoSalario()
    {
        double salario;
        double contaUm;
        double contaDois;
        double restoSalario;

        Console.Write("Informe o salário da pessoa: ");
        salario = Double.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor da primeira conta: ");
        contaUm = Double.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor da segunda conta: ");
        contaDois = Double.Parse(Console.ReadLine()!);

        restoSalario = salario - ((contaUm * 1.02) + (contaDois * 1.02));

        Console.WriteLine($"O que sobra do salário da pessoa ao pagar as contas é: {restoSalario:F}");
    }
}