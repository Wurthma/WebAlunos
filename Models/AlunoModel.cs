using WebAlunos.ViewModels;

namespace WebAlunos.Models
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public bool Deficiencia { get; set; }
        public bool NecessidadesEspeciais { get; set; }
        public string Sexo { get; set; }

        public static explicit operator AlunoModel(AlunoViewModel alunoModel)
        {
            var alunoViewModel = new AlunoModel();
            {
                alunoViewModel.Nome = alunoModel.Nome;
                alunoViewModel.Sobrenome = alunoModel.Sobrenome;
                alunoViewModel.CPF = alunoModel.CPF;
                alunoViewModel.Email = alunoModel.Email;
                alunoViewModel.Deficiencia = alunoModel.Deficiencia;
                alunoViewModel.NecessidadesEspeciais = alunoModel.NecessidadesEspeciais;
                alunoViewModel.Sexo = alunoModel.Sexo;
            };
            return alunoViewModel;
        }
    }
}