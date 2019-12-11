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
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table '_DB_CAT_RTDataSet.produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this._DB_CAT_RTDataSet.produit);
            // TODO: cette ligne de code charge les données dans la table '_DB_CAT_RTDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this._DB_CAT_RTDataSet.Categorie);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(_DB_CAT_RTDataSet.Tables[1],
                "ID_CAT=" + comboBox1.SelectedValue,"designation asc" ,DataViewRowState.CurrentRows);
            produitDataGridView.DataSource = dv;
        }
    }
}
