package lib;

import javax.swing.JOptionPane;

public class Window {
    public  void print(String message){
        JOptionPane.showMessageDialog(null, message);
    }
    public  int inputInt(String message){
        return Integer.parseInt(
            JOptionPane.showInputDialog(null, message)
        );
    }
    public float inputFloat(String message){
        return Float.parseFloat(
            JOptionPane.showInputDialog(null, message)
        );
    }
    public double inputDouble(String message){
        return Double.parseDouble(
            JOptionPane.showInputDialog(null, message)
        );
    }
}
