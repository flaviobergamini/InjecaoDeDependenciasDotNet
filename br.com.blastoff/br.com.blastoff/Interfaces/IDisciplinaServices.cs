using br.com.blastoff.Model;

namespace br.com.blastoff.Interfaces
{
    public interface IDisciplinaServices
    {
        public void BuscaAluno();
        public void BuscaAlunoPorId(int matricula);
        public void AdicionaAluno(Aluno aluno);
        public void DeletaAluno(Aluno aluno);
    }
}
