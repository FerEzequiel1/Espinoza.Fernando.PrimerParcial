﻿namespace Aplicacion
{
    partial class FrmInicio
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
            groupBox1 = new GroupBox();
            textUsuario = new TextBox();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(35, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 290);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textUsuario
            // 
            textUsuario.Enabled = false;
            textUsuario.Location = new Point(514, 12);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(191, 23);
            textUsuario.TabIndex = 2;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 409);
            Controls.Add(textUsuario);
            Controls.Add(groupBox1);
            IsMdiContainer = true;
            Name = "FrmInicio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textUsuario;
    }
}