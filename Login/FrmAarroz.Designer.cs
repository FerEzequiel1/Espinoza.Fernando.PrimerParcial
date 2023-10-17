namespace Aplicacion
{
    partial class FrmAarroz
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
            ((System.ComponentModel.ISupportInitialize)nUDMililitros).BeginInit();
            SuspendLayout();
            // 
            // txtSabor
            // 
            txtSabor.Size = new Size(152, 23);
            // 
            // cmbMarca
            // 
            cmbMarca.Items.AddRange(new object[] { "SevenUp", "Pepsi", "Trapal" });
            // 
            // FrmAarroz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 494);
            Name = "FrmAarroz";
            Text = "Ingreso Aarroz";
            ((System.ComponentModel.ISupportInitialize)nUDMililitros).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}