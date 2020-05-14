using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commerciale_TiffanyCoundoul_liage3
{
    public partial class article : Form
    {
        private GestionService services = new GestionService();

        public article()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void article_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialeDataSet.Article'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.articleTableAdapter.Fill(this.gestioncommercialeDataSet.Article);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class GestionService
    {
    }
}
