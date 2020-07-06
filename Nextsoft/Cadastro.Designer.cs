namespace Nextsoft
{
    partial class Cadastro
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.condominioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.condominioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_NextsoftDataSet = new Nextsoft.BD_NextsoftDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.familiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnMenu = new System.Windows.Forms.Button();
            this.nome3ToolStrip = new System.Windows.Forms.ToolStrip();
            this.nomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nome3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.condominioTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.CondominioTableAdapter();
            this.tableAdapterManager = new Nextsoft.BD_NextsoftDataSetTableAdapters.TableAdapterManager();
            this.familiaTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.FamiliaTableAdapter();
            this.moradorTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.MoradorTableAdapter();
            this.moradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condominioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.condominioBindingNavigator)).BeginInit();
            this.condominioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condominioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).BeginInit();
            this.nome3ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            nomeLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(2, 97);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(54, 18);
            nomeLabel.TabIndex = 7;
            nomeLabel.Text = "Nome:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            bairroLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.Location = new System.Drawing.Point(2, 131);
            bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(57, 18);
            bairroLabel.TabIndex = 9;
            bairroLabel.Text = "Bairro:";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(103, 318);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(208, 25);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.BtnSair, "Clique para SAIR");
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(103, 184);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(208, 25);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.BtnCadastrar, "Clique para SALVAR");
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAlterar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(103, 227);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(208, 25);
            this.BtnAlterar.TabIndex = 4;
            this.BtnAlterar.TabStop = false;
            this.BtnAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.BtnAlterar, "Clique para ALTERAR");
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(103, 271);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(208, 25);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.BtnExcluir, "Clique para EXCLUIR");
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // condominioBindingNavigator
            // 
            this.condominioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.condominioBindingNavigator.BindingSource = this.condominioBindingSource;
            this.condominioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.condominioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.condominioBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.condominioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.condominioBindingNavigator.Location = new System.Drawing.Point(9, 0);
            this.condominioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.condominioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.condominioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.condominioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.condominioBindingNavigator.Name = "condominioBindingNavigator";
            this.condominioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.condominioBindingNavigator.Size = new System.Drawing.Size(395, 25);
            this.condominioBindingNavigator.TabIndex = 4;
            this.condominioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.Novo);
            // 
            // condominioBindingSource
            // 
            this.condominioBindingSource.DataMember = "Condominio";
            this.condominioBindingSource.DataSource = this.bD_NextsoftDataSet;
            // 
            // bD_NextsoftDataSet
            // 
            this.bD_NextsoftDataSet.DataSetName = "BD_NextsoftDataSet";
            this.bD_NextsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(61, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.condominioBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(86, 93);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(301, 24);
            this.nomeTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nomeTextBox, "Informe o seu Nome");
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.condominioBindingSource, "Bairro", true));
            this.bairroTextBox.Enabled = false;
            this.bairroTextBox.Location = new System.Drawing.Point(86, 131);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(263, 24);
            this.bairroTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.bairroTextBox, "Informe seu Bairro");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Condominio";
            // 
            // familiaBindingSource
            // 
            this.familiaBindingSource.DataMember = "Familia";
            this.familiaBindingSource.DataSource = this.bD_NextsoftDataSet;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMenu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(103, 376);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(208, 27);
            this.BtnMenu.TabIndex = 14;
            this.BtnMenu.Text = "Menu principal";
            this.toolTip1.SetToolTip(this.BtnMenu, "Clique para voltar para o menu");
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // nome3ToolStrip
            // 
            this.nome3ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.nome3ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nome3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripLabel,
            this.nomeToolStripTextBox,
            this.nome3ToolStripButton});
            this.nome3ToolStrip.Location = new System.Drawing.Point(781, 0);
            this.nome3ToolStrip.Name = "nome3ToolStrip";
            this.nome3ToolStrip.Size = new System.Drawing.Size(209, 25);
            this.nome3ToolStrip.TabIndex = 13;
            this.nome3ToolStrip.Text = "nome3ToolStrip";
            // 
            // nomeToolStripLabel
            // 
            this.nomeToolStripLabel.Name = "nomeToolStripLabel";
            this.nomeToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.nomeToolStripLabel.Text = "Nome:";
            // 
            // nomeToolStripTextBox
            // 
            this.nomeToolStripTextBox.Name = "nomeToolStripTextBox";
            this.nomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nome3ToolStripButton
            // 
            this.nome3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nome3ToolStripButton.Name = "nome3ToolStripButton";
            this.nome3ToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.nome3ToolStripButton.Text = "Pesquisar";
            this.nome3ToolStripButton.Click += new System.EventHandler(this.nome3ToolStripButton_Click);
            // 
            // condominioTableAdapter
            // 
            this.condominioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CondominioTableAdapter = this.condominioTableAdapter;
            this.tableAdapterManager.FamiliaTableAdapter = this.familiaTableAdapter;
            this.tableAdapterManager.MoradorTableAdapter = this.moradorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nextsoft.BD_NextsoftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // familiaTableAdapter
            // 
            this.familiaTableAdapter.ClearBeforeFill = true;
            // 
            // moradorTableAdapter
            // 
            this.moradorTableAdapter.ClearBeforeFill = true;
            // 
            // moradorBindingSource
            // 
            this.moradorBindingSource.DataMember = "Morador";
            this.moradorBindingSource.DataSource = this.bD_NextsoftDataSet;
            // 
            // condominioDataGridView
            // 
            this.condominioDataGridView.AutoGenerateColumns = false;
            this.condominioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.condominioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.condominioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.condominioDataGridView.DataSource = this.condominioBindingSource;
            this.condominioDataGridView.Enabled = false;
            this.condominioDataGridView.Location = new System.Drawing.Point(511, 97);
            this.condominioDataGridView.Name = "condominioDataGridView";
            this.condominioDataGridView.Size = new System.Drawing.Size(347, 230);
            this.condominioDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 73;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nextsoft.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1276, 679);
            this.Controls.Add(this.condominioDataGridView);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.nome3ToolStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.condominioBindingNavigator);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnSair);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.condominioBindingNavigator)).EndInit();
            this.condominioBindingNavigator.ResumeLayout(false);
            this.condominioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condominioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).EndInit();
            this.nome3ToolStrip.ResumeLayout(false);
            this.nome3ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private BD_NextsoftDataSet bD_NextsoftDataSet;
        private System.Windows.Forms.BindingSource condominioBindingSource;
        private BD_NextsoftDataSetTableAdapters.CondominioTableAdapter condominioTableAdapter;
        private BD_NextsoftDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator condominioBindingNavigator;
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
        private BD_NextsoftDataSetTableAdapters.FamiliaTableAdapter familiaTableAdapter;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource familiaBindingSource;
        private BD_NextsoftDataSetTableAdapters.MoradorTableAdapter moradorTableAdapter;
        private System.Windows.Forms.BindingSource moradorBindingSource;
        private System.Windows.Forms.ToolStripButton nome2ToolStripButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip nome3ToolStrip;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton nome3ToolStripButton;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.DataGridView condominioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}