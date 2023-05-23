package App1;
// cree la clase figura de la cual no se crearan instancias,
/**
 * dicha clase va a tener un atributo, de tipo float de acceso privado
 * implemente su metodo construcctor, su getter, un metodo abstracto que se llamara imprimir
 * y un metodo abstracto que se llame calcular area el cual debera retornar un valor de tipo float,
 * crara una clase llamada triangulo, la cual heredara de figura y tendra un atributro propio llamado "altura"
 * que sera float de acceso privado, genere su metodo constructor y su getter, implemente el metodo imprimir "El area del triangulo es .calcularArea() "
 * implemnte el metodo calcular area, lo mismo para el rectangulo (altura float private) implementar constructor, getter, imprimir, calculararea
 * crear un java main class donde se creara un instancia de triangulo y una de rectangulo, desde donde se le enviara parametros al metodo constructor
 * a traves de la instancia creada del trianguo invoque al metodo imprimir
 */
abstract public class Figura {
    private float base;
    public Figura(float base){
        this.base = base;
    }
    public float getBase() {
        return base;
    }
    abstract public void imprimir();
    abstract public float calcularArea();
}
