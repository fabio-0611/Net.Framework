namespace Nextsoft
{
    partial class todastbl
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
            this.bD_NextsoftDataSet = new Nextsoft.BD_NextsoftDataSet();
            this.condominioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condominioTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.CondominioTableAdapter();
            this.tableAdapterManager = new Nextsoft.BD_NextsoftDataSetTableAdapters.TableAdapterManager();
            this.familiaTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.FamiliaTableAdapter();
            this.moradorTableAdapter = new Nextsoft.BD_NextsoftDataSetTableAdapters.MoradorTableAdapter();
            this.condominioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.moradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moradorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.familiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.familiaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bD_NextsoftDataSet1 = new Nextsoft.BD_NextsoftDataSet1();
            this.pesquisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioTableAdapter = new Nextsoft.BD_NextsoftDataSet1TableAdapters.relatorioTableAdapter();
            this.tableAdapterManager1 = new Nextsoft.BD_NextsoftDataSet1TableAdapters.TableAdapterManager();
            this.relatorioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_NextsoftDataSet
            // 
            this.bD_NextsoftDataSet.DataSetName = "BD_NextsoftDataSet";
            this.bD_NextsoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // condominioBindingSource
            // 
            this.condominioBindingSource.DataMember = "Condominio";
            this.condominioBindingSource.DataSource = this.bD_NextsoftDataSet;
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
            this.condominioDataGridView.Location = new System.Drawing.Point(16, 43);
            this.condominioDataGridView.Name = "condominioDataGridView";
            this.condominioDataGridView.ReadOnly = true;
            this.condominioDataGridView.Size = new System.Drawing.Size(300, 239);
            this.condominioDataGridView.TabIndex = 1;
            this.condominioDataGridView.TabStop = false;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabela Condomínio";
            // 
            // moradorBindingSource
            // 
            this.moradorBindingSource.DataMember = "Morador";
            this.moradorBindingSource.DataSource = this.bD_NextsoftDataSet;
            // 
            // moradorDataGridView
            // 
            this.moradorDataGridView.AutoGenerateColumns = false;
            this.moradorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.moradorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moradorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.moradorDataGridView.DataSource = this.moradorBindingSource;
            this.moradorDataGridView.Enabled = false;
            this.moradorDataGridView.Location = new System.Drawing.Point(683, 43);
            this.moradorDataGridView.Name = "moradorDataGridView";
            this.moradorDataGridView.Size = new System.Drawing.Size(407, 239);
            this.moradorDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 41;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_Familia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id_Familia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 79;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QuantidadedeBichoEstimacao";
            this.dataGridViewTextBoxColumn7.HeaderText = "QuantidadedeBichoEstimacao";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tabela Morador";
            // 
            // familiaBindingSource
            // 
            this.familiaBindingSource.DataMember = "FK__Familia__Id_Cond__25869641";
            this.familiaBindingSource.DataSource = this.condominioBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabela Família";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMenu.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(-1, 331);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(208, 27);
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.Text = "Menu principal";
            this.toolTip1.SetToolTip(this.BtnMenu, "Clique para ir para o MENU");
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(-1, 380);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(208, 27);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.TabStop = false;
            this.BtnSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.BtnSair, "Clique para Sair");
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // familiaDataGridView
            // 
            this.familiaDataGridView.AutoGenerateColumns = false;
            this.familiaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.familiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.familiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.familiaDataGridView.DataSource = this.familiaBindingSource;
            this.familiaDataGridView.Enabled = false;
            this.familiaDataGridView.Location = new System.Drawing.Point(342, 43);
            this.familiaDataGridView.Name = "familiaDataGridView";
            this.familiaDataGridView.ReadOnly = true;
            this.familiaDataGridView.Size = new System.Drawing.Size(303, 239);
            this.familiaDataGridView.TabIndex = 2;
            this.familiaDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 41;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id_Condominio";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id_Condominio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 102;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // bD_NextsoftDataSet1
            // 
            this.bD_NextsoftDataSet1.DataSetName = "BD_NextsoftDataSet1";
            this.bD_NextsoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesquisaBindingSource
            // 
            this.pesquisaBindingSource.DataMember = "pesquisa";
            this.pesquisaBindingSource.DataSource = this.bD_NextsoftDataSet1;
            // 
            // relatorioBindingSource
            // 
            this.relatorioBindingSource.DataMember = "relatorio";
            this.relatorioBindingSource.DataSource = this.bD_NextsoftDataSet1;
            // 
            // relatorioTableAdapter
            // 
            this.relatorioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CondominioTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.FamiliaTableAdapter = null;
            this.tableAdapterManager1.MoradorTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Nextsoft.BD_NextsoftDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // relatorioDataGridView
            // 
            this.relatorioDataGridView.AutoGenerateColumns = false;
            this.relatorioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.relatorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relatorioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.relatorioDataGridView.DataSource = this.relatorioBindingSource;
            this.relatorioDataGridView.Location = new System.Drawing.Point(432, 302);
            this.relatorioDataGridView.Name = "relatorioDataGridView";
            this.relatorioDataGridView.Size = new System.Drawing.Size(300, 220);
            this.relatorioDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn11.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 59;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "QuantidadedeBichoEstimacao";
            this.dataGridViewTextBoxColumn12.HeaderText = "QuantidadedeBichoEstimacao";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 175;
            // 
            // todastbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nextsoft.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1110, 591);
            this.Controls.Add(this.relatorioDataGridView);
            this.Controls.Add(this.familiaDataGridView);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moradorDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.condominioDataGridView);
            this.Name = "todastbl";
            this.ShowIcon = false;
            this.Text = "Nextsoft Sistemas";
            this.Load += new System.EventHandler(this.todastbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NextsoftDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_NextsoftDataSet bD_NextsoftDataSet;
        private System.Windows.Forms.BindingSource condominioBindingSource;
        private BD_NextsoftDataSetTableAdapters.CondominioTableAdapter condominioTableAdapter;
        private BD_NextsoftDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView condominioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BD_NextsoftDataSetTableAdapters.MoradorTableAdapter moradorTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource moradorBindingSource;
        private BD_NextsoftDataSetTableAdapters.FamiliaTableAdapter familiaTableAdapter;
        private System.Windows.Forms.DataGridView moradorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource familiaBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView familiaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolTip toolTip1;
        private BD_NextsoftDataSet1 bD_NextsoftDataSet1;
        private System.Windows.Forms.BindingSource pesquisaBindingSource;
        private System.Windows.Forms.BindingSource relatorioBindingSource;
        private BD_NextsoftDataSet1TableAdapters.relatorioTableAdapter relatorioTableAdapter;
        private BD_NextsoftDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView relatorioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}