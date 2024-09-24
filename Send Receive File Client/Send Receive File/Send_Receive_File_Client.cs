using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Send_Receive_File
{
    public partial class Send_Receive_File_Client : Form
    {
        public Send_Receive_File_Client()
        {
            InitializeComponent();
        }

        OpenFileDialog op;

        private void Browse_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            op.ShowDialog();
            BrowseForm.Text = op.FileName;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Stream fileStream = File.OpenRead(BrowseForm.Text);
            // Alocate memory space for the file
            byte[] fileBuffer = new byte[fileStream.Length];
            fileStream.Read(fileBuffer, 0, (int)fileStream.Length);
            // Open a TCP/IP Connection and send the data
            TcpClient clientSocket = new TcpClient(ServerForm.Text, 8080);
            NetworkStream networkStream = clientSocket.GetStream();
            networkStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));
            networkStream.Close();

        }
    }
}