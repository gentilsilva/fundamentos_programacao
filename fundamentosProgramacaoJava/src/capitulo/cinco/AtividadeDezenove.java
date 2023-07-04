package capitulo.cinco;

import java.util.Scanner;

public class AtividadeDezenove {

    public static void main(String[] args) {

        Scanner leia = new Scanner(System.in);
        char acao;
        double valorCompra;
        double valorVenda;
        double lucroRetorno;
        double lucroTotal = 0;
        int acoesMaioresQueMil = 0;
        int acoesMenoresQueDuzentos = 0;

        while (true) {
            System.out.print("Informe o tipo de ação (F PARA ENCERRAR): ");
            acao = leia.next().charAt(0);
            leia.nextLine();

            if (acao == 'F') {
                break;
            }

            System.out.print("Informe o valor de compra: ");
            valorCompra = Double.parseDouble(leia.nextLine());
            System.out.print("Informe o valor da venda: ");
            valorVenda = Double.parseDouble(leia.nextLine());

            lucroRetorno = valorVenda - valorCompra;

            System.out.println("O lucro com essa ação será de: " + lucroRetorno);

            if (lucroRetorno > 1000) {
                acoesMaioresQueMil++;
            } else if (lucroRetorno < 200) {
                acoesMenoresQueDuzentos++;
            }

            lucroTotal += lucroRetorno;
        }

        System.out.println("A quantidde de ações com lucro superior a R$ 1000 é: " + acoesMaioresQueMil);
        System.out.println("A quantidde de ações com lucro inferior a R$ 200 é: " + acoesMenoresQueDuzentos);
        System.out.println("o lucro total da empresa é: R$" + lucroTotal);
    }

}
