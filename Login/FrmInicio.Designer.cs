namespace Aplicacion
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
            lstProductos = new ListBox();
            label1 = new Label();
            lblUsuario = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ingresarProductoToolStripMenuItem = new ToolStripMenuItem();
            gaseosaToolStripMenuItem = new ToolStripMenuItem();
            arrozToolStripMenuItem = new ToolStripMenuItem();
            salchichaToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            historialDePersonasToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstProductos);
            groupBox1.Location = new Point(35, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(15, 22);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(848, 304);
            lstProductos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(367, -3);
            label1.MaximumSize = new Size(0, 28);
            label1.MinimumSize = new Size(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 4;
            label1.Text = "Mayorista Trapal";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(715, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(52, 21);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "label2";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MaximumSize = new Size(80, 25);
            menuStrip1.MinimumSize = new Size(80, 25);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(80, 25);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, historialDePersonasToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(62, 21);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            ingresarProductoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaseosaToolStripMenuItem, arrozToolStripMenuItem, salchichaToolStripMenuItem });
            ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            ingresarProductoToolStripMenuItem.Size = new Size(226, 26);
            ingresarProductoToolStripMenuItem.Text = "Ingresar producto";
            // 
            // gaseosaToolStripMenuItem
            // 
            gaseosaToolStripMenuItem.Name = "gaseosaToolStripMenuItem";
            gaseosaToolStripMenuItem.Size = new Size(145, 26);
            gaseosaToolStripMenuItem.Text = "Gaseosa";
            // 
            // arrozToolStripMenuItem
            // 
            arrozToolStripMenuItem.Name = "arrozToolStripMenuItem";
            arrozToolStripMenuItem.Size = new Size(145, 26);
            arrozToolStripMenuItem.Text = "Arroz";
            // 
            // salchichaToolStripMenuItem
            // 
            salchichaToolStripMenuItem.Name = "salchichaToolStripMenuItem";
            salchichaToolStripMenuItem.Size = new Size(145, 26);
            salchichaToolStripMenuItem.Text = "Salchicha";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(226, 26);
            eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            // 
            // historialDePersonasToolStripMenuItem
            // 
            historialDePersonasToolStripMenuItem.Name = "historialDePersonasToolStripMenuItem";
            historialDePersonasToolStripMenuItem.Size = new Size(226, 26);
            historialDePersonasToolStripMenuItem.Text = "Historial de personas";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 431);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FrmInicio";
            Text = "Form1";
            Load += FrmInicio_Load;
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstProductos;
        private Label label1;
        private Label lblUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private ToolStripMenuItem gaseosaToolStripMenuItem;
        private ToolStripMenuItem arrozToolStripMenuItem;
        private ToolStripMenuItem salchichaToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem historialDePersonasToolStripMenuItem;
    }
}