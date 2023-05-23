package Polimorfismo;

public class Alumno extends Persona {
    private String matricula;
    private String carrera;
    private float promedio;

    public Alumno(String nombre, String domicilio, int telefono, int edad,  String matricula, String carrera, float promedio){
        super(nombre, domicilio, telefono, edad);
        this.matricula = matricula;
        this.carrera = carrera;
        this.promedio = promedio;
    }

    @Override
    public void imprime(){
        super.imprime();
        System.out.println(
            "Matricula: " +  matricula + "\n" +
            "Carrera: " +  carrera + "\n" +
            "Promedio: " +  promedio 
        );
    }
}
