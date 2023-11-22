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
    public partial class Form1 : Form
    {
        Clinica clinica = new Clinica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();
                paciente.setNome(txtNome.Text);
                paciente.setCPF(txtCPF.Text);
                paciente.setIdade(int.Parse(txtIdade.Text));
                paciente.setAltura(double.Parse(txtAltura.Text));

                clinica.cadastrarPaciente(paciente);

                txtMediaAlturas.Text = clinica.mediaAlturaPacientes().ToString();
                txtQtdPacientes.Text = clinica.quantidadePacientes().ToString();

                MessageBox.Show("Paciente Cadastrado com Sucesso!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um valor válido!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(clinica);
            form2.Show();
        }
    }
}
