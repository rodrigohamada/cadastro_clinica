using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    public class Paciente
    {
        private string nome;
        private string cpf;
        private int idade;
        private double altura;

        public Paciente()
        {
            this.nome = "Desconhecido";
            this.cpf = "Desconhecido";
            this.idade = 0;
            this.altura = 0.0;
        }

        public string getNome() { return this.nome; }
        public string getCPF() { return this.cpf; }
        public int getIdade() { return this.idade; }
        public double getAltura() { return this.altura; }

        public void setNome(string nome) 
        { this.nome = nome; }
        public void setCPF(string cpf) 
        { this.cpf = cpf; }

        public void setIdade(int idade)
        {
            if (idade < 5 || idade > 59)
                throw new ArgumentException("Idade Inválida!!!");
            this.idade = idade;
        }

        public void setAltura(double altura)
        {
            if (altura < 0.15 || altura > 2.6)
                throw new ArgumentException("Altura Inválida!!!");
            this.altura = altura;
        }
    }
}
