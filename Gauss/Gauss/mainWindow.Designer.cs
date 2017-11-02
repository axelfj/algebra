namespace Gauss
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dimensions = new System.Windows.Forms.ComboBox();
            this.scrollHistory = new System.Windows.Forms.VScrollBar();
            this.historyMatrix = new System.Windows.Forms.TextBox();
            this.operationBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.matrix11 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.matrix12 = new System.Windows.Forms.TextBox();
            this.matrix13 = new System.Windows.Forms.TextBox();
            this.matrix14 = new System.Windows.Forms.TextBox();
            this.matrix15 = new System.Windows.Forms.TextBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.matrix25 = new System.Windows.Forms.TextBox();
            this.matrix24 = new System.Windows.Forms.TextBox();
            this.matrix23 = new System.Windows.Forms.TextBox();
            this.matrix22 = new System.Windows.Forms.TextBox();
            this.matrix21 = new System.Windows.Forms.TextBox();
            this.result3 = new System.Windows.Forms.TextBox();
            this.matrix35 = new System.Windows.Forms.TextBox();
            this.matrix34 = new System.Windows.Forms.TextBox();
            this.matrix33 = new System.Windows.Forms.TextBox();
            this.matrix32 = new System.Windows.Forms.TextBox();
            this.matrix31 = new System.Windows.Forms.TextBox();
            this.result5 = new System.Windows.Forms.TextBox();
            this.matrix55 = new System.Windows.Forms.TextBox();
            this.matrix54 = new System.Windows.Forms.TextBox();
            this.matrix53 = new System.Windows.Forms.TextBox();
            this.matrix52 = new System.Windows.Forms.TextBox();
            this.matrix51 = new System.Windows.Forms.TextBox();
            this.result4 = new System.Windows.Forms.TextBox();
            this.matrix45 = new System.Windows.Forms.TextBox();
            this.matrix44 = new System.Windows.Forms.TextBox();
            this.matrix43 = new System.Windows.Forms.TextBox();
            this.matrix42 = new System.Windows.Forms.TextBox();
            this.matrix41 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newMatrix = new System.Windows.Forms.Button();
            this.cleanMatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dimensions
            // 
            this.dimensions.FormattingEnabled = true;
            this.dimensions.Items.AddRange(new object[] {
            "1x1",
            "1x2",
            "1x3",
            "1x4",
            "1x5",
            "2x1",
            "2x2",
            "2x3",
            "2x4",
            "2x5",
            "3x1",
            "3x2",
            "3x3",
            "3x4",
            "3x5",
            "4x1",
            "4x2",
            "4x3",
            "4x4",
            "4x5",
            "5x1",
            "5x2",
            "5x3",
            "5x4",
            "5x5"});
            this.dimensions.Location = new System.Drawing.Point(108, 92);
            this.dimensions.Name = "dimensions";
            this.dimensions.Size = new System.Drawing.Size(121, 21);
            this.dimensions.TabIndex = 0;
            this.dimensions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // scrollHistory
            // 
            this.scrollHistory.Location = new System.Drawing.Point(929, 114);
            this.scrollHistory.Name = "scrollHistory";
            this.scrollHistory.Size = new System.Drawing.Size(17, 236);
            this.scrollHistory.TabIndex = 2;
            // 
            // historyMatrix
            // 
            this.historyMatrix.Location = new System.Drawing.Point(596, 114);
            this.historyMatrix.Multiline = true;
            this.historyMatrix.Name = "historyMatrix";
            this.historyMatrix.Size = new System.Drawing.Size(330, 236);
            this.historyMatrix.TabIndex = 3;
            // 
            // operationBox
            // 
            this.operationBox.Location = new System.Drawing.Point(411, 203);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(167, 20);
            this.operationBox.TabIndex = 4;
            this.operationBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(450, 229);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(89, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Aplicar";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(450, 258);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(89, 23);
            this.undoButton.TabIndex = 6;
            this.undoButton.Text = "Deshacer";
            this.undoButton.UseVisualStyleBackColor = true;
            // 
            // matrix11
            // 
            this.matrix11.Location = new System.Drawing.Point(22, 169);
            this.matrix11.Name = "matrix11";
            this.matrix11.Size = new System.Drawing.Size(37, 20);
            this.matrix11.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(305, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(377, 23);
            this.lblTitulo.TabIndex = 45;
            this.lblTitulo.Text = "Asistente para practicar eliminación Gaussiana ";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // matrix12
            // 
            this.matrix12.Location = new System.Drawing.Point(65, 169);
            this.matrix12.Name = "matrix12";
            this.matrix12.Size = new System.Drawing.Size(37, 20);
            this.matrix12.TabIndex = 46;
            // 
            // matrix13
            // 
            this.matrix13.Location = new System.Drawing.Point(108, 169);
            this.matrix13.Name = "matrix13";
            this.matrix13.Size = new System.Drawing.Size(37, 20);
            this.matrix13.TabIndex = 47;
            // 
            // matrix14
            // 
            this.matrix14.Location = new System.Drawing.Point(151, 169);
            this.matrix14.Name = "matrix14";
            this.matrix14.Size = new System.Drawing.Size(37, 20);
            this.matrix14.TabIndex = 48;
            // 
            // matrix15
            // 
            this.matrix15.Location = new System.Drawing.Point(194, 169);
            this.matrix15.Name = "matrix15";
            this.matrix15.Size = new System.Drawing.Size(37, 20);
            this.matrix15.TabIndex = 49;
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(268, 169);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(37, 20);
            this.result1.TabIndex = 50;
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(268, 195);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(37, 20);
            this.result2.TabIndex = 56;
            // 
            // matrix25
            // 
            this.matrix25.Location = new System.Drawing.Point(194, 195);
            this.matrix25.Name = "matrix25";
            this.matrix25.Size = new System.Drawing.Size(37, 20);
            this.matrix25.TabIndex = 55;
            // 
            // matrix24
            // 
            this.matrix24.Location = new System.Drawing.Point(151, 195);
            this.matrix24.Name = "matrix24";
            this.matrix24.Size = new System.Drawing.Size(37, 20);
            this.matrix24.TabIndex = 54;
            // 
            // matrix23
            // 
            this.matrix23.Location = new System.Drawing.Point(108, 195);
            this.matrix23.Name = "matrix23";
            this.matrix23.Size = new System.Drawing.Size(37, 20);
            this.matrix23.TabIndex = 53;
            // 
            // matrix22
            // 
            this.matrix22.Location = new System.Drawing.Point(65, 195);
            this.matrix22.Name = "matrix22";
            this.matrix22.Size = new System.Drawing.Size(37, 20);
            this.matrix22.TabIndex = 52;
            // 
            // matrix21
            // 
            this.matrix21.Location = new System.Drawing.Point(22, 195);
            this.matrix21.Name = "matrix21";
            this.matrix21.Size = new System.Drawing.Size(37, 20);
            this.matrix21.TabIndex = 51;
            // 
            // result3
            // 
            this.result3.Location = new System.Drawing.Point(268, 221);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(37, 20);
            this.result3.TabIndex = 62;
            // 
            // matrix35
            // 
            this.matrix35.Location = new System.Drawing.Point(194, 221);
            this.matrix35.Name = "matrix35";
            this.matrix35.Size = new System.Drawing.Size(37, 20);
            this.matrix35.TabIndex = 61;
            // 
            // matrix34
            // 
            this.matrix34.Location = new System.Drawing.Point(151, 221);
            this.matrix34.Name = "matrix34";
            this.matrix34.Size = new System.Drawing.Size(37, 20);
            this.matrix34.TabIndex = 60;
            // 
            // matrix33
            // 
            this.matrix33.Location = new System.Drawing.Point(108, 221);
            this.matrix33.Name = "matrix33";
            this.matrix33.Size = new System.Drawing.Size(37, 20);
            this.matrix33.TabIndex = 59;
            // 
            // matrix32
            // 
            this.matrix32.Location = new System.Drawing.Point(65, 221);
            this.matrix32.Name = "matrix32";
            this.matrix32.Size = new System.Drawing.Size(37, 20);
            this.matrix32.TabIndex = 58;
            // 
            // matrix31
            // 
            this.matrix31.Location = new System.Drawing.Point(22, 221);
            this.matrix31.Name = "matrix31";
            this.matrix31.Size = new System.Drawing.Size(37, 20);
            this.matrix31.TabIndex = 57;
            // 
            // result5
            // 
            this.result5.Location = new System.Drawing.Point(268, 273);
            this.result5.Name = "result5";
            this.result5.Size = new System.Drawing.Size(37, 20);
            this.result5.TabIndex = 74;
            // 
            // matrix55
            // 
            this.matrix55.Location = new System.Drawing.Point(194, 273);
            this.matrix55.Name = "matrix55";
            this.matrix55.Size = new System.Drawing.Size(37, 20);
            this.matrix55.TabIndex = 73;
            // 
            // matrix54
            // 
            this.matrix54.Location = new System.Drawing.Point(151, 273);
            this.matrix54.Name = "matrix54";
            this.matrix54.Size = new System.Drawing.Size(37, 20);
            this.matrix54.TabIndex = 72;
            // 
            // matrix53
            // 
            this.matrix53.Location = new System.Drawing.Point(108, 273);
            this.matrix53.Name = "matrix53";
            this.matrix53.Size = new System.Drawing.Size(37, 20);
            this.matrix53.TabIndex = 71;
            // 
            // matrix52
            // 
            this.matrix52.Location = new System.Drawing.Point(65, 273);
            this.matrix52.Name = "matrix52";
            this.matrix52.Size = new System.Drawing.Size(37, 20);
            this.matrix52.TabIndex = 70;
            // 
            // matrix51
            // 
            this.matrix51.Location = new System.Drawing.Point(22, 273);
            this.matrix51.Name = "matrix51";
            this.matrix51.Size = new System.Drawing.Size(37, 20);
            this.matrix51.TabIndex = 69;
            // 
            // result4
            // 
            this.result4.Location = new System.Drawing.Point(268, 247);
            this.result4.Name = "result4";
            this.result4.Size = new System.Drawing.Size(37, 20);
            this.result4.TabIndex = 68;
            // 
            // matrix45
            // 
            this.matrix45.Location = new System.Drawing.Point(194, 247);
            this.matrix45.Name = "matrix45";
            this.matrix45.Size = new System.Drawing.Size(37, 20);
            this.matrix45.TabIndex = 67;
            // 
            // matrix44
            // 
            this.matrix44.Location = new System.Drawing.Point(151, 247);
            this.matrix44.Name = "matrix44";
            this.matrix44.Size = new System.Drawing.Size(37, 20);
            this.matrix44.TabIndex = 66;
            // 
            // matrix43
            // 
            this.matrix43.Location = new System.Drawing.Point(108, 247);
            this.matrix43.Name = "matrix43";
            this.matrix43.Size = new System.Drawing.Size(37, 20);
            this.matrix43.TabIndex = 65;
            // 
            // matrix42
            // 
            this.matrix42.Location = new System.Drawing.Point(65, 247);
            this.matrix42.Name = "matrix42";
            this.matrix42.Size = new System.Drawing.Size(37, 20);
            this.matrix42.TabIndex = 64;
            // 
            // matrix41
            // 
            this.matrix41.Location = new System.Drawing.Point(22, 247);
            this.matrix41.Name = "matrix41";
            this.matrix41.Size = new System.Drawing.Size(37, 20);
            this.matrix41.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(407, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Inserte la operación:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(675, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "Historial de operaciones";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(50, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 23);
            this.label3.TabIndex = 77;
            this.label3.Text = "Elija las dimensiones de la matriz";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // newMatrix
            // 
            this.newMatrix.Location = new System.Drawing.Point(175, 119);
            this.newMatrix.Name = "newMatrix";
            this.newMatrix.Size = new System.Drawing.Size(89, 23);
            this.newMatrix.TabIndex = 78;
            this.newMatrix.Text = "Nueva matriz";
            this.newMatrix.UseVisualStyleBackColor = true;
            this.newMatrix.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cleanMatrix
            // 
            this.cleanMatrix.Location = new System.Drawing.Point(80, 119);
            this.cleanMatrix.Name = "cleanMatrix";
            this.cleanMatrix.Size = new System.Drawing.Size(89, 23);
            this.cleanMatrix.TabIndex = 79;
            this.cleanMatrix.Text = "Limpiar matriz";
            this.cleanMatrix.UseVisualStyleBackColor = true;
            this.cleanMatrix.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // mainWindow
            // 
            this.AccessibleName = "Gauss";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(980, 457);
            this.Controls.Add(this.cleanMatrix);
            this.Controls.Add(this.newMatrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result5);
            this.Controls.Add(this.matrix55);
            this.Controls.Add(this.matrix54);
            this.Controls.Add(this.matrix53);
            this.Controls.Add(this.matrix52);
            this.Controls.Add(this.matrix51);
            this.Controls.Add(this.result4);
            this.Controls.Add(this.matrix45);
            this.Controls.Add(this.matrix44);
            this.Controls.Add(this.matrix43);
            this.Controls.Add(this.matrix42);
            this.Controls.Add(this.matrix41);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.matrix35);
            this.Controls.Add(this.matrix34);
            this.Controls.Add(this.matrix33);
            this.Controls.Add(this.matrix32);
            this.Controls.Add(this.matrix31);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.matrix25);
            this.Controls.Add(this.matrix24);
            this.Controls.Add(this.matrix23);
            this.Controls.Add(this.matrix22);
            this.Controls.Add(this.matrix21);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.matrix15);
            this.Controls.Add(this.matrix14);
            this.Controls.Add(this.matrix13);
            this.Controls.Add(this.matrix12);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.matrix11);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.operationBox);
            this.Controls.Add(this.historyMatrix);
            this.Controls.Add(this.scrollHistory);
            this.Controls.Add(this.dimensions);
            this.Name = "mainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dimensions;
        private System.Windows.Forms.VScrollBar scrollHistory;
        private System.Windows.Forms.TextBox historyMatrix;
        private System.Windows.Forms.TextBox operationBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.TextBox matrix11;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox matrix12;
        private System.Windows.Forms.TextBox matrix13;
        private System.Windows.Forms.TextBox matrix14;
        private System.Windows.Forms.TextBox matrix15;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.TextBox matrix25;
        private System.Windows.Forms.TextBox matrix24;
        private System.Windows.Forms.TextBox matrix23;
        private System.Windows.Forms.TextBox matrix22;
        private System.Windows.Forms.TextBox matrix21;
        private System.Windows.Forms.TextBox result3;
        private System.Windows.Forms.TextBox matrix35;
        private System.Windows.Forms.TextBox matrix34;
        private System.Windows.Forms.TextBox matrix33;
        private System.Windows.Forms.TextBox matrix32;
        private System.Windows.Forms.TextBox matrix31;
        private System.Windows.Forms.TextBox result5;
        private System.Windows.Forms.TextBox matrix55;
        private System.Windows.Forms.TextBox matrix54;
        private System.Windows.Forms.TextBox matrix53;
        private System.Windows.Forms.TextBox matrix52;
        private System.Windows.Forms.TextBox matrix51;
        private System.Windows.Forms.TextBox result4;
        private System.Windows.Forms.TextBox matrix45;
        private System.Windows.Forms.TextBox matrix44;
        private System.Windows.Forms.TextBox matrix43;
        private System.Windows.Forms.TextBox matrix42;
        private System.Windows.Forms.TextBox matrix41;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newMatrix;
        private System.Windows.Forms.Button cleanMatrix;
    }
}

