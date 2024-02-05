using System;
using System.Windows.Forms;

namespace EconomiaDomestica.Views
{
    public interface IRegistroView
    {
        // Fields 
        int Id_Registro { get; set; }
        string Fecha { get; set; }
        string Concepto { get; set; }
        int Importe { get; set; }

        // Properties
        string SearchValue { get; set; }
        bool IsEdit { get; set; } 
        bool IsSuccessfool {  get; set; }
        string Message {  get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        //Establecer la fuente de enlace con la lista de Regsitro de tipo BindingSourse 
        // esto realiza un vinculo entre el contro de datos y el origen de datos
        void SetResgistroBindingSource(BindingSource Registro);
        void Show();
    }
}
