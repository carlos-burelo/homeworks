package Datos;

public class Maestro extends DatosGenerales {
    String rfc;
    int categoria;

    public Maestro(String nombre, String domicilio,String rfc, int edad, int telefono, int categoria ){
        super(nombre, domicilio, edad, telefono);
        this.rfc = rfc;
        this.categoria  = categoria;
    }

    public int getCategoria() {
        return categoria;
    }
    public String getRfc() {
        return rfc;
    }
}
