using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ihelp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmChamado chamado = new frmChamado();
            chamado.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
