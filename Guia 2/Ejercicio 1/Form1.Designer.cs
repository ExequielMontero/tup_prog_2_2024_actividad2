namespace Ejercicio_1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComisaria = new System.Windows.Forms.Button();
            this.btnIncidentes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nuGuardia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nuDesdeH = new System.Windows.Forms.NumericUpDown();
            this.nuHastaH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nuDuracion = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIncidente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nuDesdeJ = new System.Windows.Forms.NumericUpDown();
            this.nuHastaJ = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPersona = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuGuardia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDesdeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHastaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDesdeJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHastaJ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncidentes);
            this.groupBox1.Controls.Add(this.btnComisaria);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion Comisaria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnComisaria
            // 
            this.btnComisaria.Location = new System.Drawing.Point(340, 49);
            this.btnComisaria.Name = "btnComisaria";
            this.btnComisaria.Size = new System.Drawing.Size(169, 53);
            this.btnComisaria.TabIndex = 0;
            this.btnComisaria.Text = "Creacion Comisaria";
            this.btnComisaria.UseVisualStyleBackColor = true;
            this.btnComisaria.Click += new System.EventHandler(this.btnComisaria_Click);
            // 
            // btnIncidentes
            // 
            this.btnIncidentes.Location = new System.Drawing.Point(563, 49);
            this.btnIncidentes.Name = "btnIncidentes";
            this.btnIncidentes.Size = new System.Drawing.Size(168, 53);
            this.btnIncidentes.TabIndex = 1;
            this.btnIncidentes.Text = "Listar Incidentes";
            this.btnIncidentes.UseVisualStyleBackColor = true;
            this.btnIncidentes.Click += new System.EventHandler(this.btnIncidentes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nuDuracion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nuHastaH);
            this.groupBox2.Controls.Add(this.nuDesdeH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nuGuardia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnGuardia);
            this.groupBox2.Location = new System.Drawing.Point(7, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administracion de guardias";
            // 
            // btnGuardia
            // 
            this.btnGuardia.Location = new System.Drawing.Point(556, 34);
            this.btnGuardia.Name = "btnGuardia";
            this.btnGuardia.Size = new System.Drawing.Size(168, 53);
            this.btnGuardia.TabIndex = 1;
            this.btnGuardia.Text = "Asignacion de las Guardias";
            this.btnGuardia.UseVisualStyleBackColor = true;
            this.btnGuardia.Click += new System.EventHandler(this.btnGuardia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbDni);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbPersona);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nuHastaJ);
            this.groupBox3.Controls.Add(this.nuDesdeJ);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbIncidente);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Location = new System.Drawing.Point(6, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 173);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administracion de incidentes";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(557, 112);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(168, 53);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar Incidente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.cbPlaca);
            this.groupBox4.Location = new System.Drawing.Point(6, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(783, 420);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones sobre el agente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa de Agente";
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Items.AddRange(new object[] {
            "2323",
            "2324"});
            this.cbPlaca.Location = new System.Drawing.Point(117, 35);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(121, 21);
            this.cbPlaca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro Guardia";
            // 
            // nuGuardia
            // 
            this.nuGuardia.Location = new System.Drawing.Point(80, 28);
            this.nuGuardia.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nuGuardia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuGuardia.Name = "nuGuardia";
            this.nuGuardia.Size = new System.Drawing.Size(120, 20);
            this.nuGuardia.TabIndex = 5;
            this.nuGuardia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desde";
            // 
            // nuDesdeH
            // 
            this.nuDesdeH.Location = new System.Drawing.Point(54, 67);
            this.nuDesdeH.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nuDesdeH.Name = "nuDesdeH";
            this.nuDesdeH.Size = new System.Drawing.Size(66, 20);
            this.nuDesdeH.TabIndex = 7;
            this.nuDesdeH.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nuHastaH
            // 
            this.nuHastaH.Location = new System.Drawing.Point(134, 67);
            this.nuHastaH.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nuHastaH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuHastaH.Name = "nuHastaH";
            this.nuHastaH.Size = new System.Drawing.Size(66, 20);
            this.nuHastaH.TabIndex = 8;
            this.nuHastaH.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Duracion en M";
            // 
            // nuDuracion
            // 
            this.nuDuracion.Location = new System.Drawing.Point(93, 104);
            this.nuDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDuracion.Name = "nuDuracion";
            this.nuDuracion.Size = new System.Drawing.Size(107, 20);
            this.nuDuracion.TabIndex = 10;
            this.nuDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo Incidente";
            // 
            // cbIncidente
            // 
            this.cbIncidente.FormattingEnabled = true;
            this.cbIncidente.Items.AddRange(new object[] {
            "Robo",
            "Homicidio",
            "Disturbio Publico"});
            this.cbIncidente.Location = new System.Drawing.Point(92, 25);
            this.cbIncidente.Name = "cbIncidente";
            this.cbIncidente.Size = new System.Drawing.Size(109, 21);
            this.cbIncidente.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hora";
            // 
            // nuDesdeJ
            // 
            this.nuDesdeJ.Location = new System.Drawing.Point(47, 57);
            this.nuDesdeJ.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nuDesdeJ.Name = "nuDesdeJ";
            this.nuDesdeJ.Size = new System.Drawing.Size(66, 20);
            this.nuDesdeJ.TabIndex = 13;
            this.nuDesdeJ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuHastaJ
            // 
            this.nuHastaJ.Location = new System.Drawing.Point(135, 57);
            this.nuHastaJ.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nuHastaJ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuHastaJ.Name = "nuHastaJ";
            this.nuHastaJ.Size = new System.Drawing.Size(66, 20);
            this.nuHastaJ.TabIndex = 14;
            this.nuHastaJ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Persona";
            // 
            // tbPersona
            // 
            this.tbPersona.Location = new System.Drawing.Point(63, 86);
            this.tbPersona.Name = "tbPersona";
            this.tbPersona.Size = new System.Drawing.Size(100, 20);
            this.tbPersona.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(208, 86);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Motivo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 51);
            this.textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuGuardia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDesdeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHastaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDesdeJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHastaJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncidentes;
        private System.Windows.Forms.Button btnComisaria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.Button btnGuardia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nuDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuHastaH;
        private System.Windows.Forms.NumericUpDown nuDesdeH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuGuardia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuHastaJ;
        private System.Windows.Forms.NumericUpDown nuDesdeJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIncidente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPersona;
        private System.Windows.Forms.TextBox textBox1;
    }
}

