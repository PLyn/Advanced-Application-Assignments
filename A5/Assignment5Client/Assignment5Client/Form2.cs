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
using System.Threading;


namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        String clientName;
        TcpClient client;
        NetworkStream clientStream;
        ASCIIEncoding encoder;
        volatile bool connectionStatus;  //volatile variable to prevent any changes by the compiler as this variable will be used to check for future changes made by a thread



        public Form2(String val)
        {
            encoder = new ASCIIEncoding();
            clientName = val;
            connectionStatus = false;
            InitializeComponent();
            connStatus_lble.Text = "Please Hold While Server Connection Is Established......";
            connectionThread();  //connection is threaded to ensure smooth running of application: an action is sent to the gui component if no connection as established
        }


        /*DESCRIPTION   -- This function starts all the necessary threads for the smooth running of the application (connection thread: to connect to server, status thread: to keep track of connection and read thread to get server response) *                            		
            (ARGUMENTS)    -- () -> Void
            PRECONDITION   --  Connection must be established to start reader thread                 	
            POSTCONDITION	 -- Starts connection Thread, Reader Thread and Status Check Thread
            EXAMPLE (s)	 -- connectionThread() -> connection thread and reader threads begin running in background
            */
        private void connectionThread()
        {
            Thread connectToServer = new Thread(new ThreadStart(connection));
            Thread ConnectionStatus = new Thread(new ThreadStart(getConnectionStatus));

            connectToServer.Start();
            ConnectionStatus.Start();

        }


        /*DESCRIPTION   -- This function tries to connect to the server if no connection is established a messages is sent to the gui component*                            		
          (ARGUMENTS)    -- () -> Void
          PRECONDITION   --  No Precondition               	
          POSTCONDITION	 -- Client is now connected to server: appropiate message is sent to gui component
          EXAMPLE (s)	 -- connection() -> Connenction Established || could not connect to server
          */
        private void connection()
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse("192.168.1.6"), 8000); //connecting to server
                connectionStatus = true;
                connStatus_lble.Invoke(new Action(() => connStatus_lble.Text = "Connection Established:: Connected To Advance App Server"));
                clientStream = client.GetStream();
                writeMessage(clientName);
            }
            catch (Exception x)
            {
                connStatus_lble.Invoke(new Action(() => connStatus_lble.Text = "Could Not Connect To Server"));
            }
        }


        /*DESCRIPTION   -- This function disables send data button until connection is established then enables the send data button on Form
          (ARGUMENTS)    -- () -> Void
          PRECONDITION   --  Connection must be established to release block              	
          POSTCONDITION	 -- Send Data button is activated once connection is established
          EXAMPLE (s)	 -- getConnectionStatus() -> send Data becomes deactivated until connection is established
          */
        private void getConnectionStatus()
        {

            while (!connectionStatus)
            {
                send_btn.Invoke(new Action(() => send_btn.Enabled = false));
            }
            send_btn.Invoke(new Action(() => send_btn.Enabled = true));
            Thread messageReader = new Thread(new ThreadStart(readMessage));
            messageReader.Start();

        }

        /*DESCRIPTION   -- This function accepts a string as parameter and send that string as a message to the server
          (ARGUMENTS)    -- (String) -> Void
          PRECONDITION   --  Connection must be established                 	
          POSTCONDITION	 -- Sends message to server
          EXAMPLE (s)	 -- writeMessage("How r u server?") -> "How r u server" is sent to the server
          */
        private void writeMessage(String message)
        {
            if (connectionStatus)
            {
                byte[] buffer = encoder.GetBytes(message);

                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush(); //ensuring that all data is sent from the buffer stream
            }

        }

        /*DESCRIPTION   -- This function reads messages sent from the server and ouputs it to a gui component
           (ARGUMENTS)    -- () -> Void
           PRECONDITION   --  Connection must be established                 	
           POSTCONDITION	 -- Outputs server message to gui component
           EXAMPLE (s)	 -- readMessage() -> Server Said: "THis is my first message";
           */
        private void readMessage()
        {
            Byte[] read = new Byte[32];   // creating byte array to store bytes coming from server
           
            clientStream.Read(read, 0, read.Length);
            if (read != null)
            {
                ouput_txtBox.Invoke(new Action(() => ouput_txtBox.AppendText("\nServer Says" + encoder.GetString(read))));
            }
        }



        private void send_btn_Click(object sender, EventArgs e)
        {

            writeMessage(comboBox.GetItemText(comboBox.SelectedItem)); // sends the selected option to the server
            readMessage();
        }
    }
}
