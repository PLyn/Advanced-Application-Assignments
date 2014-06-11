using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3;
namespace MCBank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                client c = new client(12, "sd", "asd", "Asdx", "qwe", 12.09);
                c.connectDB();
                String num = c.getfName();
                c.setfName("Asdww");
                String text = c.getfName();
                //dbClientTest c = new dbClientTest();
               // c.connectDB();
                MessageBox.Show("YayY!");
                int add = c.getAllClients();
                //c.getClient(123);
                c.addClient(12, "sd", "asd", "Asdx", "qwe", 12.09);

            }
            catch (TypeInitializationException ex)
            {
                Exception e = ex.InnerException;
                while (e is TypeInitializationException)
                {
                    e = e.InnerException;
                }
                MessageBox.Show(e.StackTrace + " " + e.GetType() + " " + e.Message);
                // diagnose the problem by examining e's type, message, and 
                // stack trace here 
            }  
            Application.Run(new frmMain());
        }
    }
}
