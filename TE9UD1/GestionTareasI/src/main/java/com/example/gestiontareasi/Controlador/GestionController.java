package com.example.gestiontareasi.Controlador;

import com.example.gestiontareasi.HelloApplication;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.control.Button;
import javafx.scene.control.TextArea;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;
import javafx.scene.control.Button;

import javax.swing.*;
import java.io.IOException;
import java.util.ArrayList;

public class GestionController {
    public TextArea taTareasPendientes;
    public Button btnAgregarTarea;
    public TextArea taAgregarTareas;
    public Button btnGuardar;
    public Button btnCancelar;

    private Stage ventanaAgregar;

    public ArrayList<String> tareas = new ArrayList<String>();

    private void setVentana(Stage stage){
        this.ventanaAgregar = stage;
    }

    private Stage getVentana(){
        return this.ventanaAgregar;
    }


    @FXML
    public void abrirVentanaEmergente(ActionEvent actionEvent) {
        try {
            FXMLLoader loader = new FXMLLoader(HelloApplication.class.getResource("agregarTarea.fxml"));
            AnchorPane secondaryLayout = loader.load();

            Scene newScene = new Scene(secondaryLayout, 400, 400);
            Stage newStage = new Stage();
            newStage.setTitle("Ventana Secundaria");
            newStage.setScene(newScene);
            setVentana(newStage);

            // Muestra la ventana secundaria
            ventanaAgregar.show();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    @FXML
    public void agregarDatos(ActionEvent actionEvent) throws IOException {
        String tarea = taAgregarTareas.getText();
        tareas.add(tarea);


        Node source = (Node) actionEvent.getSource();
        Stage stage = (Stage) source.getScene().getWindow();
        stage.close();




    }
    @FXML
    public void cerrarVentana(ActionEvent actionEvent) {
    }
}
