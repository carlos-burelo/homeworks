package Editorial;

public class Boletin extends Publicacion {
    private String organismo;
    private int numero;

    public Boletin(String nombreDeLaPublicacion, int numeroDeHojas,String organismo, int numero){
        super(nombreDeLaPublicacion, numeroDeHojas);
        this.organismo = organismo;
        this.numero =  numero;
    }

    public String getOrganismo() {
        return organismo;
    }

    public int getNumero() {
        return numero;
    }

    @Override
    public void imprimir() {
        System.out.println("Nombre de la publicacion: " + getNombreDeLaPublicacion());
        System.out.println("Organismo: " + getOrganismo());
        System.out.println("Numero: " + getNumero());
        System.out.println("Numero de hojas: " + getNumeroDeHojas());
        System.out.println("Precio: " + calcularPrecio());
    }

    @Override
    public float calcularPrecio(){
        return getNumeroDeHojas() * 0.50f;
    }
}
