
/*
 * Elabore un metodo que sume los datos de un arreglo de 5 elementos, 
 * determine cual de ellos es el mayor e imprima en que posicion se encuentra
 * 
 * Elabore un metodo que lea 2 nombres e imprimalos en orden ascendente
 * 
 * Elabore un metodo que realize la sumatoria de los elementos de la diagonal principal
 * de una matriz de 4x4
 */
package PrimerParcial;

import java.util.Scanner;
import java.util.Arrays;

public class Arreglos {
    static Scanner in = new Scanner(System.in);
    static final String menu = 
        "\nIngrese alguna opcion\n\n"+
        "1) Suma de un arreglo de 5 elementos\n"+
        "2) Comparar nombres\n"+
        "3) Suma de diagonal\n"+
        "4) Salir\n";
    static int[]  array = {-3,-4,-5,-10,-6};
    static int[][] matrix = { 
        { 1 ,2, 3, 4 },
        { 4 ,5, 6, 3 },
        { 7 ,8, 9, 2 },
        { 7 ,8, 9, 1 } // diagonal 1,5,9,1
    };
    static String names[] = { "pedro","PEDRO" };
    public static void main(String[] args) {
        int option = showMenu();
        while(option != 4){
            if (option == 1) option1();
            if (option == 2) option2();
            if (option == 3) option3();
            option = showMenu();
        }
    }
    static int showMenu() {
        System.out.println(menu);
        System.out.print("Ingrese una opcion: "); 
        return in.nextInt();
    }
    static void print(String message) {
        System.out.println(message);
    }
    static void clear() {
        System.out.print("\033[H\033[2J");  
        System.out.flush();  
    }
    static void option1(){
        clear();
        int max = -100;
        int index = 0;
        int count = 0;
        for(int i = 0, length = array.length; i < length; i++){
            count += array[i];
            if(max < array[i]) {
                max = array[i];
                index = i;
            }
        }
        print("El mayor de los numeros es: " + max);
        print("La posición del numero mayor es: "+ index);
        print("La suma de todos los elementos es: " + count);
    }
    static void option2(){
        clear();
        Arrays.sort(names);
        System.out.println(
        "Los nombres en orden ascendente son: ");
            for (int i = 0; i < names.length; i++) {
                System.out.println(names[i]);
            }
        }
    static void option3(){
        clear();
        int count = 0;
        for (int i = 0; i < matrix.length; i++){
            count += matrix[i][i];
        }
        print("La suma de la diagonal es: " + count);
    }
}
