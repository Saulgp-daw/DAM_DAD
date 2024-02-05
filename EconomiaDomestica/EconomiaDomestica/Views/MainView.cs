using System;
using System.Windows.Forms;

namespace EconomiaDomestica.Views
{
    public partial class MainView : Form, IRegistroView
    {
        // Fields
        private string message;
        private bool isSuccessfool;
        private bool isEdit;

        // Constructor
        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            // Hide tabDetail as is show only on click edit
            tabControl.TabPages.Remove(tabPageDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtbSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //ToDo Agregar Editar y Eliminar
        }

        // Properties
        public int Id_Registro {
            get { return int.Parse(txtbIdRegistro.Text); }
            set { txtbIdRegistro.Text = value.ToString(); } 
        }

        public string Fecha {
            get { return txtbFecha.Text;  }
            set { txtbFecha.Text = value; }
        }

        public string Concepto {
            get { return txtbConcepto.Text; }
            set { txtbConcepto.Text = value; }
        }

        public int Importe
        {
            get { return int.Parse(txtbImporte.Text); }
            set { txtbImporte.Text = value.ToString(); }
        }

        public string SearchValue {
            get { return txtbSearch.Text; }
            set { txtbSearch.Text = value;  }
        }

        public bool IsEdit { 
            get { return isEdit; }
            set { isEdit = value;  }
        }

        public bool IsSuccessfool {
            get { return isSuccessfool; }
            set { isSuccessfool = value; }
        }

        public string Message {
            get { return message; }
            set { message = value; }
        }

       // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetResgistroBindingSource(BindingSource Registro)
        {
            // Establecemos datos del GridView a la fuente de datos
            dataGVRegistro.DataSource = Registro;
        }
    }
}
