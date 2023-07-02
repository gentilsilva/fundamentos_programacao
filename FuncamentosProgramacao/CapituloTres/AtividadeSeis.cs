namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeSeis
{
    public static void CalculaSalario()
    {
        double salario;
        double vendasRealizadas;
        double novoSalario;

        Console.Write("Digite o salário do funcionário: ");
        salario = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o valor total das vendas do funcionário: ");
        vendasRealizadas = double.Parse(Console.ReadLine()!);

        novoSalario = salario + (vendasRealizadas * 0.04);

        Console.WriteLine($"O novo salário do funcionário calculado a partir do salário de {salario}R$ e das vendas {vendasRealizadas}R$ realizadas é: {novoSalario}R$");
    }
}