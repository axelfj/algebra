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


        private string mensajeDeterminante = "El determinante es: ";
        private string mensajeSistema = "El conjunto de solución es: ";

        private void Main_Load(object sender, EventArgs e) { }

        public Main()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.cmbxEcuaciones.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblMatrizA0.Text = "";
            lblMatrizA1.Text = "";
            lblMatrizA2.Text = "";
            lblMatrizA3.Text = "";
            lblMatrizA4.Text = "";
            int n = Convert.ToInt32(cmbxEcuaciones.SelectedItem);
            double[,] matrizInicial = new double[n, n + 1];
            try
            {
                switch (n)
                {
                    case 1:
                        matrizInicial[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                        matrizInicial[0, 1] = Convert.ToInt32(txtMatriz16.Text);
                        break;
                    case 2:
                        matrizInicial[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                        matrizInicial[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                        matrizInicial[0, 2] = Convert.ToInt32(txtMatriz16.Text);

                        matrizInicial[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                        matrizInicial[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                        matrizInicial[1, 2] = Convert.ToInt32(txtMatriz26.Text);

                        break;
                    case 3:
                        matrizInicial[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                        matrizInicial[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                        matrizInicial[0, 2] = Convert.ToInt32(txtMatriz13.Text);
                        matrizInicial[0, 3] = Convert.ToInt32(txtMatriz16.Text);

                        matrizInicial[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                        matrizInicial[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                        matrizInicial[1, 2] = Convert.ToInt32(txtMatriz23.Text);
                        matrizInicial[1, 3] = Convert.ToInt32(txtMatriz26.Text);

                        matrizInicial[2, 0] = Convert.ToInt32(txtMatriz31.Text);
                        matrizInicial[2, 1] = Convert.ToInt32(txtMatriz32.Text);
                        matrizInicial[2, 2] = Convert.ToInt32(txtMatriz33.Text);
                        matrizInicial[2, 3] = Convert.ToInt32(txtMatriz36.Text);
                        break;
                    case 4:
                        matrizInicial[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                        matrizInicial[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                        matrizInicial[0, 2] = Convert.ToInt32(txtMatriz13.Text);
                        matrizInicial[0, 3] = Convert.ToInt32(txtMatriz14.Text);
                        matrizInicial[0, 4] = Convert.ToInt32(txtMatriz16.Text);

                        matrizInicial[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                        matrizInicial[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                        matrizInicial[1, 2] = Convert.ToInt32(txtMatriz23.Text);
                        matrizInicial[1, 3] = Convert.ToInt32(txtMatriz24.Text);
                        matrizInicial[1, 4] = Convert.ToInt32(txtMatriz26.Text);

                        matrizInicial[2, 0] = Convert.ToInt32(txtMatriz31.Text);
                        matrizInicial[2, 1] = Convert.ToInt32(txtMatriz32.Text);
                        matrizInicial[2, 2] = Convert.ToInt32(txtMatriz33.Text);
                        matrizInicial[2, 3] = Convert.ToInt32(txtMatriz34.Text);
                        matrizInicial[2, 4] = Convert.ToInt32(txtMatriz36.Text);

                        matrizInicial[3, 0] = Convert.ToInt32(txtMatriz41.Text);
                        matrizInicial[3, 1] = Convert.ToInt32(txtMatriz42.Text);
                        matrizInicial[3, 2] = Convert.ToInt32(txtMatriz43.Text);
                        matrizInicial[3, 3] = Convert.ToInt32(txtMatriz44.Text);
                        matrizInicial[3, 4] = Convert.ToInt32(txtMatriz46.Text);
                        break;
                    case 5:

                        matrizInicial[0, 0] = Convert.ToInt32(txtMatriz11.Text);
                        matrizInicial[0, 1] = Convert.ToInt32(txtMatriz12.Text);
                        matrizInicial[0, 2] = Convert.ToInt32(txtMatriz13.Text);
                        matrizInicial[0, 3] = Convert.ToInt32(txtMatriz14.Text);
                        matrizInicial[0, 4] = Convert.ToInt32(txtMatriz15.Text);
                        matrizInicial[0, 5] = Convert.ToInt32(txtMatriz16.Text);

                        matrizInicial[1, 0] = Convert.ToInt32(txtMatriz21.Text);
                        matrizInicial[1, 1] = Convert.ToInt32(txtMatriz22.Text);
                        matrizInicial[1, 2] = Convert.ToInt32(txtMatriz23.Text);
                        matrizInicial[1, 3] = Convert.ToInt32(txtMatriz24.Text);
                        matrizInicial[1, 4] = Convert.ToInt32(txtMatriz25.Text);
                        matrizInicial[1, 5] = Convert.ToInt32(txtMatriz26.Text);

                        matrizInicial[2, 0] = Convert.ToInt32(txtMatriz31.Text);
                        matrizInicial[2, 1] = Convert.ToInt32(txtMatriz32.Text);
                        matrizInicial[2, 2] = Convert.ToInt32(txtMatriz33.Text);
                        matrizInicial[2, 3] = Convert.ToInt32(txtMatriz34.Text);
                        matrizInicial[2, 4] = Convert.ToInt32(txtMatriz35.Text);
                        matrizInicial[2, 5] = Convert.ToInt32(txtMatriz36.Text);

                        matrizInicial[3, 0] = Convert.ToInt32(txtMatriz41.Text);
                        matrizInicial[3, 1] = Convert.ToInt32(txtMatriz42.Text);
                        matrizInicial[3, 2] = Convert.ToInt32(txtMatriz43.Text);
                        matrizInicial[3, 3] = Convert.ToInt32(txtMatriz44.Text);
                        matrizInicial[3, 4] = Convert.ToInt32(txtMatriz45.Text);
                        matrizInicial[3, 5] = Convert.ToInt32(txtMatriz46.Text);

                        matrizInicial[4, 0] = Convert.ToInt32(txtMatriz51.Text);
                        matrizInicial[4, 1] = Convert.ToInt32(txtMatriz52.Text);
                        matrizInicial[4, 2] = Convert.ToInt32(txtMatriz53.Text);
                        matrizInicial[4, 3] = Convert.ToInt32(txtMatriz54.Text);
                        matrizInicial[4, 4] = Convert.ToInt32(txtMatriz55.Text);
                        matrizInicial[4, 5] = Convert.ToInt32(txtMatriz56.Text);
                        break;
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Los campos son invalidos", "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AlgoritmoBareiss miAlgoritmo = new AlgoritmoBareiss();

            try
            {
                List<double[,]> listaResultado = miAlgoritmo.EjecutarBareiss(matrizInicial, n);

                imprimirSolucion(listaResultado, n);
            }
            catch(ArithmeticException ex)
            {
                MessageBox.Show(this, ex.Message, "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error desconocido.\nDetalles:\n" + ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMatriz_TextChanged(object sender, EventArgs e)
        {
            TextBox txtMatriz = ((TextBox)sender);

            try
            {
                if (txtMatriz.TextLength > 0 && txtMatriz.Text != "-" )
                    Convert.ToInt32(txtMatriz.Text);
            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (FormatException ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
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

        

        private void imprimirSolucion(List<double[,]> nMatrices, int n)
        {
            lblDet.Text = mensajeDeterminante + nMatrices[n][0, 0];
            lblDet.Visible = true;

            lblConjuntoSolucion.Visible = true;
            lblConjuntoSolucion.Text = mensajeSistema + "{";

            double[,] conjunto = nMatrices[n + 1];

            for (int i = 0; i < n; i++)
            {
                lblConjuntoSolucion.Text = lblConjuntoSolucion.Text + Math.Round(conjunto[0, i], 2) + (((i + 1) < n) ? "; " : "}");

                double[,] matriz = nMatrices[i];

                string matrizImprimible = "";

                for (int k = 0; k < matriz.GetLength(0); k++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matrizImprimible = matrizImprimible + matriz[k, j] + ((j + 1) < matriz.GetLength(1) ? "," : "");
                    }

                    matrizImprimible = matrizImprimible + Environment.NewLine;
                }

                switch (i)
                {
                    case 0:
                        lblMatrizA0.Text = matrizImprimible;
                        break;
                    case 1:
                        lblMatrizA1.Text = matrizImprimible;
                        break;
                    case 2:
                        lblMatrizA2.Text = matrizImprimible;
                        break;
                    case 3:
                        lblMatrizA3.Text = matrizImprimible;
                        break;
                    case 4:
                        lblMatrizA4.Text = matrizImprimible;
                        break;
                }
                
            }
        }
    }
}
