namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeDoze
{
    public static void CalculaQuantidadeSalarioMinimo()
    {
        double salarioFuncionario;
        double salarioMinimo;
        double quantidadeSalarioMinimo;

        Console.Write("Informe o salário do funcionário: ");
        salarioFuncionario = Double.Parse(Console.ReadLine()!);
        Console.Write("Informe o valor do salário mínimo: ");
        salarioMinimo = Double.Parse(Console.ReadLine()!);

        quantidadeSalarioMinimo = salarioFuncionario / salarioMinimo;

        Console.WriteLine($"A quandidade de salários mínimos que este funcionário recebe é: {quantidadeSalarioMinimo:F}");
    }
}