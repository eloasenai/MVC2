﻿namespace MVC.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int RM { get; set; }

        //MODIFICAR O MÊTODO CONSTRUTOR 
        //INSERIR OS DADOS QUE VIERAM POR PARAMETROS NOS ATRIBUTOS DO OBJETO
        public Aluno(int id, string nome, string email, int rm)
        {
            this.AlunoId = id;
            this.Nome = nome;
            this.Email = email;
            this.RM = rm;

        }


    }
}
