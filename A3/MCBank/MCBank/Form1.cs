using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3;
namespace MCBank
{
    public partial class frmMain : Form
    {
           
        public frmMain()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                client c = new client(12, "sd", "asd", "Asdx", "qwe", 12.09);
                c.connectDB();
                c.addClient(12, "sd", "asd", "Asdx", "qwe", 12.09);
                MessageBox.Show("Records added successfully", "Success");
            }
            catch (TypeInitializationException ex)
            {
                Exception ee = ex.InnerException;
                
                while (ee is TypeInitializationException)
                {
                    ee = ee.InnerException;
                    MessageBox.Show(ee.StackTrace);
                }
                // diagnose the problem by examining e's type, message, and 
                // stack trace here 
            }   
        }
    }
}
