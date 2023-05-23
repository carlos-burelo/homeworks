package PolimorfismEmployee;

public class Docentes extends Empleado {
    private int horasTrabajadas;
    private float sueldoPorHora;

    public Docentes(String nombre, String rfc, float sueldoPorHora, int horasTrabajadas){
        super(nombre, rfc);
        this.sueldoPorHora = sueldoPorHora;
        this.horasTrabajadas = horasTrabajadas;
    }

    public int getHorasTrabajadas() {
        return horasTrabajadas;
    }
    public float getSueldoPorHora() {
        return sueldoPorHora;
    }



    public void imprimir(){
        super.imprimir();
        System.out.println(
            "Horas Trabajadas: " + getHorasTrabajadas() + "\n" +
            "Salario Por Hora: " + getSueldoPorHora() + "\n\n"
        );
        
    }
}
