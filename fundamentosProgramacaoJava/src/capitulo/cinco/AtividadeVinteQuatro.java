package capitulo.cinco;

import java.util.Scanner;

public class AtividadeVinteQuatro {

    public static void main(String[] args) {

        Scanner leia = new Scanner(System.in);
        int valor;
        int maiorValor = 0;
        int menorValor = 0;

        while (true) {

            do {
                System.out.print("Informe um valor: ");
                valor = Integer.parseInt(leia.nextLine());
                if (valor < 0) {
                    System.out.println("Valor não permitido.");
                } else if (valor == 0) {
                    break;
                }
            } while (valor < 0);

            if (valor == 0) {
                break;
            }

            if (maiorValor == 0) {
                maiorValor = valor;
                menorValor = valor;
            } else if (valor > maiorValor) {
                maiorValor = valor;
            } else if (valor < menorValor) {
                menorValor = valor;
            }
        }

        System.out.println("O maior valor é: " + maiorValor);
        System.out.println("O menor valor é: " + menorValor);

    }

}
