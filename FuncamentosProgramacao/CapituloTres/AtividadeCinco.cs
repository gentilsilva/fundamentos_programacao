namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeCinco
{
    public static void Desconto()
    {
        double precoProduto;
        double desconto;

        Console.Write("Informe o preço do produto: ");
        precoProduto = double.Parse(Console.ReadLine()!);

        desconto = precoProduto * 0.9;

        Console.WriteLine($"O produto de valor {precoProduto} com desconto de 10% fica a {desconto}R$");
    }
}