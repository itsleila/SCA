using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_Acadêmico_TP7
{
    internal class Professor
    {
        public int ProfessorId { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Professor(int professorId, string nome, int matricula)
        {
            ProfessorId = professorId;
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome do Professor: {Nome}";
        }
    }
}
