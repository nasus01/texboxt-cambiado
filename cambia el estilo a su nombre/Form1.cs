using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cambia_el_estilo_a_su_nombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {





        }

        private void Btnpresione_Click(object sender, EventArgs e)
        {
            lblnombre.Text = txtnombre.Text;


            using (Font font = new Font("Constantia", 30.0f))
            {
                lblnombre.Font = font;
                lblnombre.ForeColor = Color.Green;
            }

        }

        private void Lblnombre_Click(object sender, EventArgs e)
        {
         

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gracias por utilizar mi programa hasta la prixima-- att: jack01");
            this.Close();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            lblnombre.Text = "";
            txtnombre.Text = "";
        }
    }
}
