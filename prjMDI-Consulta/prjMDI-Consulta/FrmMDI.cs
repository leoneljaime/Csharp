using System;
using System.Windows.Forms;

namespace prjMDI_Consulta
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void MnuCliente_Click(object sender, EventArgs e)
        {
            if (chkSingleton.Checked)
            {
                FrmCliente.Instancia.MdiParent = this;
                FrmCliente.Instancia.Show();
            }
            else
            {
                var frm = new FrmCliente();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
