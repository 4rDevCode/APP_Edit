using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEdit
{
    public partial class Form1 : Form
    {
        private Clase CLS = new Clase();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLS.TextConnection())
                {
                    CLS.TextConnection(); gb01.Enabled = true;
                }
                else
                {
                    gb01.Enabled = false ;
                    MessageBox.Show("Ups error: No se logro conectar con la base de datos \n ", "AppEdit", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups error: " + ex.Message + " \n ", "AppEdit", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = CLS.ObtenerZVERS(txtEmpresa.Text , nudAño.Value + "" );
                if(DT.Rows.Count > 0)
                {
                    Set();
                }
                else
                {
                    MessageBox.Show("Ups error: No se logro conectar con la base de datos. \n ", "AppEdit", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups error: " + ex.Message + " \n ", "AppEdit", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        private void Set()
        {
            try
            {
                DataTable DT = CLS.SetZVERS(txtEmpresa.Text, nudAño.Value + "");
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("Se logro guardar el cambio de manera exitosa. \n ", "AppEdit", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    gb01.Enabled = false; txtEmpresa.Text = "";
                }
                else
                {
                    MessageBox.Show("Ups error: No se logro conectar con la base de datos. \n ", "AppEdit", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups error: " + ex.Message + " \n ", "AppEdit", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
      

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)) || (e.KeyChar == 46))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if ((Char.IsDigit(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }
    }
}
