package lib;

import java.util.Scanner;

public class Terminal {
    public Scanner in = new Scanner(System.in);
    public void print(String message){
        System.out.print(message);
    }
    public  int inputInt(String message){
        System.out.print(message);
        return in.nextInt();
    }
    public float inputFloat(String message){
        System.out.print(message);
        return in.nextFloat();
    }
    public double inputDouble(String message){
        System.out.print(message);
        return in.nextDouble();
    }
}