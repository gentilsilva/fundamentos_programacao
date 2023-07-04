package capitulo.cinco;

import java.util.Scanner;

public class AtividadeVinte {

    public static void main(String[] args) {

        Scanner leia = new Scanner(System.in);
        int opcao;
        double notaUm;
        double notaDois;
        double notaTres;
        int pesoUm;
        int pesoDois;
        int pesoTres;
        int somaPesos;
        double somaNotas;
        double media = 0;

        do {
            System.out.println("""
                    Menu de opções:
                    1 - Média aritmética
                    2 - Média Ponderada
                    3 - sair
                    """);

            System.out.print("Infome a opção desejada: ");
            opcao = Integer.parseInt(leia.nextLine());

            if (opcao == 1) {
                System.out.print("Informe a primeira nota: ");
                notaUm = Double.parseDouble(leia.nextLine());
                System.out.print("Informe a segunda nota: ");
                notaDois = Double.parseDouble(leia.nextLine());

                somaNotas = notaUm + notaDois;
                media = somaNotas / 2;
            } else if (opcao == 2) {
                System.out.print("Informe a primeira nota: ");
                notaUm = Double.parseDouble(leia.nextLine());
                System.out.print("Informe o primeiro peso: ");
                pesoUm = Integer.parseInt(leia.nextLine());
                System.out.print("Informe a segunda nota: ");
                notaDois = Double.parseDouble(leia.nextLine());
                System.out.print("Informe o segundo peso: ");
                pesoDois = Integer.parseInt(leia.nextLine());
                System.out.print("Informe a terceira nota: ");
                notaTres = Double.parseDouble(leia.nextLine());
                System.out.print("Informe o terceiro peso: ");
                pesoTres = Integer.parseInt(leia.nextLine());

                somaPesos = pesoUm + pesoDois + pesoTres;
                media = ((notaUm * pesoUm) + (notaDois * pesoDois) + (notaTres * pesoTres)) / somaPesos;
            }

            System.out.println("A média das notas é: " + media);

        }while (opcao != 3);

    }

}
