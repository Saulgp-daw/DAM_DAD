module com.example.primerainterfaz {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.primerainterfaz to javafx.fxml;
    exports com.example.primerainterfaz;
}