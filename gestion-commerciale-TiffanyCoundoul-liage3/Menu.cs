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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexion mm = new connexion();
            mm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            article mm = new article();
            mm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commande mm = new Commande();
            mm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexion mm = new connexion();
            mm.Show();
        }
    }
}
