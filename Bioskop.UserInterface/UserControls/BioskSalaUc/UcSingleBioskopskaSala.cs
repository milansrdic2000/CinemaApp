using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.BioskSalaUc
{
    public partial class UcSingleBioskopskaSala : UserControl
    {
        public Dictionary<Control, Label> validationDictionary = new Dictionary<Control, Label>();
        public UcSingleBioskopskaSala()
        {
            InitializeComponent();

            validationDictionary.Add(txtNazivSale, lblNazivError);
            validationDictionary.Add(txtRedoviGenerisi, lblRedGenerisiError);
            validationDictionary.Add(txtKolonaGenerisi, lblKolonaError);
            validationDictionary.Add(txtRed, lblRedError);
            validationDictionary.Add(txtKolona, lblKolonaError);

        }




        private void UcSingleBioskopskaSala_Load(object sender, EventArgs e)
        {

        }

        private void dgvSedista_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dgvSedista_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dgvSedista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNazivSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtRedoviGenerisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKolonaGenerisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerisiSedista_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRed_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNazivError_Click(object sender, EventArgs e)
        {

        }
    }
}
