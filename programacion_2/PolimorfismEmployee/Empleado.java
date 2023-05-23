package PolimorfismEmployee;

public class Empleado {
    protected String rfc;
    protected String nombre;
    protected float sueldoBase;
    
    public Empleado(String nombre, String rfc){
        this.nombre = nombre;
        this.rfc = rfc;
    }

    
    public String getRfc() {
        return rfc;
    }

    public String getNombre() {
        return nombre;
    }
    
    public void setSueldoBase(float sueldoBase) {
        this.sueldoBase = sueldoBase;
    }
    

    public float descuento(float sueldoBase){
        if (sueldoBase >= 0 && sueldoBase <= 3500){
            return 0;
        }
        else if (sueldoBase >= 3501 && sueldoBase <= 5000){
            return sueldoBase * .05f;
        }
        else if (sueldoBase >= 5001 && sueldoBase <= 10000) {
            return sueldoBase * .10f;
        }
        else if (sueldoBase >= 10001 && sueldoBase <= 20000){
            return sueldoBase * .12f;
        }
        else {
            return sueldoBase * .20f;
        }
    }
    public float calcular(){
        return sueldoBase - descuento(sueldoBase);
    }
     
    public void imprimir(){
        System.out.println("RFC: "+ getRfc());
        System.out.println("Nombre: "+ getNombre());
    }
    
}