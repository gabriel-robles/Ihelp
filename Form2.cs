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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iHELPDataSet);

        }

        private void uSUARIOSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iHELPDataSet);

        }

        private void uSUARIOSBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iHELPDataSet);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'iHELPDataSet.USUARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.uSUARIOSTableAdapter.Fill(this.iHELPDataSet.USUARIOS);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
