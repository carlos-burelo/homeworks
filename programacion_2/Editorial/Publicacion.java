package Editorial;

abstract public class Publicacion {
    private String nombreDeLaPublicacion;
    private int numeroDeHojas;

    public Publicacion( String nombreDeLaPublicacion, int numeroDeHojas){
        this.nombreDeLaPublicacion = nombreDeLaPublicacion;
        this.numeroDeHojas = numeroDeHojas;
    }

    public String getNombreDeLaPublicacion() {
        return nombreDeLaPublicacion;
    }
    public int getNumeroDeHojas() {
        return numeroDeHojas;
    }

    abstract public void imprimir();
    abstract public float calcularPrecio();
}
