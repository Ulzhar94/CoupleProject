using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRAlpha2
{
    public partial class ViteEMadreviteHomepage : Form
    {
        public ViteEMadreviteHomepage()
        {
            InitializeComponent();
        }

        private void viteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vite vite = new Vite();
            vite.ShowDialog();
        }

        private void madreviteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MadreVite madreVite = new MadreVite();
            madreVite.ShowDialog();
        }
    }
}
