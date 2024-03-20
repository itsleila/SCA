namespace Sistema_de_Controle_Acadêmico_TP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno(1, "Emma", 12345);
            Professor professor = new Professor(5, "GraMount", 66666);
            Disciplina disciplina = new Disciplina(77, "Java");

            Turma turma = new Turma (7897, disciplina, professor);
            turma.AddAluno (aluno);
            Console.WriteLine(turma.GerarPauta());
            if (turma.AbrirTurma())
            {
                Console.WriteLine("Turma aberta!");
            }
            else
            {
                Console.WriteLine("Não foi poossível forma uma turma");
            }




        }
    }
}
