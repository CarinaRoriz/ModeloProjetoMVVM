using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloProjetoMVVM.Model
{
    public class ModeloTeste
    {
        public ModeloTeste()
        {
            Descricao = "Modelo de teste recuperado.";
            DataHora = DateTime.Now;
        }

        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
    }
}
