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
    public partial class frmChamado : Form
    {
        public frmChamado()
        {
            InitializeComponent();
        }

        private void cHAMADOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHAMADOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iHELPDataSet);

        }

        private void frmChamado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'iHELPDataSet.SISTEMAS'. Você pode movê-la ou removê-la conforme necessário.
            this.sISTEMASTableAdapter.Fill(this.iHELPDataSet.SISTEMAS);
            // TODO: esta linha de código carrega dados na tabela 'iHELPDataSet.USUARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.uSUARIOSTableAdapter.Fill(this.iHELPDataSet.USUARIOS);
            // TODO: esta linha de código carrega dados na tabela 'iHELPDataSet.CHAMADOS'. Você pode movê-la ou removê-la conforme necessário.
            this.cHAMADOSTableAdapter.Fill(this.iHELPDataSet.CHAMADOS);

        }

        private void uSUARIO_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void cHAMADO_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void cHAMADO_IDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uSUARIO_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sISTEMA_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void sISTEMA_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oBSERVACOESLabel_Click(object sender, EventArgs e)
        {

        }

        private void oBSERVACOESTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
