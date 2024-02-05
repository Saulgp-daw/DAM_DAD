using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EconomiaDomestica.Models;
using EconomiaDomestica.Views;

namespace EconomiaDomestica.Presenters
{
    public class RegistroPresenter
    {

        // Fields
        private IRegistroView view;
        private IRegistroRepository repository;
        private BindingSource registroBindingSource;
        private IEnumerable<Registro> registroList;

        // Constructor
        public RegistroPresenter(IRegistroView view, IRegistroRepository ropository)
        {
            // Inicializamos la fuente de Registros
            this.registroBindingSource = new BindingSource();

            this.view = view;
            this.repository = ropository;

            // Subscribe event handler methosd to view evets
            this.view.SearchEvent += SearchRegistro;
            this.view.AddNewEvent += AddNewRegistro;
            this.view.EditEvent += LoadSelectedRegistroToEdit;
            this.view.DeleteEvent += DeleteSelectedRegistro;
            this.view.SaveEvent += SaveRegistro;
            this.view.CancelEvent += CancelAction;

            // Set Registro dinding source
            this.view.SetResgistroBindingSource(registroBindingSource);

            // Load Registro list view
            loadAllRegistros();

            // Show view
            this.view.Show();
        }

        // Methods
        private void loadAllRegistros()
        {
            registroList = repository.GetAll();
            registroBindingSource.DataSource = registroList; //Set datasource   
        }

        private void SearchRegistro(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                registroList = repository.GetByValue(this.view.SearchValue);

                // Acualizamos fuente
                registroBindingSource.DataSource = registroList;
            }
            else
            {
                registroList = repository.GetAll();

                // Acualizamos fuente
                registroBindingSource.DataSource = registroList;
            }
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveRegistro(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedRegistro(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedRegistroToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewRegistro(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
