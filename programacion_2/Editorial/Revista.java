package Editorial;

public class Revista  extends Publicacion{

    private String tipo;
    private int numero;
    private int volumen;
    private String issm;

    public Revista(String nombreDeLaPublicacion, int numeroDeHojas,String tipo,int numero,int volumen,String issm){
        super(nombreDeLaPublicacion, numeroDeHojas);
        this.tipo = tipo;
        this.numero =  numero;
        this.volumen =  volumen;
        this.issm = issm;
    }
    public String getTipo() {
        return tipo;
    }
    public int getVolumen() {
        return volumen;
    }
    public String getIssm() {
        return issm;
    }
    public int getNumero() {
        return numero;
    }


    @Override
    public void imprimir() {
        System.out.println("Nombre de la publicacion: " + getNombreDeLaPublicacion());
        System.out.println("ISSM: " + getIssm());
        System.out.println("Numero: " + getNumero());
        System.out.println("Tipo: " + getTipo());
        System.out.println("Volumen: " + getVolumen());
        System.out.println("Numero de hojas: " + getNumeroDeHojas());
        System.out.println("Precio: " + calcularPrecio());
    }

    @Override
    public float calcularPrecio(){
        return getNumeroDeHojas() * 1.5f;
    }
}
