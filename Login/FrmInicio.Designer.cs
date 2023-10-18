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
            groupBox2 = new GroupBox();
            btnOrdenar = new Button();
            groupBox4 = new GroupBox();
            rbPrecioTotal = new RadioButton();
            rbCantidad = new RadioButton();
            groupBox3 = new GroupBox();
            rbMayor = new RadioButton();
            rbMenor = new RadioButton();
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
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lstProductos);
            groupBox1.Location = new Point(35, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 416);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOrdenar);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(15, 302);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 93);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenar por:";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(401, 30);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 41);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbPrecioTotal);
            groupBox4.Controls.Add(rbCantidad);
            groupBox4.Location = new Point(214, 8);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(168, 79);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipo";
            // 
            // rbPrecioTotal
            // 
            rbPrecioTotal.AutoSize = true;
            rbPrecioTotal.Location = new Point(6, 22);
            rbPrecioTotal.Name = "rbPrecioTotal";
            rbPrecioTotal.Size = new Size(85, 19);
            rbPrecioTotal.TabIndex = 0;
            rbPrecioTotal.TabStop = true;
            rbPrecioTotal.Text = "Precio total";
            rbPrecioTotal.UseVisualStyleBackColor = true;
            // 
            // rbCantidad
            // 
            rbCantidad.AutoSize = true;
            rbCantidad.Location = new Point(6, 44);
            rbCantidad.Name = "rbCantidad";
            rbCantidad.Size = new Size(73, 19);
            rbCantidad.TabIndex = 1;
            rbCantidad.TabStop = true;
            rbCantidad.Text = "Cantidad";
            rbCantidad.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbMayor);
            groupBox3.Controls.Add(rbMenor);
            groupBox3.Location = new Point(81, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(127, 79);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cantidad";
            // 
            // rbMayor
            // 
            rbMayor.AutoSize = true;
            rbMayor.Location = new Point(6, 22);
            rbMayor.Name = "rbMayor";
            rbMayor.Size = new Size(59, 19);
            rbMayor.TabIndex = 3;
            rbMayor.TabStop = true;
            rbMayor.Text = "Mayor";
            rbMayor.UseVisualStyleBackColor = true;
            // 
            // rbMenor
            // 
            rbMenor.AutoSize = true;
            rbMenor.Location = new Point(6, 44);
            rbMenor.Name = "rbMenor";
            rbMenor.Size = new Size(60, 19);
            rbMenor.TabIndex = 2;
            rbMenor.TabStop = true;
            rbMenor.Text = "Menor";
            rbMenor.UseVisualStyleBackColor = true;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(15, 22);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(848, 274);
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
            lblUsuario.Location = new Point(636, 0);
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
            gaseosaToolStripMenuItem.Click += gaseosaToolStripMenuItem_Click;
            // 
            // arrozToolStripMenuItem
            // 
            arrozToolStripMenuItem.Name = "arrozToolStripMenuItem";
            arrozToolStripMenuItem.Size = new Size(145, 26);
            arrozToolStripMenuItem.Text = "Arroz";
            arrozToolStripMenuItem.Click += arrozToolStripMenuItem_Click;
            // 
            // salchichaToolStripMenuItem
            // 
            salchichaToolStripMenuItem.Name = "salchichaToolStripMenuItem";
            salchichaToolStripMenuItem.Size = new Size(145, 26);
            salchichaToolStripMenuItem.Text = "Salchicha";
            salchichaToolStripMenuItem.Click += salchichaToolStripMenuItem_Click;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(226, 26);
            eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // historialDePersonasToolStripMenuItem
            // 
            historialDePersonasToolStripMenuItem.Name = "historialDePersonasToolStripMenuItem";
            historialDePersonasToolStripMenuItem.Size = new Size(226, 26);
            historialDePersonasToolStripMenuItem.Text = "Historial de personas";
            historialDePersonasToolStripMenuItem.Click += historialDePersonasToolStripMenuItem_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 494);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FrmInicio";
            Text = "Form1";
            FormClosed += FrmInicio_FormClosed;
            Load += FrmInicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private GroupBox groupBox2;
        private RadioButton rbMayor;
        private RadioButton rbMenor;
        private RadioButton rbCantidad;
        private RadioButton rbPrecioTotal;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Button btnOrdenar;
    }
}