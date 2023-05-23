package Interfaces;

public class Persona implements NewInterface {
    @Override
    public void cantar(){
        System.out.println("Canta una persona");
    }
    @Override
    public void bañar(){
        System.out.println("Una persona se baña");
    }
}
