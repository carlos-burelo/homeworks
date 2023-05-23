package PrimerParcial;
/*
 * elabora un programa que creeé cuatro modulos:
	1.- un modulo de suma el cual recibira 2 parametros realizara la suma e imprimira el resultado
	2.- un modulo de resta el cual recibira 2 parametros, realizara la resta y retonara el resultado a Main donde se imprimira
	3.- un modulo de multiplicacion, el cual recibiira 2 paramatretos, realizaa la multiplicacion y retornara el resultado a main. Ese metodo debe de ser invocado en la linea donde se imprima su resultado en main
	3.- un modulo de division recibira 2 parametros, realizara la division e imprimira el resultado
 */
import java.util.Scanner;

public class Modulos {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Ingese el primer numero: ");
        int valor1 = sc.nextInt();
        System.out.print("Ingese el primer numero: ");
        int valor2 = sc.nextInt();
        sc.close();
        suma(valor1, valor2);
        int resultadoResta = resta(valor1, valor2);
        System.out.println("El resultado de la resta es: " +  resultadoResta);
        System.out.println("El resultado de la multiplicacion es: " + multiplicacion(valor1, valor2));
        division(valor1, valor2);
    }
     static void suma(int valor1, int valor2){
        int resultado = valor1 + valor2;
        System.out.println("El resultado de la suma es: " + resultado);
    }
     static int resta(int valor1, int valor2){
        return valor1 - valor2;
    }
     static int multiplicacion(int valor1, int valor2){
        return valor1 * valor2;
    }
     static void division(int valor1, int valor2){
        float resultado = (float) valor1 / valor2;
        System.out.println("El resultado de la division es: " + resultado);
    }
}
