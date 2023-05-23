package Polimorfismo;

public class Maestro extends Persona{
    private String rfc;
    private int categoria;

    public Maestro(String nombre, String domicilio, int telefono, int edad,  String rfc, int categoria){
        super(nombre, domicilio, telefono, edad);
        this.rfc = rfc;
        this.categoria = categoria;
    }
    @Override
    public void imprime(){
        super.imprime();
        System.out.println(
            "RFC: " +  rfc + "\n" +
            "Categoria: " +  categoria 
        );
    }
}
