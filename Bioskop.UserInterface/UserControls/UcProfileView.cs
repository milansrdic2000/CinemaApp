using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Bioskop.UserInterface.UserControls
{
    public partial class UcProfileView : UserControl
    {
        public Dictionary<Control, Label> ValidationDictionary = new Dictionary<Control, Label>();
        public UcProfileView()
        {
            InitializeComponent();
            ValidationDictionary.Add(TxtEmail, lblEmailError);
            ValidationDictionary.Add(TxtIme, lblImeError);
            ValidationDictionary.Add(DtpDatumRodjenja, lblDatumError);
            ValidationDictionary.Add(TxtPrezime, lblPrezimeError);
            ValidationDictionary.Add(TxtSifra, lblSifraError);

        }

        private void UcProfileView_Load(object sender, EventArgs e)
        {
            try
            {
                /*if (MainCoordinator.Instance.ulogovaniKorisnik != null)
                {
                    Korisnik k = CommunicationClient.Instance.GetKorisniK(MainCoordinator.Instance.ulogovaniKorisnik.Id);

                    tbDatumRodj.Text = k.Datum_Rodjenja.ToString();
                    tbEmail.Text = k.Email;
                }
                else
                {
                    throw new NotImplementedException("Nije implementirano jos za administratora");
                }*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lblImeError_Click(object sender, EventArgs e)
        {

        }

        private void lblSifraError_Click(object sender, EventArgs e)
        {

        }
    }
}
