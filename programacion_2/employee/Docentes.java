package employee;

public class Docentes extends Empleado {
    private float horasTrabajadas;
    private float sueldoPorHora;
    private float descuento;
    private float salarioBruto;
    private float salarioNeto;

    public Docentes(String nombre, String rfc){
        super(nombre, rfc);
    }

    public void setHorasTrabajadas(float horasTrabajadas) {
        this.horasTrabajadas = horasTrabajadas;
    }

    public void setSueldoPorHora(float sueldoPorHora) {
        this.sueldoPorHora = sueldoPorHora;
    }

    public float getHorasTrabajadas() {
        return horasTrabajadas;
    }
    public float getSueldoPorHora() {
        return sueldoPorHora;
    }
    public float getDescuento() {
        return descuento;
    }
    public float getSalarioBruto() {
        return salarioBruto;
    }
    public float getSalarioNeto() {
        return salarioNeto;
    }

    private void calcular(){
        float sueldo = this.horasTrabajadas * this.sueldoPorHora;
        if (sueldo >= 0 && sueldo <= 3500) {
            this.salarioBruto = sueldo;
        }
        if (sueldo >= 3501 && sueldo <= 5000){
            this.descuento =  sueldo * (float) 0.5;
        }
        if (sueldo >= 5001 && sueldo<=10000) {
            this.descuento = sueldo * (float) 0.10;
        }

    }

    public void mostrar(){
        System.out.println("Docente\n\n");
        super.mostrar();
        calcular();
    }
}
