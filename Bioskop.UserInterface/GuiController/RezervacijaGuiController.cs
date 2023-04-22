using Bioskop.Common;
using Bioskop.Common.Model;
using Bioskop.UserInterface.UserControls;
using Bioskop.UserInterface.UserControls.RezervisanjeUc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Bioskop.UserInterface.GuiController
{
    public class KorakRezervacije
    {
        public int BrojKoraka { get; set; }
        public string TekstKoraka { get; set; }

        public bool DugmePotrebno { get; set; }
        public string TekstDugmeta { get; set; }
    }
    public class RezervacijaGuiController
    {
        private UcRezervisanje ucRezervisanje;

        private Label lblKorak;
        private Label lblFilmInfo;
        private Label lblProjekcijaInfo;



        private Button btnVratiSe;


        // izabrani filmovi i projekcije
        public Film Film;
        public ProjekcijaFilma ProjekcijaFilma;
        public Rezervacija Rezervacija;

        List<KorakRezervacije> listKorak = new List<KorakRezervacije>();
        KorakRezervacije trenutniKorak;

        public RezervacijaGuiController()
        {
            listKorak.Add(new KorakRezervacije() { BrojKoraka = 1, TekstKoraka = "Korak 1 - izaberite film za gledanje!" });
            listKorak.Add(new KorakRezervacije() { BrojKoraka = 2, TekstKoraka = "Korak 2 - izaberite projekciju filma!", DugmePotrebno = true, TekstDugmeta = "Vrati se na izbor filmova" });
            listKorak.Add(new KorakRezervacije() { BrojKoraka = 3, TekstKoraka = "Korak 3 - rezervisite mesto!", DugmePotrebno = true, TekstDugmeta = "Vrati se na izbor projekcija" });

            trenutniKorak = listKorak[0];
        }
        #region Izor Sedista za rezervisanje, 3. korak

        private UcOdabirSedista ucOdabirSedista;
        private DataGridView DgvRezSedista;

        private Sediste[,] matricaSedista;
        private int brKarata = 0;

        private List<Sediste> listSedista;



        FormMode frmRezervisiMod = FormMode.AddSingle;

        //Poslednji korak, gde biramo sedista
        public UcOdabirSedista CreateIzborSedista(Rezervacija rezervacija, FormMode formMode = FormMode.AddSingle)
        {



            ucOdabirSedista = new UcOdabirSedista();
            DgvRezSedista = ucOdabirSedista.DgvSedista;



            this.frmRezervisiMod = formMode;


            // ako korisnik nema vec rezervaciju, tj ako dodaje prvi put rez
            if (formMode == FormMode.AddSingle)
            {
                rezervacija.Korisnik = MainCoordinator.Instance.ulogovaniKorisnik;
                this.Rezervacija = rezervacija;
            }
            // ako editujemo rezervaciju
            else if (formMode == FormMode.EditSingle)
            {
                this.ProjekcijaFilma = rezervacija.ProjekcijaFilma;
                this.Film = rezervacija.ProjekcijaFilma.Film;
                this.Rezervacija = rezervacija;
            }





            //ucOdabirSedista.DgvSedista.DataSource = listSedista;

            //DgvRezSedista.Columns["Rezervisano"].ReadOnly = true;

            //ObojiDataGrid();

            listSedista = (CommunicationClient.Instance.VratiSedistaSaDostupnosti(rezervacija).ListSedistaSaDostupnosti);

            //PRAVLJENJE SEDISTA IZGLEDA DGV

            PripremiFormu();

            //eventi
            ucOdabirSedista.BtnRezervisiMesta.Click += RezervisiOnClick;
            DgvRezSedista.DataBindingComplete += DgvSedistaDataBindingComplete;
            DgvRezSedista.CellBeginEdit += DgvSedistaCellBeginEdit;
            DgvRezSedista.SelectionChanged += DgvSediste_SelectionChanged;

            DgvRezSedista.CellMouseEnter += dgvSedistePrikaz_CellMouseEnter;
            DgvRezSedista.CellMouseLeave += dgvSedistePrikaz_CellMouseLeave;
            DgvRezSedista.ColumnWidthChanged += dgvSedistePrikaz_ColumnWidthChanged;
            DgvRezSedista.CellClick += dgvSedista_CellClick;

            OsveziPodatkeORez();

            return ucOdabirSedista;
        }
        public void PripremiFormu()
        {
            int kolone = IzracunajBrojKolona(listSedista, out int redovi);
            matricaSedista = new Sediste[redovi, kolone];
            brojKarata = 0;

            Console.WriteLine("test:" + matricaSedista.Length.ToString());
            Console.WriteLine("Vraceni redovi i kolone:" + redovi + "," + kolone);
            NapraviGridSedista(kolone, redovi);
            MapirajSedista(listSedista);
            ObojiDataGrid();
        }
        #region Napravi dgv sa slicicama i to
        public void NapraviGridSedista(int Kolona, int Red)
        {
            DgvRezSedista.Rows.Clear();
            DgvRezSedista.Columns.Clear();

            DgvRezSedista.Cursor = Cursors.Hand;
            // dgvSedistePrikaz.RowTemplate.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            for (int j = 0; j < Kolona; j++)
            {
                DataGridViewImageColumn column = new DataGridViewImageColumn();
                column.HeaderText = (j + 1).ToString();
                column.Name = (j + 1).ToString();
                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //column.FillWeight = Convert.ToInt32(1.0 / Kolona * 100);
                column.Width = 100;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;


                //Console.WriteLine("Procenat: " + (1.0 / Kolona * 100).ToString());
                DgvRezSedista.Columns.Add(column);


            }
            for (int i = 0; i < Red; i++)
            {
                DgvRezSedista.Rows.Add();
                DgvRezSedista.Rows[i].Height = DgvRezSedista.Columns[0].Width;
                DgvRezSedista.Rows[i].HeaderCell.Value = (i + 1).ToString();

                for (int j = 0; j < Kolona; j++)
                {
                    DataGridViewCell cell = DgvRezSedista[j, i];
                    DgvRezSedista[j, i].Value = Properties.Resources.sediste;



                }

            }

        }

        public int IzracunajBrojKolona(List<Sediste> listSedista, out int redovi)
        {
            redovi = 0;
            int brKolona = 0;

            for (int i = 0; i < listSedista.Count; i++)
            {
                if (listSedista[i].Kolona > brKolona) brKolona = listSedista[i].Kolona;
                if (listSedista[i].Red > redovi) redovi = listSedista[i].Red;
            }

            return brKolona;
        }
        public void MapirajSedista(List<Sediste> listSedista)
        {
            for (int i = 0; i < listSedista.Count; i++)
            {
                int kolona = listSedista[i].Kolona - 1;
                int red = listSedista[i].Red - 1;
                Console.WriteLine("red i kolona:" + red + "," + kolona);
                matricaSedista[red, kolona] = listSedista[i];

            }
        }
        public void ObojiDataGrid()
        {
            /* foreach (DataGridViewRow row in DgvRezSedista.Rows)
             {
                 Sediste s = (Sediste)row.DataBoundItem;

                 if (s.MojeRezervisano)
                     row.DefaultCellStyle.BackColor = Color.Red;
                 else if (s.Rezervisano)
                     row.DefaultCellStyle.BackColor = Color.Gray;
             }*/
            for (int i = 0; i < DgvRezSedista.Rows.Count; i++)
            {
                for (int j = 0; j < DgvRezSedista.Columns.Count; j++)
                {
                    DataGridViewCell cell = DgvRezSedista[j, i];

                    Sediste s = matricaSedista[i, j];
                    if (s == null)
                    {
                        cell.Value = Properties.Resources.x;
                        continue;
                    }
                    Console.WriteLine(s.ToString());
                    if (s.MojeRezervisano)
                    {
                        cell.Value = Properties.Resources.mojeZauzetoSediste;
                        brojKarata++;
                    }
                    else if (s.Rezervisano)
                        cell.Value = Properties.Resources.zauzetoSediste;

                }
            }
            DgvRezSedista.Refresh();
        }
        //menjanje rezervacije
        private void dgvSedista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                Sediste s = matricaSedista[e.RowIndex, e.ColumnIndex];
                DataGridViewCell cell = DgvRezSedista[e.ColumnIndex, e.RowIndex];

                if (s == null) throw new Exception("Nazalost, ovo sediste je izbaceno iz sale!");
                // ako je necije tudje sediste
                if (s.Rezervisano && s.MojeRezervisano == false)
                {

                    throw new Exception("Sediste je rezervisano vec!");

                }
                // ako je moje sediste
                else if (s.MojeRezervisano == true)
                {
                    cell.Value = Properties.Resources.sediste;
                    s.Rezervisano = false;
                    s.MojeRezervisano = false;
                    brojKarata--;

                    if (s.CrudStatus != CrudStatus.Create)
                        s.CrudStatus = CrudStatus.Delete;

                    if (s.CrudStatus == CrudStatus.Create)
                    {
                        s.CrudStatus = CrudStatus.Default;
                    }

                }
                //ako je sediste slobodno
                else if (s.MojeRezervisano == false)
                {
                    s.Rezervisano = true;
                    s.MojeRezervisano = true;
                    cell.Value = Properties.Resources.mojeZauzetoSediste;
                    brojKarata++;

                    if (s.CrudStatus != CrudStatus.Delete)
                        s.CrudStatus = CrudStatus.Create;
                    else
                    {
                        s.CrudStatus = CrudStatus.Default;
                    }
                }
                OsveziPodatkeORez();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void DgvSedistaCellBeginEdit(object sender,
        DataGridViewCellCancelEventArgs e)
        {

        }
        private void dgvSedistePrikaz_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            try
            {
                /*if (e.Column.Width > 200)
                {
                    Console.WriteLine(e.Column.Index);
                    e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                else
                {
                    e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvSedistePrikaz_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
                DataGridViewCell cell = DgvRezSedista[e.ColumnIndex, e.RowIndex];
                //cell.Value = Properties.Resources.sedisteHover;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void dgvSedistePrikaz_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
                DataGridViewCell cell = DgvRezSedista[e.ColumnIndex, e.RowIndex];
                //cell.Value = Properties.Resources.sediste;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        //dgv sediste eventi
        public void DgvSedistaDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                ObojiDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void DgvSediste_SelectionChanged(Object sender, EventArgs e)
        {
            try
            {
                DgvRezSedista.ClearSelection();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void RezervisiOnClick(object sender, EventArgs e)
        {
            try
            {
                //if (DgvRezSedista.SelectedRows.Count <= 0) throw new Exception("Izaberite sediste za rezervisanje!");


                List<Karta> ListKarta = new List<Karta>();

                //za svaki selektovani red, pravimo kartu i proveravamo da l je ona rezervisana
                for (int i = 0; i < DgvRezSedista.Rows.Count; i++)
                {
                    for (int j = 0; j < DgvRezSedista.Columns.Count; j++)
                    {
                        Sediste s = matricaSedista[i, j];

                        if (s == null) continue;

                        Karta k = new Karta()
                        {
                            Sediste = s,
                            Projekcija_Id = ProjekcijaFilma.Id,
                            Korisnik_Id = MainCoordinator.Instance.ulogovaniKorisnik.Id,
                        };

                        if (s.CrudStatus == CrudStatus.Create)
                        {
                            if (CommunicationClient.Instance.IsSedisteReservisano(s, ProjekcijaFilma))
                            {

                                listSedista = (CommunicationClient.Instance.VratiSedistaSaDostupnosti(Rezervacija).ListSedistaSaDostupnosti);
                                PripremiFormu();
                                throw new Exception($"Sediste {s.ToString()} je zauzeto!");

                            }
                        }
                        if (s.CrudStatus == CrudStatus.Create)
                            ListKarta.Add(k);
                        else if (s.CrudStatus == CrudStatus.Delete)
                        {
                            ListKarta.Add(k);
                        }
                    }
                }
                ObojiDataGrid();
                Rezervacija rez = new Rezervacija()
                {
                    Datum_Rezervacije = DateTime.Now,
                    Korisnik = MainCoordinator.Instance.ulogovaniKorisnik,
                    //ovo treba
                    ProjekcijaFilma = ProjekcijaFilma,

                    //testing
                    /*  ProjekcijaFilma = new ProjekcijaFilma() { Id = 2, BioskopskaSala = new BioskopskaSala() { Id = 5003 }, },*/
                    ListKarta = ListKarta
                };

                if (frmRezervisiMod == FormMode.AddSingle)
                {
                    CommunicationClient.Instance.DodajRezervaciju(rez);
                    MessageBox.Show("Uspesno dodata rezervacija!");
                }
                else if (frmRezervisiMod == FormMode.EditSingle)
                {
                    CommunicationClient.Instance.IzmeniRezervaciju(rez);
                    MessageBox.Show("Uspesno izmenjena rezervacija!");
                }



                ucRezervisanje.Dispose();
                Film = null;
                ProjekcijaFilma = null;
                Rezervacija = null;
                matricaSedista = null;
                brojKarata = 0;
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        #endregion

        #region Kreiranje rezervacije - pocetak


        public UcRezervisanje CreateRezervisanje()
        {
            ucRezervisanje = new UcRezervisanje();

            Film = null;
            ProjekcijaFilma = null;
            Rezervacija = null;
            brojKarata = 0;

            lblFilmInfo = ucRezervisanje.LblIzabraniFilm;
            lblProjekcijaInfo = ucRezervisanje.LblIzabranaProjekcija;

            lblKorak = ucRezervisanje.LblKorak;
            lblKorak.Text = "Prvi korak - odaberite zeljeni film!";
            lblKorak.Font = new System.Drawing.Font("cascadia mono", 13);
            //lblKorak.Size = new System.Drawing.Size(ucRezervisanje.Width, 500);


            btnVratiSe = ucRezervisanje.BtnVratiSe;
            btnVratiSe.Text = "Vrati se";
            btnVratiSe.Click += VratiSeOnClick;

            //ChangeControl(filmGuiController.CreateAllUcFilmView());

            //Film = filmGuiController.selectedFilm;

            //ovo treba
            MainCoordinator.Instance.ShowFilmoveZaRezervaciju();

            //testing
            //MainCoordinator.Instance.ShowIzborSedistaZaRezervaciju(new BioskopskaSala() { Id = 5003 });

            return ucRezervisanje;
        }
        public void VratiSeOnClick(object sender, EventArgs e)
        {
            try
            {
                if (trenutniKorak.BrojKoraka == 3)
                {
                    MainCoordinator.Instance.ShowProjekcijeZaRezervaciju(ProjekcijaFilma);
                    ProjekcijaFilma = null;
                    Rezervacija = null;
                    brojKarata = 0;
                    OsveziPodatkeORez();


                }
                else if (trenutniKorak.BrojKoraka == 2)
                {
                    MainCoordinator.Instance.ShowFilmoveZaRezervaciju();
                    Film = null;
                    Rezervacija = null;
                    ProjekcijaFilma = null;
                    brojKarata = 0;
                    OsveziPodatkeORez();
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        int brojKarata = 0;
        int cena = 0;
        int? ukupnaCena = 0;
        public void OsveziPodatkeORez()
        {
            //lblProjekcijaInfo.Text = "/";
            //lblProjekcijaInfo.Text = "/";
            lblFilmInfo.Text = Film?.ToString();
            lblProjekcijaInfo.Text = ProjekcijaFilma?.ToString();
            //ucRezervisanje.LblBrojKarata.Text = Rezervacija?.ListKarta?.Count.ToString();
            ucRezervisanje.LblBrojKarata.Text = brojKarata.ToString();
            ucRezervisanje.LblCena.Text = ProjekcijaFilma?.Cena_Karte.ToString();

            decimal? ukupnaCena = brojKarata * Rezervacija?.ProjekcijaFilma?.Cena_Karte;

            if (ukupnaCena.HasValue)
                ucRezervisanje.LblUkupnaCena.Text = ukupnaCena.Value.ToString();
            else ucRezervisanje.LblUkupnaCena.Text = "";

        }
        public void ChangeMainControl(Control control, int korakIndex)
        {

            ucRezervisanje.PnlMainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ucRezervisanje.PnlMainContent.Controls.Add(control);

            trenutniKorak = listKorak[korakIndex];
            lblKorak.Text = trenutniKorak.TekstKoraka.ToString();


            if (!trenutniKorak.DugmePotrebno)
            {
                btnVratiSe.Text = "/";
            }
            else
            {
                btnVratiSe.Text = trenutniKorak.TekstDugmeta;
            }


            if (trenutniKorak.BrojKoraka > 1)
            {
                //ucRezervisanje.PnlMain.Controls.Add();
            }

            if (Film != null)
            {
                lblFilmInfo.Text = Film.ToString();
            }
            else
            {
                lblFilmInfo.Text = "/";
            }
            if (ProjekcijaFilma != null)
            {
                lblProjekcijaInfo.Text = ProjekcijaFilma.ToString();
            }
            else
            {
                lblProjekcijaInfo.Text = "/";
            }

        }
        #endregion

        #region Prikaz svih rezervacija i edit

        private UcAllRezervacije ucAllRezervacije;
        private DataGridView DgvRezervacijeSve;
        public UcAllRezervacije CreateAllRezervacije()
        {
            ucAllRezervacije = new UcAllRezervacije();

            DgvRezervacijeSve = ucAllRezervacije.DgvRezervacije;

            ucAllRezervacije.DgvRezervacije.DataSource = CommunicationClient.Instance.NadjiRezervacije(new Rezervacija()
            {
                Korisnik = MainCoordinator.Instance.ulogovaniKorisnik,
                FilterFields = new FilterField[] { new FilterField("Korisnik_Id") }
            });

            ucAllRezervacije.BtnIzaberiRez.Click += IzaberiRezervacijuOnClick;

            DgvRezervacijeSve.Columns["Korisnik"].Visible = false;

            DgvRezervacijeSve.Columns["Projekcija_Id"].Visible = false;
            DgvRezervacijeSve.Columns["ProjekcijaFilma"].HeaderText = "Projekcija";
            DgvRezervacijeSve.Columns["Datum_Rezervacije"].HeaderText = "Datum rezervacije ";

            return ucAllRezervacije;
        }

        public void IzaberiRezervacijuOnClick(object sender, EventArgs e)
        {
            try
            {
                if (DgvRezervacijeSve.SelectedRows.Count <= 0) throw new Exception("Niste izabrali rezervaciju!");

                Rezervacija rez = (Rezervacija)DgvRezervacijeSve.SelectedRows[0].DataBoundItem;

                rez.FilterFields = new FilterField[] { new FilterField("Korisnik_Id"), new FilterField("Projekcija_Id") };
                rez = CommunicationClient.Instance.VratiRezervaciju(rez);

                MainCoordinator.Instance.ShowIzmenaRezervacije(rez);

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
