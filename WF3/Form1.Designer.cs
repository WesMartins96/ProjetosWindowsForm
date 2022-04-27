namespace WF3
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
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(55, 75);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(178, 27);
            this.txtNumberOne.TabIndex = 0;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(55, 108);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(178, 27);
            this.txtNumberTwo.TabIndex = 0;
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.ForeColor = System.Drawing.Color.Blue;
            this.btnMenos.Location = new System.Drawing.Point(55, 176);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(37, 32);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.White;
            this.btnMais.ForeColor = System.Drawing.Color.Blue;
            this.btnMais.Location = new System.Drawing.Point(98, 176);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(37, 32);
            this.btnMais.TabIndex = 1;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.White;
            this.btnMulti.ForeColor = System.Drawing.Color.Blue;
            this.btnMulti.Location = new System.Drawing.Point(153, 176);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(37, 32);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.White;
            this.btnDiv.ForeColor = System.Drawing.Color.Blue;
            this.btnDiv.Location = new System.Drawing.Point(196, 176);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(37, 32);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(55, 261);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(178, 27);
            this.txtResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(288, 383);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txtResult;
    }
}

