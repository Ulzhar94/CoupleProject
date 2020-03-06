using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRAlpha2
{
    public partial class MadreVite : Form
    {
        OperazioniMadreVite OperazioniMadreVite = new OperazioniMadreVite();

        public MadreVite()
        {
            InitializeComponent();
        }

        private void MadreVite_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcolaButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(DiamEsternoTextBoxMV.Text) || string.IsNullOrEmpty(heliCoilcomboBoxMV.Text)
                || string.IsNullOrEmpty(TipologiaComboBoxMV.Text) || string.IsNullOrWhiteSpace(AngoloTextBoxMV.Text) || string.IsNullOrWhiteSpace(PassoTextBoxMV.Text)
                || string.IsNullOrWhiteSpace(PrincipiTextBoxMV.Text) || string.IsNullOrEmpty(DiamMedioComboBoxMV.Text) || string.IsNullOrEmpty(DiametroInternoComboBoxMV.Text))
            {
                MessageBox.Show("Uno o più campi non sono stati compilati");
            }

            dataGridMadreVite.Rows[0].Cells[0].Value = OperazioniMadreVite.getScostamento(DiametroInternoComboBoxMV.Text, DiamMedioComboBoxMV.Text, 
                double.Parse(PassoTextBoxMV.Text, CultureInfo.InvariantCulture));

            dataGridMadreVite.Rows[0].Cells[1].Value = OperazioniMadreVite.getDiamInternoMin(double.Parse(dataGridMadreVite.Rows[0].Cells[0].Value.ToString()), DiamMedioComboBoxMV.Text, DiametroInternoComboBoxMV.Text,
                DiamEsternoTextBoxMV.Text, double.Parse(PassoTextBoxMV.Text, CultureInfo.InvariantCulture), heliCoilcomboBoxMV.Text, TipologiaComboBoxMV.Text);
        }

        private void PassoTextBoxMV_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiametroInternoTextBoxMV_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrincipiTextBoxMV_TextChanged(object sender, EventArgs e)
        {

        }

        private void AngoloTextBoxMV_TextChanged(object sender, EventArgs e)
        {

        }

        private void heliCoilcomboBoxMV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ViteEMadreviteHomepage viteEMadreviteHomepage = new ViteEMadreviteHomepage();
            viteEMadreviteHomepage.Show();
        }

        private void DiamEsternoTextBoxMV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
