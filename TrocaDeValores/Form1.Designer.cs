namespace TrocaDeValores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntrocar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntrocar
            // 
            this.btntrocar.Location = new System.Drawing.Point(58, 139);
            this.btntrocar.Name = "btntrocar";
            this.btntrocar.Size = new System.Drawing.Size(177, 38);
            this.btntrocar.TabIndex = 0;
            this.btntrocar.Text = "TROCAR";
            this.btntrocar.UseVisualStyleBackColor = true;
            this.btntrocar.Click += new System.EventHandler(this.btntrocar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VALOR 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALOR 2:";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(135, 63);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(100, 20);
            this.txtvalor1.TabIndex = 3;
            this.txtvalor1.TextChanged += new System.EventHandler(this.txtvalor1_TextChanged);
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(135, 102);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(100, 20);
            this.txtvalor2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 375);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntrocar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Troca de Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntrocar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
    }
}

