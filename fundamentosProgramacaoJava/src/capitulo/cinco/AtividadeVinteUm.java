package capitulo.cinco;

import java.util.Scanner;

public class AtividadeVinteUm {

    public static void main(String[] args) {

        Scanner leia = new Scanner(System.in);
        int voto;
        int candidatoUm = 0;
        int candidatoDois = 0;
        int candidatoTres = 0;
        int candidatoQuatro = 0;
        int nulo = 0;
        int branco = 0;
        int totalVotos;
        double porcentagemNulo;
        double porcentagemBranco;

        while (true) {
            System.out.println("""
                    0 - Encerrar
                    1 - Candidato um
                    2 - Candidato dois
                    3 - Candidato tres
                    4 - Candidato quatro
                    5 - Nulo
                    6 - Branco
                    """);
            System.out.print("Informe o voto: ");
            voto = Integer.parseInt(leia.nextLine());

            if(voto == 0) {
                break;
            } else if (voto == 1) {
                candidatoUm++;
            } else if (voto == 2) {
                candidatoDois++;
            } else if (voto == 3) {
                candidatoTres++;
            } else if (voto == 4) {
                candidatoQuatro++;
            } else if (voto == 5) {
                nulo++;
            } else if (voto == 6) {
                branco++;
            } else {
                System.out.println("Opção inválida.");
            }
        }

        totalVotos = candidatoUm + candidatoDois + candidatoTres + candidatoQuatro + nulo + branco;

        porcentagemNulo = (double) (nulo * 100) / totalVotos;
        porcentagemBranco = (double) (branco * 100) / totalVotos;

        System.out.printf("""
                Votos para o candidato Um: %d
                Votos para o candidato Dois: %d
                Votos para o candidato Tres: %d
                Votos para o candidato Quatro: %d
                Votos nulos: %d
                Votos brancos: %d
                Porcentagem votos nulos: %.2f
                Porcentagem votos brancos: %.2f
                """, candidatoUm, candidatoDois, candidatoTres, candidatoQuatro, nulo, branco, porcentagemNulo,
                porcentagemBranco);
        System.out.println();
    }

}
