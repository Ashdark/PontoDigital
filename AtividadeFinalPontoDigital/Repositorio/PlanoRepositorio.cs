using System.Collections.Generic;
using System.IO;
using AtividadeFinalPontoDigital.Models;

namespace AtividadeFinalPontoDigital.Repositorio
{
    public class PlanoRepositorio
    {
                private const string PATH = "Database/Planos.csv";
                public List<PlanoModel> Planos = new List<PlanoModel>();
            public List<PlanoModel> Listar(){
            var registros = File.ReadAllLines(PATH);
            foreach(var item in registros){
                var valores = item.Split(";");
                PlanoModel plano = new PlanoModel();
                plano.Nome = valores[1];
                this.Planos.Add(plano);
            }
            return this.Planos;
        }
    }
}