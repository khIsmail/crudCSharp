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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorie c = new Categorie();
            c.ShowDialog();
        }

        private void ConsulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.ShowDialog();
                
        }
    }
}
