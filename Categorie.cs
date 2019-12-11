using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBW2
{
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
        }

        private void CategorieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categorieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._DB_CAT_RTDataSet);

        }

        private void Categorie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table '_DB_CAT_RTDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this._DB_CAT_RTDataSet.Categorie);

        }

        private void CategorieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
