package capitulo.cinco;

import java.util.Scanner;

public class AtividadeVinteCinco {

    public static void main(String[] args) {

        Scanner leia = new Scanner(System.in);
        int codigoCliente;
        int tipo;
        double valorInvestido;
        double rendimentoMensal;
        double totalInvestido = 0;
        double totalJurosPago = 0;

        while (true) {

            System.out.print("Informe o código do cliente (0 PARA ENCERRAR): ");
            codigoCliente = Integer.parseInt(leia.nextLine());

            if (codigoCliente <= 0) {
                break;
            }

            System.out.println("""
                    Tipo de investimento
                    1 - Poupança - 1.5%
                    2 - Poupança Plus - 2%
                    3 - Fundos de renda fixa - 4%
                    """);
            System.out.print("Escolha: ");
            tipo = Integer.parseInt(leia.nextLine());

            System.out.print("Informe o valor investido: ");
            valorInvestido = Double.parseDouble(leia.nextLine());

            if (tipo == 1) {
                rendimentoMensal = valorInvestido * 0.015;
                System.out.println("O rendimento mensal é: R$" + rendimentoMensal);
                totalInvestido += valorInvestido;
                totalJurosPago += rendimentoMensal;
            } else if (tipo == 2) {
                rendimentoMensal = valorInvestido * 0.02;
                System.out.println("O rendimento mensal é: R$" + rendimentoMensal);
                totalInvestido += valorInvestido;
                totalJurosPago += rendimentoMensal;
            } else if (tipo == 3) {
                rendimentoMensal = valorInvestido * 0.04;
                System.out.println("O rendimento mensal é: R$" + rendimentoMensal);
                totalInvestido += valorInvestido;
                totalJurosPago += rendimentoMensal;
            }
        }

        System.out.println("O total investido foi: R$" + totalInvestido);
        System.out.println("O total de juros pago foi: R$" + totalJurosPago);

    }

}
