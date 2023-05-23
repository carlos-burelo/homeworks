package Polimorfismo;

public class Main {
    public static void main(String[] args) {
        Persona personas[] = new Persona[3];
        personas[0] = new Persona("juan", "Calzada de hueso #3", 323423, 23);
        personas[1] = new Alumno("juan", "Calzada de hueso #3", 993234123, 23, "212h2322", "ISC", 8.5F);
        personas[2] = new Maestro("juan", "Calzada de hueso #3", 993234123, 23, "RFC12345", 1);
        for (Persona persona : personas) {
            persona.imprime();
        }
    }
}
