﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;


namespace PolaczenieTcpKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = textBox1.Text; int port = System.Convert.ToInt16(numericUpDown1.Value); 
            try 
            { 
                TcpClient klient = new TcpClient(host, port); 
                listBox1.Items.Add("Nawiązano połączenie z " + host + " na porcie:                " + port); 
                klient.Close(); 
            }
            catch (Exception ex) 
            { 
                listBox1.Items.Add("Błąd: Nie udało się nawiązać połączenia!"); 
                MessageBox.Show(ex.ToString()); 
            } 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
