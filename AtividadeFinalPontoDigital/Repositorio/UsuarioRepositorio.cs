using System;
using System.Collections.Generic;
using System.IO;
using AtividadeFinalPontoDigital.Models;

namespace AtividadeFinalPontoDigital.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioModel CadastrarUsuario(UsuarioModel usuario){
            if(File.Exists("Database/Usuarios.csv")){
                usuario.Id = File.ReadAllLines("Database/Usuarios.csv").Length+1;
            }else{
                usuario.Id = 1;
            }
        StreamWriter sw = new StreamWriter("Database/Usuarios.csv",true);
        sw.WriteLine($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Id};{usuario.DataNascimento};{usuario.Plano}");
        sw.Close();
        return usuario;
        }
            public List<UsuarioModel> Listar(){
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
            string[] linhas = File.ReadAllLines("Database/Usuarios.csv");
            UsuarioModel usuario;

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    //sair do foreach
                    continue;
                }
                string[] linha = item.Split(";");
                
                usuario = new UsuarioModel(
                    nome: linha[0],
                    email: linha[1],
                    senha: linha[2],
                    id: int.Parse(linha[3]),
                    dataNascimento: DateTime.Parse(linha[4]),
                    plano: linha[5]
                    
                );
                listaDeUsuarios.Add(usuario);
            }
            return listaDeUsuarios;
        }
        public bool BuscarUsuario(string email,string senha){
             List<UsuarioModel> listaDeUsuarios = Listar();

             foreach (var item in listaDeUsuarios)
             {
                 if (email == item.Email && senha == item.Senha)
                 {
                     return true;//Retorna o usuario
                 }
             }
             return false;
        }
            public List<AdminModel> ListarAdministradores(){
            List<AdminModel> listaDeAdministradores = new List<AdminModel>();
            string[] lines = File.ReadAllLines("Database/Admins.csv");
            AdminModel admin;

            foreach (var item in lines)
            {
                if (string.IsNullOrEmpty(item))
                {
                    //sair do foreach
                    continue;
                }
                string[] linha = item.Split(";");
                
                admin = new AdminModel(
                    nome: linha[0],
                    email: linha[1],
                    senha: linha[2]            
                );
                listaDeAdministradores.Add(admin);
            }
            return listaDeAdministradores;
        }
            public bool BuscarAdministrador(string email,string senha){
             List<AdminModel> listaDeAdministradores = ListarAdministradores();

             foreach (var item in listaDeAdministradores)
             {
                 if (email == item.Email && senha == item.Senha)
                 {
                     return true;//Retorna o usuario
                 }
             }
             return false;
        }
    }
}