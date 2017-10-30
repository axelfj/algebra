using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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
            int n = Convert.ToInt32(cmbxEcuaciones.SelectedItem);
            int[,] matriz = new int[n, n + 1];

            switch (n)
            {
                case 1:
                    matriz[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                    matriz[0, 1] = Convert.ToInt32(txtMatriz16.Text);
                    break;
                case 2:
                    matriz[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                    matriz[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                    matriz[0, 2] = Convert.ToInt32(txtMatriz16.Text);

                    matriz[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                    matriz[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                    matriz[1, 2] = Convert.ToInt32(txtMatriz26.Text);

                    break;
                case 3:
                    matriz[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                    matriz[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                    matriz[0, 2] = Convert.ToInt32(txtMatriz13.Text);
                    matriz[0, 3] = Convert.ToInt32(txtMatriz16.Text);

                    matriz[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                    matriz[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                    matriz[1, 2] = Convert.ToInt32(txtMatriz23.Text);
                    matriz[1, 3] = Convert.ToInt32(txtMatriz26.Text);

                    matriz[2, 0] = Convert.ToInt32(txtMatriz31.Text);
                    matriz[2, 1] = Convert.ToInt32(txtMatriz32.Text);
                    matriz[2, 2] = Convert.ToInt32(txtMatriz33.Text);
                    matriz[2, 3] = Convert.ToInt32(txtMatriz36.Text);
                    break;
                case 4:
                    matriz[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                    matriz[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                    matriz[0, 2] = Convert.ToInt32(txtMatriz13.Text);
                    matriz[0, 3] = Convert.ToInt32(txtMatriz14.Text);
                    matriz[0, 4] = Convert.ToInt32(txtMatriz16.Text);

                    matriz[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                    matriz[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                    matriz[1, 2] = Convert.ToInt32(txtMatriz23.Text);
                    matriz[1, 3] = Convert.ToInt32(txtMatriz24.Text);
                    matriz[1, 4] = Convert.ToInt32(txtMatriz26.Text);

                    matriz[2, 0] = Convert.ToInt32(txtMatriz31.Text);
                    matriz[2, 1] = Convert.ToInt32(txtMatriz32.Text);
                    matriz[2, 2] = Convert.ToInt32(txtMatriz33.Text);
                    matriz[2, 3] = Convert.ToInt32(txtMatriz34.Text);
                    matriz[2, 4] = Convert.ToInt32(txtMatriz36.Text);

                    matriz[3, 0] = Convert.ToInt32(txtMatriz41.Text);
                    matriz[3, 1] = Convert.ToInt32(txtMatriz42.Text);
                    matriz[3, 2] = Convert.ToInt32(txtMatriz43.Text);
                    matriz[3, 3] = Convert.ToInt32(txtMatriz44.Text);
                    matriz[3, 4] = Convert.ToInt32(txtMatriz46.Text);
                    break;
                case 5:

                    matriz[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                    matriz[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                    matriz[0, 2] = Convert.ToInt32(txtMatriz13.Text);
                    matriz[0, 3] = Convert.ToInt32(txtMatriz14.Text);
                    matriz[0, 4] = Convert.ToInt32(txtMatriz15.Text);
                    matriz[0, 5] = Convert.ToInt32(txtMatriz16.Text);

                    matriz[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                    matriz[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                    matriz[1, 2] = Convert.ToInt32(txtMatriz23.Text);
                    matriz[1, 3] = Convert.ToInt32(txtMatriz24.Text);
                    matriz[1, 4] = Convert.ToInt32(txtMatriz25.Text);
                    matriz[1, 5] = Convert.ToInt32(txtMatriz26.Text);

                    matriz[2, 0] = Convert.ToInt32(txtMatriz31.Text);
                    matriz[2, 1] = Convert.ToInt32(txtMatriz32.Text);
                    matriz[2, 2] = Convert.ToInt32(txtMatriz33.Text);
                    matriz[2, 3] = Convert.ToInt32(txtMatriz34.Text);
                    matriz[2, 4] = Convert.ToInt32(txtMatriz35.Text);
                    matriz[2, 5] = Convert.ToInt32(txtMatriz36.Text);

                    matriz[3, 0] = Convert.ToInt32(txtMatriz41.Text);
                    matriz[3, 1] = Convert.ToInt32(txtMatriz42.Text);
                    matriz[3, 2] = Convert.ToInt32(txtMatriz43.Text);
                    matriz[3, 3] = Convert.ToInt32(txtMatriz44.Text);
                    matriz[3, 4] = Convert.ToInt32(txtMatriz45.Text);
                    matriz[3, 5] = Convert.ToInt32(txtMatriz46.Text);

                    matriz[4, 0] = Convert.ToInt32(txtMatriz51.Text);
                    matriz[4, 1] = Convert.ToInt32(txtMatriz52.Text);
                    matriz[4, 2] = Convert.ToInt32(txtMatriz53.Text);
                    matriz[4, 3] = Convert.ToInt32(txtMatriz54.Text);
                    matriz[4, 4] = Convert.ToInt32(txtMatriz55.Text);
                    matriz[4, 5] = Convert.ToInt32(txtMatriz56.Text);
                    break;
            }

            AlgoritmoBareiss ab = new AlgoritmoBareiss();

            ab.EjecutarBareiss(matriz, n);
        }

        private void txtMatriz_TextChanged(object sender, EventArgs e)
        {
            TextBox txtMatriz = ((TextBox)sender);

            try
            {
                if (txtMatriz.TextLength > 0 && txtMatriz.Text != "-" )
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
            catch(Exception ex)
            {
                MessageBox.Show(this, "Error desconocido.\nDetalles:\n"+ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbxEcuaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMatriz11.Text = "";
            txtMatriz12.Text = "";
            txtMatriz13.Text = "";
            txtMatriz14.Text = "";
            txtMatriz16.Text = "";
            txtMatriz15.Text = "";

            txtMatriz21.Text = "";
            txtMatriz22.Text = "";
            txtMatriz23.Text = "";
            txtMatriz24.Text = "";
            txtMatriz25.Text = "";
            txtMatriz26.Text = "";

            txtMatriz31.Text = "";
            txtMatriz32.Text = "";
            txtMatriz33.Text = "";
            txtMatriz34.Text = "";
            txtMatriz35.Text = "";
            txtMatriz36.Text = "";

            txtMatriz41.Text = "";
            txtMatriz42.Text = "";
            txtMatriz43.Text = "";
            txtMatriz44.Text = "";
            txtMatriz45.Text = "";
            txtMatriz46.Text = "";

            txtMatriz51.Text = "";
            txtMatriz52.Text = "";
            txtMatriz53.Text = "";
            txtMatriz54.Text = "";
            txtMatriz55.Text = "";
            txtMatriz56.Text = "";

            txtMatriz12.ReadOnly = false;
            txtMatriz13.ReadOnly = false;
            txtMatriz14.ReadOnly = false;
            txtMatriz15.ReadOnly = false;

            txtMatriz21.ReadOnly = false;
            txtMatriz22.ReadOnly = false;
            txtMatriz23.ReadOnly = false;
            txtMatriz24.ReadOnly = false;
            txtMatriz25.ReadOnly = false;
            txtMatriz26.ReadOnly = false;

            txtMatriz31.ReadOnly = false;
            txtMatriz32.ReadOnly = false;
            txtMatriz33.ReadOnly = false;
            txtMatriz34.ReadOnly = false;
            txtMatriz35.ReadOnly = false;
            txtMatriz36.ReadOnly = false;

            txtMatriz41.ReadOnly = false;
            txtMatriz42.ReadOnly = false;
            txtMatriz43.ReadOnly = false;
            txtMatriz44.ReadOnly = false;
            txtMatriz45.ReadOnly = false;
            txtMatriz46.ReadOnly = false;

            txtMatriz51.ReadOnly = false;
            txtMatriz52.ReadOnly = false;
            txtMatriz53.ReadOnly = false;
            txtMatriz54.ReadOnly = false;
            txtMatriz55.ReadOnly = false;
            txtMatriz56.ReadOnly = false;

            switch (cmbxEcuaciones.SelectedItem)
            {
                case "1":
                    txtMatriz12.ReadOnly = true;
                    txtMatriz13.ReadOnly = true;
                    txtMatriz14.ReadOnly = true;
                    txtMatriz15.ReadOnly = true;

                    txtMatriz21.ReadOnly = true;
                    txtMatriz22.ReadOnly = true;
                    txtMatriz23.ReadOnly = true;
                    txtMatriz24.ReadOnly = true;
                    txtMatriz25.ReadOnly = true;
                    txtMatriz26.ReadOnly = true;

                    txtMatriz31.ReadOnly = true;
                    txtMatriz32.ReadOnly = true;
                    txtMatriz33.ReadOnly = true;
                    txtMatriz34.ReadOnly = true;
                    txtMatriz35.ReadOnly = true;
                    txtMatriz36.ReadOnly = true;

                    txtMatriz41.ReadOnly = true;
                    txtMatriz42.ReadOnly = true;
                    txtMatriz43.ReadOnly = true;
                    txtMatriz44.ReadOnly = true;
                    txtMatriz45.ReadOnly = true;
                    txtMatriz46.ReadOnly = true;

                    txtMatriz51.ReadOnly = true;
                    txtMatriz52.ReadOnly = true;
                    txtMatriz53.ReadOnly = true;
                    txtMatriz54.ReadOnly = true;
                    txtMatriz55.ReadOnly = true;
                    txtMatriz56.ReadOnly = true;
                    break;
                case "2":
                    txtMatriz13.ReadOnly = true;
                    txtMatriz14.ReadOnly = true;
                    txtMatriz15.ReadOnly = true;

                    txtMatriz23.ReadOnly = true;
                    txtMatriz24.ReadOnly = true;
                    txtMatriz25.ReadOnly = true;

                    txtMatriz31.ReadOnly = true;
                    txtMatriz32.ReadOnly = true;
                    txtMatriz33.ReadOnly = true;
                    txtMatriz34.ReadOnly = true;
                    txtMatriz35.ReadOnly = true;
                    txtMatriz36.ReadOnly = true;

                    txtMatriz41.ReadOnly = true;
                    txtMatriz42.ReadOnly = true;
                    txtMatriz43.ReadOnly = true;
                    txtMatriz44.ReadOnly = true;
                    txtMatriz45.ReadOnly = true;
                    txtMatriz46.ReadOnly = true;

                    txtMatriz51.ReadOnly = true;
                    txtMatriz52.ReadOnly = true;
                    txtMatriz53.ReadOnly = true;
                    txtMatriz54.ReadOnly = true;
                    txtMatriz55.ReadOnly = true;
                    txtMatriz56.ReadOnly = true;
                    break;
                case "3":
                    txtMatriz14.ReadOnly = true;
                    txtMatriz15.ReadOnly = true;

                    txtMatriz24.ReadOnly = true;
                    txtMatriz25.ReadOnly = true;

                    txtMatriz34.ReadOnly = true;
                    txtMatriz35.ReadOnly = true;

                    txtMatriz41.ReadOnly = true;
                    txtMatriz42.ReadOnly = true;
                    txtMatriz43.ReadOnly = true;
                    txtMatriz44.ReadOnly = true;
                    txtMatriz45.ReadOnly = true;
                    txtMatriz46.ReadOnly = true;

                    txtMatriz51.ReadOnly = true;
                    txtMatriz52.ReadOnly = true;
                    txtMatriz53.ReadOnly = true;
                    txtMatriz54.ReadOnly = true;
                    txtMatriz55.ReadOnly = true;
                    txtMatriz56.ReadOnly = true;
                    break;
                case "4":
                    txtMatriz15.ReadOnly = true;

                    txtMatriz25.ReadOnly = true;

                    txtMatriz35.ReadOnly = true;

                    txtMatriz45.ReadOnly = true;

                    txtMatriz51.ReadOnly = true;
                    txtMatriz52.ReadOnly = true;
                    txtMatriz53.ReadOnly = true;
                    txtMatriz54.ReadOnly = true;
                    txtMatriz55.ReadOnly = true;
                    txtMatriz56.ReadOnly = true;
                    break;
            }
        }
    }
}
