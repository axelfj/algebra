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
        public int iterator = 1;
        public string toHistory = "";
        public Stack<int[,]> undo = new Stack<int[,]>();

        public mainWindow()
        {
            InitializeComponent();
            this.dimensions.SelectedIndex = 0;
        }

        private void lblTitulo_Click(object sender, EventArgs e){}

        private void textBox2_TextChanged(object sender, EventArgs e){}

        private void mainWindow_Load(object sender, EventArgs e){}

        private void label3_Click_1(object sender, EventArgs e){}

        private void button1_Click_1(object sender, EventArgs e)
        {

            toHistory = toHistory + toString(toMatrix());
            historyMatrix.Text = toHistory;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            clean();
            toHistory = "";
            historyMatrix.Text = "";
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

        private int[,] toMatrix()
        {
            string parser = dimensions.Text;

            int m = parser[0] - 48;
            int n = parser[2] - 48;

            int[,] matrix = new int[m + 1, n + 1];

            switch (m)
            {
                case 1:
                    switch (n)
                    {
                        case 1:
                            matrix[0,0] = Convert.ToInt32(matrix11.Text);

                            matrix[0,1] = Convert.ToInt32(result1.Text);
                            break;
                        case 2:
                            matrix[0,0] = Convert.ToInt32(matrix11.Text);
                            matrix[0,1] = Convert.ToInt32(matrix12.Text);

                            matrix[0,2] = Convert.ToInt32(result1.Text);
                            break;
                        case 3:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);

                            matrix[0, 3] = Convert.ToInt32(result1.Text);
                            break;
                        case 4:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);

                            matrix[0, 4] = Convert.ToInt32(result1.Text);
                            break;
                        case 5:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[0, 3] = Convert.ToInt32(matrix14.Text);
                            matrix[0, 4] = Convert.ToInt32(matrix15.Text);

                            matrix[0, 5] = Convert.ToInt32(result1.Text);
                            break;
                    }
                    break;
                case 2:
                    switch (n)
                    {
                        case 1:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);

                            matrix[0, 1] = Convert.ToInt32(result1.Text);
                            matrix[1, 1] = Convert.ToInt32(result2.Text);
                            break;
                        case 2:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);

                            matrix[0, 2] = Convert.ToInt32(result1.Text);
                            matrix[1, 2] = Convert.ToInt32(result2.Text);
                            break;
                        case 3:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[0, 2] = Convert.ToInt32(matrix13.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[1, 2] = Convert.ToInt32(matrix23.Text);

                            matrix[0, 3] = Convert.ToInt32(result1.Text);
                            matrix[1, 3] = Convert.ToInt32(result2.Text);
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

                            matrix[0, 4] = Convert.ToInt32(result1.Text);
                            matrix[1, 4] = Convert.ToInt32(result2.Text);
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

                            matrix[0, 5] = Convert.ToInt32(result1.Text);
                            matrix[1, 5] = Convert.ToInt32(result2.Text);
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

                            matrix[0, 1] = Convert.ToInt32(result1.Text);
                            matrix[1, 1] = Convert.ToInt32(result2.Text);
                            matrix[2, 1] = Convert.ToInt32(result3.Text);
                            break;
                        case 2:
                            matrix[0, 0] = Convert.ToInt32(matrix11.Text);
                            matrix[0, 1] = Convert.ToInt32(matrix12.Text);
                            matrix[1, 0] = Convert.ToInt32(matrix21.Text);
                            matrix[1, 1] = Convert.ToInt32(matrix22.Text);
                            matrix[2, 0] = Convert.ToInt32(matrix31.Text);
                            matrix[2, 1] = Convert.ToInt32(matrix32.Text);

                            matrix[0, 2] = Convert.ToInt32(result1.Text);
                            matrix[1, 2] = Convert.ToInt32(result2.Text);
                            matrix[2, 2] = Convert.ToInt32(result3.Text);
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

                            matrix[0, 3] = Convert.ToInt32(result1.Text);
                            matrix[1, 3] = Convert.ToInt32(result2.Text);
                            matrix[2, 3] = Convert.ToInt32(result3.Text);
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

                            matrix[0, 4] = Convert.ToInt32(result1.Text);
                            matrix[1, 4] = Convert.ToInt32(result2.Text);
                            matrix[2, 4] = Convert.ToInt32(result3.Text);
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

                            matrix[0, 5] = Convert.ToInt32(result1.Text);
                            matrix[1, 5] = Convert.ToInt32(result2.Text);
                            matrix[2, 5] = Convert.ToInt32(result3.Text);
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

                            matrix[0, 1] = Convert.ToInt32(result1.Text);
                            matrix[1, 1] = Convert.ToInt32(result2.Text);
                            matrix[2, 1] = Convert.ToInt32(result3.Text);
                            matrix[3, 1] = Convert.ToInt32(result4.Text);
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

                            matrix[0, 2] = Convert.ToInt32(result1.Text);
                            matrix[1, 2] = Convert.ToInt32(result2.Text);
                            matrix[2, 2] = Convert.ToInt32(result3.Text);
                            matrix[3, 2] = Convert.ToInt32(result4.Text);
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

                            matrix[0, 3] = Convert.ToInt32(result1.Text);
                            matrix[1, 3] = Convert.ToInt32(result2.Text);
                            matrix[2, 3] = Convert.ToInt32(result3.Text);
                            matrix[3, 3] = Convert.ToInt32(result4.Text);
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

                            matrix[0, 4] = Convert.ToInt32(result1.Text);
                            matrix[1, 4] = Convert.ToInt32(result2.Text);
                            matrix[2, 4] = Convert.ToInt32(result3.Text);
                            matrix[3, 4] = Convert.ToInt32(result4.Text);
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

                            matrix[0, 5] = Convert.ToInt32(result1.Text);
                            matrix[1, 5] = Convert.ToInt32(result2.Text);
                            matrix[2, 5] = Convert.ToInt32(result3.Text);
                            matrix[3, 5] = Convert.ToInt32(result4.Text);
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

                            matrix[0, 1] = Convert.ToInt32(result1.Text);
                            matrix[1, 1] = Convert.ToInt32(result2.Text);
                            matrix[2, 1] = Convert.ToInt32(result3.Text);
                            matrix[3, 1] = Convert.ToInt32(result4.Text);
                            matrix[4, 1] = Convert.ToInt32(result5.Text);
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

                            matrix[0, 2] = Convert.ToInt32(result1.Text);
                            matrix[1, 2] = Convert.ToInt32(result2.Text);
                            matrix[2, 2] = Convert.ToInt32(result3.Text);
                            matrix[3, 2] = Convert.ToInt32(result4.Text);
                            matrix[4, 2] = Convert.ToInt32(result5.Text);
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

                            matrix[0, 3] = Convert.ToInt32(result1.Text);
                            matrix[1, 3] = Convert.ToInt32(result2.Text);
                            matrix[2, 3] = Convert.ToInt32(result3.Text);
                            matrix[3, 3] = Convert.ToInt32(result4.Text);
                            matrix[4, 3] = Convert.ToInt32(result5.Text);
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

                            matrix[0, 4] = Convert.ToInt32(result1.Text);
                            matrix[1, 4] = Convert.ToInt32(result2.Text);
                            matrix[2, 4] = Convert.ToInt32(result3.Text);
                            matrix[3, 4] = Convert.ToInt32(result4.Text);
                            matrix[4, 4] = Convert.ToInt32(result5.Text);
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

                            matrix[0, 5] = Convert.ToInt32(result1.Text);
                            matrix[1, 5] = Convert.ToInt32(result2.Text);
                            matrix[2, 5] = Convert.ToInt32(result3.Text);
                            matrix[3, 5] = Convert.ToInt32(result4.Text);
                            matrix[4, 5] = Convert.ToInt32(result5.Text);
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

        private void historyMatrix_TextChanged(object sender, EventArgs e){}

        private void scrollHistory_Scroll(object sender, ScrollEventArgs e){}
        
        private void applyButton_Click(object sender, EventArgs e)
        {
            // Dimensiones de la matriz //
            string dimensionsParser = dimensions.Text;
            int m = dimensionsParser[0] - 48;
            int n = dimensionsParser[2] - 47;
            int[,] matrix = toMatrix();


            // Hacemos un array de char, para almacenar la operación que se desea efectuar //
            //int number = 0;
            string operationParser = operationBox.Text;
            char[] opParse = operationParser.ToArray();

            int number = new int();
            int firstRow = new int();
            int secondRow = new int();

            if (opParse.Length == 3)
            {
                number = Convert.ToInt32(opParse[0]) - 48;
                firstRow = Convert.ToInt32(opParse[2]) - 49;
                matrix = productRow(matrix, number, firstRow);
                toGui(matrix,firstRow, n);
            }

            if (opParse.Length == 6)
            {
                number = Convert.ToInt32(opParse[0]) - 48;
                firstRow = Convert.ToInt32(opParse[2]) - 49;
                secondRow = Convert.ToInt32(opParse[5]) - 49;
                matrix = rowXrow(matrix, number, firstRow, secondRow);
                toGui(matrix, secondRow, n-1);
            }

            if (opParse.Length == 5)
            {
                if (opParse[2] == ',')
                {
                    firstRow = Convert.ToInt32(opParse[1]) - 49;
                    secondRow = Convert.ToInt32(opParse[4]) - 49;
                    matrix = changeRows(matrix, firstRow, secondRow);
                    toGui(matrix, firstRow, n);
                    toGui(matrix, secondRow, n);
                }
            }

            undo.Push(matrix);
            toHistory = toString(matrix);
            historyMatrix.Text = toHistory;
            operationBox.Text = "";
        }

        private String toString(int[,] matrix)
        {
            string operationParser = operationBox.Text;
            toHistory += "Op #" + Convert.ToString(iterator) + "\t" + operationParser + Environment.NewLine;
            toHistory = toHistory + Environment.NewLine;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                string matrixRow = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixRow += Convert.ToString(matrix[i, j]) + ",";
                }
                toHistory += matrixRow + Environment.NewLine;
            }
            iterator++;
            return toHistory;
        }

        private int[,] productRow(int[,] matrix, int number, int row)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[row, i] *= number; 
            }
            return matrix;
        }

        private int[,] rowXrow(int[,] matrix, int number, int firstRow, int secondRow)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[secondRow, i] += (matrix[firstRow,i]*number);
            }
            return matrix;
        }

        private void toGui(int[,] matrix, int row, int columns)
        {
            if (row == 0)
            {
                if (columns == 1)
                {
                    matrix11.Text = Convert.ToString(matrix[row, 0]);
                    
                    result1.Text = Convert.ToString(matrix[row, 1]);
                }
                if (columns == 2)
                {
                    matrix11.Text = Convert.ToString(matrix[row, 0]);
                    matrix12.Text = Convert.ToString(matrix[row, 1]);
                    
                    result1.Text = Convert.ToString(matrix[row, 2]);
                }
                if (columns == 3)
                {
                    matrix11.Text = Convert.ToString(matrix[row, 0]);
                    matrix12.Text = Convert.ToString(matrix[row, 1]);
                    matrix13.Text = Convert.ToString(matrix[row, 2]);
                    
                    result1.Text = Convert.ToString(matrix[row, 3]);
                }
                if (columns == 4)
                {
                    matrix11.Text = Convert.ToString(matrix[row, 0]);
                    matrix12.Text = Convert.ToString(matrix[row, 1]);
                    matrix13.Text = Convert.ToString(matrix[row, 2]);
                    matrix14.Text = Convert.ToString(matrix[row, 3]);
                    
                    result1.Text = Convert.ToString(matrix[row, 4]);
                }
                if (columns == 5)
                {
                    matrix11.Text = Convert.ToString(matrix[row, 0]);
                    matrix12.Text = Convert.ToString(matrix[row, 1]);
                    matrix13.Text = Convert.ToString(matrix[row, 2]);
                    matrix14.Text = Convert.ToString(matrix[row, 3]);
                    matrix15.Text = Convert.ToString(matrix[row, 4]);
                    result1.Text = Convert.ToString(matrix[row, 5]);
                }
                
            }
            if (row == 1)
            {
                if (columns == 1)
                {
                    matrix21.Text = Convert.ToString(matrix[row, 0]);

                    result2.Text = Convert.ToString(matrix[row, 1]);
                }
                if (columns == 2)
                {
                    matrix21.Text = Convert.ToString(matrix[row, 0]);
                    matrix22.Text = Convert.ToString(matrix[row, 1]);

                    result2.Text = Convert.ToString(matrix[row, 2]);
                }
                if (columns == 3)
                {
                    matrix21.Text = Convert.ToString(matrix[row, 0]);
                    matrix22.Text = Convert.ToString(matrix[row, 1]);
                    matrix23.Text = Convert.ToString(matrix[row, 2]);

                    result2.Text = Convert.ToString(matrix[row, 3]);
                }
                if (columns == 4)
                {
                    matrix21.Text = Convert.ToString(matrix[row, 0]);
                    matrix22.Text = Convert.ToString(matrix[row, 1]);
                    matrix23.Text = Convert.ToString(matrix[row, 2]);
                    matrix24.Text = Convert.ToString(matrix[row, 3]);

                    result2.Text = Convert.ToString(matrix[row, 4]);
                }
                if (columns == 5)
                {
                    matrix21.Text = Convert.ToString(matrix[row, 0]);
                    matrix22.Text = Convert.ToString(matrix[row, 1]);
                    matrix23.Text = Convert.ToString(matrix[row, 2]);
                    matrix24.Text = Convert.ToString(matrix[row, 3]);
                    matrix25.Text = Convert.ToString(matrix[row, 4]);
                    result2.Text = Convert.ToString(matrix[row, 5]);
                }
                
            }
            if (row == 2)
            {
                if (columns == 1)
                {
                    matrix31.Text = Convert.ToString(matrix[row, 0]);

                    result3.Text = Convert.ToString(matrix[row, 1]);
                }
                if (columns == 2)
                {
                    matrix31.Text = Convert.ToString(matrix[row, 0]);
                    matrix32.Text = Convert.ToString(matrix[row, 1]);

                    result3.Text = Convert.ToString(matrix[row, 2]);
                }
                if (columns == 3)
                {
                    matrix31.Text = Convert.ToString(matrix[row, 0]);
                    matrix32.Text = Convert.ToString(matrix[row, 1]);
                    matrix33.Text = Convert.ToString(matrix[row, 2]);

                    result3.Text = Convert.ToString(matrix[row, 3]);
                }
                if (columns == 4)
                {
                    matrix31.Text = Convert.ToString(matrix[row, 0]);
                    matrix32.Text = Convert.ToString(matrix[row, 1]);
                    matrix33.Text = Convert.ToString(matrix[row, 2]);
                    matrix34.Text = Convert.ToString(matrix[row, 3]);

                    result3.Text = Convert.ToString(matrix[row, 4]);
                }
                if (columns == 5)
                {
                    matrix31.Text = Convert.ToString(matrix[row, 0]);
                    matrix32.Text = Convert.ToString(matrix[row, 1]);
                    matrix33.Text = Convert.ToString(matrix[row, 2]);
                    matrix34.Text = Convert.ToString(matrix[row, 3]);
                    matrix35.Text = Convert.ToString(matrix[row, 4]);
                    result3.Text = Convert.ToString(matrix[row, 5]);
                }
                
            }
            if (row == 3 && columns == 5)
            {
                if (columns == 1)
                {
                    matrix41.Text = Convert.ToString(matrix[row, 0]);

                    result4.Text = Convert.ToString(matrix[row, 1]);
                }
                if (columns == 2)
                {
                    matrix41.Text = Convert.ToString(matrix[row, 0]);
                    matrix42.Text = Convert.ToString(matrix[row, 1]);

                    result4.Text = Convert.ToString(matrix[row, 2]);
                }
                if (columns == 3)
                {
                    matrix41.Text = Convert.ToString(matrix[row, 0]);
                    matrix42.Text = Convert.ToString(matrix[row, 1]);
                    matrix43.Text = Convert.ToString(matrix[row, 2]);

                    result4.Text = Convert.ToString(matrix[row, 3]);
                }
                if (columns == 4)
                {
                    matrix41.Text = Convert.ToString(matrix[row, 0]);
                    matrix42.Text = Convert.ToString(matrix[row, 1]);
                    matrix43.Text = Convert.ToString(matrix[row, 2]);
                    matrix44.Text = Convert.ToString(matrix[row, 3]);

                    result4.Text = Convert.ToString(matrix[row, 4]);
                }
                if (columns == 5)
                {
                    matrix41.Text = Convert.ToString(matrix[row, 0]);
                    matrix42.Text = Convert.ToString(matrix[row, 1]);
                    matrix43.Text = Convert.ToString(matrix[row, 2]);
                    matrix44.Text = Convert.ToString(matrix[row, 3]);
                    matrix45.Text = Convert.ToString(matrix[row, 4]);
                    result4.Text = Convert.ToString(matrix[row, 5]);
                }

            }
            if (row == 4)
            {
                if (columns == 1)
                {
                    matrix51.Text = Convert.ToString(matrix[row, 0]);

                    result5.Text = Convert.ToString(matrix[row, 1]);
                }
                if (columns == 2)
                {
                    matrix51.Text = Convert.ToString(matrix[row, 0]);
                    matrix52.Text = Convert.ToString(matrix[row, 1]);

                    result5.Text = Convert.ToString(matrix[row, 2]);
                }
                if (columns == 3)
                {
                    matrix51.Text = Convert.ToString(matrix[row, 0]);
                    matrix52.Text = Convert.ToString(matrix[row, 1]);
                    matrix53.Text = Convert.ToString(matrix[row, 2]);

                    result5.Text = Convert.ToString(matrix[row, 3]);
                }
                if (columns == 4)
                {
                    matrix51.Text = Convert.ToString(matrix[row, 0]);
                    matrix52.Text = Convert.ToString(matrix[row, 1]);
                    matrix53.Text = Convert.ToString(matrix[row, 2]);
                    matrix54.Text = Convert.ToString(matrix[row, 3]);
                    
                    result5.Text = Convert.ToString(matrix[row, 4]);
                }
                if (columns == 5)
                {
                    matrix51.Text = Convert.ToString(matrix[row, 0]);
                    matrix52.Text = Convert.ToString(matrix[row, 1]);
                    matrix53.Text = Convert.ToString(matrix[row, 2]);
                    matrix54.Text = Convert.ToString(matrix[row, 3]);
                    matrix55.Text = Convert.ToString(matrix[row, 4]);
                    result5.Text = Convert.ToString(matrix[row, 5]);
                }
                
            }
        }

        private int[,] changeRows(int[,] matrix, int firstRow, int secondRow)
        {
            int[,] copy = matrix;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[firstRow, i] = copy[secondRow, i];
                matrix[secondRow, i] = copy[firstRow, i];
            }
            return matrix;
        }
    }
}
