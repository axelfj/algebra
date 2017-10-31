namespace UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstruccion1 = new System.Windows.Forms.Label();
            this.cmbxEcuaciones = new System.Windows.Forms.ComboBox();
            this.lblInstrucciones2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMatriz11 = new System.Windows.Forms.TextBox();
            this.txtMatriz12 = new System.Windows.Forms.TextBox();
            this.txtMatriz13 = new System.Windows.Forms.TextBox();
            this.txtMatriz14 = new System.Windows.Forms.TextBox();
            this.txtMatriz15 = new System.Windows.Forms.TextBox();
            this.txtMatriz16 = new System.Windows.Forms.TextBox();
            this.txtMatriz26 = new System.Windows.Forms.TextBox();
            this.txtMatriz25 = new System.Windows.Forms.TextBox();
            this.txtMatriz24 = new System.Windows.Forms.TextBox();
            this.txtMatriz23 = new System.Windows.Forms.TextBox();
            this.txtMatriz22 = new System.Windows.Forms.TextBox();
            this.txtMatriz21 = new System.Windows.Forms.TextBox();
            this.txtMatriz46 = new System.Windows.Forms.TextBox();
            this.txtMatriz45 = new System.Windows.Forms.TextBox();
            this.txtMatriz44 = new System.Windows.Forms.TextBox();
            this.txtMatriz43 = new System.Windows.Forms.TextBox();
            this.txtMatriz42 = new System.Windows.Forms.TextBox();
            this.txtMatriz41 = new System.Windows.Forms.TextBox();
            this.txtMatriz36 = new System.Windows.Forms.TextBox();
            this.txtMatriz35 = new System.Windows.Forms.TextBox();
            this.txtMatriz34 = new System.Windows.Forms.TextBox();
            this.txtMatriz33 = new System.Windows.Forms.TextBox();
            this.txtMatriz32 = new System.Windows.Forms.TextBox();
            this.txtMatriz31 = new System.Windows.Forms.TextBox();
            this.txtMatriz56 = new System.Windows.Forms.TextBox();
            this.txtMatriz55 = new System.Windows.Forms.TextBox();
            this.txtMatriz54 = new System.Windows.Forms.TextBox();
            this.txtMatriz53 = new System.Windows.Forms.TextBox();
            this.txtMatriz52 = new System.Windows.Forms.TextBox();
            this.txtMatriz51 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMatrizA0 = new System.Windows.Forms.Label();
            this.lblMatrizA1 = new System.Windows.Forms.Label();
            this.lblMatrizA2 = new System.Windows.Forms.Label();
            this.lblMatrizA3 = new System.Windows.Forms.Label();
            this.lblMatrizA4 = new System.Windows.Forms.Label();
            this.lblBracketAbre = new System.Windows.Forms.Label();
            this.lblBracketCierra = new System.Windows.Forms.Label();
            this.lblA0 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblDet = new System.Windows.Forms.Label();
            this.lblConjuntoSolucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(289, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(519, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eliminación Gaussiana libre de fracciones (método de un solo paso)";
            // 
            // lblInstruccion1
            // 
            this.lblInstruccion1.AutoSize = true;
            this.lblInstruccion1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion1.Location = new System.Drawing.Point(238, 44);
            this.lblInstruccion1.Name = "lblInstruccion1";
            this.lblInstruccion1.Size = new System.Drawing.Size(374, 23);
            this.lblInstruccion1.TabIndex = 1;
            this.lblInstruccion1.Text = "Seleccione la cantidad de ecuaciones deseadas:";
            // 
            // cmbxEcuaciones
            // 
            this.cmbxEcuaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.cmbxEcuaciones.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbxEcuaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEcuaciones.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEcuaciones.FormattingEnabled = true;
            this.cmbxEcuaciones.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbxEcuaciones.Location = new System.Drawing.Point(618, 41);
            this.cmbxEcuaciones.Name = "cmbxEcuaciones";
            this.cmbxEcuaciones.Size = new System.Drawing.Size(50, 31);
            this.cmbxEcuaciones.TabIndex = 2;
            this.cmbxEcuaciones.SelectedIndexChanged += new System.EventHandler(this.cmbxEcuaciones_SelectedIndexChanged);
            // 
            // lblInstrucciones2
            // 
            this.lblInstrucciones2.AutoSize = true;
            this.lblInstrucciones2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones2.Location = new System.Drawing.Point(674, 44);
            this.lblInstrucciones2.Name = "lblInstrucciones2";
            this.lblInstrucciones2.Size = new System.Drawing.Size(98, 23);
            this.lblInstrucciones2.TabIndex = 3;
            this.lblInstrucciones2.Text = "Luego pulse";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(778, 38);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMatriz11
            // 
            this.txtMatriz11.Location = new System.Drawing.Point(397, 92);
            this.txtMatriz11.Name = "txtMatriz11";
            this.txtMatriz11.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz11.TabIndex = 5;
            this.txtMatriz11.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz12
            // 
            this.txtMatriz12.Location = new System.Drawing.Point(441, 92);
            this.txtMatriz12.Name = "txtMatriz12";
            this.txtMatriz12.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz12.TabIndex = 6;
            this.txtMatriz12.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz13
            // 
            this.txtMatriz13.Location = new System.Drawing.Point(485, 92);
            this.txtMatriz13.Name = "txtMatriz13";
            this.txtMatriz13.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz13.TabIndex = 7;
            this.txtMatriz13.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz14
            // 
            this.txtMatriz14.Location = new System.Drawing.Point(529, 92);
            this.txtMatriz14.Name = "txtMatriz14";
            this.txtMatriz14.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz14.TabIndex = 8;
            this.txtMatriz14.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz15
            // 
            this.txtMatriz15.Location = new System.Drawing.Point(573, 92);
            this.txtMatriz15.Name = "txtMatriz15";
            this.txtMatriz15.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz15.TabIndex = 9;
            this.txtMatriz15.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz16
            // 
            this.txtMatriz16.Location = new System.Drawing.Point(646, 92);
            this.txtMatriz16.Name = "txtMatriz16";
            this.txtMatriz16.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz16.TabIndex = 10;
            this.txtMatriz16.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz26
            // 
            this.txtMatriz26.Location = new System.Drawing.Point(646, 118);
            this.txtMatriz26.Name = "txtMatriz26";
            this.txtMatriz26.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz26.TabIndex = 16;
            this.txtMatriz26.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz25
            // 
            this.txtMatriz25.Location = new System.Drawing.Point(573, 118);
            this.txtMatriz25.Name = "txtMatriz25";
            this.txtMatriz25.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz25.TabIndex = 15;
            this.txtMatriz25.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz24
            // 
            this.txtMatriz24.Location = new System.Drawing.Point(529, 118);
            this.txtMatriz24.Name = "txtMatriz24";
            this.txtMatriz24.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz24.TabIndex = 14;
            this.txtMatriz24.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz23
            // 
            this.txtMatriz23.Location = new System.Drawing.Point(485, 118);
            this.txtMatriz23.Name = "txtMatriz23";
            this.txtMatriz23.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz23.TabIndex = 13;
            this.txtMatriz23.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz22
            // 
            this.txtMatriz22.Location = new System.Drawing.Point(441, 118);
            this.txtMatriz22.Name = "txtMatriz22";
            this.txtMatriz22.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz22.TabIndex = 12;
            this.txtMatriz22.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz21
            // 
            this.txtMatriz21.Location = new System.Drawing.Point(397, 118);
            this.txtMatriz21.Name = "txtMatriz21";
            this.txtMatriz21.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz21.TabIndex = 11;
            this.txtMatriz21.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz46
            // 
            this.txtMatriz46.Location = new System.Drawing.Point(646, 170);
            this.txtMatriz46.Name = "txtMatriz46";
            this.txtMatriz46.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz46.TabIndex = 28;
            this.txtMatriz46.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz45
            // 
            this.txtMatriz45.Location = new System.Drawing.Point(573, 170);
            this.txtMatriz45.Name = "txtMatriz45";
            this.txtMatriz45.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz45.TabIndex = 27;
            this.txtMatriz45.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz44
            // 
            this.txtMatriz44.Location = new System.Drawing.Point(529, 170);
            this.txtMatriz44.Name = "txtMatriz44";
            this.txtMatriz44.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz44.TabIndex = 26;
            this.txtMatriz44.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz43
            // 
            this.txtMatriz43.Location = new System.Drawing.Point(485, 170);
            this.txtMatriz43.Name = "txtMatriz43";
            this.txtMatriz43.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz43.TabIndex = 25;
            this.txtMatriz43.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz42
            // 
            this.txtMatriz42.Location = new System.Drawing.Point(441, 170);
            this.txtMatriz42.Name = "txtMatriz42";
            this.txtMatriz42.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz42.TabIndex = 24;
            this.txtMatriz42.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz41
            // 
            this.txtMatriz41.Location = new System.Drawing.Point(397, 170);
            this.txtMatriz41.Name = "txtMatriz41";
            this.txtMatriz41.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz41.TabIndex = 23;
            this.txtMatriz41.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz36
            // 
            this.txtMatriz36.Location = new System.Drawing.Point(646, 144);
            this.txtMatriz36.Name = "txtMatriz36";
            this.txtMatriz36.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz36.TabIndex = 22;
            this.txtMatriz36.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz35
            // 
            this.txtMatriz35.Location = new System.Drawing.Point(573, 144);
            this.txtMatriz35.Name = "txtMatriz35";
            this.txtMatriz35.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz35.TabIndex = 21;
            this.txtMatriz35.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz34
            // 
            this.txtMatriz34.Location = new System.Drawing.Point(529, 144);
            this.txtMatriz34.Name = "txtMatriz34";
            this.txtMatriz34.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz34.TabIndex = 20;
            this.txtMatriz34.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz33
            // 
            this.txtMatriz33.Location = new System.Drawing.Point(485, 144);
            this.txtMatriz33.Name = "txtMatriz33";
            this.txtMatriz33.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz33.TabIndex = 19;
            this.txtMatriz33.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz32
            // 
            this.txtMatriz32.Location = new System.Drawing.Point(441, 144);
            this.txtMatriz32.Name = "txtMatriz32";
            this.txtMatriz32.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz32.TabIndex = 18;
            this.txtMatriz32.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz31
            // 
            this.txtMatriz31.Location = new System.Drawing.Point(397, 144);
            this.txtMatriz31.Name = "txtMatriz31";
            this.txtMatriz31.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz31.TabIndex = 17;
            this.txtMatriz31.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz56
            // 
            this.txtMatriz56.Location = new System.Drawing.Point(646, 196);
            this.txtMatriz56.Name = "txtMatriz56";
            this.txtMatriz56.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz56.TabIndex = 34;
            this.txtMatriz56.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz55
            // 
            this.txtMatriz55.Location = new System.Drawing.Point(573, 196);
            this.txtMatriz55.Name = "txtMatriz55";
            this.txtMatriz55.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz55.TabIndex = 33;
            this.txtMatriz55.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz54
            // 
            this.txtMatriz54.Location = new System.Drawing.Point(529, 196);
            this.txtMatriz54.Name = "txtMatriz54";
            this.txtMatriz54.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz54.TabIndex = 32;
            this.txtMatriz54.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz53
            // 
            this.txtMatriz53.Location = new System.Drawing.Point(485, 196);
            this.txtMatriz53.Name = "txtMatriz53";
            this.txtMatriz53.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz53.TabIndex = 31;
            this.txtMatriz53.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz52
            // 
            this.txtMatriz52.Location = new System.Drawing.Point(441, 196);
            this.txtMatriz52.Name = "txtMatriz52";
            this.txtMatriz52.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz52.TabIndex = 30;
            this.txtMatriz52.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // txtMatriz51
            // 
            this.txtMatriz51.Location = new System.Drawing.Point(397, 196);
            this.txtMatriz51.Name = "txtMatriz51";
            this.txtMatriz51.Size = new System.Drawing.Size(38, 20);
            this.txtMatriz51.TabIndex = 29;
            this.txtMatriz51.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 149);
            this.label1.TabIndex = 35;
            this.label1.Text = "(";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 149);
            this.label2.TabIndex = 36;
            this.label2.Text = ")";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 149);
            this.label3.TabIndex = 37;
            this.label3.Text = "|";
            // 
            // lblMatrizA0
            // 
            this.lblMatrizA0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatrizA0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatrizA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizA0.Location = new System.Drawing.Point(157, 258);
            this.lblMatrizA0.Name = "lblMatrizA0";
            this.lblMatrizA0.Size = new System.Drawing.Size(134, 102);
            this.lblMatrizA0.TabIndex = 38;
            this.lblMatrizA0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrizA1
            // 
            this.lblMatrizA1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatrizA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatrizA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizA1.Location = new System.Drawing.Point(331, 258);
            this.lblMatrizA1.Name = "lblMatrizA1";
            this.lblMatrizA1.Size = new System.Drawing.Size(134, 102);
            this.lblMatrizA1.TabIndex = 39;
            this.lblMatrizA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrizA2
            // 
            this.lblMatrizA2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatrizA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatrizA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizA2.Location = new System.Drawing.Point(494, 258);
            this.lblMatrizA2.Name = "lblMatrizA2";
            this.lblMatrizA2.Size = new System.Drawing.Size(134, 102);
            this.lblMatrizA2.TabIndex = 40;
            this.lblMatrizA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrizA3
            // 
            this.lblMatrizA3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatrizA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatrizA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizA3.Location = new System.Drawing.Point(674, 258);
            this.lblMatrizA3.Name = "lblMatrizA3";
            this.lblMatrizA3.Size = new System.Drawing.Size(134, 102);
            this.lblMatrizA3.TabIndex = 41;
            this.lblMatrizA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrizA4
            // 
            this.lblMatrizA4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatrizA4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatrizA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizA4.Location = new System.Drawing.Point(843, 258);
            this.lblMatrizA4.Name = "lblMatrizA4";
            this.lblMatrizA4.Size = new System.Drawing.Size(134, 102);
            this.lblMatrizA4.TabIndex = 42;
            this.lblMatrizA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBracketAbre
            // 
            this.lblBracketAbre.AutoSize = true;
            this.lblBracketAbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBracketAbre.Location = new System.Drawing.Point(44, 227);
            this.lblBracketAbre.Name = "lblBracketAbre";
            this.lblBracketAbre.Size = new System.Drawing.Size(107, 149);
            this.lblBracketAbre.TabIndex = 43;
            this.lblBracketAbre.Text = "{";
            // 
            // lblBracketCierra
            // 
            this.lblBracketCierra.AutoSize = true;
            this.lblBracketCierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBracketCierra.Location = new System.Drawing.Point(983, 227);
            this.lblBracketCierra.Name = "lblBracketCierra";
            this.lblBracketCierra.Size = new System.Drawing.Size(107, 149);
            this.lblBracketCierra.TabIndex = 44;
            this.lblBracketCierra.Text = "}";
            // 
            // lblA0
            // 
            this.lblA0.AutoSize = true;
            this.lblA0.Location = new System.Drawing.Point(220, 242);
            this.lblA0.Name = "lblA0";
            this.lblA0.Size = new System.Drawing.Size(20, 13);
            this.lblA0.TabIndex = 45;
            this.lblA0.Text = "A0";
            // 
            // lblA4
            // 
            this.lblA4.AutoSize = true;
            this.lblA4.Location = new System.Drawing.Point(900, 242);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(20, 13);
            this.lblA4.TabIndex = 46;
            this.lblA4.Text = "A4";
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.Location = new System.Drawing.Point(734, 245);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(20, 13);
            this.lblA3.TabIndex = 47;
            this.lblA3.Text = "A3";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Location = new System.Drawing.Point(547, 242);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(20, 13);
            this.lblA2.TabIndex = 48;
            this.lblA2.Text = "A2";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(385, 242);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(20, 13);
            this.lblA1.TabIndex = 49;
            this.lblA1.Text = "A1";
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.BackColor = System.Drawing.SystemColors.Control;
            this.lblDet.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDet.Location = new System.Drawing.Point(240, 429);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(289, 38);
            this.lblDet.TabIndex = 52;
            this.lblDet.Text = "El determinante es: ";
            this.lblDet.Visible = false;
            // 
            // lblConjuntoSolucion
            // 
            this.lblConjuntoSolucion.AutoSize = true;
            this.lblConjuntoSolucion.BackColor = System.Drawing.SystemColors.Control;
            this.lblConjuntoSolucion.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConjuntoSolucion.Location = new System.Drawing.Point(151, 508);
            this.lblConjuntoSolucion.Name = "lblConjuntoSolucion";
            this.lblConjuntoSolucion.Size = new System.Drawing.Size(378, 38);
            this.lblConjuntoSolucion.TabIndex = 53;
            this.lblConjuntoSolucion.Text = "El conjunto de solución es: ";
            this.lblConjuntoSolucion.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 604);
            this.Controls.Add(this.lblConjuntoSolucion);
            this.Controls.Add(this.lblDet);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblA3);
            this.Controls.Add(this.lblA4);
            this.Controls.Add(this.lblA0);
            this.Controls.Add(this.lblBracketAbre);
            this.Controls.Add(this.lblBracketCierra);
            this.Controls.Add(this.lblMatrizA4);
            this.Controls.Add(this.lblMatrizA3);
            this.Controls.Add(this.lblMatrizA2);
            this.Controls.Add(this.lblMatrizA1);
            this.Controls.Add(this.lblMatrizA0);
            this.Controls.Add(this.txtMatriz56);
            this.Controls.Add(this.txtMatriz55);
            this.Controls.Add(this.txtMatriz54);
            this.Controls.Add(this.txtMatriz53);
            this.Controls.Add(this.txtMatriz52);
            this.Controls.Add(this.txtMatriz51);
            this.Controls.Add(this.txtMatriz46);
            this.Controls.Add(this.txtMatriz45);
            this.Controls.Add(this.txtMatriz44);
            this.Controls.Add(this.txtMatriz43);
            this.Controls.Add(this.txtMatriz42);
            this.Controls.Add(this.txtMatriz41);
            this.Controls.Add(this.txtMatriz36);
            this.Controls.Add(this.txtMatriz35);
            this.Controls.Add(this.txtMatriz34);
            this.Controls.Add(this.txtMatriz33);
            this.Controls.Add(this.txtMatriz32);
            this.Controls.Add(this.txtMatriz31);
            this.Controls.Add(this.txtMatriz26);
            this.Controls.Add(this.txtMatriz25);
            this.Controls.Add(this.txtMatriz24);
            this.Controls.Add(this.txtMatriz23);
            this.Controls.Add(this.txtMatriz22);
            this.Controls.Add(this.txtMatriz21);
            this.Controls.Add(this.txtMatriz16);
            this.Controls.Add(this.txtMatriz15);
            this.Controls.Add(this.txtMatriz14);
            this.Controls.Add(this.txtMatriz13);
            this.Controls.Add(this.txtMatriz12);
            this.Controls.Add(this.txtMatriz11);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblInstrucciones2);
            this.Controls.Add(this.cmbxEcuaciones);
            this.Controls.Add(this.lblInstruccion1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Algoritmo de Bareiss";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion1;
        private System.Windows.Forms.ComboBox cmbxEcuaciones;
        private System.Windows.Forms.Label lblInstrucciones2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMatriz11;
        private System.Windows.Forms.TextBox txtMatriz12;
        private System.Windows.Forms.TextBox txtMatriz13;
        private System.Windows.Forms.TextBox txtMatriz14;
        private System.Windows.Forms.TextBox txtMatriz15;
        private System.Windows.Forms.TextBox txtMatriz16;
        private System.Windows.Forms.TextBox txtMatriz26;
        private System.Windows.Forms.TextBox txtMatriz25;
        private System.Windows.Forms.TextBox txtMatriz24;
        private System.Windows.Forms.TextBox txtMatriz23;
        private System.Windows.Forms.TextBox txtMatriz22;
        private System.Windows.Forms.TextBox txtMatriz21;
        private System.Windows.Forms.TextBox txtMatriz46;
        private System.Windows.Forms.TextBox txtMatriz45;
        private System.Windows.Forms.TextBox txtMatriz44;
        private System.Windows.Forms.TextBox txtMatriz43;
        private System.Windows.Forms.TextBox txtMatriz42;
        private System.Windows.Forms.TextBox txtMatriz41;
        private System.Windows.Forms.TextBox txtMatriz36;
        private System.Windows.Forms.TextBox txtMatriz35;
        private System.Windows.Forms.TextBox txtMatriz34;
        private System.Windows.Forms.TextBox txtMatriz33;
        private System.Windows.Forms.TextBox txtMatriz32;
        private System.Windows.Forms.TextBox txtMatriz31;
        private System.Windows.Forms.TextBox txtMatriz56;
        private System.Windows.Forms.TextBox txtMatriz55;
        private System.Windows.Forms.TextBox txtMatriz54;
        private System.Windows.Forms.TextBox txtMatriz53;
        private System.Windows.Forms.TextBox txtMatriz52;
        private System.Windows.Forms.TextBox txtMatriz51;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMatrizA0;
        private System.Windows.Forms.Label lblMatrizA1;
        private System.Windows.Forms.Label lblMatrizA2;
        private System.Windows.Forms.Label lblMatrizA3;
        private System.Windows.Forms.Label lblMatrizA4;
        private System.Windows.Forms.Label lblBracketAbre;
        private System.Windows.Forms.Label lblBracketCierra;
        private System.Windows.Forms.Label lblA0;
        private System.Windows.Forms.Label lblA4;
        private System.Windows.Forms.Label lblA3;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblDet;
        private System.Windows.Forms.Label lblConjuntoSolucion;
    }
}

