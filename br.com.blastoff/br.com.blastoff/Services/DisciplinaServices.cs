using br.com.blastoff.Interfaces;
using br.com.blastoff.Model;

namespace br.com.blastoff.Services
{
    public class DisciplinaServices
    {
        private IDisciplinaServices _disciplinaServices;
        public DisciplinaServices(IDisciplinaServices disciplinaServices)
        {
            _disciplinaServices=disciplinaServices;
        }

        public void ListaAluno()
        {
            _disciplinaServices.BuscaAluno();
        }

        public void AdicionaAlunos(Aluno aluno)
        {
            _disciplinaServices.AdicionaAluno(aluno);
        }

        public void ListaAlunoPorMatricula(int matricula)
        {
            _disciplinaServices.BuscaAlunoPorId(matricula);
        }

        public void ExcluiAluno(Aluno aluno)
        {
            _disciplinaServices.DeletaAluno(aluno);
        }
    }
}
