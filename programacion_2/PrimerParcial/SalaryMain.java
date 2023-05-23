package PrimerParcial;

/*
 * Elabore un programa que calcule el salario de un empleado
 * al cual le pagan de acuerdo a las horas trabajdas y su salario x hora.
 * los atributos del trabajador seran RFC, nombre, horas trabajadas y salario 
 * por hora. Habra sobrecarga de metodos constructores en donde tendra el un 
 * metodo por defecto y un metodo con parametros.
 */

/*
 * --------------------------------------------------------------------------------------|
 * Salary                                                                                |
 * --------------------------------------------------------------------------------------|
 * -RFC: String                                                                          |
 * -nombre: String                                                                       |
 * -salarioPorHora: int                                                                  |
 * -horasTrabajadas: int                                                                 |
 * --------------------------------------------------------------------------------------|
 * +Salary(RFC:String, nombre: String, salarioPorHora: int, horasTrabajadas: int): void  |
 * +Salary(): void                                                                       |
 *                                                                                       | 
 * +setRFC(RFC:String): void                                                             |
 * +setNombre(nombre:String): void                                                       |
 * +setSalarioPorHora(salarioPorHora: int): void                                         |
 * +setHorasTrabajadas(horasTrabajadas: int): void                                       |
 * +calculateSalary():void                                                               |
 * --------------------------------------------------------------------------------------|
 */
public class SalaryMain {
    public static void main(String[] args) {
        Salary trabajador1 = new Salary(
            "Pedro", 
            35, 
            200, 
            "RFC98765RFC"
        );
        trabajador1.calculateSalary();
        
        Salary trabajador2  = new Salary();
        trabajador2.setNombre("Pedro");
        trabajador2.setRFC("RFC987654FRC");
        trabajador2.setHorasTrabajadas(40);
        trabajador2.setSalarioPorHora(300);
        trabajador2.calculateSalary();
    }
}
 

