package employee;

public class EmpleadoAdministrativoDeConfianza extends Empleado{
    private float compensacion;
    private float salario;

    public EmpleadoAdministrativoDeConfianza(){
        super(null, null);
    }
    public float getSalario() {
        return salario;
    }
    public float getCompensacion() {
        return compensacion;
    }

    public void setSalario(float salario) {
        this.salario = salario;
    }
}
