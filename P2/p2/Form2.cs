using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    public partial class Form2 : Form
    {
        Clinica clinica;
        public Form2(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Paciente paciente = clinica.pesquisarPaciente(txtCPFPesquisa.Text);

            if (paciente != null)
            {
                txtNomePesquisa.Text = paciente.getNome();
                txtCPFPesquisa2.Text = paciente.getCPF();
                txtIdadePesquisa.Text = paciente.getIdade().ToString();
                txtAlturaPesquisa.Text = paciente.getAltura().ToString();
            }
            else
            {
                MessageBox.Show("Paciente não Encontrado!");
            }
        }
    }
}
