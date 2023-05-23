package PrimerParcial;
import java.util.Scanner;


public class AreaDeUnCilindro {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Ingrese el nombre de la figura: ");
        String nombre = in.nextLine();
        System.out.print("Ingrese el radio del " + nombre +": ");
        int radio = in.nextInt();
        System.out.print("Ingrese la altura del " + nombre +" ");
        int altura = in.nextInt();
        in.close();
        double resultado = Math.PI * Math.pow(radio, 2) * altura;
        System.out.print("El volumen de el " + nombre + " es: " + resultado);
    }
}

// Scanner in = new Scanner(System.in);
// System.out.print("Ingrese el radio del cilindro: ");
// int radio = in.nextInt();
// System.out.print("Ingrese la altura del cilindro: ");
// int altuta = in.nextInt();
// in.close();