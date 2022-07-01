using br.com.blastoff.Interfaces;

namespace br.com.blastoff.Model
{
    abstract class Disciplina: IDisciplinaServices
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public List<Aluno> alunos { get; set; } = new List<Aluno>();

        public void AdicionaAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void BuscaAluno()
        {
            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Curso: {aluno.Curso}");
                Console.WriteLine($"Matrícula: {aluno.Matricula}");
                Console.WriteLine("-------------------------------");
            }
        }

        public void BuscaAlunoPorId(int matricula)
        {
            foreach (Aluno aluno in alunos)
            {
                if (aluno.Matricula == matricula)
                {
                    Console.WriteLine($"Nome: {aluno.Nome}");
                    Console.WriteLine($"Curso: {aluno.Curso}");
                    Console.WriteLine($"Matrícula: {aluno.Matricula}");
                    Console.WriteLine("-------------------------------");
                }
            }
        }

        public void DeletaAluno(Aluno aluno)
        {
            alunos.Remove(aluno);
        }
    }
}
