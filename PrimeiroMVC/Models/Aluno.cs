namespace PrimeiroMVC.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int RM { get; set; }


        //modificar o metodo construtor
        //inserir os dados que vieram por parametros nos 
        //atributos do objeto

        public Aluno(int id, string nome, string email, int rm)
        {
            this.AlunoId = id;
            this.Nome = nome;
            this.Email = email;
            this.RM = rm;
        }
    }
}
