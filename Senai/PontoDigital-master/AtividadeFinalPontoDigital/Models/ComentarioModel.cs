namespace AtividadeFinalPontoDigital.Models
{
    public class ComentarioModel
    {
        public string Nome{get;set;}
        public string Comentario{get;set;}
        public int ID{get;set;}

        public ComentarioModel(string nomecomentario,string comentario)
        {
            Nome = nomecomentario;
            Comentario = comentario;
        }

        public ComentarioModel(string nomecomentario,string comentario,int id)
        {
            Nome = nomecomentario;
            Comentario = comentario;
            ID = id;
        }

        public ComentarioModel()
        {
        }
    }
}