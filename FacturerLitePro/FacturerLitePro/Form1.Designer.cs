namespace FacturerLitePro
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clients = new System.Windows.Forms.TabPage();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcgroundDataSet = new FacturerLitePro.pcgroundDataSet();
            this.Productes = new System.Windows.Forms.TabPage();
            this.productesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Factures = new System.Windows.Forms.TabPage();
            this.facturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaDetall = new System.Windows.Forms.TabPage();
            this.factura_detallDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura_detallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new FacturerLitePro.pcgroundDataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new FacturerLitePro.pcgroundDataSetTableAdapters.TableAdapterManager();
            this.productesTableAdapter = new FacturerLitePro.pcgroundDataSetTableAdapters.productesTableAdapter();
            this.facturaTableAdapter = new FacturerLitePro.pcgroundDataSetTableAdapters.facturaTableAdapter();
            this.factura_detallTableAdapter = new FacturerLitePro.pcgroundDataSetTableAdapters.factura_detallTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcgroundDataSet)).BeginInit();
            this.Productes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productesBindingSource)).BeginInit();
            this.Factures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            this.FacturaDetall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factura_detallDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_detallBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clients);
            this.tabControl1.Controls.Add(this.Productes);
            this.tabControl1.Controls.Add(this.Factures);
            this.tabControl1.Controls.Add(this.FacturaDetall);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.clientsDataGridView);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(665, 375);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(659, 369);
            this.clientsDataGridView.TabIndex = 0;
          //  this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Client";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cognom1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cognom1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cognom2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cognom2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adreça";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adreça";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Codi_Postal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Codi_Postal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Població";
            this.dataGridViewTextBoxColumn7.HeaderText = "Població";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Província";
            this.dataGridViewTextBoxColumn8.HeaderText = "Província";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telèfon";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telèfon";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fax";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "E-mail";
            this.dataGridViewTextBoxColumn11.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.pcgroundDataSet;
            // 
            // pcgroundDataSet
            // 
            this.pcgroundDataSet.DataSetName = "pcgroundDataSet";
            this.pcgroundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Productes
            // 
            this.Productes.Controls.Add(this.productesDataGridView);
            this.Productes.Location = new System.Drawing.Point(4, 22);
            this.Productes.Name = "Productes";
            this.Productes.Size = new System.Drawing.Size(665, 375);
            this.Productes.TabIndex = 2;
            this.Productes.Text = "Productes";
            this.Productes.UseVisualStyleBackColor = true;
            // 
            // productesDataGridView
            // 
            this.productesDataGridView.AutoGenerateColumns = false;
            this.productesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.productesDataGridView.DataSource = this.productesBindingSource;
            this.productesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productesDataGridView.Name = "productesDataGridView";
            this.productesDataGridView.Size = new System.Drawing.Size(665, 375);
            this.productesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id_Producte";
            this.dataGridViewTextBoxColumn12.HeaderText = "id_Producte";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Producte";
            this.dataGridViewTextBoxColumn13.HeaderText = "Producte";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Preu";
            this.dataGridViewTextBoxColumn14.HeaderText = "Preu";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // productesBindingSource
            // 
            this.productesBindingSource.DataMember = "productes";
            this.productesBindingSource.DataSource = this.pcgroundDataSet;
            // 
            // Factures
            // 
            this.Factures.Controls.Add(this.facturaDataGridView);
            this.Factures.Location = new System.Drawing.Point(4, 22);
            this.Factures.Name = "Factures";
            this.Factures.Size = new System.Drawing.Size(679, 381);
            this.Factures.TabIndex = 3;
            this.Factures.Text = "Factures";
            this.Factures.UseVisualStyleBackColor = true;
            // 
            // facturaDataGridView
            // 
            this.facturaDataGridView.AutoGenerateColumns = false;
            this.facturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.facturaDataGridView.DataSource = this.facturaBindingSource;
            this.facturaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facturaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.facturaDataGridView.Name = "facturaDataGridView";
            this.facturaDataGridView.Size = new System.Drawing.Size(679, 381);
            this.facturaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "n_Factura";
            this.dataGridViewTextBoxColumn15.HeaderText = "n_Factura";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "id_Client";
            this.dataGridViewTextBoxColumn16.HeaderText = "id_Client";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn17.HeaderText = "Data";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Descompte";
            this.dataGridViewTextBoxColumn18.HeaderText = "Descompte";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "IVA";
            this.dataGridViewTextBoxColumn19.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "factura";
            this.facturaBindingSource.DataSource = this.pcgroundDataSet;
            // 
            // FacturaDetall
            // 
            this.FacturaDetall.Controls.Add(this.factura_detallDataGridView);
            this.FacturaDetall.Location = new System.Drawing.Point(4, 22);
            this.FacturaDetall.Name = "FacturaDetall";
            this.FacturaDetall.Size = new System.Drawing.Size(665, 375);
            this.FacturaDetall.TabIndex = 4;
            this.FacturaDetall.Text = "Factures Detall";
            this.FacturaDetall.UseVisualStyleBackColor = true;
            // 
            // factura_detallDataGridView
            // 
            this.factura_detallDataGridView.AutoGenerateColumns = false;
            this.factura_detallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factura_detallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.factura_detallDataGridView.DataSource = this.factura_detallBindingSource;
            this.factura_detallDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factura_detallDataGridView.Location = new System.Drawing.Point(0, 0);
            this.factura_detallDataGridView.Name = "factura_detallDataGridView";
            this.factura_detallDataGridView.Size = new System.Drawing.Size(665, 375);
            this.factura_detallDataGridView.TabIndex = 0;
            //this.factura_detallDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.factura_detallDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "n_Factura";
            this.dataGridViewTextBoxColumn20.HeaderText = "n_Factura";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "id_Producte";
            this.dataGridViewTextBoxColumn21.HeaderText = "id_Producte";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Quantitat";
            this.dataGridViewTextBoxColumn22.HeaderText = "Quantitat";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // factura_detallBindingSource
            // 
            this.factura_detallBindingSource.DataMember = "factura_detall";
            this.factura_detallBindingSource.DataSource = this.pcgroundDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.factura_detallTableAdapter = null;
            this.tableAdapterManager.facturaTableAdapter = null;
            this.tableAdapterManager.productesTableAdapter = this.productesTableAdapter;
            this.tableAdapterManager.UpdateOrder = FacturerLitePro.pcgroundDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productesTableAdapter
            // 
            this.productesTableAdapter.ClearBeforeFill = true;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // factura_detallTableAdapter
            // 
            this.factura_detallTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 407);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcgroundDataSet)).EndInit();
            this.Productes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productesBindingSource)).EndInit();
            this.Factures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.FacturaDetall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.factura_detallDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_detallBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clients;
        private pcgroundDataSet pcgroundDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private pcgroundDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private pcgroundDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private pcgroundDataSetTableAdapters.productesTableAdapter productesTableAdapter;
        private System.Windows.Forms.BindingSource productesBindingSource;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TabPage Productes;
        private System.Windows.Forms.DataGridView productesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TabPage Factures;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private pcgroundDataSetTableAdapters.facturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.DataGridView facturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.TabPage FacturaDetall;
        private System.Windows.Forms.BindingSource factura_detallBindingSource;
        private pcgroundDataSetTableAdapters.factura_detallTableAdapter factura_detallTableAdapter;
        private System.Windows.Forms.DataGridView factura_detallDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

