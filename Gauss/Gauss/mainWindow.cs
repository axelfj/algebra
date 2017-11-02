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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clean();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            Text = "Asistente para eliminación Gaussiana";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            clean();
        }

        public void clean()
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
        }
    }
}
