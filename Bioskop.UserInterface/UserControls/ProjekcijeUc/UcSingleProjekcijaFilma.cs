using System.Collections.Generic;
using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.ProjekcijeUc
{
    public partial class UcSingleProjekcijaFilma : UserControl
    {

        public Dictionary<Control, Label> validationDictionary = new Dictionary<Control, Label>();
        public UcSingleProjekcijaFilma()
        {
            InitializeComponent();
            validationDictionary.Add(txtCena, lblCenaError);
            validationDictionary.Add(dtpDatumProj, lblDatumError);
        }

        private void dgvFilmovi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
