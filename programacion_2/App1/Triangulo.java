package App1;

public class Triangulo extends Figura{
    private float altura;

    public Triangulo(float base, float altura){
        super(base);
        this.altura = altura;
    }
    public float calcularArea() {
        return (getBase() *  altura) / 2;
    }
    public float getAltura() {
        return altura;
    }
    
    public void imprimir() {
        System.out.println(
            "La base del triangulo es:" + calcularArea()
        );
    }
}
