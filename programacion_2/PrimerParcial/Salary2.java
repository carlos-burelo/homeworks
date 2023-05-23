package PrimerParcial;

public class Salary2 {
    private String nombre;
    private int horasTrabajadas;
    private int salarioPorHora;
    private String RFC;

    public Salary2(){}
    
    public Salary2(String nombre, int horasTrabajadas, int salarioPorHora, String RFC ){
        this.salarioPorHora = salarioPorHora;
        this.horasTrabajadas = horasTrabajadas;
        this.RFC = RFC;
        this.nombre = nombre;
    }
    public void calculateSalary(){
        int total = salarioPorHora * horasTrabajadas;
        String message = 
            "\nTrabajador: " + this.nombre + "\n"+
            "RFC: " + this.RFC + "\n"+
            "Salario por hora: $" + this.salarioPorHora + "\n"+
            "Horas trabajadas: " + this.horasTrabajadas + "\n"+
            "Salario total: $" + total + "\n" ;
        System.out.println(message);
    }
    public void calculateSalary(String nombre, int horasTrabajadas, int salarioPorHora, String RFC){
        int total = salarioPorHora * horasTrabajadas;
        String message = 
            "\nTrabajador: " + nombre + "\n"+
            "RFC: " + RFC + "\n"+
            "Salario por hora: $" + salarioPorHora + "\n"+
            "Horas trabajadas: " + horasTrabajadas + "\n"+
            "Salario total: $" + total + "\n" ;
        System.out.println(message);
    }
}
