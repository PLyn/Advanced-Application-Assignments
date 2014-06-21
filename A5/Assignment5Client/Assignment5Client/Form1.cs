/*
 *  Assignment 5 - Sockets and Multithreading
 *  By: Peter Lyn (26100068) && Tajwane Campbell (29085001)
 *  Date: 21/06/14
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Form2 form;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            createClient("Client #1");
        }

        /*DESCRIPTION   -- This Function will create an instant of a client form with the tittle name of the string passed to it            		
         (ARGUMENTS)    -- (String) -> Void
         PRECONDITION   --  This function accepts one parameter of type String                    	
         POSTCONDITION	 -- Will Show a client Form on Screen		
         EXAMPLE (s)	 -- createClient("Student") -> A instant of client form with the title name student will be shown on screen
         */
        private void createClient(String clientName)
        {
            form = new Form2(clientName);
            form.Text = clientName;
            form.Show();
        }

        
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the application and all child applications once clicked
        }

        private void client3_btn_Click_1(object sender, EventArgs e)
        {
            createClient("Client #3");
        }

        private void client2_btn_Click_1(object sender, EventArgs e)
        {
            createClient("Client #2");
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
