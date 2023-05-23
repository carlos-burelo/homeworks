package Datos;

public class DatosGenerales {
    private String nombre;
    private String domicilio;
    private int edad;
    private int telefono;

    public DatosGenerales(String nombre,String domicilio, int edad, int telefono){
        this.nombre = nombre;
        this.edad = edad;
        this.domicilio = domicilio;
        this.telefono = telefono;
    }
    public String getDomicilio() {
        return domicilio;
    }
    public int getEdad() {
        return edad;
    }
    public String getNombre() {
        return nombre;
    }
    public int getTelefono() {
        return telefono;
    }
    
}
