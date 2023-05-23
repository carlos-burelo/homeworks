package Polimorfismo;

public class Persona {
    private String nombre;
    private String domicilio;
    private int telefono;
    private int edad;

    public Persona(String nombre, String domicilio, int telefono, int edad){
        this.nombre = nombre;
        this.domicilio = domicilio;
        this.telefono = telefono;
        this.edad = edad;
    }

    public void imprime(){
        // imprime los datos
        System.out.println(
            "\nNombre: " + nombre + "\n" +
            "Domicilio: " + domicilio + "\n" +
            "Telefono: " + telefono + "\n" +
            "Edad: " + edad
        );
    }
}
