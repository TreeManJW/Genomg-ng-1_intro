using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genomgång_1_intro
{
    public partial class Form1 : Form
    {
        bool dödaHans = false;
        bool namn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)){
                namn = false;
            }
            else{
                namn = true;
            }

            if (dödaHans == true & namn == true){
                BackColor = Color.Red;
                MessageBox.Show("Haha vi skoja. Nu vet Hans att du vill döda honom och att du heter " + textBox1.Text + "! Sov med ett öga öppet inatt!");
                //Thread.Sleep(5000);
                Environment.Exit(0); 
            }
            else{
                MessageBox.Show("Du vill antingen inte döda hans eller så vet han inte ditt namn!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                dödaHans = true;
            }
            else{
                dödaHans = false;
            }
        }
    }
}
