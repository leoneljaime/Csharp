using System;
using System.Windows.Forms;

namespace prjMDI_Consulta
{
    public partial class FrmCliente : Form
    {
        private static FrmCliente _instancia = null;

        public static FrmCliente Instancia
        {
            get { return _instancia ?? (_instancia = new FrmCliente()); }
        }


        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var frm = new FrmConsulta();
            frm.FormClosed += frm_FormClosed;
            Hide();
            frm.Show();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var f = sender as Form;
            if (f != null)
                lblCliente.Text = f.Tag.ToString();
            
            Show();
        }
    }
}
