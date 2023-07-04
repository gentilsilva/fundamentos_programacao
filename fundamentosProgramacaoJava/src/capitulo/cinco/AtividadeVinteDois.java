package capitulo.cinco;

import java.util.Scanner;

public class AtividadeVinteDois {

    public static void main(String[] args) {

        Scanner leia = new Scanner(System.in);
        int idade;
        double altura;
        double somaAltura = 0;
        double mediaAltura;
        int contadorIdade = 0;

        while (true) {
            System.out.print("Informe a idade: ");
            idade = Integer.parseInt(leia.nextLine());

            if (idade <= 0) {
                break;
            }

            System.out.print("Informe a altura: ");
            altura = Double.parseDouble(leia.nextLine());

            if (idade > 50) {
                somaAltura += altura;
                contadorIdade++;
            }
        }

        mediaAltura = somaAltura / contadorIdade;

        System.out.printf("A média de altura das pessoas com mais de 50 anos é: %.2f", mediaAltura);
    }

}
