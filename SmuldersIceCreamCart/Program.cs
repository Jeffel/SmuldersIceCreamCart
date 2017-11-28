using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;

namespace SmuldersIceCreamCart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] dbinfo = File.ReadAllLines(dialog.FileName);
                string host = dbinfo[0];
                string username = dbinfo[1];
                string password = dbinfo[2];

                new Connection(host, username, password);
                Application.EnableVisualStyles();
                
                Application.Run(new Login());
            }
        }
    }
}
