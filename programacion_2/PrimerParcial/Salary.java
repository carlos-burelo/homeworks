package PrimerParcial;

public class Salary {

    private String nombre;
    private int horasTrabajadas;
    private int salarioPorHora ;
    private String RFC;

    public Salary(){}

    public Salary(String nombre, int horasTrabajadas, int salarioPorHora, String RFC ){
        this.salarioPorHora = salarioPorHora;
        this.horasTrabajadas = horasTrabajadas;
        this.RFC = RFC;
        this.nombre = nombre;
    }
    public void setNombre(String nombre){
        this.nombre =  nombre;
    }
    public void setHorasTrabajadas(int horasTrabajadas){
        this.horasTrabajadas =  horasTrabajadas;
    }
    public void setSalarioPorHora(int salarioPorHora){
        this.salarioPorHora =  salarioPorHora;
    }
    public void setRFC(String RFC){
        this.RFC =  RFC;
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
}
