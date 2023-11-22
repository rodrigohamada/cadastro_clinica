namespace p2
{
    partial class Form1
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
            this.btnAdicionarPaciente = new System.Windows.Forms.Button();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMediaAlturas = new System.Windows.Forms.TextBox();
            this.txtQtdPacientes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnAdicionarPaciente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADICIONAR PACIENTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQtdPacientes);
            this.groupBox2.Controls.Add(this.txtMediaAlturas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(315, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RELATÓRIO";
            // 
            // btnAdicionarPaciente
            // 
            this.btnAdicionarPaciente.Location = new System.Drawing.Point(11, 178);
            this.btnAdicionarPaciente.Name = "btnAdicionarPaciente";
            this.btnAdicionarPaciente.Size = new System.Drawing.Size(269, 44);
            this.btnAdicionarPaciente.TabIndex = 0;
            this.btnAdicionarPaciente.Text = "ADICIONAR PACIENTE";
            this.btnAdicionarPaciente.UseVisualStyleBackColor = true;
            this.btnAdicionarPaciente.Click += new System.EventHandler(this.btnAdicionarPaciente_Click);
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(35, 272);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(246, 49);
            this.btnPesquisarPaciente.TabIndex = 1;
            this.btnPesquisarPaciente.Text = "PESQUISAR PACIENTE";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(90, 68);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(190, 26);
            this.txtCPF.TabIndex = 2;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(90, 100);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(190, 26);
            this.txtIdade.TabIndex = 3;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(90, 132);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(190, 26);
            this.txtAltura.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "NOME:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(7, 68);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(7, 100);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(64, 20);
            this.lblIdade.TabIndex = 7;
            this.lblIdade.Text = "IDADE:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(7, 132);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(77, 20);
            this.lblAltura.TabIndex = 8;
            this.lblAltura.Text = "ALTURA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÉDIA DAS ALTURAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "QTD. DE PACIENTES:";
            // 
            // txtMediaAlturas
            // 
            this.txtMediaAlturas.Enabled = false;
            this.txtMediaAlturas.Location = new System.Drawing.Point(11, 109);
            this.txtMediaAlturas.Name = "txtMediaAlturas";
            this.txtMediaAlturas.Size = new System.Drawing.Size(177, 26);
            this.txtMediaAlturas.TabIndex = 2;
            // 
            // txtQtdPacientes
            // 
            this.txtQtdPacientes.Enabled = false;
            this.txtQtdPacientes.Location = new System.Drawing.Point(10, 190);
            this.txtQtdPacientes.Name = "txtQtdPacientes";
            this.txtQtdPacientes.Size = new System.Drawing.Size(177, 26);
            this.txtQtdPacientes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 332);
            this.Controls.Add(this.btnPesquisarPaciente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CLÍNICA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionarPaciente;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.TextBox txtQtdPacientes;
        private System.Windows.Forms.TextBox txtMediaAlturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

