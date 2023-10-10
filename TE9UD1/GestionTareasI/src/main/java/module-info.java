module com.example.gestiontareasi {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.gestiontareasi to javafx.fxml;
    exports com.example.gestiontareasi;
}