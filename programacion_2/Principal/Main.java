package Principal;

import Interfaces.*;

public class Main {
    public static void main(String[] args) {
        NewInterface accesoAMetodos = new Persona();
        ejecutar(accesoAMetodos, "cantar");
        accesoAMetodos = new Ave();
        ejecutar(accesoAMetodos, "bañar");
    }
    public static void ejecutar(NewInterface accesoAMetodos, String accion){
        if (accion.equals("cantar")){
            accesoAMetodos.cantar();
        } else {
            accesoAMetodos.bañar();
        }
    }
}
