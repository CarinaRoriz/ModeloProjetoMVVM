using ModeloProjetoMVVM.DTO;
using ModeloProjetoMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloProjetoMVVM.ViewModel
{
    public class ViewModelTeste
    {
        public ViewModelTeste()
        {
        }

        public DTOTeste BuscarModelo()
        {
            ModeloTeste modelo = new ModeloTeste();
            return new DTOTeste { descricao = modelo.Descricao, dataHora = modelo.DataHora };
        }
    }
}
