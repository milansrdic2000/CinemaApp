using System.Collections.Generic;
using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.Film
{
    public partial class UcSingleFilmView : UserControl
    {
        public Dictionary<Control, Label> validationDictionary = new Dictionary<Control, Label>();
        public UcSingleFilmView()
        {
            InitializeComponent();

            validationDictionary.Add(txtNazivFilma, lblNazivError);
            validationDictionary.Add(txtTrajanje, lblTrajanjeError);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*public FilmC getFilmFromForm()
{
   FilmC film = new FilmC()
   {
       Administrator = MainCoordinator.Instance.ulogovaniAdministrator,
       Datum_Premijere = dtpDatumPremijere.Value,
       Naziv_Filma = txtNazivFilma.Text,
       Opis_Filma = txtOpis.Text,
       Reziser = (Reziser)cbReziser.SelectedItem,
       Zanr = (Zanr)cbZanr.SelectedItem,
       Trajanje_U_Minutima = Convert.ToInt32(txtTrajanje.Text),

   };
   return film;
}
public void PopulateFilm(FilmC film)
{
   txtNazivFilma.Text = film.Naziv_Filma;
   txtOpis.Text = film.Opis_Filma;
   txtTrajanje.Text = film.Trajanje_U_Minutima.ToString();
   cbReziser.SelectedItem = film.Reziser;
   cbZanr.SelectedItem = film.Zanr;
   dtpDatumPremijere.Value = film.Datum_Premijere;
}*/
        /*public void PopulateZanr(List<Zanr> listZanr)
         {
             cbZanr.DataSource = listZanr;
         }
         private void btnDodaj_Click(object sender, EventArgs e)
         {

         }*/
    }
}

