package PrimerParcial;

public class Main {
    public static void main(String[] args) {
        final String NOMBRE = "Carlos";
        final String DOMICILIO = "Cunduacan";
        final int TELEFONO = 123456789;
        final int EDAD = 30;

        Alumno alumno = new Alumno(
            "212H12345", 
            10, 
            "ISC", 
            NOMBRE, 
            DOMICILIO,
            EDAD, 
            TELEFONO
        );
        Maestro maestro = new Maestro(
            "RFC1234RFC", 
            "Docente", 
            NOMBRE, 
            DOMICILIO,
            EDAD, 
            TELEFONO
        );
        alumno.mostrarDatos();
        maestro.mostrarDatos();
    }
}
