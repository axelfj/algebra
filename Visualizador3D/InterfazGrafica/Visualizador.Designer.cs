namespace InterfazGrafica
{
    partial class Visualizador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trbrEjeZ = new System.Windows.Forms.TrackBar();
            this.lblRotarZ = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.txtPX = new System.Windows.Forms.TextBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.txtPY = new System.Windows.Forms.TextBox();
            this.lblP2 = new System.Windows.Forms.Label();
            this.txtPZ = new System.Windows.Forms.TextBox();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblBaseB = new System.Windows.Forms.Label();
            this.lblVisualizador = new System.Windows.Forms.Label();
            this.lblBaseBAbre = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblU3 = new System.Windows.Forms.Label();
            this.txtUZ = new System.Windows.Forms.TextBox();
            this.lblU2 = new System.Windows.Forms.Label();
            this.txtUY = new System.Windows.Forms.TextBox();
            this.lblU1 = new System.Windows.Forms.Label();
            this.txtUX = new System.Windows.Forms.TextBox();
            this.lblV3 = new System.Windows.Forms.Label();
            this.txtVZ = new System.Windows.Forms.TextBox();
            this.lblV2 = new System.Windows.Forms.Label();
            this.txtVY = new System.Windows.Forms.TextBox();
            this.lblV1 = new System.Windows.Forms.Label();
            this.txtVX = new System.Windows.Forms.TextBox();
            this.lblW3 = new System.Windows.Forms.Label();
            this.txtWZ = new System.Windows.Forms.TextBox();
            this.lblW2 = new System.Windows.Forms.Label();
            this.txtWY = new System.Windows.Forms.TextBox();
            this.lblW1 = new System.Windows.Forms.Label();
            this.txtWX = new System.Windows.Forms.TextBox();
            this.lblBCierra = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.btnDibujar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbrEjeZ)).BeginInit();
            this.SuspendLayout();
            // 
            // trbrEjeZ
            // 
            this.trbrEjeZ.Location = new System.Drawing.Point(12, 669);
            this.trbrEjeZ.Maximum = 628;
            this.trbrEjeZ.Name = "trbrEjeZ";
            this.trbrEjeZ.Size = new System.Drawing.Size(520, 45);
            this.trbrEjeZ.TabIndex = 1000;
            this.trbrEjeZ.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbrEjeZ.Scroll += new System.EventHandler(this.TrbrEjeZ_Scroll);
            // 
            // lblRotarZ
            // 
            this.lblRotarZ.AutoSize = true;
            this.lblRotarZ.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotarZ.Location = new System.Drawing.Point(198, 717);
            this.lblRotarZ.Name = "lblRotarZ";
            this.lblRotarZ.Size = new System.Drawing.Size(146, 23);
            this.lblRotarZ.TabIndex = 1;
            this.lblRotarZ.Text = "Rotar en el eje Z";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(119, 50);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(49, 23);
            this.lblP.TabIndex = 2;
            this.lblP.Text = "P = (";
            // 
            // txtPX
            // 
            this.txtPX.Location = new System.Drawing.Point(174, 54);
            this.txtPX.Name = "txtPX";
            this.txtPX.Size = new System.Drawing.Size(30, 20);
            this.txtPX.TabIndex = 3;
            this.txtPX.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(210, 54);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(17, 23);
            this.lblP1.TabIndex = 4;
            this.lblP1.Text = ",";
            // 
            // txtPY
            // 
            this.txtPY.Location = new System.Drawing.Point(233, 54);
            this.txtPY.Name = "txtPY";
            this.txtPY.Size = new System.Drawing.Size(30, 20);
            this.txtPY.TabIndex = 5;
            this.txtPY.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(269, 54);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(17, 23);
            this.lblP2.TabIndex = 6;
            this.lblP2.Text = ",";
            // 
            // txtPZ
            // 
            this.txtPZ.Location = new System.Drawing.Point(292, 54);
            this.txtPZ.Name = "txtPZ";
            this.txtPZ.Size = new System.Drawing.Size(30, 20);
            this.txtPZ.TabIndex = 7;
            this.txtPZ.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.Location = new System.Drawing.Point(328, 50);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(16, 23);
            this.lblP3.TabIndex = 8;
            this.lblP3.Text = ")";
            // 
            // lblBaseB
            // 
            this.lblBaseB.AutoSize = true;
            this.lblBaseB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseB.Location = new System.Drawing.Point(8, 116);
            this.lblBaseB.Name = "lblBaseB";
            this.lblBaseB.Size = new System.Drawing.Size(80, 23);
            this.lblBaseB.TabIndex = 9;
            this.lblBaseB.Text = "Base B =";
            // 
            // lblVisualizador
            // 
            this.lblVisualizador.AutoSize = true;
            this.lblVisualizador.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizador.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblVisualizador.Location = new System.Drawing.Point(181, 9);
            this.lblVisualizador.Name = "lblVisualizador";
            this.lblVisualizador.Size = new System.Drawing.Size(196, 35);
            this.lblVisualizador.TabIndex = 10;
            this.lblVisualizador.Text = "Visualizador 3D";
            // 
            // lblBaseBAbre
            // 
            this.lblBaseBAbre.AutoSize = true;
            this.lblBaseBAbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseBAbre.Location = new System.Drawing.Point(74, 66);
            this.lblBaseBAbre.Name = "lblBaseBAbre";
            this.lblBaseBAbre.Size = new System.Drawing.Size(77, 108);
            this.lblBaseBAbre.TabIndex = 11;
            this.lblBaseBAbre.Text = "{";
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.Location = new System.Drawing.Point(120, 92);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(48, 23);
            this.lblU.TabIndex = 12;
            this.lblU.Text = "u = (";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(120, 115);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(48, 23);
            this.lblV.TabIndex = 13;
            this.lblV.Text = "v = (";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(119, 138);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(51, 23);
            this.lblW.TabIndex = 14;
            this.lblW.Text = "w = (";
            // 
            // lblU3
            // 
            this.lblU3.AutoSize = true;
            this.lblU3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU3.Location = new System.Drawing.Point(328, 92);
            this.lblU3.Name = "lblU3";
            this.lblU3.Size = new System.Drawing.Size(16, 23);
            this.lblU3.TabIndex = 20;
            this.lblU3.Text = ")";
            // 
            // txtUZ
            // 
            this.txtUZ.Location = new System.Drawing.Point(292, 96);
            this.txtUZ.Name = "txtUZ";
            this.txtUZ.Size = new System.Drawing.Size(30, 20);
            this.txtUZ.TabIndex = 19;
            this.txtUZ.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblU2
            // 
            this.lblU2.AutoSize = true;
            this.lblU2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU2.Location = new System.Drawing.Point(269, 96);
            this.lblU2.Name = "lblU2";
            this.lblU2.Size = new System.Drawing.Size(17, 23);
            this.lblU2.TabIndex = 18;
            this.lblU2.Text = ",";
            // 
            // txtUY
            // 
            this.txtUY.Location = new System.Drawing.Point(233, 96);
            this.txtUY.Name = "txtUY";
            this.txtUY.Size = new System.Drawing.Size(30, 20);
            this.txtUY.TabIndex = 17;
            this.txtUY.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblU1
            // 
            this.lblU1.AutoSize = true;
            this.lblU1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU1.Location = new System.Drawing.Point(210, 96);
            this.lblU1.Name = "lblU1";
            this.lblU1.Size = new System.Drawing.Size(17, 23);
            this.lblU1.TabIndex = 16;
            this.lblU1.Text = ",";
            // 
            // txtUX
            // 
            this.txtUX.Location = new System.Drawing.Point(174, 96);
            this.txtUX.Name = "txtUX";
            this.txtUX.Size = new System.Drawing.Size(30, 20);
            this.txtUX.TabIndex = 15;
            this.txtUX.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblV3
            // 
            this.lblV3.AutoSize = true;
            this.lblV3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV3.Location = new System.Drawing.Point(328, 115);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(16, 23);
            this.lblV3.TabIndex = 26;
            this.lblV3.Text = ")";
            // 
            // txtVZ
            // 
            this.txtVZ.Location = new System.Drawing.Point(292, 119);
            this.txtVZ.Name = "txtVZ";
            this.txtVZ.Size = new System.Drawing.Size(30, 20);
            this.txtVZ.TabIndex = 25;
            this.txtVZ.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2.Location = new System.Drawing.Point(269, 119);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(17, 23);
            this.lblV2.TabIndex = 24;
            this.lblV2.Text = ",";
            // 
            // txtVY
            // 
            this.txtVY.Location = new System.Drawing.Point(233, 119);
            this.txtVY.Name = "txtVY";
            this.txtVY.Size = new System.Drawing.Size(30, 20);
            this.txtVY.TabIndex = 23;
            this.txtVY.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1.Location = new System.Drawing.Point(210, 119);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(17, 23);
            this.lblV1.TabIndex = 22;
            this.lblV1.Text = ",";
            // 
            // txtVX
            // 
            this.txtVX.Location = new System.Drawing.Point(174, 119);
            this.txtVX.Name = "txtVX";
            this.txtVX.Size = new System.Drawing.Size(30, 20);
            this.txtVX.TabIndex = 21;
            this.txtVX.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblW3
            // 
            this.lblW3.AutoSize = true;
            this.lblW3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW3.Location = new System.Drawing.Point(328, 138);
            this.lblW3.Name = "lblW3";
            this.lblW3.Size = new System.Drawing.Size(16, 23);
            this.lblW3.TabIndex = 32;
            this.lblW3.Text = ")";
            // 
            // txtWZ
            // 
            this.txtWZ.Location = new System.Drawing.Point(292, 142);
            this.txtWZ.Name = "txtWZ";
            this.txtWZ.Size = new System.Drawing.Size(30, 20);
            this.txtWZ.TabIndex = 31;
            this.txtWZ.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblW2
            // 
            this.lblW2.AutoSize = true;
            this.lblW2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW2.Location = new System.Drawing.Point(269, 142);
            this.lblW2.Name = "lblW2";
            this.lblW2.Size = new System.Drawing.Size(17, 23);
            this.lblW2.TabIndex = 30;
            this.lblW2.Text = ",";
            // 
            // txtWY
            // 
            this.txtWY.Location = new System.Drawing.Point(233, 142);
            this.txtWY.Name = "txtWY";
            this.txtWY.Size = new System.Drawing.Size(30, 20);
            this.txtWY.TabIndex = 29;
            this.txtWY.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblW1
            // 
            this.lblW1.AutoSize = true;
            this.lblW1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW1.Location = new System.Drawing.Point(210, 142);
            this.lblW1.Name = "lblW1";
            this.lblW1.Size = new System.Drawing.Size(17, 23);
            this.lblW1.TabIndex = 28;
            this.lblW1.Text = ",";
            // 
            // txtWX
            // 
            this.txtWX.Location = new System.Drawing.Point(174, 142);
            this.txtWX.Name = "txtWX";
            this.txtWX.Size = new System.Drawing.Size(30, 20);
            this.txtWX.TabIndex = 27;
            this.txtWX.TextChanged += new System.EventHandler(this.Visualizador_TextChanged);
            // 
            // lblBCierra
            // 
            this.lblBCierra.AutoSize = true;
            this.lblBCierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCierra.Location = new System.Drawing.Point(328, 66);
            this.lblBCierra.Name = "lblBCierra";
            this.lblBCierra.Size = new System.Drawing.Size(77, 108);
            this.lblBCierra.TabIndex = 33;
            this.lblBCierra.Text = "}";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 177);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(520, 486);
            this.canvas.TabIndex = 34;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(427, 105);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(78, 45);
            this.btnDibujar.TabIndex = 35;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.BtnDibujar_Click);
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 749);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.lblW3);
            this.Controls.Add(this.txtWZ);
            this.Controls.Add(this.lblW2);
            this.Controls.Add(this.txtWY);
            this.Controls.Add(this.lblW1);
            this.Controls.Add(this.txtWX);
            this.Controls.Add(this.lblV3);
            this.Controls.Add(this.txtVZ);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.txtVY);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.txtVX);
            this.Controls.Add(this.lblU3);
            this.Controls.Add(this.txtUZ);
            this.Controls.Add(this.lblU2);
            this.Controls.Add(this.txtUY);
            this.Controls.Add(this.lblU1);
            this.Controls.Add(this.txtUX);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblVisualizador);
            this.Controls.Add(this.lblBaseB);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.txtPZ);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.txtPY);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.txtPX);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblRotarZ);
            this.Controls.Add(this.trbrEjeZ);
            this.Controls.Add(this.lblBaseBAbre);
            this.Controls.Add(this.lblBCierra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Visualizador";
            this.Text = "Visualizador";
            ((System.ComponentModel.ISupportInitialize)(this.trbrEjeZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbrEjeZ;
        private System.Windows.Forms.Label lblRotarZ;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtPX;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.TextBox txtPY;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.TextBox txtPZ;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblBaseB;
        private System.Windows.Forms.Label lblVisualizador;
        private System.Windows.Forms.Label lblBaseBAbre;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblU3;
        private System.Windows.Forms.TextBox txtUZ;
        private System.Windows.Forms.Label lblU2;
        private System.Windows.Forms.TextBox txtUY;
        private System.Windows.Forms.Label lblU1;
        private System.Windows.Forms.TextBox txtUX;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.TextBox txtVZ;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.TextBox txtVY;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.TextBox txtVX;
        private System.Windows.Forms.Label lblW3;
        private System.Windows.Forms.TextBox txtWZ;
        private System.Windows.Forms.Label lblW2;
        private System.Windows.Forms.TextBox txtWY;
        private System.Windows.Forms.Label lblW1;
        private System.Windows.Forms.TextBox txtWX;
        private System.Windows.Forms.Label lblBCierra;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button btnDibujar;
    }
}

