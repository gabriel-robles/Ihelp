
namespace Ihelp
{
    partial class frmChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamado));
            System.Windows.Forms.Label cHAMADO_IDLabel;
            System.Windows.Forms.Label uSUARIO_IDLabel;
            System.Windows.Forms.Label sISTEMA_IDLabel;
            System.Windows.Forms.Label oBSERVACOESLabel;
            this.iHELPDataSet = new Ihelp.IHELPDataSet();
            this.cHAMADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHAMADOSTableAdapter = new Ihelp.IHELPDataSetTableAdapters.CHAMADOSTableAdapter();
            this.tableAdapterManager = new Ihelp.IHELPDataSetTableAdapters.TableAdapterManager();
            this.cHAMADOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cHAMADOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cHAMADO_IDLabel1 = new System.Windows.Forms.Label();
            this.uSUARIO_IDComboBox = new System.Windows.Forms.ComboBox();
            this.sISTEMA_IDComboBox = new System.Windows.Forms.ComboBox();
            this.oBSERVACOESTextBox = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new Ihelp.IHELPDataSetTableAdapters.USUARIOSTableAdapter();
            this.sISTEMASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMASTableAdapter = new Ihelp.IHELPDataSetTableAdapters.SISTEMASTableAdapter();
            cHAMADO_IDLabel = new System.Windows.Forms.Label();
            uSUARIO_IDLabel = new System.Windows.Forms.Label();
            sISTEMA_IDLabel = new System.Windows.Forms.Label();
            oBSERVACOESLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iHELPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMADOSBindingNavigator)).BeginInit();
            this.cHAMADOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iHELPDataSet
            // 
            this.iHELPDataSet.DataSetName = "IHELPDataSet";
            this.iHELPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHAMADOSBindingSource
            // 
            this.cHAMADOSBindingSource.DataMember = "CHAMADOS";
            this.cHAMADOSBindingSource.DataSource = this.iHELPDataSet;
            // 
            // cHAMADOSTableAdapter
            // 
            this.cHAMADOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHAMADOSTableAdapter = this.cHAMADOSTableAdapter;
            this.tableAdapterManager.SISTEMASTableAdapter = this.sISTEMASTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ihelp.IHELPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = this.uSUARIOSTableAdapter;
            // 
            // cHAMADOSBindingNavigator
            // 
            this.cHAMADOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cHAMADOSBindingNavigator.BindingSource = this.cHAMADOSBindingSource;
            this.cHAMADOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cHAMADOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cHAMADOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cHAMADOSBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.cHAMADOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cHAMADOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cHAMADOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cHAMADOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cHAMADOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cHAMADOSBindingNavigator.Name = "cHAMADOSBindingNavigator";
            this.cHAMADOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cHAMADOSBindingNavigator.Size = new System.Drawing.Size(730, 25);
            this.cHAMADOSBindingNavigator.TabIndex = 0;
            this.cHAMADOSBindingNavigator.Text = "bindingNavigator1";
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
            // cHAMADOSBindingNavigatorSaveItem
            // 
            this.cHAMADOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cHAMADOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cHAMADOSBindingNavigatorSaveItem.Image")));
            this.cHAMADOSBindingNavigatorSaveItem.Name = "cHAMADOSBindingNavigatorSaveItem";
            this.cHAMADOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cHAMADOSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cHAMADOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cHAMADOSBindingNavigatorSaveItem_Click);
            // 
            // cHAMADO_IDLabel
            // 
            cHAMADO_IDLabel.AutoSize = true;
            cHAMADO_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cHAMADO_IDLabel.Location = new System.Drawing.Point(29, 59);
            cHAMADO_IDLabel.Name = "cHAMADO_IDLabel";
            cHAMADO_IDLabel.Size = new System.Drawing.Size(162, 16);
            cHAMADO_IDLabel.TabIndex = 1;
            cHAMADO_IDLabel.Text = "Código do chamado :";
            cHAMADO_IDLabel.Click += new System.EventHandler(this.cHAMADO_IDLabel_Click);
            // 
            // cHAMADO_IDLabel1
            // 
            this.cHAMADO_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHAMADOSBindingSource, "CHAMADO_ID", true));
            this.cHAMADO_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHAMADO_IDLabel1.Location = new System.Drawing.Point(193, 59);
            this.cHAMADO_IDLabel1.Name = "cHAMADO_IDLabel1";
            this.cHAMADO_IDLabel1.Size = new System.Drawing.Size(121, 23);
            this.cHAMADO_IDLabel1.TabIndex = 2;
            this.cHAMADO_IDLabel1.Text = "label1";
            this.cHAMADO_IDLabel1.Click += new System.EventHandler(this.cHAMADO_IDLabel1_Click);
            // 
            // uSUARIO_IDLabel
            // 
            uSUARIO_IDLabel.AutoSize = true;
            uSUARIO_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uSUARIO_IDLabel.Location = new System.Drawing.Point(29, 88);
            uSUARIO_IDLabel.Name = "uSUARIO_IDLabel";
            uSUARIO_IDLabel.Size = new System.Drawing.Size(161, 16);
            uSUARIO_IDLabel.TabIndex = 3;
            uSUARIO_IDLabel.Text = "Email do requerente :";
            uSUARIO_IDLabel.Click += new System.EventHandler(this.uSUARIO_IDLabel_Click);
            // 
            // uSUARIO_IDComboBox
            // 
            this.uSUARIO_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cHAMADOSBindingSource, "USUARIO_ID", true));
            this.uSUARIO_IDComboBox.DataSource = this.uSUARIOSBindingSource;
            this.uSUARIO_IDComboBox.DisplayMember = "EMAIL";
            this.uSUARIO_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uSUARIO_IDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUARIO_IDComboBox.FormattingEnabled = true;
            this.uSUARIO_IDComboBox.Location = new System.Drawing.Point(196, 85);
            this.uSUARIO_IDComboBox.Name = "uSUARIO_IDComboBox";
            this.uSUARIO_IDComboBox.Size = new System.Drawing.Size(294, 24);
            this.uSUARIO_IDComboBox.TabIndex = 4;
            this.uSUARIO_IDComboBox.ValueMember = "USUARIO_ID";
            this.uSUARIO_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.uSUARIO_IDComboBox_SelectedIndexChanged);
            // 
            // sISTEMA_IDLabel
            // 
            sISTEMA_IDLabel.AutoSize = true;
            sISTEMA_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sISTEMA_IDLabel.Location = new System.Drawing.Point(29, 115);
            sISTEMA_IDLabel.Name = "sISTEMA_IDLabel";
            sISTEMA_IDLabel.Size = new System.Drawing.Size(162, 16);
            sISTEMA_IDLabel.TabIndex = 5;
            sISTEMA_IDLabel.Text = "Sistema com defeito :";
            sISTEMA_IDLabel.Click += new System.EventHandler(this.sISTEMA_IDLabel_Click);
            // 
            // sISTEMA_IDComboBox
            // 
            this.sISTEMA_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cHAMADOSBindingSource, "SISTEMA_ID", true));
            this.sISTEMA_IDComboBox.DataSource = this.sISTEMASBindingSource;
            this.sISTEMA_IDComboBox.DisplayMember = "NOME_SISTEMA";
            this.sISTEMA_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sISTEMA_IDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sISTEMA_IDComboBox.FormattingEnabled = true;
            this.sISTEMA_IDComboBox.Location = new System.Drawing.Point(196, 112);
            this.sISTEMA_IDComboBox.Name = "sISTEMA_IDComboBox";
            this.sISTEMA_IDComboBox.Size = new System.Drawing.Size(294, 24);
            this.sISTEMA_IDComboBox.TabIndex = 6;
            this.sISTEMA_IDComboBox.ValueMember = "SISTEMA_ID";
            this.sISTEMA_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.sISTEMA_IDComboBox_SelectedIndexChanged);
            // 
            // oBSERVACOESLabel
            // 
            oBSERVACOESLabel.AutoSize = true;
            oBSERVACOESLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oBSERVACOESLabel.Location = new System.Drawing.Point(29, 142);
            oBSERVACOESLabel.Name = "oBSERVACOESLabel";
            oBSERVACOESLabel.Size = new System.Drawing.Size(121, 16);
            oBSERVACOESLabel.TabIndex = 7;
            oBSERVACOESLabel.Text = "Obeservações :";
            oBSERVACOESLabel.Click += new System.EventHandler(this.oBSERVACOESLabel_Click);
            // 
            // oBSERVACOESTextBox
            // 
            this.oBSERVACOESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHAMADOSBindingSource, "OBSERVACOES", true));
            this.oBSERVACOESTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oBSERVACOESTextBox.Location = new System.Drawing.Point(196, 139);
            this.oBSERVACOESTextBox.Multiline = true;
            this.oBSERVACOESTextBox.Name = "oBSERVACOESTextBox";
            this.oBSERVACOESTextBox.Size = new System.Drawing.Size(294, 100);
            this.oBSERVACOESTextBox.TabIndex = 8;
            this.oBSERVACOESTextBox.TextChanged += new System.EventHandler(this.oBSERVACOESTextBox_TextChanged);
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
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.iHELPDataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // sISTEMASBindingSource
            // 
            this.sISTEMASBindingSource.DataMember = "SISTEMAS";
            this.sISTEMASBindingSource.DataSource = this.iHELPDataSet;
            // 
            // sISTEMASTableAdapter
            // 
            this.sISTEMASTableAdapter.ClearBeforeFill = true;
            // 
            // frmChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(730, 330);
            this.Controls.Add(cHAMADO_IDLabel);
            this.Controls.Add(this.cHAMADO_IDLabel1);
            this.Controls.Add(uSUARIO_IDLabel);
            this.Controls.Add(this.uSUARIO_IDComboBox);
            this.Controls.Add(sISTEMA_IDLabel);
            this.Controls.Add(this.sISTEMA_IDComboBox);
            this.Controls.Add(oBSERVACOESLabel);
            this.Controls.Add(this.oBSERVACOESTextBox);
            this.Controls.Add(this.cHAMADOSBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChamado";
            this.Text = "Cadastrar Chamado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iHELPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMADOSBindingNavigator)).EndInit();
            this.cHAMADOSBindingNavigator.ResumeLayout(false);
            this.cHAMADOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IHELPDataSet iHELPDataSet;
        private System.Windows.Forms.BindingSource cHAMADOSBindingSource;
        private IHELPDataSetTableAdapters.CHAMADOSTableAdapter cHAMADOSTableAdapter;
        private IHELPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cHAMADOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cHAMADOSBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cHAMADO_IDLabel1;
        private System.Windows.Forms.ComboBox uSUARIO_IDComboBox;
        private System.Windows.Forms.ComboBox sISTEMA_IDComboBox;
        private System.Windows.Forms.TextBox oBSERVACOESTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private IHELPDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private IHELPDataSetTableAdapters.SISTEMASTableAdapter sISTEMASTableAdapter;
        private System.Windows.Forms.BindingSource sISTEMASBindingSource;
    }
}