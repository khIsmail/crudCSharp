namespace DBW2
{
    partial class Categorie
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
            System.Windows.Forms.Label iD_CATLabel;
            System.Windows.Forms.Label nOM_CATLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorie));
            this._DB_CAT_RTDataSet = new DBW2._DB_CAT_RTDataSet();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new DBW2._DB_CAT_RTDataSetTableAdapters.CategorieTableAdapter();
            this.tableAdapterManager = new DBW2._DB_CAT_RTDataSetTableAdapters.TableAdapterManager();
            this.categorieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.categorieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CATTextBox = new System.Windows.Forms.TextBox();
            this.nOM_CATTextBox = new System.Windows.Forms.TextBox();
            this.categorieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CATLabel = new System.Windows.Forms.Label();
            nOM_CATLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._DB_CAT_RTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).BeginInit();
            this.categorieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CATLabel
            // 
            iD_CATLabel.AutoSize = true;
            iD_CATLabel.Location = new System.Drawing.Point(279, 74);
            iD_CATLabel.Name = "iD_CATLabel";
            iD_CATLabel.Size = new System.Drawing.Size(56, 17);
            iD_CATLabel.TabIndex = 1;
            iD_CATLabel.Text = "ID CAT:";
            // 
            // nOM_CATLabel
            // 
            nOM_CATLabel.AutoSize = true;
            nOM_CATLabel.Location = new System.Drawing.Point(279, 102);
            nOM_CATLabel.Name = "nOM_CATLabel";
            nOM_CATLabel.Size = new System.Drawing.Size(75, 17);
            nOM_CATLabel.TabIndex = 3;
            nOM_CATLabel.Text = "NOM CAT:";
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
            this.tableAdapterManager.produitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBW2._DB_CAT_RTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categorieBindingNavigator
            // 
            this.categorieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categorieBindingNavigator.BindingSource = this.categorieBindingSource;
            this.categorieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categorieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categorieBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.categorieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categorieBindingNavigatorSaveItem});
            this.categorieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categorieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categorieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categorieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categorieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categorieBindingNavigator.Name = "categorieBindingNavigator";
            this.categorieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categorieBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.categorieBindingNavigator.TabIndex = 0;
            this.categorieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // categorieBindingNavigatorSaveItem
            // 
            this.categorieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categorieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categorieBindingNavigatorSaveItem.Image")));
            this.categorieBindingNavigatorSaveItem.Name = "categorieBindingNavigatorSaveItem";
            this.categorieBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.categorieBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.categorieBindingNavigatorSaveItem.Click += new System.EventHandler(this.CategorieBindingNavigatorSaveItem_Click);
            // 
            // iD_CATTextBox
            // 
            this.iD_CATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorieBindingSource, "ID_CAT", true));
            this.iD_CATTextBox.Location = new System.Drawing.Point(360, 71);
            this.iD_CATTextBox.Name = "iD_CATTextBox";
            this.iD_CATTextBox.Size = new System.Drawing.Size(100, 22);
            this.iD_CATTextBox.TabIndex = 2;
            // 
            // nOM_CATTextBox
            // 
            this.nOM_CATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorieBindingSource, "NOM_CAT", true));
            this.nOM_CATTextBox.Location = new System.Drawing.Point(360, 99);
            this.nOM_CATTextBox.Name = "nOM_CATTextBox";
            this.nOM_CATTextBox.Size = new System.Drawing.Size(100, 22);
            this.nOM_CATTextBox.TabIndex = 4;
            // 
            // categorieDataGridView
            // 
            this.categorieDataGridView.AutoGenerateColumns = false;
            this.categorieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categorieDataGridView.DataSource = this.categorieBindingSource;
            this.categorieDataGridView.Location = new System.Drawing.Point(250, 189);
            this.categorieDataGridView.Name = "categorieDataGridView";
            this.categorieDataGridView.RowHeadersWidth = 51;
            this.categorieDataGridView.RowTemplate.Height = 24;
            this.categorieDataGridView.Size = new System.Drawing.Size(304, 220);
            this.categorieDataGridView.TabIndex = 5;
            this.categorieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategorieDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CAT";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_CAT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOM_CAT";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOM_CAT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.categorieDataGridView);
            this.Controls.Add(iD_CATLabel);
            this.Controls.Add(this.iD_CATTextBox);
            this.Controls.Add(nOM_CATLabel);
            this.Controls.Add(this.nOM_CATTextBox);
            this.Controls.Add(this.categorieBindingNavigator);
            this.Name = "Categorie";
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DB_CAT_RTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).EndInit();
            this.categorieBindingNavigator.ResumeLayout(false);
            this.categorieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _DB_CAT_RTDataSet _DB_CAT_RTDataSet;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private _DB_CAT_RTDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private _DB_CAT_RTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categorieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categorieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CATTextBox;
        private System.Windows.Forms.TextBox nOM_CATTextBox;
        private System.Windows.Forms.DataGridView categorieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}