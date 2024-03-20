using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Controle_Acadêmico_TP7
{
    internal class Turma
    {
        public int Codigo { get; set; } 
        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma(int codigo, Disciplina disciplina, Professor professor)
        {
            Codigo = codigo;
            Professor = professor;
            Disciplina = disciplina;
            Alunos = new List<Aluno>();
        }

        public string AddAluno(Aluno aluno)
        {
            if (Alunos.Count < 50)
            {
                Alunos.Add(aluno);
                return "Aluno adicionado com sucesso!";
            }
            else
            {
                return "Aluno não adcionado. A turma esta cheia!";
            }
        }


        public bool AbrirTurma()
        {
            if (Alunos.Count >= 10 && Alunos.Count <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public override string ToString() 
        {
            string alunosInscritos = "";
            foreach (var aluno in Alunos)
            {
                alunosInscritos += $"- {aluno.Nome} (Matrícula: {aluno.Matricula})\n";
            }
            return $"Código da Turma: {Codigo}\nDisciplina: {Disciplina.Nome}\nProfessor: {Professor.Nome}\nAlunos:\n{alunosInscritos}";
        }  
        
        public string GerarPauta()
        {
            return ToString();
        }


    }
}
