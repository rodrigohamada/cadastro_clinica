namespace p2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPFPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtAlturaPesquisa = new System.Windows.Forms.TextBox();
            this.txtCPFPesquisa2 = new System.Windows.Forms.TextBox();
            this.txtIdadePesquisa = new System.Windows.Forms.TextBox();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtCPFPesquisa);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PESQUISAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNomePesquisa);
            this.groupBox2.Controls.Add(this.txtIdadePesquisa);
            this.groupBox2.Controls.Add(this.txtCPFPesquisa2);
            this.groupBox2.Controls.Add(this.txtAlturaPesquisa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(280, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DO PACIENTE";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 54);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDADE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ALTURA:";
            // 
            // txtCPFPesquisa
            // 
            this.txtCPFPesquisa.Location = new System.Drawing.Point(56, 54);
            this.txtCPFPesquisa.Name = "txtCPFPesquisa";
            this.txtCPFPesquisa.Size = new System.Drawing.Size(191, 26);
            this.txtCPFPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(10, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(237, 45);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtAlturaPesquisa
            // 
            this.txtAlturaPesquisa.Enabled = false;
            this.txtAlturaPesquisa.Location = new System.Drawing.Point(89, 128);
            this.txtAlturaPesquisa.Name = "txtAlturaPesquisa";
            this.txtAlturaPesquisa.Size = new System.Drawing.Size(156, 26);
            this.txtAlturaPesquisa.TabIndex = 8;
            // 
            // txtCPFPesquisa2
            // 
            this.txtCPFPesquisa2.Enabled = false;
            this.txtCPFPesquisa2.Location = new System.Drawing.Point(89, 66);
            this.txtCPFPesquisa2.Name = "txtCPFPesquisa2";
            this.txtCPFPesquisa2.Size = new System.Drawing.Size(156, 26);
            this.txtCPFPesquisa2.TabIndex = 9;
            // 
            // txtIdadePesquisa
            // 
            this.txtIdadePesquisa.Enabled = false;
            this.txtIdadePesquisa.Location = new System.Drawing.Point(89, 97);
            this.txtIdadePesquisa.Name = "txtIdadePesquisa";
            this.txtIdadePesquisa.Size = new System.Drawing.Size(156, 26);
            this.txtIdadePesquisa.TabIndex = 10;
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Enabled = false;
            this.txtNomePesquisa.Location = new System.Drawing.Point(89, 32);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(156, 26);
            this.txtNomePesquisa.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 202);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "PESQUISAR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCPFPesquisa;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.TextBox txtIdadePesquisa;
        private System.Windows.Forms.TextBox txtCPFPesquisa2;
        private System.Windows.Forms.TextBox txtAlturaPesquisa;
    }
}