namespace Aplicacion
{
    partial class FrmSalchicha
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
            label6 = new Label();
            nUDUnidades = new NumericUpDown();
            label7 = new Label();
            txtChancho = new TextBox();
            gpArmado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDUnidades).BeginInit();
            SuspendLayout();
            // 
            // cmbMarca
            // 
            cmbMarca.Items.AddRange(new object[] { "SevenUp", "Pepsi", "Trapal" });
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gpArmado
            // 
            gpArmado.Controls.Add(txtChancho);
            gpArmado.Controls.Add(label7);
            gpArmado.Controls.Add(nUDUnidades);
            gpArmado.Controls.Add(label6);
            gpArmado.Controls.SetChildIndex(txtNombre, 0);
            gpArmado.Controls.SetChildIndex(txtTipo, 0);
            gpArmado.Controls.SetChildIndex(nUDCantidad, 0);
            gpArmado.Controls.SetChildIndex(cmbMarca, 0);
            gpArmado.Controls.SetChildIndex(nUDPrecio, 0);
            gpArmado.Controls.SetChildIndex(btnAgregar, 0);
            gpArmado.Controls.SetChildIndex(label6, 0);
            gpArmado.Controls.SetChildIndex(nUDUnidades, 0);
            gpArmado.Controls.SetChildIndex(label7, 0);
            gpArmado.Controls.SetChildIndex(txtChancho, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 146);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 15;
            label6.Text = "Unidades";
            // 
            // nUDUnidades
            // 
            nUDUnidades.Location = new Point(391, 164);
            nUDUnidades.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDUnidades.Name = "nUDUnidades";
            nUDUnidades.Size = new Size(120, 23);
            nUDUnidades.TabIndex = 16;
            nUDUnidades.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(582, 146);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 19;
            label7.Text = "Tiene chancho?";
            // 
            // txtChancho
            // 
            txtChancho.Location = new Point(582, 164);
            txtChancho.Name = "txtChancho";
            txtChancho.Size = new Size(100, 23);
            txtChancho.TabIndex = 20;
            // 
            // FrmSalchicha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 494);
            Name = "FrmSalchicha";
            Text = "FrmSalchicha";
            gpArmado.ResumeLayout(false);
            gpArmado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDUnidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label label7;
        private NumericUpDown nUDUnidades;
        private TextBox txtChancho;
    }
}