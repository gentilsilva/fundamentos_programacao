package capitulo.cinco;

import java.util.Scanner;

public class AtividadeVinteTres {

    public static void main(String[] args) {

        Scanner leia = new Scanner(System.in);
        int opcao;
        double salario;
        double novoSalario;
        double ferias;
        double decimoTerceiro;
        int mesesTrabalhados;

        while (true) {
            System.out.println("""
                    Menu de opções
                    1 - Novo salário
                    2 - Férias
                    3 - Décimo terceiro
                    4 - Sair
                    """);
            System.out.print("Escolha: ");
            opcao = Integer.parseInt(leia.nextLine());
            System.out.print("Informe o salário: ");
            salario = Double.parseDouble(leia.nextLine());

            do {
                System.out.print("Informe quantos meses trabalhados na empresa: ");
                mesesTrabalhados = Integer.parseInt(leia.nextLine());
                if (mesesTrabalhados > 12) {
                    System.out.println("Meses trabalhados não podem ser maior que 12");
                }
            } while (mesesTrabalhados > 12);


            if (opcao == 1) {
                if (salario <= 210) {
                    novoSalario = salario * 1.15;
                } else if (salario <= 600) {
                    novoSalario = salario * 1.1;
                } else {
                    novoSalario = salario * 1.05;
                }
                System.out.printf("O novo salário do funcionário é: %.2f", novoSalario);
            } else if (opcao == 2) {
                ferias = salario + (salario / 3);
                System.out.printf("As férias do funcionário é: %.2f", ferias);
            } else if (opcao == 3) {
                decimoTerceiro = (salario * mesesTrabalhados) / 12;
                System.out.printf("O valor do décimo terceiro é: %.2f", decimoTerceiro);
            } else if (opcao == 4) {
                break;
            } else {
                System.out.println("Opção inválida.");
            }
            System.out.println();
        }

    }

}
