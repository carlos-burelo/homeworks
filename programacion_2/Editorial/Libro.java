package Editorial;

/**
 * una casa editorial maneja tres tipos de publicaciones, libros, boletines y revistas.
todas ellas manejas los datos por nombre de la publicación y numero de hojas.

el libro maneja tambien los siguientes datos:
ismb, autor, editorial y numero de edición.

el boletin maneja:
oranismo y numero.

la revista:
tipo, numero, volumen e issm.

calcule el peso para cada uno de ellos si el del libro el costo por pagina es un peso
en el voletin es .50 ventavos y en la revista 1.5

 */

public class Libro extends Publicacion {
    private String ismb;
    private String autor;
    private String editorial;
    private int numeroDeEdición;

    public Libro(String nombreDeLaPublicacion, int numeroDeHojas, String ismb, String autor, String editorial, int numeroDeEdición){
        super(nombreDeLaPublicacion, numeroDeHojas);
        this.ismb = ismb;
        this.autor = autor;
        this.editorial = editorial;
        this.numeroDeEdición = numeroDeEdición;
    }

    public String getIsmb() {
        return ismb;
    }
    public String getAutor() {
        return autor;
    }
    public String getEditorial() {
        return editorial;
    }
    public int getNumeroDeEdición() {
        return numeroDeEdición;
    }

    @Override
    public void imprimir() {
        System.out.println("Nombre de la publicacion: " + getNombreDeLaPublicacion());
        System.out.println("ISMB: " + getIsmb());
        System.out.println("Author: " + getAutor());
        System.out.println("Numero de la edicion: " + getNumeroDeEdición());
        System.out.println("Numero de hojas: " + getNumeroDeHojas());
        System.out.println("Precio: " + calcularPrecio());
    }

    @Override
    public float calcularPrecio(){
        return getNumeroDeHojas();
    }
}
