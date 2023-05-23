package employee;

import java.util.Map;

public class Empleado {
    private String rfc;
    private String nombre;

    public Empleado(String nombre, String  rfc){
        this.nombre = nombre;
        this.rfc = rfc;
    }

    public void mostrar(){
        System.out.println(
            "Nombre: " + this.nombre + "\n" +
            "RFC: " + this.rfc + "\n" 
        );
    }
}
