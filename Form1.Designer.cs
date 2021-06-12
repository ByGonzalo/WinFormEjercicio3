
namespace WindowsFormsApp3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btsuma = new System.Windows.Forms.Button();
            this.btresta = new System.Windows.Forms.Button();
            this.btmulti = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btsuma
            // 
            this.btsuma.Location = new System.Drawing.Point(258, 55);
            this.btsuma.Name = "btsuma";
            this.btsuma.Size = new System.Drawing.Size(44, 23);
            this.btsuma.TabIndex = 2;
            this.btsuma.Text = "+";
            this.btsuma.UseVisualStyleBackColor = true;
            this.btsuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btresta
            // 
            this.btresta.Location = new System.Drawing.Point(318, 55);
            this.btresta.Name = "btresta";
            this.btresta.Size = new System.Drawing.Size(44, 23);
            this.btresta.TabIndex = 3;
            this.btresta.Text = "-";
            this.btresta.UseVisualStyleBackColor = true;
            this.btresta.Click += new System.EventHandler(this.btresta_Click);
            // 
            // btmulti
            // 
            this.btmulti.Location = new System.Drawing.Point(258, 96);
            this.btmulti.Name = "btmulti";
            this.btmulti.Size = new System.Drawing.Size(44, 23);
            this.btmulti.TabIndex = 4;
            this.btmulti.Text = "*";
            this.btmulti.UseVisualStyleBackColor = true;
            this.btmulti.Click += new System.EventHandler(this.btmulti_Click);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(318, 96);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(44, 23);
            this.btdiv.TabIndex = 5;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btmulti);
            this.Controls.Add(this.btresta);
            this.Controls.Add(this.btsuma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btsuma;
        private System.Windows.Forms.Button btresta;
        private System.Windows.Forms.Button btmulti;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Label label1;
    }
}

