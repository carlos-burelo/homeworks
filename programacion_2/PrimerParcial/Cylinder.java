package PrimerParcial;


public class Cylinder {
    
    protected float radius;
    protected float height;

    
    public Cylinder() {}

    public Cylinder(float radius, float height) {
        this.height = height;
        this.radius =  radius;
    }
    
    public double calculateVolume() {
        return Math.PI * Math.pow(this.radius, 2) * this.height;
    }
    public double calculateVolume(float radius, float height) {
        return Math.PI * Math.pow(radius, 2) * height;
    }
}
