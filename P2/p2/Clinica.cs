using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    public class Clinica
    {
        private List<Paciente> lista_pacientes;

        public Clinica()
        {
            this.lista_pacientes = new List<Paciente>();
        }

        public void cadastrarPaciente(Paciente paciente)
        {
            this.lista_pacientes.Add(paciente);
        }

        public Paciente pesquisarPaciente(string cpf)
        {
            foreach (Paciente paciente in this.lista_pacientes)
            {
                if (paciente.getCPF().Equals(cpf))
                    return paciente;
            }
            return null;
        }

        public int quantidadePacientes()
        {
            return this.lista_pacientes.Count;
        }

        public double mediaAlturaPacientes()
        {
            double somaAlturas = 0.0;
            foreach (Paciente paciente in this.lista_pacientes)
            {
                somaAlturas += paciente.getAltura();
            }
            return somaAlturas / this.lista_pacientes.Count;
        }
    }
}
