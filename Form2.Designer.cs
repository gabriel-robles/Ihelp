
namespace Ihelp
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            System.Windows.Forms.Label uSUARIO_IDLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label eMAILLabel;
            this.iHELPDataSet = new Ihelp.IHELPDataSet();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new Ihelp.IHELPDataSetTableAdapters.USUARIOSTableAdapter();
            this.tableAdapterManager = new Ihelp.IHELPDataSetTableAdapters.TableAdapterManager();
            this.uSUARIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uSUARIOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uSUARIO_IDLabel1 = new System.Windows.Forms.Label();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            uSUARIO_IDLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iHELPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingNavigator)).BeginInit();
            this.uSUARIOSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iHELPDataSet
            // 
            this.iHELPDataSet.DataSetName = "IHELPDataSet";
            this.iHELPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.iHELPDataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHAMADOSTableAdapter = null;
            this.tableAdapterManager.SISTEMASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ihelp.IHELPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = this.uSUARIOSTableAdapter;
            // 
            // uSUARIOSBindingNavigator
            // 
            this.uSUARIOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uSUARIOSBindingNavigator.BindingSource = this.uSUARIOSBindingSource;
            this.uSUARIOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uSUARIOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uSUARIOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uSUARIOSBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.uSUARIOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uSUARIOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uSUARIOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uSUARIOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uSUARIOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uSUARIOSBindingNavigator.Name = "uSUARIOSBindingNavigator";
            this.uSUARIOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uSUARIOSBindingNavigator.Size = new System.Drawing.Size(752, 25);
            this.uSUARIOSBindingNavigator.TabIndex = 0;
            this.uSUARIOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // uSUARIOSBindingNavigatorSaveItem
            // 
            this.uSUARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uSUARIOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uSUARIOSBindingNavigatorSaveItem.Image")));
            this.uSUARIOSBindingNavigatorSaveItem.Name = "uSUARIOSBindingNavigatorSaveItem";
            this.uSUARIOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uSUARIOSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.uSUARIOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.uSUARIOSBindingNavigatorSaveItem_Click_2);
            // 
            // uSUARIO_IDLabel
            // 
            uSUARIO_IDLabel.AutoSize = true;
            uSUARIO_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uSUARIO_IDLabel.Location = new System.Drawing.Point(27, 50);
            uSUARIO_IDLabel.Name = "uSUARIO_IDLabel";
            uSUARIO_IDLabel.Size = new System.Drawing.Size(149, 16);
            uSUARIO_IDLabel.TabIndex = 1;
            uSUARIO_IDLabel.Text = "Código do usuário :";
            // 
            // uSUARIO_IDLabel1
            // 
            this.uSUARIO_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "USUARIO_ID", true));
            this.uSUARIO_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUARIO_IDLabel1.Location = new System.Drawing.Point(177, 50);
            this.uSUARIO_IDLabel1.Name = "uSUARIO_IDLabel1";
            this.uSUARIO_IDLabel1.Size = new System.Drawing.Size(100, 23);
            this.uSUARIO_IDLabel1.TabIndex = 2;
            this.uSUARIO_IDLabel1.Text = "label1";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(27, 79);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(60, 16);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "Nome :";
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "NOME", true));
            this.nOMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOMETextBox.Location = new System.Drawing.Point(94, 77);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(216, 22);
            this.nOMETextBox.TabIndex = 4;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(27, 105);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(58, 16);
            eMAILLabel.TabIndex = 5;
            eMAILLabel.Text = "Email :";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "EMAIL", true));
            this.eMAILTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMAILTextBox.Location = new System.Drawing.Point(95, 105);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(215, 22);
            this.eMAILTextBox.TabIndex = 6;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Fechar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(752, 290);
            this.Controls.Add(uSUARIO_IDLabel);
            this.Controls.Add(this.uSUARIO_IDLabel1);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(this.uSUARIOSBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.Text = "Cadastro de Usuários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iHELPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingNavigator)).EndInit();
            this.uSUARIOSBindingNavigator.ResumeLayout(false);
            this.uSUARIOSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IHELPDataSet iHELPDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private IHELPDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private IHELPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uSUARIOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uSUARIOSBindingNavigatorSaveItem;
        private System.Windows.Forms.Label uSUARIO_IDLabel1;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}