module com.example.gestiontareasi {
    requires javafx.controls;
    requires javafx.fxml;
    requires java.desktop;


    opens com.example.gestiontareasi to javafx.fxml;
    exports com.example.gestiontareasi;
    exports com.example.gestiontareasi.Controlador;
    opens com.example.gestiontareasi.Controlador to javafx.fxml;
}