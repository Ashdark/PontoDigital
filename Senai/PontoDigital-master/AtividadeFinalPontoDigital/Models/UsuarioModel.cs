using System;

namespace AtividadeFinalPontoDigital.Models
{
    public class UsuarioModel
    {
        public UsuarioModel(string nome, string email, DateTime dataNascimento, string senha, int id, string plano)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Senha = senha;
            Id = id;
            Plano = plano;
        }
        public UsuarioModel(string nome, string email, string senha, DateTime dataNascimento, string plano){
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
            this.Plano = plano;
        }
        public UsuarioModel(string email, string senha){
            this.Senha = senha;
            this.Email = email;
        }

        public string Nome{get;set;}
       public string Email{get;set;}
       public string Senha{get;set;} 
       public int Id{get;set;}
       public DateTime DataNascimento{get;set;}
       public string Plano{get;set;}
    }
}