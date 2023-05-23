package employee;

public class EmpleadoAdministrativo extends Empleado {
    private int prestacion1;
    private int prestacion2;
    private float salario;

    public EmpleadoAdministrativo(){
        super(null, null);
    }

    public int getPrestacion1() {
        return prestacion1;
    }

    public int getPrestacion2() {
        return prestacion2;
    }

    public float getSalario() {
        return salario;
    }

    public void setPrestacion1(int prestacion1) {
        this.prestacion1 = prestacion1;
    }

    public void setPrestacion2(int prestacion2) {
        this.prestacion2 = prestacion2;
    }

    public void setSalario(float salario) {
        this.salario = salario;
    }
}
