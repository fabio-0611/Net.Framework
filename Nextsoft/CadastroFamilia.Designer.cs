namespace Nextsoft
{
    partial class CadastroFamilia
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
            System.Windows.Forms.Label id_CondominioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFamilia));
            this.bD_NextsoftDataSet = new Nextsoft.BD_NextsoftDataSet();
            this.familiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familiaTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.FamiliaTableAdapter();
            this.tableAdapterManager = new Nextsoft.BD_NextsoftDataSetTableAdapters.TableAdapterManager();
            this.familiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.id_CondominioTextBox = new System.Windows.Forms.TextBox();
            this.familiaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnMenu = new System.Windows.Forms.Button();
            this.consultarToolStrip = new System.Windows.Forms.ToolStrip();
            this.consultarToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.consultarToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.consultarToolStripButton = new System.Windows.Forms.ToolStripButton();
            nomeLabel = new System.Windows.Forms.Label();
            id_CondominioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingNavigator)).BeginInit();
            this.familiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiaDataGridView)).BeginInit();
            this.consultarToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(17, 109);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(54, 18);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // id_CondominioLabel
            // 
            id_CondominioLabel.AutoSize = true;
            id_CondominioLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_CondominioLabel.Location = new System.Drawing.Point(17, 135);
            id_CondominioLabel.Name = "id_CondominioLabel";
            id_CondominioLabel.Size = new System.Drawing.Size(115, 18);
            id_CondominioLabel.TabIndex = 5;
            id_CondominioLabel.Text = "Id Condominio:";
            // 
            // bD_NextsoftDataSet
            // 
            this.bD_NextsoftDataSet.DataSetName = "BD_NextsoftDataSet";
            this.bD_NextsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familiaBindingSource
            // 
            this.familiaBindingSource.DataMember = "Familia";
            this.familiaBindingSource.DataSource = this.bD_NextsoftDataSet;
            // 
            // familiaTableAdapter
            // 
            this.familiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CondominioTableAdapter = null;
            this.tableAdapterManager.FamiliaTableAdapter = this.familiaTableAdapter;
            this.tableAdapterManager.MoradorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nextsoft.BD_NextsoftDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // familiaBindingNavigator
            // 
            this.familiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.familiaBindingNavigator.BindingSource = this.familiaBindingSource;
            this.familiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.familiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.familiaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.familiaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.familiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.familiaBindingNavigator.Location = new System.Drawing.Point(9, 2);
            this.familiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.familiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.familiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.familiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.familiaBindingNavigator.Name = "familiaBindingNavigator";
            this.familiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.familiaBindingNavigator.Size = new System.Drawing.Size(371, 25);
            this.familiaBindingNavigator.TabIndex = 0;
            this.familiaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.NovoFamilia);
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
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familiaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(158, 107);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(167, 20);
            this.nomeTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.nomeTextBox, "Informe o seu nome");
            // 
            // id_CondominioTextBox
            // 
            this.id_CondominioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familiaBindingSource, "Id_Condominio", true));
            this.id_CondominioTextBox.Location = new System.Drawing.Point(158, 133);
            this.id_CondominioTextBox.Name = "id_CondominioTextBox";
            this.id_CondominioTextBox.Size = new System.Drawing.Size(50, 20);
            this.id_CondominioTextBox.TabIndex = 1;
            // 
            // familiaDataGridView
            // 
            this.familiaDataGridView.AutoGenerateColumns = false;
            this.familiaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.familiaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.familiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.familiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.familiaDataGridView.DataSource = this.familiaBindingSource;
            this.familiaDataGridView.Location = new System.Drawing.Point(418, 109);
            this.familiaDataGridView.Name = "familiaDataGridView";
            this.familiaDataGridView.ReadOnly = true;
            this.familiaDataGridView.Size = new System.Drawing.Size(300, 228);
            this.familiaDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Condominio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Condominio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 102;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(85, 265);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(208, 27);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.BtnExcluir, "Clique para excluir");
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAlterar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(85, 232);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(208, 27);
            this.BtnAlterar.TabIndex = 3;
            this.BtnAlterar.TabStop = false;
            this.BtnAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.BtnAlterar, "Clique para alterar");
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(85, 199);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(208, 27);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.BtnCadastrar, "Clique para Salvar");
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(85, 298);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(208, 27);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.BtnSair, "Clique para sair");
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastrar Família";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMenu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(85, 331);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(208, 27);
            this.BtnMenu.TabIndex = 13;
            this.BtnMenu.Text = "Menu principal";
            this.toolTip1.SetToolTip(this.BtnMenu, "Clique para voltar para o menu");
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // consultarToolStrip
            // 
            this.consultarToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.consultarToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.consultarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripLabel,
            this.consultarToolStripTextBox,
            this.consultarToolStripButton});
            this.consultarToolStrip.Location = new System.Drawing.Point(595, 2);
            this.consultarToolStrip.Name = "consultarToolStrip";
            this.consultarToolStrip.Size = new System.Drawing.Size(209, 25);
            this.consultarToolStrip.TabIndex = 14;
            this.consultarToolStrip.Text = "consultarToolStrip";
            // 
            // consultarToolStripLabel
            // 
            this.consultarToolStripLabel.Name = "consultarToolStripLabel";
            this.consultarToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.consultarToolStripLabel.Text = "Nome:";
            // 
            // consultarToolStripTextBox
            // 
            this.consultarToolStripTextBox.Name = "consultarToolStripTextBox";
            this.consultarToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // consultarToolStripButton
            // 
            this.consultarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consultarToolStripButton.Name = "consultarToolStripButton";
            this.consultarToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.consultarToolStripButton.Text = "Pesquisar";
            this.consultarToolStripButton.Click += new System.EventHandler(this.consultarToolStripButton_Click);
            // 
            // CadastroFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nextsoft.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.consultarToolStrip);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.familiaDataGridView);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(id_CondominioLabel);
            this.Controls.Add(this.id_CondominioTextBox);
            this.Controls.Add(this.familiaBindingNavigator);
            this.Name = "CadastroFamilia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextSoft Sistemas";
            this.Load += new System.EventHandler(this.CadastroFamilia1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingNavigator)).EndInit();
            this.familiaBindingNavigator.ResumeLayout(false);
            this.familiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiaDataGridView)).EndInit();
            this.consultarToolStrip.ResumeLayout(false);
            this.consultarToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_NextsoftDataSet bD_NextsoftDataSet;
        private System.Windows.Forms.BindingSource familiaBindingSource;
        private BD_NextsoftDataSetTableAdapters.FamiliaTableAdapter familiaTableAdapter;
        private BD_NextsoftDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator familiaBindingNavigator;
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
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox id_CondominioTextBox;
        private System.Windows.Forms.DataGridView familiaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.ToolStrip consultarToolStrip;
        private System.Windows.Forms.ToolStripLabel consultarToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox consultarToolStripTextBox;
        private System.Windows.Forms.ToolStripButton consultarToolStripButton;
    }
}