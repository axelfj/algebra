using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gauss
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            this.dimensions.SelectedIndex = 0;
        }



        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainWindow_Load(object sender, EventArgs e){}

        private void label3_Click_1(object sender, EventArgs e){}

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            clean();
        }

        private void clean()
        {
            matrix11.Text = "";
            matrix12.Text = "";
            matrix13.Text = "";
            matrix14.Text = "";
            matrix15.Text = "";

            matrix21.Text = "";
            matrix22.Text = "";
            matrix23.Text = "";
            matrix24.Text = "";
            matrix25.Text = "";

            matrix31.Text = "";
            matrix32.Text = "";
            matrix33.Text = "";
            matrix34.Text = "";
            matrix35.Text = "";

            matrix41.Text = "";
            matrix42.Text = "";
            matrix43.Text = "";
            matrix44.Text = "";
            matrix45.Text = "";

            matrix51.Text = "";
            matrix52.Text = "";
            matrix53.Text = "";
            matrix54.Text = "";
            matrix55.Text = "";

            result1.Text = "";
            result2.Text = "";
            result3.Text = "";
            result4.Text = "";
            result5.Text = "";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string parser = operationBox.Text;
            int[,] matrix = toMatrix();
            historyMatrix.Text = Convert.ToString(matrix);
            //historyMatrix.Text = "Operación:\t" + parser;
            operationBox.Text = "";
        }

        private int[,] toMatrix()
        {
            string parser = dimensions.Text;

            int m = parser[0] - 48;
            int n = parser[2] - 48;

            int[,] matrix = new int[m, n];

            switch (m)
            {
                case 1:
                    switch (n)
                    {
                        case 1:
                            matrix[0,0] = Convert.ToInt32(matrix11.Text);
                            break;
                        case 2:
                            matrix[0,0] = Convert.ToInt32(matrix11.Text);
                            matrix[0,1] = Convert.ToInt32(matrix12.Text);
                            break;
                        case 3:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            break;
                        case 4:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            break;
                        case 5:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[0, 4] = Convert.ToInt32(matrix15.Text);
                            break;
                    }
                    break;
                case 2:
                    switch (n)
                    {
                        case 1:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            break;
                        case 2:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            break;
                        case 3:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            break;
                        case 4:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            break;
                        case 5:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[0, 4] = Convert.ToInt32(matrix15.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            matrix[1, 4] = Convert.ToInt32(matrix25.Text);
                            break;
                    }
                    break;
                case 3:
                    switch (n)
                    {
                        case 1:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            break;
                        case 2:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            break;
                        case 3:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            break;
                        case 4:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[2, 3] = Convert.ToInt32(matrix34.Text);
                            break;
                        case 5:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[0, 4] = Convert.ToInt32(matrix15.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            matrix[1, 4] = Convert.ToInt32(matrix25.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[2, 3] = Convert.ToInt32(matrix34.Text);
                            matrix[2, 4] = Convert.ToInt32(matrix35.Text);
                            break;
                    }
                    break;
                case 4:
                    switch (n)
                    {
                        case 1:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            break;
                        case 2:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            break;
                        case 3:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            matrix[3, 2] = Convert.ToInt32(matrix43.Text);
                            break;
                        case 4:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[2, 3] = Convert.ToInt32(matrix34.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            matrix[3, 2] = Convert.ToInt32(matrix43.Text);
                            matrix[3, 3] = Convert.ToInt32(matrix44.Text);
                            break;
                        case 5:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[0, 4] = Convert.ToInt32(matrix15.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            matrix[1, 4] = Convert.ToInt32(matrix25.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[2, 3] = Convert.ToInt32(matrix34.Text);
                            matrix[2, 4] = Convert.ToInt32(matrix35.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            matrix[3, 2] = Convert.ToInt32(matrix43.Text);
                            matrix[3, 3] = Convert.ToInt32(matrix44.Text);
                            matrix[3, 4] = Convert.ToInt32(matrix45.Text);
                            break;
                    }
                    break;
                case 5:
                    switch (n)
                    {
                        case 1:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[4, 0] = Convert.ToInt32(matrix51.Text);
                            break;
                        case 2:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            matrix[4, 0] = Convert.ToInt32(matrix51.Text);
                            matrix[4, 1] = Convert.ToInt32(matrix52.Text);
                            break;
                        case 3:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            matrix[3, 2] = Convert.ToInt32(matrix43.Text);
                            matrix[4, 0] = Convert.ToInt32(matrix51.Text);
                            matrix[4, 1] = Convert.ToInt32(matrix52.Text);
                            matrix[4, 2] = Convert.ToInt32(matrix53.Text);
                            break;
                        case 4:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[2, 3] = Convert.ToInt32(matrix34.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            matrix[3, 2] = Convert.ToInt32(matrix43.Text);
                            matrix[3, 3] = Convert.ToInt32(matrix44.Text);
                            matrix[4, 0] = Convert.ToInt32(matrix51.Text);
                            matrix[4, 1] = Convert.ToInt32(matrix52.Text);
                            matrix[4, 2] = Convert.ToInt32(matrix53.Text);
                            matrix[4, 3] = Convert.ToInt32(matrix54.Text);
                            break;
                        case 5:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[0, 4] = Convert.ToInt32(matrix15.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);
                            matrix[1, 3] = Convert.ToInt32(matrix24.Text);
                            matrix[1, 4] = Convert.ToInt32(matrix25.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);
                            matrix[2, 2] = Convert.ToInt32(matrix33.Text);
                            matrix[2, 3] = Convert.ToInt32(matrix34.Text);
                            matrix[2, 4] = Convert.ToInt32(matrix35.Text);
                            matrix[3, 0] = Convert.ToInt32(matrix41.Text);
                            matrix[3, 1] = Convert.ToInt32(matrix42.Text);
                            matrix[3, 2] = Convert.ToInt32(matrix43.Text);
                            matrix[3, 3] = Convert.ToInt32(matrix44.Text);
                            matrix[3, 4] = Convert.ToInt32(matrix45.Text);
                            matrix[4, 0] = Convert.ToInt32(matrix51.Text);
                            matrix[4, 1] = Convert.ToInt32(matrix52.Text);
                            matrix[4, 2] = Convert.ToInt32(matrix53.Text);
                            matrix[4, 3] = Convert.ToInt32(matrix54.Text);
                            matrix[4, 4] = Convert.ToInt32(matrix55.Text);
                            break;
                    }
                    break;
            }
            return matrix;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dimensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            clean();

            matrix11.ReadOnly = false;
            matrix12.ReadOnly = false;
            matrix13.ReadOnly = false;
            matrix14.ReadOnly = false;
            matrix15.ReadOnly = false;

            matrix21.ReadOnly = false;
            matrix22.ReadOnly = false;
            matrix23.ReadOnly = false;
            matrix24.ReadOnly = false;
            matrix25.ReadOnly = false;

            matrix31.ReadOnly = false;
            matrix32.ReadOnly = false;
            matrix33.ReadOnly = false;
            matrix34.ReadOnly = false;
            matrix35.ReadOnly = false;

            matrix41.ReadOnly = false;
            matrix42.ReadOnly = false;
            matrix43.ReadOnly = false;
            matrix44.ReadOnly = false;
            matrix45.ReadOnly = false;

            matrix51.ReadOnly = false;
            matrix52.ReadOnly = false;
            matrix53.ReadOnly = false;
            matrix54.ReadOnly = false;
            matrix55.ReadOnly = false;

            result1.ReadOnly = false;
            result2.ReadOnly = false;
            result3.ReadOnly = false;
            result4.ReadOnly = false;
            result5.ReadOnly = false;


            switch (dimensions.SelectedItem)
            {
                case "1x1":
                    matrix12.ReadOnly = true;
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix21.ReadOnly = true;
                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result2.ReadOnly = true;
                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "2x1":
                    matrix12.ReadOnly = true;
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "3x1":
                    matrix12.ReadOnly = true;
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "4x1":
                    matrix12.ReadOnly = true;
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result5.ReadOnly = true;
                    break;

                case "5x1":
                    matrix12.ReadOnly = true;
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;
                    break;

                case "1x2":
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix21.ReadOnly = true;
                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result2.ReadOnly = true;
                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "2x2":
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "3x2":
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "4x2":
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result5.ReadOnly = true;
                    break;

                case "5x2":
                    matrix13.ReadOnly = true;
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;
                    break;

                case "1x3":
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix21.ReadOnly = true;
                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result2.ReadOnly = true;
                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "2x3":
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "3x3":
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "4x3":
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result5.ReadOnly = true;
                    break;

                case "5x3":
                    matrix14.ReadOnly = true;
                    matrix15.ReadOnly = true;

                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;
                    break;

                case "1x4":
                    matrix15.ReadOnly = true;

                    matrix21.ReadOnly = true;
                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result2.ReadOnly = true;
                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "2x4":
                    matrix15.ReadOnly = true;

                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "3x4":
                    matrix15.ReadOnly = true;

                    matrix25.ReadOnly = true;

                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "4x4":
                    matrix15.ReadOnly = true;

                    matrix25.ReadOnly = true;

                    matrix35.ReadOnly = true;

                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result5.ReadOnly = true;
                    break;

                case "5x4":
                    matrix15.ReadOnly = true;

                    matrix25.ReadOnly = true;

                    matrix35.ReadOnly = true;

                    matrix45.ReadOnly = true;

                    matrix55.ReadOnly = true;
                    break;

                case "1x5":
                    matrix21.ReadOnly = true;
                    matrix22.ReadOnly = true;
                    matrix23.ReadOnly = true;
                    matrix24.ReadOnly = true;
                    matrix25.ReadOnly = true;

                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result2.ReadOnly = true;
                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "2x5":
                    matrix31.ReadOnly = true;
                    matrix32.ReadOnly = true;
                    matrix33.ReadOnly = true;
                    matrix34.ReadOnly = true;
                    matrix35.ReadOnly = true;

                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result3.ReadOnly = true;
                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "3x5":
                    matrix41.ReadOnly = true;
                    matrix42.ReadOnly = true;
                    matrix43.ReadOnly = true;
                    matrix44.ReadOnly = true;
                    matrix45.ReadOnly = true;

                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result4.ReadOnly = true;
                    result5.ReadOnly = true;
                    break;

                case "4x5":
                    matrix51.ReadOnly = true;
                    matrix52.ReadOnly = true;
                    matrix53.ReadOnly = true;
                    matrix54.ReadOnly = true;
                    matrix55.ReadOnly = true;

                    result5.ReadOnly = true;
                    break;

            }
        }

        private void historyMatrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void scrollHistory_Scroll(object sender, ScrollEventArgs e)
        {
        }
    }
}
