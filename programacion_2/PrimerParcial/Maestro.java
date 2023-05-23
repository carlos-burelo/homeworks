package PrimerParcial;

public class Maestro extends Persona {
    private String RFC;
    private String categoria;

    public Maestro(String RFC, String catetoria,String nombre, String domicilio, int edad, int telefono){
        super( nombre, edad, telefono, domicilio);
        this.RFC = RFC;
        this.categoria = catetoria;
    }

    public String getRFC(){
        return this.RFC;
    }
    public String getCategoria(){
        return this.categoria;
    }

    public void mostrarDatos() {
        System.out.println("\nDATOS DEL MAESTRO :\n");
        System.out.println("RFC: " + getRFC());
        System.out.println("Categoria: " + getCategoria());
        super.mostrarDatos();
    }
}