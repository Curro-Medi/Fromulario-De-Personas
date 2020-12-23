namespace Practica1
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buscado = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonbuscar = new System.Windows.Forms.Button();
            this.busqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica1.Properties.Resources.dni1;
            this.pictureBox1.Location = new System.Drawing.Point(98, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 312);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(1036, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscado
            // 
            this.buscado.FormattingEnabled = true;
            this.buscado.ItemHeight = 16;
            this.buscado.Location = new System.Drawing.Point(572, 325);
            this.buscado.Name = "buscado";
            this.buscado.Size = new System.Drawing.Size(529, 52);
            this.buscado.TabIndex = 2;
            this.buscado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 132);
            this.label1.MinimumSize = new System.Drawing.Size(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Búsqueda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonbuscar
            // 
            this.botonbuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonbuscar.ForeColor = System.Drawing.Color.LawnGreen;
            this.botonbuscar.Location = new System.Drawing.Point(790, 221);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(97, 31);
            this.botonbuscar.TabIndex = 5;
            this.botonbuscar.Text = "Consultar";
            this.botonbuscar.UseVisualStyleBackColor = false;
            this.botonbuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // busqueda
            // 
            this.busqueda.Location = new System.Drawing.Point(719, 193);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(255, 22);
            this.busqueda.TabIndex = 6;
            this.busqueda.TextChanged += new System.EventHandler(this.busqueda_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1155, 519);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.botonbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox buscado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.TextBox busqueda;
    }
}