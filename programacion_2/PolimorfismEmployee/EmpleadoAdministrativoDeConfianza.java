package PolimorfismEmployee;

public class EmpleadoAdministrativoDeConfianza extends Empleado{
    private float compensacion;
    private float salario;
    private int categoria;

    public EmpleadoAdministrativoDeConfianza(String nombre, String rfc, int categoria, float salario, float compensacion){
        super(nombre, rfc);
        this.categoria = categoria;
        this.salario = salario;
        this.compensacion = compensacion;
    }
    public float getSalario() {
        return salario;
    }
    public float getCompensacion() {
        return compensacion;
    }
    public int getCategoria() {
        return categoria;
    }

    public void setSalario(float salario) {
        this.salario = salario;
    }
    public void imprimir() {
        System.out.println("Empleado administrativo de confianza");
        super.imprimir();
        System.out.println(
            "Categoria: " + getCategoria() + "\n" +
            "Compensación: $" + getCompensacion() + "\n" +
            "Salario Bruto: $" + getSalario() + "\n"
        );
    }
}
