package PrimerParcial;

public class Rectangulo {

    private int base;
    private int altura;

    public Rectangulo(int base, int altura){
        this.base = base;
        this.altura = altura;
    }
    void perimetro(){
        final int PERIMETRO = 2 * base +  2 * altura;
        System.out.println("El perimetro del rectangulo es: "+ PERIMETRO);
    }
     void area(){
        final int AREA = base * altura;
        System.out.println("El area del rectangulo es: "+ AREA);
    }
}
