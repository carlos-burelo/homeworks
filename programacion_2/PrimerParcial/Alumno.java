package PrimerParcial;

public class Alumno extends Persona {
    private String matricula;
    private float promedio;
    private String carrera;

    public Alumno(String matricula, float promedio, String carrera,
    String nombre, String domicilio, int edad, int telefono){
        super(nombre, edad, telefono, domicilio);
        this.matricula = matricula;
        this.promedio =  promedio;
        this.carrera = carrera;
    }

    public String getMatricula() {
        return matricula;
    }
    public float getPromedio() {
        return promedio;
    }
    public String getCarrera() {
        return carrera;
    }


    public void mostrarDatos() {
        System.out.println("\nDATOS DEL  ALUMNO:\n");
        System.out.println("Matricula: " + getMatricula());
        System.out.println("Promedio: " + getPromedio());
        System.out.println("Carrera: " + getCarrera());
        super.mostrarDatos();
    }
}
