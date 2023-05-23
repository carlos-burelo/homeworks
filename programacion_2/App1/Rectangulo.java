package App1;

public class Rectangulo extends Figura {
    private float altura;
    public Rectangulo(float base, float altura){
        super(base);
        this.altura = altura;
    }

    public float getAltura() {
        return altura;
    }
    public void imprimir() {
        System.out.println(
            "La base del rectangulo es:" + this.calcularArea()
        );
    }


    public float calcularArea() {
        return getBase()  * this.altura;
    }

}
