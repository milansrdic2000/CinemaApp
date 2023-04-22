using Bioskop.Common;
using Bioskop.Common.Exceptions;
using Bioskop.UserInterface.UserControls.ProjekcijeUc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Bioskop.UserInterface.GuiController
{
    public class ProjekcijaGuiController
    {
        FormMode formMode;
        UcAllProjekcijeFilma ucAllProjekcijeFilma;
        UcSingleProjekcijaFilma ucSingleProjekcijaFilma;

        FormMode formModeAll;

        #region SVE projekcije

        DataGridView dgvProjekcije;
        public ProjekcijaFilma IzabranaProjekcija;
        public UcAllProjekcijeFilma CreateAllProjekcijePrikaz(FormMode formMode = FormMode.ChooseSingleForEdit, ProjekcijaFilma filterProjekcija = null)
        {
            ucAllProjekcijeFilma = new UcAllProjekcijeFilma();

            dgvProjekcije = ucAllProjekcijeFilma.DgvListProjekcija;

            this.formModeAll = formMode;

            if (filterProjekcija == null)
            {
                ucAllProjekcijeFilma.DgvListProjekcija.DataSource = CommunicationClient.Instance.VratiSveProjekcije();

                ucAllProjekcijeFilma.TxtPretraga.TextChanged += PretragaOnTextChange;
            }

            else
            {
                ucAllProjekcijeFilma.PnlPretrazi.Dispose();
                ucAllProjekcijeFilma.TlpMain.ColumnCount = 1;
                ucAllProjekcijeFilma.DgvListProjekcija.DataSource = CommunicationClient.Instance.NadjiProjekcije(filterProjekcija);
            }

            ucAllProjekcijeFilma.BtnIzmeniProjekciju.Click += GoToIzmeniProjekcijuOnClick;

            if (formMode == FormMode.ChooseForReservation)
            {
                ucAllProjekcijeFilma.BtnIzmeniProjekciju.Text = "Predji na rezervisanje mesta!";
            }
            else
            {
                ucAllProjekcijeFilma.BtnIzmeniProjekciju.Text = "Izaberi projekciju!";
            }

            dgvProjekcije.Columns["Id"].Visible = false;
            dgvProjekcije.Columns["Film_Id"].Visible = false;

            dgvProjekcije.Columns["Datum_Projekcije"].HeaderText = "Datum";
            dgvProjekcije.Columns["Cena_Karte"].HeaderText = "Cena karte";
            dgvProjekcije.Columns["BioskopskaSala"].HeaderText = "Sala";

            return ucAllProjekcijeFilma;
        }

        public void GoToIzmeniProjekcijuOnClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjekcije.SelectedRows.Count <= 0) throw new Exception("Morate izabrati projekciju!");

                ProjekcijaFilma projekcija = (ProjekcijaFilma)dgvProjekcije.SelectedRows[0].DataBoundItem;

                projekcija = CommunicationClient.Instance.VratiProjekciju(projekcija);

                this.IzabranaProjekcija = projekcija;

                if (formModeAll == FormMode.ChooseSingleForEdit)
                    MainCoordinator.Instance.ShowIzmeniProjekciju(projekcija);

                else if (formModeAll == FormMode.ChooseForReservation)
                {
                    // provera da li ima rezervacije na ovu projekciju
                    Rezervacija rezervacija = new Rezervacija()
                    {
                        ProjekcijaFilma = projekcija,
                        Korisnik = MainCoordinator.Instance.ulogovaniKorisnik,
                        FilterFields = new FilterField[] { new FilterField("Korisnik_Id"), new FilterField("Projekcija_Id") }
                    };

                    rezervacija = CommunicationClient.Instance.VratiRezervaciju(rezervacija);

                    if (rezervacija != null)
                    {
                        DialogResult dr = MessageBox.Show("Vec imate rezervaciju na ovu projekciju. Zelite li da je izmenite?", "Rezervacija!", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                            MainCoordinator.Instance.ShowIzmenaRezervacije(rezervacija);

                        }
                        else
                        {
                            //projekcija.FilterFields = new FilterField[] { new FilterField("Id") };

                            projekcija.Film.FilterFieldsJoin = new FilterField[] { new FilterField("Id") };

                            MainCoordinator.Instance.ShowProjekcijeZaRezervaciju(projekcija);
                            return;
                        }
                    }
                    else
                    {
                        MainCoordinator.Instance.ShowIzborSedistaZaRezervaciju(this.IzabranaProjekcija);
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void PretragaOnTextChange(object sender, EventArgs e)
        {
            try
            {
                string txt = ucAllProjekcijeFilma.TxtPretraga.Text;
                if (txt.Length > 0)
                {
                    ProjekcijaFilma projekcija = new ProjekcijaFilma();
                    Film f = new Film();
                    f.Naziv_Filma = txt;
                    FilterField filter = new FilterField("Naziv_Filma", $"Naziv_Filma like @Naziv_Filma + '%'");
                    f.FilterFieldsJoin = new FilterField[] { filter };
                    projekcija.Film = f;

                    List<ProjekcijaFilma> listaProjekcija = CommunicationClient.Instance.NadjiProjekcije(projekcija);

                    ucAllProjekcijeFilma.DgvListProjekcija.DataSource = listaProjekcija;
                }
                else
                {
                    List<ProjekcijaFilma> listaProjekcija = CommunicationClient.Instance.VratiSveProjekcije();

                    ucAllProjekcijeFilma.DgvListProjekcija.DataSource = listaProjekcija;
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region POJEDINACNA projekcija


        private DataGridView dgvFilmovi;
        private ComboBox cbSala;
        private ComboBox cbTipProjekcije;
        private TextBox txtCenaKarte;
        private DateTimePicker dtpDatum;
        private Button btnSacuvaj;
        private Button btnIzmeni;

        private ProjekcijaFilma projekcijaZaIzmenu;
        FilmGuiController filmGuiController;
        public UcSingleProjekcijaFilma CreateSingleProjekcijaView(ProjekcijaFilma projekcija, FormMode formMode)
        {
            ucSingleProjekcijaFilma = new UcSingleProjekcijaFilma();
            this.formMode = formMode;


            //Dodeljivanje promenljivih
            dgvFilmovi = ucSingleProjekcijaFilma.DgvFilmovi;
            cbSala = ucSingleProjekcijaFilma.CbSale;
            cbTipProjekcije = ucSingleProjekcijaFilma.CbTipProjekcije;
            txtCenaKarte = ucSingleProjekcijaFilma.TxtCena;
            dtpDatum = ucSingleProjekcijaFilma.DtpDatumProj;
            btnSacuvaj = ucSingleProjekcijaFilma.BtnSacuvaj;
            btnIzmeni = ucSingleProjekcijaFilma.BtnIzmeni;

            //podesavamo format date pickera, datum plus vreme
            dtpDatum.Format = DateTimePickerFormat.Custom;
            //dtpDatum.ShowUpDown = true;
            //dtpDatum.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            //System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern;

            //mapiranje enuma, posto ne moze broj na pocetak
            Array a = Enum.GetValues(typeof(TipProjekcije));
            List<string> enumIspravljeno = new List<string>();
            foreach (TipProjekcije t in a)
            {
                enumIspravljeno.Add(t.ToString().Remove(0, 1));
            }
            cbTipProjekcije.DataSource = enumIspravljeno;

            //eventi
            btnSacuvaj.Click += SacuvajProjekcijuOnClick;
            btnIzmeni.Click += IzmeniProjekcijuOnClick;
            dgvFilmovi.DataBindingComplete += DgvFilmovi_DataBindingComplete;
            ucSingleProjekcijaFilma.TxtPretraga.TextChanged += TxtPretragaOnChange;

            HandleSwitchButtons();

            cbSala.DataSource = CommunicationClient.Instance.VratiSveBioskopskeSale();

            if (formMode == FormMode.EditSingle)
            {
                projekcijaZaIzmenu = projekcija;
                SetProjekcijaToGui(projekcija);

            }

            dgvFilmovi.DataSource = CommunicationClient.Instance.VratiSveFilmove();







            return ucSingleProjekcijaFilma;
        }
        private void DgvFilmovi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                //dgv Filmovi sredjivanje
                dgvFilmovi.Columns["Id"].Visible = false;
                dgvFilmovi.Columns["Opis_Filma"].Visible = false;
                dgvFilmovi.Columns["Datum_Premijere"].Visible = false;
                dgvFilmovi.Columns["Administrator"].Visible = false;

                //dgvFilmovi.Columns["Reziser"].Visible = false;
                //dgvFilmovi.Columns["Zanr"].Visible = false;
                dgvFilmovi.Columns["Naziv_Filma"].HeaderText = "Naziv";
                dgvFilmovi.Columns["Trajanje_U_Minutima"].HeaderText = "Minuti";
                //selektujemo onaj red koji ima film objekta koji se edituje trenutno

                if (formMode == FormMode.AddSingle) return;
                foreach (DataGridViewRow row in dgvFilmovi.Rows)
                {

                    Film f = (Film)row.DataBoundItem;
                    if (f.Equals(projekcijaZaIzmenu.Film))
                    {
                        dgvFilmovi.CurrentCell = row.Cells[1];
                        row.Selected = true;
                        break;
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        public void TxtPretragaOnChange(object sender, EventArgs e)
        {
            try
            {
                string txt = ucSingleProjekcijaFilma.TxtPretraga.Text;

                if (txt.Length > 0)
                {
                    Film f = new Film()
                    {
                        FilterFields = new FilterField[] { new FilterField("Naziv_Filma", "upper(Naziv_Filma) like @Naziv_Filma + '%'") },
                        Naziv_Filma = txt
                    };
                    dgvFilmovi.DataSource = CommunicationClient.Instance.NadjiFilmove(f);
                }
                else
                {
                    dgvFilmovi.DataSource = CommunicationClient.Instance.VratiSveFilmove();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void HandleSwitchButtons()
        {
            bool x = formMode == FormMode.AddSingle;
            btnSacuvaj.Visible = x;
            btnIzmeni.Visible = !x;
        }
        public ProjekcijaFilma GetProjekcijaFromGui()
        {

            if (dgvFilmovi.SelectedRows.Count <= 0) throw new Exception("Morate selektovati film!");
            if (cbSala.SelectedIndex == -1) throw new Exception("Morate izabrati salu!");

            Film f = (Film)dgvFilmovi.SelectedRows[0].DataBoundItem;
            BioskopskaSala sala = (BioskopskaSala)cbSala.SelectedItem;

            string tipProjekcije = "_" + cbTipProjekcije.SelectedItem.ToString();
            ProjekcijaFilma projekcija = new ProjekcijaFilma()
            {
                BioskopskaSala = sala,
                Film = f,
                Cena_Karte = Convert.ToDecimal(txtCenaKarte.Text),
                Datum_Projekcije = dtpDatum.Value,
                Tip_Projekcije = (TipProjekcije)Enum.Parse(typeof(TipProjekcije), tipProjekcije)
            };
            if (projekcijaZaIzmenu != null)
                projekcija.Id = projekcijaZaIzmenu.Id;

            return projekcija;
        }

        public void SetProjekcijaToGui(ProjekcijaFilma projekcija)
        {

            txtCenaKarte.Text = projekcija.Cena_Karte.ToString();
            dtpDatum.Value = projekcija.Datum_Projekcije;
            cbSala.SelectedItem = projekcija.BioskopskaSala;

            cbTipProjekcije.SelectedItem = projekcija.Tip_Projekcije.ToString().Remove(0, 1);

        }
        public void ClearAll()
        {
            ucSingleProjekcijaFilma.Dispose();
        }
        public void SacuvajProjekcijuOnClick(object sender, EventArgs e)
        {
            try
            {
                if (!ucSingleProjekcijaFilma.TxtCena.Text.IsNumber())
                    throw new ProjekcijaException("Cena mora biti broj!", 2);

                if (dtpDatum.Value.AddMinutes(5) < DateTime.Now)
                {
                    throw new ProjekcijaException("Nema smisla unositi projekciju u proslosti!", 1);
                }
                ProjekcijaFilma projekcija = GetProjekcijaFromGui();

                if (projekcija.Datum_Projekcije.Date < projekcija.Film.Datum_Premijere.Date) throw new ProjekcijaException($"Ne mozete staviti projekciju pre nego sto je premijera filma!{Environment.NewLine} Premijera filma {projekcija.Film.Naziv_Filma} je: {projekcija.Film.Datum_Premijere.ToString("dd. MMM yyyy.")}", 1);
                CommunicationClient.Instance.DodajProjekciju(projekcija);
                MessageBox.Show("Uspesno dodata projekcjia");
                ClearAll();

                MainCoordinator.Instance.ValidateTb(ucSingleProjekcijaFilma.validationDictionary, null, "");
            }
            catch (ProjekcijaException ex)
            {
                if (ex.Code == 1)
                {
                    MainCoordinator.Instance.ValidateTb(ucSingleProjekcijaFilma.validationDictionary, ucSingleProjekcijaFilma.DtpDatumProj, ex.Message);
                }
                if (ex.Code == 2)
                {
                    MainCoordinator.Instance.ValidateTb(ucSingleProjekcijaFilma.validationDictionary, ucSingleProjekcijaFilma.TxtCena, ex.Message);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void IzmeniProjekcijuOnClick(object sender, EventArgs e)
        {
            try
            {
                ProjekcijaFilma projekcija = GetProjekcijaFromGui();

                if (projekcija.Datum_Projekcije < projekcija.Film.Datum_Premijere) throw new Exception("Ne mozete staviti projekciju pre nego sto je premijera filma!");
                CommunicationClient.Instance.izmeniProjekciju(projekcija);

                MessageBox.Show("Uspesno izmenjena projekcjia");

                ClearAll();

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
