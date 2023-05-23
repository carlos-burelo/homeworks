package PrimerParcial;

public class Triangulo {

    private int base;
    private int altura;

    public Triangulo(int base, int altura){
        this.altura = altura;
        this.base = base;
    }
     void perimetro (){
        final int PERIMETRO = this.base * 3;
        System.out.println("El perimetro de la figura es: " + PERIMETRO);
    }
     void area(){
        final double AREA = (this.base * (float) this.altura) / 2 ;
        System.out.println("El perimetro de la figura es: " + AREA);
    }
}
