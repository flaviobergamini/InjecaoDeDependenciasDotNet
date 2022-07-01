namespace br.com.blastoff.Model
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, string curso, int matricula)
        {
            Nome=nome;
            Curso=curso;
            Matricula=matricula;
        }
    }
}
