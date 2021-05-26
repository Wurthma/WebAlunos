using System.ComponentModel.DataAnnotations;
using WebAlunos.Models;

namespace WebAlunos.ViewModels
{
        public class AlunoViewModel
        {
            [Required]
            [MaxLength(100)]
            public string Nome { get; set; }
            
            [Required]
            [MaxLength(100)]
            public string Sobrenome { get; set; }

            [Required]
            [MaxLength(11)]
            public string CPF { get; set; }

            [Required]
            [MaxLength(50)]
            public string Email { get; set; }
            
            public bool Deficiencia { get; set; }
            
            public bool NecessidadesEspeciais { get; set; }
            
            [Required]
            public string Sexo { get; set; }

            public static explicit operator AlunoViewModel(AlunoModel alunoModel)
            {
                var alunoViewModel = new AlunoViewModel();
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