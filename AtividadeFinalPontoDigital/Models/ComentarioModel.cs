namespace AtividadeFinalPontoDigital.Models
{
    public class ComentarioModel
    {
        public string Nome{get;set;}
        public string Comentario{get;set;}

        public ComentarioModel(string nomecomentario,string comentario)
        {
            Nome = nomecomentario;
            Comentario = comentario;
        }
    }
}