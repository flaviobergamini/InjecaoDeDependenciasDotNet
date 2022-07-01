using br.com.blastoff.Model;
using br.com.blastoff.Model.Disciplinas;
using br.com.blastoff.Services;

namespace br.com.blastoff
{
    public class Progam
    {
        public static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Flavio", "Eng Computação", 1450);
            Aluno aluno2 = new Aluno("Pamela", "Eng Computação", 3000);

            Algoritmos algoritmos = new Algoritmos();
            BancoDeDados bancoDeDados = new BancoDeDados();

            DisciplinaServices disciplinaServices1 = new DisciplinaServices(algoritmos);
            DisciplinaServices disciplinaServices2 = new DisciplinaServices(bancoDeDados);


            disciplinaServices1.ListaAluno();
            disciplinaServices1.AdicionaAlunos(aluno1);
            disciplinaServices1.AdicionaAlunos(aluno2);
            Console.WriteLine("\nListando aluno por matrícula\n");
            disciplinaServices1.ListaAlunoPorMatricula(3000);
            Console.WriteLine("\nListando todos os alunos\n");
            disciplinaServices1.ListaAluno();
            Console.WriteLine("\nExcluindo aluno\n");
            disciplinaServices1.ExcluiAluno(aluno1);
            disciplinaServices1.ListaAluno();

            Console.WriteLine("#######################################################################");

            Aluno aluno3 = new Aluno("Rafaela", "Eng Computação", 1451);
            Aluno aluno4 = new Aluno("Leticia", "Eng Computação", 3001);


            disciplinaServices2.ListaAluno();
            disciplinaServices2.AdicionaAlunos(aluno3);
            disciplinaServices2.AdicionaAlunos(aluno4);
            Console.WriteLine("\nListando aluno por matrícula\n");
            disciplinaServices2.ListaAlunoPorMatricula(3001);
            Console.WriteLine("\nListando todos os alunos\n");
            disciplinaServices2.ListaAluno();
            Console.WriteLine("\nExcluindo aluno\n");
            disciplinaServices2.ExcluiAluno(aluno3);
            disciplinaServices2.ListaAluno();

        }
    }
}