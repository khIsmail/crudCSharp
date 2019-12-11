namespace DBW2
{
    partial class Produit
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._DB_CAT_RTDataSet = new DBW2._DB_CAT_RTDataSet();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new DBW2._DB_CAT_RTDataSetTableAdapters.CategorieTableAdapter();
            this.tableAdapterManager = new DBW2._DB_CAT_RTDataSetTableAdapters.TableAdapterManager();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new DBW2._DB_CAT_RTDataSetTableAdapters.produitTableAdapter();
            this.produitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._DB_CAT_RTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categorieBindingSource;
            this.comboBox1.DisplayMember = "NOM_CAT";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_CAT";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // _DB_CAT_RTDataSet
            // 
            this._DB_CAT_RTDataSet.DataSetName = "_DB_CAT_RTDataSet";
            this._DB_CAT_RTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this._DB_CAT_RTDataSet;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = this.categorieTableAdapter;
            this.tableAdapterManager.produitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = DBW2._DB_CAT_RTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "FK_produit_Categorie";
            this.produitBindingSource.DataSource = this.categorieBindingSource;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // produitDataGridView
            // 
            this.produitDataGridView.AutoGenerateColumns = false;
            this.produitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.produitDataGridView.DataSource = this.produitBindingSource;
            this.produitDataGridView.Location = new System.Drawing.Point(61, 155);
            this.produitDataGridView.Name = "produitDataGridView";
            this.produitDataGridView.RowHeadersWidth = 51;
            this.produitDataGridView.RowTemplate.Height = 24;
            this.produitDataGridView.Size = new System.Drawing.Size(678, 220);
            this.produitDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_prod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_prod";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "designation";
            this.dataGridViewTextBoxColumn2.HeaderText = "designation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prix";
            this.dataGridViewTextBoxColumn3.HeaderText = "prix";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantite";
            this.dataGridViewTextBoxColumn4.HeaderText = "quantite";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_cat";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_cat";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.produitDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DB_CAT_RTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private _DB_CAT_RTDataSet _DB_CAT_RTDataSet;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private _DB_CAT_RTDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private _DB_CAT_RTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _DB_CAT_RTDataSetTableAdapters.produitTableAdapter produitTableAdapter;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.DataGridView produitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}