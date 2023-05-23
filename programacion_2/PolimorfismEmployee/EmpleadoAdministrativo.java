package PolimorfismEmployee;

public class EmpleadoAdministrativo extends Empleado {
    private float prestacion1;
    private float prestacion2;
    private float salario;

    public EmpleadoAdministrativo(String nombre, String rfc, float prestacion1, float prestacion2, float salario){
        super(nombre, rfc);
        this.prestacion1 = prestacion1;
        this.prestacion2 = prestacion2;
        this.salario = salario;
    }

    public float getPrestacion1() {
        return prestacion1;
    }

    public float getPrestacion2() {
        return prestacion2;
    }

    public float getSalario() {
        return salario;
    }

    public void imprimir(){
        System.out.println("Empleado administrativo");
        super.imprimir();
        System.out.println(
            "Prestacion 1: " + getPrestacion1() + "\n" +
            "Prestacion 2: " + getPrestacion2() + "\n" +
            "Salario Bruto: $" + getSalario() + "\n"
        );
    }
}
