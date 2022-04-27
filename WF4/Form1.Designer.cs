namespace WF4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCriarArquivo = new System.Windows.Forms.TextBox();
            this.txtRemoveArquivo = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(102, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar um arquivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(82, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Deletar um arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(88, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mover um arquivo";
            // 
            // txtCriarArquivo
            // 
            this.txtCriarArquivo.Location = new System.Drawing.Point(256, 40);
            this.txtCriarArquivo.Name = "txtCriarArquivo";
            this.txtCriarArquivo.Size = new System.Drawing.Size(373, 20);
            this.txtCriarArquivo.TabIndex = 1;
            // 
            // txtRemoveArquivo
            // 
            this.txtRemoveArquivo.Location = new System.Drawing.Point(256, 140);
            this.txtRemoveArquivo.Name = "txtRemoveArquivo";
            this.txtRemoveArquivo.Size = new System.Drawing.Size(373, 20);
            this.txtRemoveArquivo.TabIndex = 1;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(256, 309);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(373, 20);
            this.txtOrigem.TabIndex = 1;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(256, 338);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(373, 20);
            this.txtDestino.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(256, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome do arquivo de origem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(256, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome do arquivo de destino";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(635, 40);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 3;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(635, 138);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(635, 322);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 3;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.txtRemoveArquivo);
            this.Controls.Add(this.txtCriarArquivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCriarArquivo;
        private System.Windows.Forms.TextBox txtRemoveArquivo;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnMover;
    }
}

