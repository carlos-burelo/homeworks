package PrimerParcial;

public class Persona {
    private String nombre;
    private int edad;
    private int telefono;
    private String domicilio;

    public Persona(String nombre, int edad, int telefono, String domicilio){
        this.nombre = nombre;
        this.edad = edad;
        this.telefono = telefono;
        this.domicilio = domicilio;
    }

    public String getNombre() {
        return nombre;
    }
    public int getEdad() {
        return edad;
    }
    public int getTelefono() {
        return telefono;
    }
    public String getDomicilio() {
        return domicilio;
    }

    public void  mostrarDatos(){
        System.out.println("Nombre: " + getNombre());
        System.out.println("Edad: " + getEdad());
        System.out.println("Telefono: " + getTelefono());
        System.out.println("Domicilio: " + getDomicilio());
    }
}

