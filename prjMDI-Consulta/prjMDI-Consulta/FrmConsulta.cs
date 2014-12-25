using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prjMDI_Consulta
{
    public partial class FrmConsulta : Form
    {
        private List<Cliente>  _clientes = new List<Cliente>();

        public FrmConsulta()
        {
            InitializeComponent();

            Load += FrmConsulta_Load;
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            listBoxCliente.DataSource = _clientes = new List<Cliente>
            {
                new Cliente("Leonel Jaime"),
                new Cliente("Maria"),
                new Cliente("Pedro"),
                new Cliente("Matheus"),
                new Cliente("Paulo"),
                new Cliente("Carlos"),
                new Cliente("Henrique")
            };
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            listBoxCliente.DataSource = _clientes.Where(x => x.Nome.Contains(txtConsulta.Text)).ToList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Tag = listBoxCliente.Text;
            Close();
        }
    }
}
