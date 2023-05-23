package PrimerParcial;

import java.util.Scanner;

import lib.Window;


public class Volumen {
    static Scanner in = new Scanner(System.in);
    static Window x = new Window();
    
    public static void main(String[] args) {
        
        Cylinder cilindro1 = new Cylinder(2,2);
        double value1 = cilindro1.calculateVolume();
        x.print("El valor:" + value1);

        Cylinder cilindro2 = new Cylinder();
        double value2 = cilindro2.calculateVolume(10, 5);
        x.print("El valor:" + value2);
    }
    
}
/**
 * Cree una clase llamada volumeCilindro debe 
 * tener 2 atributos, radio y altura, tambien tendra 2 constructores, uno por defecto
 * y otro con 2 argumentos (uno por cada atributo de la clase).
 * 
 * Cree un metodo que calcule el volumen, este metodo recibira radio y altura como parametro
 * cree otro metodo que calcule el volumen donde el radio y la altura
 * le sean solicitados al usuario
 *
 */