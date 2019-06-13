using System;
using System.Collections.Generic;
using System.IO;
using AtividadeFinalPontoDigital.Models;

namespace AtividadeFinalPontoDigital.Repositorio
{
    public class ComentarioRepositorio
    {
        public ComentarioModel Cadastrar(ComentarioModel comentario){
        Console.WriteLine("Nome:"+comentario.Nome);
        System.Console.WriteLine("comentário:"+comentario.Comentario);
        StreamWriter sw = new StreamWriter("Database/Comentarios.csv",true);
        sw.WriteLine($"{comentario.Nome};{comentario.Comentario}");
        sw.Close();
        return comentario;
        }
            public List<ComentarioModel> Listar(){
            List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();
            string[] line = File.ReadAllLines("Database/Comentarios.csv");
            ComentarioModel comentario;

            foreach (var item in line)
            {
                string[] lin = item.Split(";");
                
                comentario = new ComentarioModel(
                    nomecomentario: lin[0],
                    comentario: lin[1]
                );
                listaDeComentarios.Add(comentario);
            }
            return listaDeComentarios;
        }
    }
}