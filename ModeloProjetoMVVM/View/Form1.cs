using ModeloProjetoMVVM.DTO;
using ModeloProjetoMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloProjetoMVVM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Requisição realizada pela View");

            ViewModelTeste viewModel = new ViewModelTeste();

            MessageBox.Show("Requisição realizada na ViewModel pela View");
            DTOTeste dto = viewModel.BuscarModelo();

            MessageBox.Show("Requisição realizada na Model pela ViewModel");

            this.textBox1.Text = dto.descricao;
            this.textBox2.Text = dto.dataHora.ToShortDateString();

        }

    }
}
