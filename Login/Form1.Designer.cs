using Control_de_ingresos;

namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 75);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su contraeña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 93);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(25, 132);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(113, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(25, 161);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(173, 218);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnIngresar;
        private Button btnCancelar;
    }
}