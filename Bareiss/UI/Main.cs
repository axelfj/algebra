using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.cmbxEcuaciones.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void txtMatriz_TextChanged(object sender, EventArgs e)
        {
            TextBox txtMatriz = ((TextBox)sender);

            try
            {
                if (txtMatriz.TextLength > 0)
                    Convert.ToInt32(txtMatriz.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(this, "Ingrese solo numeros", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatriz.Text = "";
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(this, ex.Message, "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatriz.Text = "";
            }
        }
    }
}
