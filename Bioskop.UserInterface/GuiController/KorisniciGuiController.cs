using Bioskop.Common;
using Bioskop.Common.Exceptions;
using Bioskop.UserInterface.UserControls;
using System;
using System.IO;

namespace Bioskop.UserInterface.GuiController
{
    public class KorisniciGuiController
    {
        public FrmLogin frmLogin;

        private UcProfileView ucProfileView;


        public KorisniciGuiController()
        {

        }
        public void CreateLoginForm(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;

            frmLogin.BtnPrijaviSe.Click += BtnLoginOnClick;
            frmLogin.LblRegistrujSe.Click += LblRegistrujSeClick;
        }

        #region Registracija/ izmena profila - single korisnik view

        public UcProfileView CreateSingleProfileView(FormMode formMode = FormMode.EditSingle, Korisnik k = null)
        {
            ucProfileView = new UcProfileView();
            ucProfileView.BtnRegistrujSe.Click += BtnRegistrujSeOnClick;
            ucProfileView.BtnVratiSe.Click += BtnVratiSeOnClick;
            if (formMode == FormMode.EditSingle)
            {
                ucProfileView.BtnRegistrujSe.Visible = false;
                ucProfileView.BtnVratiSe.Visible = false;
                ucProfileView.TxtSifra.Visible = false;
                ucProfileView.LblSifra.Visible = false;
                ucProfileView.LblSifraError.Visible = false;

                ucProfileView.TxtEmail.Text = k.Email;
                ucProfileView.TxtIme.Text = k.Ime;
                ucProfileView.TxtPrezime.Text = k.Prezime;
                ucProfileView.DtpDatumRodjenja.Value = k.Datum_Rodjenja;
                ucProfileView.LblNaslov.Text = "Pregled profila";

                ucProfileView.TxtEmail.ReadOnly = true;
                ucProfileView.TxtIme.ReadOnly = true;
                ucProfileView.TxtPrezime.ReadOnly = true;
                ucProfileView.DtpDatumRodjenja.Enabled = true;

            }
            else
            {
                ucProfileView.BtnRegistrujSe.Visible = true;
                ucProfileView.BtnVratiSe.Visible = true;
                ucProfileView.TxtSifra.Visible = true;
                ucProfileView.LblSifraError.Visible = false;
                ucProfileView.LblSifra.Visible = true;
                ucProfileView.LblNaslov.Text = "Registruj se";
            }

            return ucProfileView;
        }
        public void BtnVratiSeOnClick(object sender, EventArgs e)
        {
            try
            {
                MainCoordinator.Instance.ShowLoginFromRegistration();
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void BtnRegistrujSeOnClick(object sender, EventArgs e)
        {
            try
            {
                Korisnik k = new Korisnik()
                {
                    Email = ucProfileView.TxtEmail.Text,
                    Ime = ucProfileView.TxtIme.Text,
                    Prezime = ucProfileView.TxtPrezime.Text,
                    Datum_Rodjenja = ucProfileView.DtpDatumRodjenja.Value,
                    Sifra = ucProfileView.TxtSifra.Text
                };

                if (k.Ime == "") throw new KorisnikException("Unesi ime!", 1);
                if (k.Prezime == "") throw new KorisnikException("Unesi prezime!", 2);
                CommunicationClient.Instance.Register(k);




                MainCoordinator.Instance.ShowLoginFromRegistration();


            }

            catch (KorisnikException ex)
            {
                if (ex.Code == 1)
                    MainCoordinator.Instance.ValidateTb(ucProfileView.ValidationDictionary, ucProfileView.TxtIme, ex.Message);
                else if (ex.Code == 2)
                    MainCoordinator.Instance.ValidateTb(ucProfileView.ValidationDictionary, ucProfileView.TxtPrezime, ex.Message);
                else if (ex.Code == 3)
                    MainCoordinator.Instance.ValidateTb(ucProfileView.ValidationDictionary, ucProfileView.DtpDatumRodjenja, ex.Message);
                else if (ex.Code == 4)
                    MainCoordinator.Instance.ValidateTb(ucProfileView.ValidationDictionary, ucProfileView.TxtSifra, ex.Message);
                else if (ex.Code == 404)
                    MainCoordinator.Instance.ValidateTb(ucProfileView.ValidationDictionary, ucProfileView.TxtEmail, ex.Message);

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC:" + ex.Message);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Login funkcionalnost
        public Korisnik GetKorisnikFromForm()
        {
            Korisnik k = new Korisnik()
            {
                Email = frmLogin.TxtEmail.Text,
                Sifra = frmLogin.TxtSifra.Text,
            };
            return k;
        }

        public Administrator GetAdminFromForm()
        {
            Administrator k = new Administrator()
            {
                Email = frmLogin.TxtEmail.Text,
                Sifra = frmLogin.TxtSifra.Text,
            };
            return k;
        }

        public void BtnLoginOnClick(object sender, EventArgs e)
        {
            try
            {
                if (MainCoordinator.Instance.frmLogin.TxtEmail.Text == "") throw new KorisnikException("Popunite email!", 404);
                if (MainCoordinator.Instance.frmLogin.TxtSifra.Text == "") throw new KorisnikException("Popunite sifru!", 405);
                if (!frmLogin.CbAdmin.Checked)
                {
                    Korisnik k = GetKorisnikFromForm();
                    k = CommunicationClient.Instance.Login(k);
                    MainCoordinator.Instance.ulogovaniKorisnik = k;

                }
                else
                {
                    Administrator admin = GetAdminFromForm();
                    admin = CommunicationClient.Instance.Login(admin);
                    MainCoordinator.Instance.ulogovaniAdministrator = admin;
                }
                MainCoordinator.Instance.ShowMainFormFromLogin();

            }
            catch (KorisnikException ex)
            {
                if (ex.Code == 404)
                    MainCoordinator.Instance.ValidateTb(frmLogin.ValidationDictionary, frmLogin.TxtEmail, ex.Message);
                else if (ex.Code == 405)
                    MainCoordinator.Instance.ValidateTb(frmLogin.ValidationDictionary, frmLogin.TxtSifra, ex.Message);

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC:" + ex.Message);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void LblRegistrujSeClick(object sender, EventArgs e)
        {
            try
            {
                MainCoordinator.Instance.ShowRegistrationProcess();
            }

            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
