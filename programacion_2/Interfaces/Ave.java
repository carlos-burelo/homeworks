package Interfaces;

public class Ave implements NewInterface{
    @Override
    public void cantar(){
        System.out.println("Canta un ave");
    }
    @Override
    public void bañar(){
        System.out.println("Un ave se baña");
    }
}
