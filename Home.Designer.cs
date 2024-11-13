namespace AranaStorage
{
    partial class Home
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
            this.estoqueBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTxb = new System.Windows.Forms.TextBox();
            this.senhaTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estoqueAdmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // estoqueBtn
            // 
            this.estoqueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueBtn.Location = new System.Drawing.Point(270, 219);
            this.estoqueBtn.Name = "estoqueBtn";
            this.estoqueBtn.Size = new System.Drawing.Size(142, 49);
            this.estoqueBtn.TabIndex = 0;
            this.estoqueBtn.Text = "Estoque";
            this.estoqueBtn.UseVisualStyleBackColor = true;
            this.estoqueBtn.Click += new System.EventHandler(this.estoqueBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecraft", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "ARANA TECH";
            // 
            // loginTxb
            // 
            this.loginTxb.Location = new System.Drawing.Point(154, 294);
            this.loginTxb.Name = "loginTxb";
            this.loginTxb.Size = new System.Drawing.Size(420, 20);
            this.loginTxb.TabIndex = 4;
            // 
            // senhaTxb
            // 
            this.senhaTxb.Location = new System.Drawing.Point(154, 338);
            this.senhaTxb.Name = "senhaTxb";
            this.senhaTxb.Size = new System.Drawing.Size(420, 20);
            this.senhaTxb.TabIndex = 5;
            this.senhaTxb.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minecraft", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(81, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minecraft", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(81, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // estoqueAdmBtn
            // 
            this.estoqueAdmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueAdmBtn.Location = new System.Drawing.Point(409, 368);
            this.estoqueAdmBtn.Name = "estoqueAdmBtn";
            this.estoqueAdmBtn.Size = new System.Drawing.Size(165, 31);
            this.estoqueAdmBtn.TabIndex = 8;
            this.estoqueAdmBtn.Text = "Gerenciar Estoque";
            this.estoqueAdmBtn.UseVisualStyleBackColor = true;
            this.estoqueAdmBtn.Click += new System.EventHandler(this.estoqueAdmBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::AranaStorage.Properties.Resources.AranaHome2_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 480);
            this.Controls.Add(this.estoqueAdmBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.senhaTxb);
            this.Controls.Add(this.loginTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estoqueBtn);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button estoqueBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTxb;
        private System.Windows.Forms.TextBox senhaTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button estoqueAdmBtn;
    }
}

