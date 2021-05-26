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
    }
}