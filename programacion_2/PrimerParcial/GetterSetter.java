package PrimerParcial;

public class GetterSetter {

    private float base;
    private float altura;

    public void setBase(int base){
        this.base = base;
    }
    public void setAltura(int altura){
        this.altura = altura;
    }
    public float getBase(){
        return this.base;
    }
    public float getAltura(){
        return this.altura;
    }
    public void imprimeDatos(){
        System.out.println("La base es: " + getBase());
        System.out.println("La altura es: " + getAltura());
    }
}
