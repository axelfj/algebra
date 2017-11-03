using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class Visualizador : Form
    {
        private string TituloCoordenadasPB;
        private Point3D PuntosP;
        private Base3D BaseB;
        private Double Angulo;
        private Point CentroCanvas;
        private bool Dibujando;
        private int radioCirculo;
        private double factorZoom;
        private double distanciaXYZ;

        public Visualizador()
        {
            InitializeComponent();
            PuntosP = new Point3D();
            BaseB = new Base3D();
            Angulo = 0;
            TituloCoordenadasPB = "Coordenadas de P en la Base B: {{{0}, {1}, {2}}}";
            CentroCanvas.X = canvas.Width / 2;
            CentroCanvas.Y = canvas.Height / 2;
            Dibujando = false;
            radioCirculo = 5;
            factorZoom = 30;
            distanciaXYZ = 5;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = canvas.CreateGraphics();

            Isografo isografo = new Isografo();

            Point3D pEnBNoZoom = isografo.PuntosPEnBaseB(PuntosP, BaseB);

            string CoordenadasPB = String.Format(TituloCoordenadasPB, pEnBNoZoom.X, pEnBNoZoom.Y, pEnBNoZoom.Z);

            Point ejeX = isografo.Transformar3Da2D(new Point3D(distanciaXYZ * factorZoom, 0, 0), Angulo);
            Point ejeY = isografo.Transformar3Da2D(new Point3D(0, distanciaXYZ * factorZoom, 0), Angulo);
            Point ejeZ = isografo.Transformar3Da2D(new Point3D(0, 0, distanciaXYZ * factorZoom), Angulo);

            graphics.DrawString(CoordenadasPB, lblBaseB.Font, Brushes.Black, 10, 10);

            ejeX = Centralizar(ejeX);
            ejeY = Centralizar(ejeY);
            ejeZ = Centralizar(ejeZ);

            graphics.DrawLine(Pens.Gray, CentroCanvas, ejeX);
            graphics.DrawLine(Pens.Gray, CentroCanvas, ejeY);
            graphics.DrawLine(Pens.Gray, CentroCanvas, ejeZ);

            Point baseX = Centralizar(isografo.Transformar3Da2D(BaseB.U, Angulo));
            Point baseY = Centralizar(isografo.Transformar3Da2D(BaseB.V, Angulo));
            Point baseZ = Centralizar(isografo.Transformar3Da2D(BaseB.W, Angulo));

            Pen lapizBase = new Pen(Brushes.Blue, 2);

            graphics.DrawLine(lapizBase, CentroCanvas, baseX);
            graphics.DrawLine(lapizBase, CentroCanvas, baseY);
            graphics.DrawLine(lapizBase, CentroCanvas, baseZ);

            lapizBase.Dispose();

            Point3D puntoX3D = isografo.PuntosPEnBaseB(new Point3D((BaseB.U.X != 0) ? PuntosP.X : 1, (BaseB.U.Y != 0) ? PuntosP.Y : 1, (BaseB.U.Z != 0) ? PuntosP.Z : 1), BaseB);
            Point3D puntoY3D = isografo.PuntosPEnBaseB(new Point3D((BaseB.V.X != 0) ? PuntosP.X : 1, (BaseB.V.Y != 0) ? PuntosP.Y : 1, (BaseB.V.Z != 0) ? PuntosP.Z : 1), BaseB);
            Point3D puntoZ3D = isografo.PuntosPEnBaseB(new Point3D((BaseB.W.X != 0) ? PuntosP.X : 1, (BaseB.W.Y != 0) ? PuntosP.Y : 1, (BaseB.W.Z != 0) ? PuntosP.Z : 1), BaseB);

            Point puntoX = isografo.Transformar3Da2D(puntoX3D, Angulo);
            Point puntoY = isografo.Transformar3Da2D(puntoY3D, Angulo);
            Point puntoZ = isografo.Transformar3Da2D(puntoZ3D, Angulo);

            puntoX.X = (puntoX.X + baseX.X);
            puntoX.Y = (puntoX.Y + baseX.Y);
            puntoY.X = (puntoY.X + baseY.X);
            puntoY.Y = (puntoY.Y + baseY.Y);
            puntoZ.X = (puntoZ.X + baseZ.X);
            puntoZ.Y = (puntoZ.Y + baseZ.Y);

            graphics.DrawLine(Pens.Cyan, CentroCanvas, puntoX);
            graphics.DrawLine(Pens.Cyan, CentroCanvas, puntoY);
            graphics.DrawLine(Pens.Cyan, CentroCanvas, puntoZ);

            Pen lineaPunteada = new Pen(Brushes.Green)
            {
                DashCap = System.Drawing.Drawing2D.DashCap.Round,

                DashPattern = new float[] { 4.0F, 2.0F }
            };

            Point puntoPEnB = Centralizar(isografo.Transformar3Da2D(PuntosP, Angulo));

            Point interseccionXY = new Point((puntoX.X + puntoY.X) - CentroCanvas.X, (puntoY.Y + puntoX.Y) - CentroCanvas.Y);

            if (Dibujando)
            {
                graphics.FillEllipse(Brushes.Red, new Rectangle(puntoPEnB.X - radioCirculo, puntoPEnB.Y - radioCirculo, radioCirculo * 2, radioCirculo * 2));
                graphics.DrawLine(lineaPunteada, puntoY, interseccionXY);
                graphics.DrawLine(lineaPunteada, puntoX, interseccionXY);
                graphics.DrawLine(lineaPunteada, interseccionXY, puntoPEnB);
            }

            lineaPunteada.Dispose();
            graphics.Dispose();
        }

        public Point Centralizar(Point punto)
        {
            punto.X = punto.X + CentroCanvas.X;
            punto.Y = punto.Y + CentroCanvas.Y;

            return punto;
        }

        private void BtnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                PuntosP.X = Convert.ToDouble(txtPX.Text) * factorZoom;
                PuntosP.Y = Convert.ToDouble(txtPY.Text) * factorZoom;
                PuntosP.Z = Convert.ToDouble(txtPZ.Text) * factorZoom;

                Point3D u = new Point3D(Convert.ToDouble(txtUX.Text) * factorZoom, Convert.ToDouble(txtUY.Text) * factorZoom, Convert.ToDouble(txtUZ.Text) * factorZoom);
                Point3D v = new Point3D(Convert.ToDouble(txtVX.Text) * factorZoom, Convert.ToDouble(txtVY.Text) * factorZoom, Convert.ToDouble(txtVZ.Text) * factorZoom);
                Point3D w = new Point3D(Convert.ToDouble(txtWX.Text) * factorZoom, Convert.ToDouble(txtWY.Text) * factorZoom, Convert.ToDouble(txtWZ.Text) * factorZoom);

                BaseB.U = u;
                BaseB.V = v;
                BaseB.W = w;

                if (!BaseB.EsLinearIndependiente())
                {
                    MessageBox.Show(this, "La base no es linearmente independiente", "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Dibujando = true;
            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {
                MessageBox.Show(this, "Los campos son invalidos", "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            canvas.Invalidate();
        }

        private void Visualizador_TextChanged(object sender, EventArgs e)
        {
            TextBox txtAtributo = ((TextBox)sender);

            try
            {
                if (txtAtributo.TextLength > 0 && txtAtributo.Text != "-")
                    Convert.ToInt32(txtAtributo.Text);
            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (FormatException ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {
                MessageBox.Show(this, "Ingrese solo numeros", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAtributo.Text = "";
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(this, ex.Message, "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAtributo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error desconocido.\nDetalles:\n" + ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TrbrEjeZ_Scroll(object sender, EventArgs e)
        {
            Angulo = ((TrackBar)sender).Value * 0.01;

            canvas.Invalidate();
        }

        private void lblW3_Click(object sender, EventArgs e)
        {

        }

        private void lblW2_Click(object sender, EventArgs e)
        {

        }

        private void lblW1_Click(object sender, EventArgs e)
        {

        }

        private void lblV3_Click(object sender, EventArgs e)
        {

        }

        private void lblV2_Click(object sender, EventArgs e)
        {

        }

        private void lblV1_Click(object sender, EventArgs e)
        {

        }

        private void lblU3_Click(object sender, EventArgs e)
        {

        }

        private void lblU2_Click(object sender, EventArgs e)
        {

        }

        private void lblU1_Click(object sender, EventArgs e)
        {

        }

        private void lblW_Click(object sender, EventArgs e)
        {

        }

        private void lblV_Click(object sender, EventArgs e)
        {

        }

        private void lblU_Click(object sender, EventArgs e)
        {

        }

        private void lblVisualizador_Click(object sender, EventArgs e)
        {

        }

        private void lblBaseB_Click(object sender, EventArgs e)
        {

        }

        private void lblP3_Click(object sender, EventArgs e)
        {

        }

        private void lblP2_Click(object sender, EventArgs e)
        {

        }

        private void lblP1_Click(object sender, EventArgs e)
        {

        }

        private void lblP_Click(object sender, EventArgs e)
        {

        }

        private void lblBaseBAbre_Click(object sender, EventArgs e)
        {

        }

        private void lblBCierra_Click(object sender, EventArgs e)
        {

        }
    }
}
