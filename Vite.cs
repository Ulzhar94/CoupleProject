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
    public partial class Vite : Form
    {


        public Vite()
        {
            InitializeComponent();
        }

        private void calcolaButton_Click(object sender, EventArgs e)
        {

            OperazioniVite operazioni = new OperazioniVite();
            //SCOSTAMENTO UNO
            dataGridView1.Rows[0].Cells[0].Value = operazioni.GetScostamentoUno(classeDiamEstText.Text,double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture));
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Green;

            //DIAMETRO ESTERNO MASSIMO
            dataGridView1.Rows[0].Cells[1].Value = operazioni.GetDiametroEsternoMax(heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem),
                classeDiametroMedioTextBox.Text, double.Parse(diametroEsternoTextBox.Text, CultureInfo.InvariantCulture), double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture),
                double.Parse(angoloTextBox.Text, CultureInfo.InvariantCulture), (double)dataGridView1.Rows[0].Cells[0].Value);
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Green;

            //TOLLERANZA UNO
            dataGridView1.Rows[0].Cells[2].Value = operazioni.GetTolleranzaUno(classeDiamEstText.Text, double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture),
                heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem), classeDiametroMedioTextBox.Text);
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Green;

            //DIAMETRO ESTERNO MINIMO
            dataGridView1.Rows[0].Cells[3].Value = operazioni.GetDiametroEsternoMin((double)dataGridView1.Rows[0].Cells[1].Value,
                (double)dataGridView1.Rows[0].Cells[2].Value);
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;

           //SCOSTAMENTO 2
            dataGridView2.Rows[0].Cells[0].Value = operazioni.GetScostamentoDue(heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem),
                classeDiametroMedioTextBox.Text, double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture)); ;
            dataGridView2.Columns[0].DefaultCellStyle.ForeColor = Color.Green;

            //DIAMETRO MEDIO MAX
            dataGridView2.Rows[0].Cells[1].Value = operazioni.GetDiametroMedioMax(classeDiametroMedioTextBox.Text, double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture),
               (double)dataGridView1.Rows[0].Cells[0].Value,double.Parse(diametroEsternoTextBox.Text, CultureInfo.InvariantCulture), 
               heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem), double.Parse(angoloTextBox.Text, CultureInfo.InvariantCulture));
            dataGridView2.Columns[1].DefaultCellStyle.ForeColor = Color.Green;

            // TOLLERANZA 2
            dataGridView2.Rows[0].Cells[2].Value = operazioni.GetTolleranzaDue(heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem),
                classeDiametroMedioTextBox.Text, double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture), double.Parse(diametroEsternoTextBox.Text, CultureInfo.InvariantCulture));
            dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Green;

            // DIAMETRO MEDIO MINIMO
            dataGridView2.Rows[0].Cells[3].Value = operazioni.GetDiametroMedioMin(heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem),
           (double)dataGridView2.Rows[0].Cells[1].Value, (double)dataGridView2.Rows[0].Cells[2].Value);
            dataGridView2.Columns[3].DefaultCellStyle.ForeColor = Color.Green;

            // DIAMETRO NOCC MAX
            dataGridView3.Rows[0].Cells[0].Value = operazioni.GetDiametroNoccMax(tipologiaComboBox.GetItemText(tipologiaComboBox.SelectedItem),
                (double)dataGridView1.Rows[0].Cells[1].Value, double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture));
            dataGridView3.Columns[0].DefaultCellStyle.ForeColor = Color.Green;

            // TOLLERANZA 3 
            dataGridView3.Rows[0].Cells[1].Value = operazioni.GetTolleranzaTre(heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem),
                (double)dataGridView3.Rows[0].Cells[0].Value, (double)dataGridView2.Rows[0].Cells[2].Value, 
                double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture), tipologiaComboBox.GetItemText(tipologiaComboBox.SelectedItem));
            dataGridView3.Columns[1].DefaultCellStyle.ForeColor = Color.Green;

            // DIAMETRO NOCC MIN
            dataGridView3.Rows[0].Cells[2].Value = operazioni.GetDiametroNoccMin(heliCoilcomboBox.GetItemText(heliCoilcomboBox.SelectedItem),
                (double)dataGridView3.Rows[0].Cells[0].Value, (double)dataGridView2.Rows[0].Cells[2].Value,
                (double)dataGridView3.Rows[0].Cells[1].Value, double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture), tipologiaComboBox.GetItemText(tipologiaComboBox.SelectedItem));
            dataGridView3.Columns[2].DefaultCellStyle.ForeColor = Color.Green;

            // RAGGIO FONDO MIN
            dataGridView4.Rows[0].Cells[0].Value = operazioni.GetRaggioFondoMin(tipologiaComboBox.GetItemText(tipologiaComboBox.SelectedItem), double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture));
            dataGridView4.Columns[0].DefaultCellStyle.ForeColor = Color.Green;

            // RAGGIO FONDO MAX
            dataGridView4.Rows[0].Cells[1].Value = operazioni.GetRaggioFondoMax(tipologiaComboBox.GetItemText(tipologiaComboBox.SelectedItem), double.Parse(passoTextBox.Text, CultureInfo.InvariantCulture));
            dataGridView4.Columns[1].DefaultCellStyle.ForeColor = Color.Green;
        }

        private void backButtonVite_Click(object sender, EventArgs e)
        {
            this.Close();
            ViteEMadreviteHomepage viteEMadreviteHomepage = new ViteEMadreviteHomepage();
            viteEMadreviteHomepage.Show();


        }

        private void Vite_Load(object sender, EventArgs e)
        {

        }

        private void tipologiaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void heliCoilcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
