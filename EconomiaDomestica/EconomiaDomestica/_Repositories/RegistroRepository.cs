using System;
using System.Collections.Generic;
using System.Data.SQLite;
using EconomiaDomestica.Models;


namespace EconomiaDomestica._Repositories
{
    public class RegistroRepository : BaseRepository, IRegistroRepository
    {          

        // Constructor
        public RegistroRepository(string connectionString) {
            this.connectionString = connectionString;        
        }


        // Methods
        public void Add(Registro registro)
        {
            throw new NotImplementedException();
        }

        public void Delete(Registro registro)
        {
            throw new NotImplementedException();
        }

        public void Edit(Registro registro)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registro> GetAll()
        {
            List<Registro> registrosList = new List<Registro>();

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Registros";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var registroModel = new Registro();
                registroModel.IdRegistro = Convert.ToInt32(reader[0]);
                registroModel.FechaRegistro = reader[1].ToString();
                registroModel.ConceptoRegistro = reader[2].ToString();
                registroModel.ImporteRegistro = Convert.ToInt32(reader[3]);
                registrosList.Add(registroModel);
            }
            connection.Close();

            return registrosList;

        }

        public IEnumerable<Registro> GetByValue(string value)
        {

            int registroId = int.TryParse(value, out _)?Convert.ToInt32(value) : 0;
            string registroConcepto = value;
            List<Registro> registrosList = new List<Registro>();

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Registros where Id_Registro=@id";
            command.Parameters.Add(new SQLiteParameter("@id", registroId));

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Registro registroModel = new Registro();
                registroModel.IdRegistro = Convert.ToInt32(reader[0]);
                registroModel.FechaRegistro = reader[1].ToString();
                registroModel.ConceptoRegistro = reader[2].ToString();
                registroModel.ImporteRegistro = Convert.ToInt32(reader[3]);
                registrosList.Add(registroModel);
            }
            connection.Close();

            return registrosList;
        }
    }
}
