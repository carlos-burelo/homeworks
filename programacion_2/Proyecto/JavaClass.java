package Proyecto;

import javax.swing.JOptionPane;

public class JavaClass {

    private double numero1;
    private double numero2;
    private double resultado;


    public JavaClass(){}

    public double getNumero1() {
        return numero1;
    }
    public double getNumero2() {
        return numero2;
    }
    public void setNumero1(double numero1) {
        this.numero1 = numero1;
    }
    public void setNumero2(double numero2) {
        this.numero2 = numero2;
    }
    
    public double realizarOperacion(int operacion){
        double numero1 = getNumero1();
        double numero2 = getNumero2();

        switch (operacion) {
            case 0:
                this.resultado =  numero1 + numero2;
                break;
            case 1:
                this.resultado = numero1 +  numero2;
                break;
            case 2:
                this.resultado = numero1 * numero2;
                break;
            case  3:
                this.resultado =  numero1 / numero2;
                break;
            default:
                showError();
                break;
        }
        return this.resultado;
    }

    public void showError(){
        JOptionPane.showMessageDialog(null, "Numero incorrecto, intente de nuevo");
    }
}
