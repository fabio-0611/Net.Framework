namespace Nextsoft
{
    partial class CadastroMorador
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
            System.Windows.Forms.Label id_FamiliaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label quantidadedeBichoEstimacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMorador));
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.bD_NextsoftDataSet = new Nextsoft.BD_NextsoftDataSet();
            this.moradorTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.MoradorTableAdapter();
            this.moradorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.moradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.id_FamiliaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.quantidadedeBichoEstimacaoTextBox = new System.Windows.Forms.TextBox();
            this.moradorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new Nextsoft.BD_NextsoftDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.consultaMoradorToolStrip = new System.Windows.Forms.ToolStrip();
            this.consultaMoradorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.consultaMoradorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.consultaMoradorToolStripButton = new System.Windows.Forms.ToolStripButton();
            id_FamiliaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            quantidadedeBichoEstimacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingNavigator)).BeginInit();
            this.moradorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorDataGridView)).BeginInit();
            this.consultaMoradorToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_FamiliaLabel
            // 
            id_FamiliaLabel.AutoSize = true;
            id_FamiliaLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_FamiliaLabel.Location = new System.Drawing.Point(-2, 42);
            id_FamiliaLabel.Name = "id_FamiliaLabel";
            id_FamiliaLabel.Size = new System.Drawing.Size(77, 17);
            id_FamiliaLabel.TabIndex = 21;
            id_FamiliaLabel.Text = "Id Familia:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(-2, 97);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(50, 17);
            nomeLabel.TabIndex = 23;
            nomeLabel.Text = "Nome:";
            // 
            // quantidadedeBichoEstimacaoLabel
            // 
            quantidadedeBichoEstimacaoLabel.AutoSize = true;
            quantidadedeBichoEstimacaoLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadedeBichoEstimacaoLabel.Location = new System.Drawing.Point(-3, 157);
            quantidadedeBichoEstimacaoLabel.Name = "quantidadedeBichoEstimacaoLabel";
            quantidadedeBichoEstimacaoLabel.Size = new System.Drawing.Size(217, 17);
            quantidadedeBichoEstimacaoLabel.TabIndex = 25;
            quantidadedeBichoEstimacaoLabel.Text = "Quantidadede Bicho Estimacao:";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMenu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(55, 410);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(208, 27);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Menu principal";
            this.toolTip1.SetToolTip(this.BtnMenu, "Clique para ir Menu");
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(55, 344);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(208, 27);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.BtnExcluir, "Clique para Excluir");
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAlterar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(55, 311);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(208, 27);
            this.BtnAlterar.TabIndex = 4;
            this.BtnAlterar.TabStop = false;
            this.BtnAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.BtnAlterar, "Clique para Alterar");
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(55, 278);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(208, 27);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.BtnCadastrar, "Clique para Cadastrar");
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(55, 377);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(208, 27);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.BtnSair, "Clique para sair");
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // bD_NextsoftDataSet
            // 
            this.bD_NextsoftDataSet.DataSetName = "BD_NextsoftDataSet";
            this.bD_NextsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moradorTableAdapter
            // 
            this.moradorTableAdapter.ClearBeforeFill = true;
            // 
            // moradorBindingNavigator
            // 
            this.moradorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.moradorBindingNavigator.BindingSource = this.moradorBindingSource;
            this.moradorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.moradorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.moradorBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.moradorBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.moradorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.moradorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moradorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.moradorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.moradorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.moradorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.moradorBindingNavigator.Name = "moradorBindingNavigator";
            this.moradorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.moradorBindingNavigator.Size = new System.Drawing.Size(371, 25);
            this.moradorBindingNavigator.TabIndex = 19;
            this.moradorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.Adicionar);
            // 
            // moradorBindingSource
            // 
            this.moradorBindingSource.DataMember = "Morador";
            this.moradorBindingSource.DataSource = this.bD_NextsoftDataSet;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // id_FamiliaTextBox
            // 
            this.id_FamiliaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradorBindingSource, "Id_Familia", true));
            this.id_FamiliaTextBox.Location = new System.Drawing.Point(1, 62);
            this.id_FamiliaTextBox.Name = "id_FamiliaTextBox";
            this.id_FamiliaTextBox.Size = new System.Drawing.Size(63, 20);
            this.id_FamiliaTextBox.TabIndex = 0;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(1, 117);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(159, 20);
            this.nomeTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nomeTextBox, "Digite o seu nome");
            // 
            // quantidadedeBichoEstimacaoTextBox
            // 
            this.quantidadedeBichoEstimacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradorBindingSource, "QuantidadedeBichoEstimacao", true));
            this.quantidadedeBichoEstimacaoTextBox.Location = new System.Drawing.Point(1, 177);
            this.quantidadedeBichoEstimacaoTextBox.Name = "quantidadedeBichoEstimacaoTextBox";
            this.quantidadedeBichoEstimacaoTextBox.Size = new System.Drawing.Size(61, 20);
            this.quantidadedeBichoEstimacaoTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.quantidadedeBichoEstimacaoTextBox, "Digite a quantidade de animal");
            // 
            // moradorDataGridView
            // 
            this.moradorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moradorDataGridView.AutoGenerateColumns = false;
            this.moradorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.moradorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.moradorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moradorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.moradorDataGridView.DataSource = this.moradorBindingSource;
            this.moradorDataGridView.Location = new System.Drawing.Point(365, 74);
            this.moradorDataGridView.Name = "moradorDataGridView";
            this.moradorDataGridView.ReadOnly = true;
            this.moradorDataGridView.Size = new System.Drawing.Size(475, 227);
            this.moradorDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Familia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Familia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantidadedeBichoEstimacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantidadedeBichoEstimacao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CondominioTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FamiliaTableAdapter = null;
            this.tableAdapterManager.MoradorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nextsoft.BD_NextsoftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // consultaMoradorToolStrip
            // 
            this.consultaMoradorToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.consultaMoradorToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.consultaMoradorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaMoradorToolStripLabel,
            this.consultaMoradorToolStripTextBox,
            this.consultaMoradorToolStripButton});
            this.consultaMoradorToolStrip.Location = new System.Drawing.Point(469, 0);
            this.consultaMoradorToolStrip.Name = "consultaMoradorToolStrip";
            this.consultaMoradorToolStrip.Size = new System.Drawing.Size(240, 25);
            this.consultaMoradorToolStrip.TabIndex = 27;
            this.consultaMoradorToolStrip.Text = "consultaMoradorToolStrip";
            // 
            // consultaMoradorToolStripLabel
            // 
            this.consultaMoradorToolStripLabel.Name = "consultaMoradorToolStripLabel";
            this.consultaMoradorToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.consultaMoradorToolStripLabel.Text = "Nome:";
            // 
            // consultaMoradorToolStripTextBox
            // 
            this.consultaMoradorToolStripTextBox.Name = "consultaMoradorToolStripTextBox";
            this.consultaMoradorToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // consultaMoradorToolStripButton
            // 
            this.consultaMoradorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consultaMoradorToolStripButton.Name = "consultaMoradorToolStripButton";
            this.consultaMoradorToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.consultaMoradorToolStripButton.Text = "Pesquisar";
            this.consultaMoradorToolStripButton.Click += new System.EventHandler(this.consultaMoradorToolStripButton_Click);
            // 
            // CadastroMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nextsoft.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(852, 457);
            this.Controls.Add(this.consultaMoradorToolStrip);
            this.Controls.Add(this.moradorDataGridView);
            this.Controls.Add(id_FamiliaLabel);
            this.Controls.Add(this.id_FamiliaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(quantidadedeBichoEstimacaoLabel);
            this.Controls.Add(this.quantidadedeBichoEstimacaoTextBox);
            this.Controls.Add(this.moradorBindingNavigator);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnSair);
            this.Name = "CadastroMorador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nextsoft Sistemas";
            this.Load += new System.EventHandler(this.CadastroMorador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingNavigator)).EndInit();
            this.moradorBindingNavigator.ResumeLayout(false);
            this.moradorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorDataGridView)).EndInit();
            this.consultaMoradorToolStrip.ResumeLayout(false);
            this.consultaMoradorToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnSair;
        private BD_NextsoftDataSet bD_NextsoftDataSet;
        private System.Windows.Forms.BindingSource moradorBindingSource;
        private BD_NextsoftDataSetTableAdapters.MoradorTableAdapter moradorTableAdapter;
        private BD_NextsoftDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator moradorBindingNavigator;
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
        private System.Windows.Forms.TextBox id_FamiliaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox quantidadedeBichoEstimacaoTextBox;
        private System.Windows.Forms.DataGridView moradorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip consultaMoradorToolStrip;
        private System.Windows.Forms.ToolStripLabel consultaMoradorToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox consultaMoradorToolStripTextBox;
        private System.Windows.Forms.ToolStripButton consultaMoradorToolStripButton;
    }
}