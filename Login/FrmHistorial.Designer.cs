﻿namespace Aplicacion
{
    partial class FrmHistorial
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
            lstHistorial = new ListBox();
            btnVolver = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(33, 63);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(490, 394);
            lstHistorial.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(2, 1);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(80, 25);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(218, 25);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 2;
            label1.Text = "Ultimos ingresos";
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 498);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(lstHistorial);
            Name = "FrmHistorial";
            Text = "Historial";
            Load += FrmHistorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstHistorial;
        private Button btnVolver;
        private Label label1;
    }
}