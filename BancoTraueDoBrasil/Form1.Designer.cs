namespace BancoTraueDoBrasil
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
            this.lbMensagem = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.textSaque = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lbNomeBanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbMensagem.ForeColor = System.Drawing.Color.Navy;
            this.lbMensagem.Location = new System.Drawing.Point(12, 91);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(217, 17);
            this.lbMensagem.TabIndex = 0;
            this.lbMensagem.Text = "Insira o valor a ser sacado";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbResultado.ForeColor = System.Drawing.Color.Navy;
            this.lbResultado.Location = new System.Drawing.Point(12, 267);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 14);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Visible = false;
            // 
            // textSaque
            // 
            this.textSaque.BackColor = System.Drawing.Color.Beige;
            this.textSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSaque.Location = new System.Drawing.Point(61, 138);
            this.textSaque.Name = "textSaque";
            this.textSaque.Size = new System.Drawing.Size(124, 20);
            this.textSaque.TabIndex = 2;
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Navy;
            this.btnSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacar.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSacar.ForeColor = System.Drawing.Color.Gold;
            this.btnSacar.Location = new System.Drawing.Point(61, 201);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(124, 38);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lbNomeBanco
            // 
            this.lbNomeBanco.AutoSize = true;
            this.lbNomeBanco.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeBanco.ForeColor = System.Drawing.Color.Navy;
            this.lbNomeBanco.Location = new System.Drawing.Point(79, 28);
            this.lbNomeBanco.Name = "lbNomeBanco";
            this.lbNomeBanco.Size = new System.Drawing.Size(77, 34);
            this.lbNomeBanco.TabIndex = 4;
            this.lbNomeBanco.Text = "BTB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(256, 402);
            this.Controls.Add(this.lbNomeBanco);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.textSaque);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbMensagem);
            this.Name = "Form1";
            this.Text = "Banco Traue do Brasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox textSaque;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lbNomeBanco;
    }
}

