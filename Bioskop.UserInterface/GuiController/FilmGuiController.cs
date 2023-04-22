using Bioskop.Common;
using Bioskop.Common.Exceptions;
using Bioskop.UserInterface.UserControls.Film;
using Bioskop.UserInterface.UserControls.FilmUc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Bioskop.UserInterface.GuiController
{
    public class FilmGuiController
    {


        #region SINGLE FILM VIEW
        private UcSingleFilmView ucSingleFilmView;
        public Film filmForEdit;
        private FormMode formModeSingle;
        public UcSingleFilmView CreateSingleUcFilmView(FormMode formMode, Film film)
        {
            ucSingleFilmView = new UcSingleFilmView();

            this.formModeSingle = formMode;
            this.filmForEdit = film;
            // punimo ZANROVE
            List<Zanr> listZanrova = CommunicationClient.Instance.VratiSveZanrove();

            ucSingleFilmView.CbZanrovi.DataSource = listZanrova;

            //- punimo REZISERE
            List<Reziser> listReziser = CommunicationClient.Instance.VratiSveRezisere();
            ;
            ucSingleFilmView.CbReziseri.DataSource = listReziser;


            //eventi

            ucSingleFilmView.BtnDodaj.Click += KreirajFilm;
            ucSingleFilmView.BtnIzmei.Click += IzmeniFilm;

            if (formMode == FormMode.EditSingle || formMode == FormMode.ReadOnly)
            {
                PopulateFilm(film);
                HandleFormModeSwitch(false);
            }
            else
            {
                HandleFormModeSwitch(true);
            }

            return ucSingleFilmView;
        }
        public Film getFilmFromForm()
        {

            Film film = new Film()
            {
                Administrator = MainCoordinator.Instance.ulogovaniAdministrator,
                Datum_Premijere = ucSingleFilmView.DtpDatumPremijere.Value,
                Naziv_Filma = ucSingleFilmView.TxtNazivFilma.Text,
                Opis_Filma = ucSingleFilmView.TxtOpis.Text,
                Reziser = (Reziser)ucSingleFilmView.CbReziseri.SelectedItem,
                Zanr = (Zanr)ucSingleFilmView.CbZanrovi.SelectedItem,

                Trajanje_U_Minutima = Convert.ToInt32(ucSingleFilmView.TxtTrajanje.Text),

            };
            return film;
        }
        public void PopulateFilm(Film film)
        {
            ucSingleFilmView.TxtNazivFilma.Text = film.Naziv_Filma;
            ucSingleFilmView.TxtOpis.Text = film.Opis_Filma;
            ucSingleFilmView.TxtTrajanje.Text = film.Trajanje_U_Minutima.ToString();
            ucSingleFilmView.CbReziseri.SelectedItem = film.Reziser;
            ucSingleFilmView.CbZanrovi.SelectedItem = film.Zanr;
            ucSingleFilmView.DtpDatumPremijere.Value = film.Datum_Premijere;
        }
        public void HandleFormModeSwitch(bool IsCreateMode)
        {

            if (formModeSingle == FormMode.ReadOnly)
            {
                ucSingleFilmView.BtnDodaj.Visible = false;
                ucSingleFilmView.BtnIzmei.Visible = false;

                ucSingleFilmView.TxtNazivFilma.ReadOnly = true;
                ucSingleFilmView.TxtOpis.ReadOnly = true;
                ucSingleFilmView.TxtTrajanje.ReadOnly = true;
                ucSingleFilmView.DtpDatumPremijere.Enabled = false;
                ucSingleFilmView.CbReziseri.Enabled = false;
                ucSingleFilmView.CbZanrovi.Enabled = false;

                ucSingleFilmView.LblTitle.Text = "Pregled filma";

                return;
            }
            ucSingleFilmView.BtnDodaj.Visible = IsCreateMode;
            ucSingleFilmView.BtnIzmei.Visible = !IsCreateMode;


            if (IsCreateMode) ucSingleFilmView.LblTitle.Text = "Dodaj film";
            else ucSingleFilmView.LblTitle.Text = "Izmeni film";
        }
        public void KreirajFilm(object sender, EventArgs e)
        {
            try
            {
                if (!ucSingleFilmView.TxtTrajanje.Text.IsNumber())
                {
                    throw new FilmException("Trajanje mora biti u minutima (brojevima)!", 2);
                }
                Film film = getFilmFromForm();



                CommunicationClient.Instance.DodajFilm(film);

                ucSingleFilmView.Dispose();
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (FilmException ex)
            {
                if (ex.Code == 1)
                    MainCoordinator.Instance.ValidateTb(ucSingleFilmView.validationDictionary, ucSingleFilmView.TxtNazivFilma, ex.Message);

                else if (ex.Code == 2)
                {
                    MainCoordinator.Instance.ValidateTb(ucSingleFilmView.validationDictionary, ucSingleFilmView.TxtTrajanje, ex.Message);
                }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void IzmeniFilm(object sender, EventArgs e)
        {
            try
            {
                if (!ucSingleFilmView.TxtTrajanje.Text.IsNumber())
                {
                    throw new FilmException("Trajanje mora biti u minutima (brojevima)!", 2);
                }

                Film film = getFilmFromForm();
                film.Id = filmForEdit.Id;



                CommunicationClient.Instance.IzmeniFilm(film);

                ucSingleFilmView.Dispose();

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (FilmException ex)
            {
                if (ex.Code == 1)
                    MainCoordinator.Instance.ValidateTb(ucSingleFilmView.validationDictionary, ucSingleFilmView.TxtNazivFilma, ex.Message);

                else if (ex.Code == 2)
                {
                    MainCoordinator.Instance.ValidateTb(ucSingleFilmView.validationDictionary, ucSingleFilmView.TxtTrajanje, ex.Message);
                }
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ALL FILM VIEW

        private UcAllFilmView ucAllFilmView;
        public Film selectedFilm;
        DataGridView dgvFilmovi;
        FormMode formModeForAll;
        public UcAllFilmView CreateAllUcFilmView(FormMode formMode = FormMode.ChooseSingleForEdit)
        {
            ucAllFilmView = new UcAllFilmView();

            dgvFilmovi = ucAllFilmView.DgvFilmoviLista;

            dgvFilmovi.DataSource = CommunicationClient.Instance.VratiSveFilmove();

            //dgv Filmovi sredjivanje
            dgvFilmovi.Columns["Id"].Visible = false;
            dgvFilmovi.Columns["Opis_Filma"].Visible = false;
            dgvFilmovi.Columns["Datum_Premijere"].Visible = false;
            dgvFilmovi.Columns["Administrator"].Visible = false;

            //dgvFilmovi.Columns["Reziser"].Visible = false;
            //dgvFilmovi.Columns["Zanr"].Visible = false;
            dgvFilmovi.Columns["Naziv_Filma"].HeaderText = "Naziv";
            dgvFilmovi.Columns["Trajanje_U_Minutima"].HeaderText = "Minuti";
            //eventi

            dgvFilmovi.SelectionChanged += CheckSelection;
            ucAllFilmView.BtnIzmeni.Click += EditSingleFilm;
            ucAllFilmView.TxtPretraga.TextChanged += TxtPretragaOnTxtChange;


            ucAllFilmView.AutoSize = true;

            this.formModeForAll = formMode;

            return ucAllFilmView;
        }
        public void CheckSelection(object sender, EventArgs e)
        {

        }
        //pretraga
        public void TxtPretragaOnTxtChange(object sender, EventArgs e)
        {
            try
            {
                TextBox txtPretraga = ucAllFilmView.TxtPretraga;
                if (txtPretraga.Text.Length > 0)
                {
                    Film film = new Film()
                    {
                        Naziv_Filma = txtPretraga.Text,
                        Datum_Premijere = new DateTime(2023, 1, 13),
                        FilterFields = new FilterField[] { new FilterField("Naziv_Filma", $" lower(naziv_filma) like @Naziv_Filma+'%'") }
                    };
                    List<Film> listaFilmova = CommunicationClient.Instance.NadjiFilmove(film);

                    dgvFilmovi.DataSource = listaFilmova;
                }
                else
                {
                    List<Film> listaFilmova = CommunicationClient.Instance.VratiSveFilmove();

                    dgvFilmovi.DataSource = listaFilmova;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC in film pretraga...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //btn izmeni klik event handler, edit film ili IZABERI PROJEKCIJU ZA REZERVACIJU
        public void EditSingleFilm(object sender, EventArgs e)
        {
            try
            {
                if (dgvFilmovi.SelectedRows.Count <= 0) throw new Exception("Niste izabrali nijedan film");

                selectedFilm = (Film)dgvFilmovi.SelectedRows[0].DataBoundItem;

                Film svezFilm = CommunicationClient.Instance.VratiFilm(selectedFilm);

                if (formModeForAll == FormMode.ChooseSingleForEdit)
                    MainCoordinator.Instance.ShowIzmeniFilm(svezFilm);
                else if (formModeForAll == FormMode.ChooseForReservation)
                {
                    svezFilm.FilterFieldsJoin = new FilterField[] { new FilterField("Id") };
                    MainCoordinator.Instance.ShowProjekcijeZaRezervaciju(new ProjekcijaFilma() { Film = svezFilm, FilterFields = new FilterField[] { new FilterField("Datum_Projekcije", "Datum_Projekcije > @Datum_Projekcije") }, Datum_Projekcije = DateTime.Now });
                }
                else if (formModeForAll == FormMode.ReadOnly)
                {
                    MainCoordinator.Instance.ShowPregledajFilm(svezFilm);

                }
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
