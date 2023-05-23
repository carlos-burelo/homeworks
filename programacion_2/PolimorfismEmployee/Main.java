package PolimorfismEmployee;

public class Main {
    public static void main(String[] args) {
        Empleado empleados[] = new Empleado[3];
        empleados[0] = new Docentes("Andres ", "aeaa630102c03 ", 145, 64);
        empleados[1] = new EmpleadoAdministrativo("Juan", "pesj980101y00", 350, 180, 3000);
        empleados[2] = new EmpleadoAdministrativoDeConfianza("xhenia", "dosx020202b02", 3, 6000, 2000);

        for (Empleado empleado : empleados) {
            empleado.imprimir();
        }
    }
}
