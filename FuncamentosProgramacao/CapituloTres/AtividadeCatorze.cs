namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeCatorze
{
    public static void CalculaIdade()
    {
        int dataDeNascimento;
        int anoAtual;

        Console.Write("Informe a data de nascimento do usuário: ");
        dataDeNascimento = int.Parse(Console.ReadLine()!);
        Console.Write("Informe o ano atual: ");
        anoAtual = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"A idade da pessoa em anos pe: {anoAtual - dataDeNascimento}");
        Console.WriteLine($"A idade da pessoa em meses é: {(anoAtual - dataDeNascimento) * 12}");
        Console.WriteLine($"A idade da pessoa em dias é: {((anoAtual - dataDeNascimento) * 365)}");
        Console.WriteLine($"A idade da pessoa em semanas é: {(anoAtual - dataDeNascimento) * 52}");
    }
}