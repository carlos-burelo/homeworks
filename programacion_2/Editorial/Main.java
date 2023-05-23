package Editorial;

public class Main {
    public static void main(String[] args) {
        Publicacion publicaciones[] =  new Publicacion[3];
        publicaciones[0] = new Libro(
            "La Sirenita", 
            100, 
            "12321321312", 
            "Hans Christian Andersen", 
            "Combel Editorial", 
            1
            );
        publicaciones[1] = new Boletin(
            "UNESCO solidaria con ecuador",
            10, 
            "Organizacion de las naciones unidas para la educacion y  la cultura", 
            1
            );
        publicaciones[2] = new Revista(
            "Covid 19",
            50,
            "Cientifica?", 
            15, 
            2, 
            "12321321312"
            );
        for (Publicacion publicacion : publicaciones) {
            publicacion.imprimir();
            System.out.println("\n\n");
        }
    }
}
