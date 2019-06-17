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
        if(!File.Exists("Database/Comentarios.csv")){
            comentario.ID = 1;
        }else{
            comentario.ID = File.ReadAllLines("Database/Comentarios.csv").Length+1;
        }
        StreamWriter sw = new StreamWriter("Database/Comentarios.csv",true);
        sw.WriteLine($"{comentario.ID}{comentario.Nome};{comentario.Comentario}");
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
                    id: int.Parse(lin[0]),
                    nomecomentario: lin[1],
                    comentario: lin[2]
                );
                listaDeComentarios.Add(comentario);
            }
            return listaDeComentarios;
        }
        public ComentarioModel Aprovar (ComentarioModel comentario){
            string [] linhas = File.ReadAllLines("Database/Comentarios.csv");
            for(int i = 0; i < linhas.Length; i++){
                string[]linha = linhas[i].Split(";");
                if(comentario.ID == int.Parse(linha[0])){
                    linhas[i] = $"{comentario.ID}{comentario.Nome};{comentario.Comentario};Aprovado";
                }
            }
            File.WriteAllLines("Database/ComentariosAprovados.csv", linhas);
            return comentario;
        }
            public ComentarioModel Reprovar (ComentarioModel comentario){
            string [] linhas = File.ReadAllLines("Database/Comentarios.csv");
            for(int i = 0; i < linhas.Length; i++){
                string[]linha = linhas[i].Split(";");
                if(comentario.Nome == linha[0]){
                    linhas[i] = $"{comentario.Nome};{comentario.Comentario};Reprovado";
                }
            }
            File.WriteAllLines("Database/Comentarios.csv", linhas);
            return comentario;
        }
            public ComentarioModel BuscarPorNome(int id) {
            string[] linhas = File.ReadAllLines("Database/Comentarios.csv");

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                if (id.Equals(linha[0]))
                {
                    ComentarioModel comentario= new ComentarioModel();
                    comentario.ID = int.Parse(linha[0]);
                    comentario.Nome = linha[1];
                    comentario.Comentario = linha[2];

                    return comentario;
                }
            }
            return null;
        }
            public List<ComentarioModel> ListarAprovados(){
            List<ComentarioModel> listaDeComentariosAprovados = new List<ComentarioModel>();
            string[] line = File.ReadAllLines("Database/ComentariosAprovados.csv");
            ComentarioModel comentario;

            foreach (var item in line)
            {
                string[] lin = item.Split(";");
                
                comentario = new ComentarioModel(
                    id: int.Parse(lin[0]),
                    nomecomentario: lin[1],
                    comentario: lin[2]
                );
                listaDeComentariosAprovados.Add(comentario);
            }
            return listaDeComentariosAprovados;
        }
    }
}