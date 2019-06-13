namespace AtividadeFinalPontoDigital.Models
{
    public class AdminModel
    {
        public string Nome{get;set;}
        public string Email{get;set;}
        public string Senha{get;set;}
            public AdminModel(string nome, string email, string senha){
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
    }
}