﻿namespace Aplicacion
{
    partial class FrmGaseosa
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
            btnAgregar = new Button();
            btnVolver = new Button();
            gpArmado = new GroupBox();
            btnCancelar = new Button();
            label7 = new Label();
            nUDMililitros = new NumericUpDown();
            label6 = new Label();
            nUDPrecio = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            cmbMarca = new ComboBox();
            nUDCantidad = new NumericUpDown();
            txtSabor = new TextBox();
            label3 = new Label();
            txtTipo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            gpArmado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDMililitros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(629, 273);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(1, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(80, 25);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // gpArmado
            // 
            gpArmado.Controls.Add(btnCancelar);
            gpArmado.Controls.Add(label7);
            gpArmado.Controls.Add(nUDMililitros);
            gpArmado.Controls.Add(btnAgregar);
            gpArmado.Controls.Add(label6);
            gpArmado.Controls.Add(nUDPrecio);
            gpArmado.Controls.Add(label5);
            gpArmado.Controls.Add(label4);
            gpArmado.Controls.Add(cmbMarca);
            gpArmado.Controls.Add(nUDCantidad);
            gpArmado.Controls.Add(txtSabor);
            gpArmado.Controls.Add(label3);
            gpArmado.Controls.Add(txtTipo);
            gpArmado.Controls.Add(label2);
            gpArmado.Controls.Add(txtNombre);
            gpArmado.Controls.Add(label1);
            gpArmado.Location = new Point(100, 76);
            gpArmado.Name = "gpArmado";
            gpArmado.Size = new Size(785, 332);
            gpArmado.TabIndex = 3;
            gpArmado.TabStop = false;
            gpArmado.Text = "Carga del producto";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(492, 273);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 30);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 146);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 13;
            label7.Text = "Sabor";
            // 
            // nUDMililitros
            // 
            nUDMililitros.DecimalPlaces = 3;
            nUDMililitros.Location = new Point(374, 164);
            nUDMililitros.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nUDMililitros.Minimum = new decimal(new int[] { 500, 0, 0, 196608 });
            nUDMililitros.Name = "nUDMililitros";
            nUDMililitros.Size = new Size(120, 23);
            nUDMililitros.TabIndex = 12;
            nUDMililitros.Value = new decimal(new int[] { 500, 0, 0, 196608 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 146);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 11;
            label6.Text = "Mililitros";
            // 
            // nUDPrecio
            // 
            nUDPrecio.DecimalPlaces = 2;
            nUDPrecio.Location = new Point(192, 164);
            nUDPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nUDPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDPrecio.Name = "nUDPrecio";
            nUDPrecio.Size = new Size(120, 23);
            nUDPrecio.TabIndex = 10;
            nUDPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 146);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(565, 31);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "SevenUp", "Pepsi", "Trapal" });
            cmbMarca.Location = new Point(565, 49);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(124, 23);
            cmbMarca.TabIndex = 8;
            cmbMarca.Text = "Ingrese una opción";
            // 
            // nUDCantidad
            // 
            nUDCantidad.Location = new Point(14, 164);
            nUDCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDCantidad.Name = "nUDCantidad";
            nUDCantidad.Size = new Size(120, 23);
            nUDCantidad.TabIndex = 7;
            nUDCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtSabor
            // 
            txtSabor.Location = new Point(565, 164);
            txtSabor.Name = "txtSabor";
            txtSabor.Size = new Size(154, 23);
            txtSabor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 146);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(341, 49);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(153, 23);
            txtTipo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 31);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // FrmGaseosa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 494);
            Controls.Add(gpArmado);
            Controls.Add(btnVolver);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmGaseosa";
            Text = "IngresoGaseosa";
            gpArmado.ResumeLayout(false);
            gpArmado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDMililitros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnVolver;
        private GroupBox gpArmado;
        private TextBox txtTipo;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private NumericUpDown nUDCantidad;
        private Label label4;
        private NumericUpDown nUDPrecio;
        private Label label5;
        private Button btnCancelar;
        public TextBox txtSabor;
        public NumericUpDown nUDMililitros;
        public Label label6;
        public Label label7;
        public ComboBox cmbMarca;
    }
}