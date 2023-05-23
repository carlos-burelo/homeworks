package Datos;

public class Alumno extends DatosGenerales{
    private String carrera;
    private String matricula;
    private float promedio;

    public Alumno(String nombre,String domicilio, int edad, int telefono,String carrera,String matricula,float promedio){
        super(nombre, domicilio, edad, telefono);
        this.carrera = carrera;
        this.matricula = matricula;
        this.promedio = promedio;
    }
    public String getCarrera() {
        return carrera;
    }
    public String getMatricula() {
        return matricula;
    }
    public float getPromedio() {
        return promedio;
    }
}
