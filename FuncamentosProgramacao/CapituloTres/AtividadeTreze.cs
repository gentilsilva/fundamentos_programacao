namespace FuncamentosProgramacao.CapituloTres;

public class AtividadeTreze
{
    public static void CalculaTabuada()
    {
        int numeroTabuada;

        Console.Write("Informe qual o valor que deseja calcular: ");
        numeroTabuada = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"{numeroTabuada} * 0 = {numeroTabuada * 0}");
        Console.WriteLine($"{numeroTabuada} * 1 = {numeroTabuada * 1}");
        Console.WriteLine($"{numeroTabuada} * 2 = {numeroTabuada * 2}");
        Console.WriteLine($"{numeroTabuada} * 3 = {numeroTabuada * 3}");
        Console.WriteLine($"{numeroTabuada} * 4 = {numeroTabuada * 4}");
        Console.WriteLine($"{numeroTabuada} * 5 = {numeroTabuada * 5}");
        Console.WriteLine($"{numeroTabuada} * 6 = {numeroTabuada * 6}");
        Console.WriteLine($"{numeroTabuada} * 7 = {numeroTabuada * 7}");
        Console.WriteLine($"{numeroTabuada} * 8 = {numeroTabuada * 8}");
        Console.WriteLine($"{numeroTabuada} * 9 = {numeroTabuada * 9}");
        Console.WriteLine($"{numeroTabuada} * 10 = {numeroTabuada * 10}");
    }
}