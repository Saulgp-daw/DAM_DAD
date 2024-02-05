using System;
using System.Windows.Forms;
using EconomiaDomestica.Models;
using EconomiaDomestica.Views;
using EconomiaDomestica.Presenters;
using EconomiaDomestica._Repositories;
using System.Configuration;

namespace EconomiaDomestica
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Get connection from App.config
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;
            IRegistroView view = new MainView();
            IRegistroRepository repository = new RegistroRepository(sqlConnectionString);
            new RegistroPresenter(view, repository);

            Application.Run((Form) view);
        }
    }
}
