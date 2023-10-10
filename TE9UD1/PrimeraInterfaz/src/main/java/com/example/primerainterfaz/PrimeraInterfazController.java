package com.example.primerainterfaz;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.MenuBar;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.input.InputEvent;
import javafx.stage.FileChooser;
import javafx.stage.Stage;

import java.io.*;

public class PrimeraInterfazController {

    @FXML
    private Button btnEnviar;

    @FXML
    private TextField inputTexto;

    @FXML
    private TextArea sbTextArea;

    @FXML
    private MenuBar menuBar;

    private File selectedFile;

    @FXML
    protected void escribirEnTextArea(){
        String textoInput = inputTexto.getText();
        sbTextArea.setText(textoInput);
    }

    @FXML
    private void abrirArchivo(ActionEvent event) {
        FileChooser fileChooser = new FileChooser();
        fileChooser.setTitle("Abrir Archivo");
        selectedFile = fileChooser.showOpenDialog(menuBar.getScene().getWindow());

        if (selectedFile != null) {
            try {
                BufferedReader reader = new BufferedReader(new FileReader(selectedFile));
                StringBuilder contenido = new StringBuilder();
                String linea;

                while ((linea = reader.readLine()) != null) {
                    contenido.append(linea).append("\n");
                }

                reader.close();
                sbTextArea.setText(contenido.toString());
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    @FXML
    private void guardarArchivo(ActionEvent event) {
        if (selectedFile != null) {
            try {
                FileWriter writer = new FileWriter(selectedFile);
                writer.write(sbTextArea.getText());
                writer.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        } else {
            FileChooser fileChooser = new FileChooser();
            fileChooser.setTitle("Guardar Archivo");
            selectedFile = fileChooser.showSaveDialog(menuBar.getScene().getWindow());

            if (selectedFile != null) {
                try {
                    FileWriter writer = new FileWriter(selectedFile);
                    writer.write(sbTextArea.getText());
                    writer.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }
    }


}
