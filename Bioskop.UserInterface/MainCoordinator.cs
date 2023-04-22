using Bioskop.Common;
using Bioskop.UserInterface.GuiController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bioskop.UserInterface
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        private MainCoordinator()
        {
            filmGuiController = new FilmGuiController();
            salaGuiController = new SalaGuiController();
            projekcijaGuiController = new ProjekcijaGuiController();
            rezervacijaGuiController = new RezervacijaGuiController();
            korisnikGuiController = new KorisniciGuiController();


        }
        //KONTROLERI
        private FilmGuiController filmGuiController;
        private SalaGuiController salaGuiController;
        private ProjekcijaGuiController projekcijaGuiController;
        private RezervacijaGuiController rezervacijaGuiController;
        private KorisniciGuiController korisnikGuiController;
        //KORISNICI ULOGOVANI
        public Korisnik ulogovaniKorisnik;
        public Administrator ulogovaniAdministrator;

        //FORME
        public FrmLogin frmLogin;
        public FrmGlavna frmGlavna;

        //FUNKCIJE

        #region Prikazi Login/Registar
        public void CreateLogin()
        {
            try
            {
                korisnikGuiController.CreateLoginForm(this.frmLogin);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void ShowRegistrationProcess()
        {
            try
            {
                frmLogin.ChangeRightPanel(korisnikGuiController.CreateSingleProfileView(FormMode.AddSingle));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void ShowLoginFromRegistration()
        {
            try
            {
                frmLogin.ChangeRightPanel(frmLogin.PnlLogin);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void ShowDetaljiKorisnika()
        {
            try
            {
                Korisnik k = CommunicationClient.Instance.GetKorisniK(MainCoordinator.Instance.ulogovaniKorisnik.Id);
                frmGlavna.ChangePanel(
                     korisnikGuiController.CreateSingleProfileView(FormMode.EditSingle, ulogovaniKorisnik));

                MainCoordinator.Instance.ulogovaniKorisnik = k;
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC...");
                // return null;
                throw ex;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ShowMainFormFromLogin()
        {
            try
            {
                frmLogin.Visible = false;
                frmGlavna = new FrmGlavna();

                DialogResult dr = frmGlavna.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    frmLogin.Visible = true;
                    frmLogin.TxtSifra.Text = "";
                    frmLogin.TxtEmail.Text = "";
                    ValidateTb(frmLogin.ValidationDictionary, null, "");
                }
                else
                {
                    frmLogin.Close();
                }
                ulogovaniAdministrator = null;
                ulogovaniKorisnik = null;
                frmGlavna.Dispose();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void VratiSeNaLogin()
        {
            if (frmGlavna == null) return;
            frmGlavna.DialogResult = DialogResult.OK;
            frmGlavna.Close();
            frmGlavna.Dispose();
            ulogovaniAdministrator = null;
            ulogovaniKorisnik = null;
            frmLogin.Visible = true;
        }
        #endregion

        #region Funkcije : Prikazi uc vezane za filmove

        public void ShowDodajFilm()
        {
            try
            {
                //if (ulogovaniAdministrator == null) throw new Exception("Neutorizovan pristup!");
                frmGlavna.ChangePanel(filmGuiController.CreateSingleUcFilmView(FormMode.AddSingle, null));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC dodaj film");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ShowIzmeniFilm(Film film)
        {
            try
            {
                // if (ulogovaniAdministrator == null) throw new Exception("Neutorizovan pristup!");
                frmGlavna.ChangePanel(filmGuiController.CreateSingleUcFilmView(FormMode.EditSingle, film));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC izmeni film");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ShowPregledajFilm(Film film)
        {
            try
            {
                // if (ulogovaniAdministrator == null) throw new Exception("Neutorizovan pristup!");
                frmGlavna.ChangePanel(filmGuiController.CreateSingleUcFilmView(FormMode.ReadOnly, film));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC pregled filma");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ShowViewAllFilms()
        {
            try
            {
                frmGlavna.ChangePanel(filmGuiController.CreateAllUcFilmView());
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC pogledaj sve filmove...");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ShowViewAllFilmsClientReadOnly()
        {
            try
            {
                frmGlavna.ChangePanel(filmGuiController.CreateAllUcFilmView(FormMode.ReadOnly));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC pregled film");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Prikazi uc vezane sa bioskopskim salama

        public void ShowDodajBioskopskaSala()
        {
            try
            {
                //if (ulogovaniAdministrator == null) throw new Exception("Neutorizovan pristup!");
                frmGlavna.ChangePanel(salaGuiController.CreateSingleBioskopskaSala(FormMode.AddSingle));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void ShowAzurirajBioskopskaSala(BioskopskaSala sala)
        {
            try
            {
                //if (ulogovaniAdministrator == null) throw new Exception("Neutorizovan pristup!");
                frmGlavna.ChangePanel(salaGuiController.CreateSingleBioskopskaSala(FormMode.EditSingle, sala));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void ShowPrikazBioskopskaSala()
        {
            try
            {

                frmGlavna.ChangePanel(salaGuiController.CreateAllBioskopskeSale());
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC prikaz sala");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Prikazi kontrole za projekcije
        public void ShowPrikazSvihProjekcija()
        {
            try
            {
                frmGlavna.ChangePanel(projekcijaGuiController.CreateAllProjekcijePrikaz());
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void ShowDodajProjekciju()
        {
            try
            {
                //if (ulogovaniAdministrator == null) throw new Exception("Neutorizovan pristup!");
                frmGlavna.ChangePanel(projekcijaGuiController.CreateSingleProjekcijaView(null, FormMode.AddSingle));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void ShowIzmeniProjekciju(ProjekcijaFilma projekcija)
        {
            try
            {
                //if (ulogovaniAdministrator == null) throw new Exception("Neutorizovan pristup!");
                frmGlavna.ChangePanel(projekcijaGuiController.CreateSingleProjekcijaView(projekcija, FormMode.EditSingle));
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Prikazi kontrole za rezervisanje

        //prvi korak, zapravo kreiramo izbor filmova
        public void ShowKreirajRezervaciju()
        {
            try
            {
                frmGlavna.ChangePanel(rezervacijaGuiController.CreateRezervisanje());


            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        // da bi korisnik mogao da izabere i izmeni neku
        public void ShowAllRezervacija()
        {
            try
            {
                frmGlavna.ChangePanel(rezervacijaGuiController.CreateAllRezervacije());


            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //kada korisnik izabere Rez, onda mu omoguci da izmeni karte koje ima
        public void ShowIzmenaRezervacije(Rezervacija rez)
        {
            try
            {
                frmGlavna.ChangePanel(rezervacijaGuiController.CreateRezervisanje());

                rezervacijaGuiController.ChangeMainControl(rezervacijaGuiController.CreateIzborSedista(rez, FormMode.EditSingle), 2);

                rezervacijaGuiController.OsveziPodatkeORez();


            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        // 1.  prvo se ucitavaju svi filmovi
        public void ShowFilmoveZaRezervaciju()
        {
            try
            {

                rezervacijaGuiController.ChangeMainControl(filmGuiController.CreateAllUcFilmView(FormMode.ChooseForReservation), 0);

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        // 2 - prikazuju se sve projekcije za film koji je izabrao korisnik
        public void ShowProjekcijeZaRezervaciju(ProjekcijaFilma filterProjekcija)
        {
            try
            {

                rezervacijaGuiController.Film = filterProjekcija.Film;


                rezervacijaGuiController.ChangeMainControl(projekcijaGuiController.CreateAllProjekcijePrikaz(FormMode.ChooseForReservation, filterProjekcija), 1);

                rezervacijaGuiController.OsveziPodatkeORez();
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        // 3 - za odabranu projekciju prikazuju se sedista sale 
        public void ShowIzborSedistaZaRezervaciju(ProjekcijaFilma projekcija)
        {
            try
            {
                rezervacijaGuiController.ProjekcijaFilma = projekcija;

                rezervacijaGuiController.ChangeMainControl(rezervacijaGuiController.CreateIzborSedista(new Rezervacija() { ProjekcijaFilma = projekcija }), 2);

                rezervacijaGuiController.OsveziPodatkeORez();
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        #endregion


        //validacija
        public void ValidateTb(Dictionary<Control, Label> dict, Control errorControl, string text)
        {
            try
            {

                foreach (KeyValuePair<Control, Label> pair in dict)
                {

                    if (errorControl == pair.Key)
                    {
                        pair.Key.BackColor = Color.FromArgb(255, 69, 0);
                        pair.Value.Visible = true;
                        pair.Value.Text = text;
                    }
                    else
                    {
                        pair.Key.BackColor = Color.FromArgb(244, 176, 122);
                        pair.Value.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Validacija exception");
            }
        }
    }
}
