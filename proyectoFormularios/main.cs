using login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teira.Agustin.PrimerParcial.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Login login = new Login();
            //Application.Run(new formCRUD(login.usuario));
            
            if (login.ShowDialog() == DialogResult.OK)
            {
                login.Close();
                Application.Run(new formCRUD(login.usuario));
            }
            else
            {
                login.Close();
                Application.Run(new formCRUD(login.usuario));
            }
        }
    }
}
