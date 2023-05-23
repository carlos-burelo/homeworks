package Proyecto;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;


public class JavaForm {

    public static void main(String[] args) {
        JFrame frame = new JFrame("Suma");
        JTextField fieldNum1 = new JTextField();
        JTextField fieldNum2 = new JTextField();
        JComboBox<String> jComboBox;
        JButton btnCalcular = new JButton("Calcular");
        JLabel labelResultado = new JLabel("");
        jComboBox = new JComboBox<String>();
        jComboBox.addItem("SUMAR");
        jComboBox.addItem("RESTAR");
        jComboBox.addItem("MULTIPLICAR");
        jComboBox.addItem("DIVIDIR");

        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        frame.setLayout(new GridLayout(7, 1));
        frame.getContentPane().add(new JLabel("Número 1"));
        frame.getContentPane().add(fieldNum1);
        frame.getContentPane().add(new JLabel("Número 2"));
        frame.getContentPane().add(fieldNum2);
        frame.getContentPane().add(btnCalcular);
        frame.getContentPane().add(jComboBox, labelResultado);
        frame.getContentPane().add(new JLabel("Resultado:"));
        frame.getContentPane().add(labelResultado);
        frame.setSize(500, 300);
        frame.setVisible(true);

        jComboBox.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String val1 = fieldNum1.getText().trim();
                String val2 = fieldNum2.getText().trim();
                double num1 = Double.parseDouble(val1);
                double num2 = Double.parseDouble(val2);
                
                int option = jComboBox.getSelectedIndex();

                JavaClass menu =  new JavaClass();
                menu.setNumero1(num1);
                menu.setNumero2(num2);
                double result = menu.realizarOperacion(option);
                labelResultado.setText(result+"");
            }
        });
    }
}
