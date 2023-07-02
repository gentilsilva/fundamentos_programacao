namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeSete
{
    public static void CalculaNovoPeso()
    {
        double pesoPessoa;
        double novoPessoEngordar;
        double novoPesoEmagrecer;

        Console.Write("Informe o pesso da pessoa: ");
        pesoPessoa = Double.Parse(Console.ReadLine()!);

        novoPessoEngordar = pesoPessoa * 1.15;
        novoPesoEmagrecer = pesoPessoa * 0.8;

        Console.WriteLine($"Novo peso se a pessoa engordar 15% {novoPessoEngordar:F}");
        Console.WriteLine($"Novo peso se a pessoa emagrecer 20% {novoPesoEmagrecer:F}");
    }
}