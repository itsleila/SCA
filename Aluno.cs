using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_Acadêmico_TP7
{
    internal class Aluno
    {
        public int AlunoId { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Aluno(int alunoId, string nome, int matricula)
        {
            AlunoId = alunoId;
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome do Aluno: {Nome}";
        }
    }
}
