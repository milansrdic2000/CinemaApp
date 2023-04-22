using Bioskop.Common;
using Bioskop.Common.Exceptions;
using Bioskop.Common.Model;
using Bioskop.UserInterface.UserControls.BioskSalaUc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bioskop.UserInterface.GuiController
{
    public class SalaGuiController
    {
        #region Single bioskopska sala

        private BioskopskaSala BioskopskaSala { get; set; }
        public UcSingleBioskopskaSala UcSingleBioskopskaSala { get; set; }

        BindingList<Sediste> ListSediste;

        List<Sediste> ListSedisteZaBrisanje;

        private FormMode FormModeTrenutni;
        public UcSingleBioskopskaSala CreateSingleBioskopskaSala(FormMode formMode, BioskopskaSala sala = null)
        {
            UcSingleBioskopskaSala = new UcSingleBioskopskaSala();
            this.FormModeTrenutni = formMode;

            ListSediste = new BindingList<Sediste>();
            ListSedisteZaBrisanje = new List<Sediste>();

            this.UcSingleBioskopskaSala.DgvSedista.DataSource = ListSediste;
            this.UcSingleBioskopskaSala.DgvSedista.CellValueChanged += DgvSedistaValueChanged;
            this.UcSingleBioskopskaSala.DgvSedista.CellBeginEdit += dataGridView1_CellBeginEdit;

            this.UcSingleBioskopskaSala.BtnDodajSedist.Click += DodajSediste;
            this.UcSingleBioskopskaSala.BtnDodajSalu.Click += DodajBioskopskuSalu;
            this.UcSingleBioskopskaSala.BtnObrisiSediste.Click += ObrisiSediste;
            this.UcSingleBioskopskaSala.BtnIzmeniSalu.Click += IzmeniBioskopskuSalu;
            this.UcSingleBioskopskaSala.BtnGenerisiSediste.Click += GenerisiSedistaMatrica;


            if (formMode == FormMode.EditSingle)
            {
                if (sala == null) throw new Exception("Niste naveli bioskopsku salu! (null je)");


                BioskopskaSala = sala;


                //UcSingleBioskopskaSala.PopulateBioskopskaSala(BioskopskaSala);
                this.UcSingleBioskopskaSala.TxtNazivsale.Text = sala.Naziv_Sale;


                ListSediste = new BindingList<Sediste>(BioskopskaSala.ListSedista);
                this.UcSingleBioskopskaSala.DgvSedista.DataSource = ListSediste;

                HandleSwitchModes(false);
            }
            else
            {
                HandleSwitchModes(true);
            }
            DataGridView dgvSediste = this.UcSingleBioskopskaSala.DgvSedista;

            dgvSediste.Columns["Sediste_Id"].Visible = false;
            dgvSediste.Columns["CrudStatus"].Visible = false;
            dgvSediste.Columns["Rezervisano"].Visible = false;
            dgvSediste.Columns["MojeRezervisano"].Visible = false;


            return UcSingleBioskopskaSala;
        }
        public void GenerisiSedistaMatrica(object sender, EventArgs e)
        {
            try
            {

                //ListSediste.Clear();
                //UcSingleBioskopskaSala.DgvSedista.DataSource = ListSediste;

                if (!UcSingleBioskopskaSala.TxtRedoviGenerisani.Text.IsNumber()) throw new SalaException("Unesi broj!", 1);
                if (!UcSingleBioskopskaSala.TxtKoloneGenerisane.Text.IsNumber()) throw new SalaException("Unesi broj!", 2);

                int kolone = Convert.ToInt32(UcSingleBioskopskaSala.TxtKoloneGenerisane.Text);
                int red = Convert.ToInt32(UcSingleBioskopskaSala.TxtRedoviGenerisani.Text);


                ObrisiSve();
                for (int i = 1; i <= red; i++)
                {
                    for (int j = 1; j <= kolone; j++)
                    {
                        Sediste s = new Sediste()
                        {
                            Red = i,
                            Kolona = j,
                            CrudStatus = CrudStatus.Create,
                        };
                        if (FormModeTrenutni == FormMode.EditSingle)
                        {
                            s.Sala_Id = BioskopskaSala.Id;
                        }
                        ListSediste.Add(s);
                    }
                }

                MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, null, "");
            }
            catch (SalaException ex)
            {
                if (ex.Code == 1)
                {
                    MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, UcSingleBioskopskaSala.TxtRedoviGenerisani, ex.Message);
                }
                if (ex.Code == 2)
                {
                    MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, UcSingleBioskopskaSala.TxtKoloneGenerisane, ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void HandleSwitchModes(bool isCreateMode)
        {
            this.UcSingleBioskopskaSala.BtnDodajSalu.Visible = isCreateMode;
            this.UcSingleBioskopskaSala.BtnIzmeniSalu.Visible = !isCreateMode;
        }
        public void DodajSediste(object sender, EventArgs e)
        {
            try
            {
                if (!UcSingleBioskopskaSala.TxtRed.Text.IsNumber()) throw new SalaException("Morate uneti brojcanu vrednost!", 3);
                if (!UcSingleBioskopskaSala.TxtKolona.Text.IsNumber()) throw new SalaException("Morate uneti brojcanu vrednost!", 4);

                Sediste s = new Sediste()
                {
                    Red = Int32.Parse(UcSingleBioskopskaSala.TxtRed.Text),
                    Kolona = Int32.Parse(UcSingleBioskopskaSala.TxtKolona.Text),
                };

                if (ListSediste.DaLiSedistePostojiUsali(s))
                {
                    MessageBox.Show("Postoji vec ovakvo sediste");
                }
                else
                {
                    s.CrudStatus = CrudStatus.Create;

                    if (FormModeTrenutni == FormMode.EditSingle)
                    {
                        s.Sala_Id = BioskopskaSala.Id;
                    }
                    ListSediste.Add(s);
                    MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, null, "");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC film");
            }
            catch (SalaException ex)
            {
                if (ex.Code == 3)
                {
                    MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, UcSingleBioskopskaSala.TxtRed, ex.Message);
                }
                if (ex.Code == 4)
                {
                    MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, UcSingleBioskopskaSala.TxtKolona, ex.Message);
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void ObrisiSediste(object sender, EventArgs e)
        {
            try
            {
                if (UcSingleBioskopskaSala.DgvSedista.SelectedRows.Count <= 0) throw new Exception("Niste izabrali sediste za brisanje!");

                Sediste s = (Sediste)UcSingleBioskopskaSala.DgvSedista.SelectedRows[0].DataBoundItem;



                ListSediste.Remove(s);

                //PROVERA da li je sediste dodato u GUIJU od korisnika, ili je vraceno i skladisteno u bazi 
                if (s.CrudStatus == CrudStatus.Create)
                {
                    //MessageBox.Show("korisnik dodao sad, nista");
                }
                else
                {
                    s.CrudStatus = CrudStatus.Delete;
                    ListSedisteZaBrisanje.Add(s);
                }
            }

            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void ObrisiSve()
        {
            if (UcSingleBioskopskaSala.DgvSedista.Rows.Count <= 0) return;
            foreach (DataGridViewRow row in UcSingleBioskopskaSala.DgvSedista.Rows)
            {
                Sediste s = (Sediste)row.DataBoundItem;


                //PROVERA da li je sediste dodato u GUIJU od korisnika, ili je vraceno i skladisteno u bazi 
                if (s.CrudStatus == CrudStatus.Create)
                {
                    //MessageBox.Show("korisnik dodao sad, nista");
                }
                else
                {
                    s.CrudStatus = CrudStatus.Delete;
                    ListSedisteZaBrisanje.Add(s);
                }
            }
            ListSediste.Clear();
        }
        int oldvalue;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 1 && e.ColumnIndex != 2)
                {
                    throw new Exception("Ne mozete menjati ove kolone");
                }
                oldvalue = (int)UcSingleBioskopskaSala.DgvSedista[e.ColumnIndex, e.RowIndex].Value;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void DgvSedistaValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 1 && e.ColumnIndex != 2)
                {
                    throw new Exception("Ne mozete menjati ove kolone");
                }
                Sediste s = (Sediste)UcSingleBioskopskaSala.DgvSedista.Rows[e.RowIndex].DataBoundItem;


                foreach (Sediste sed in ListSediste)
                {
                    if (sed == s) continue;
                    if (sed.Red == s.Red && sed.Kolona == s.Kolona)
                    {
                        //UcSingleBioskopskaSala.DgvSedista.Cance();
                        UcSingleBioskopskaSala.DgvSedista[e.ColumnIndex, e.RowIndex].Value = oldvalue;
                        throw new Exception("Vec postoji sediste sa ovim redom i kolonom!");
                    }
                }

                if (s.CrudStatus == CrudStatus.Create) return;
                s.CrudStatus = CrudStatus.Update;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ClearAll()
        {
            UcSingleBioskopskaSala.Dispose();
        }
        public void DodajBioskopskuSalu(object sender, EventArgs e)
        {
            try
            {

                BioskopskaSala sala = new BioskopskaSala()
                {
                    Naziv_Sale = UcSingleBioskopskaSala.TxtNazivsale.Text
                };
                sala.ListSedista = ListSediste.ToList();

                /*foreach (Sediste s in ListSediste)
                {
                    s.BioskopskaSala = sala;
                }*/

                CommunicationClient.Instance.DodajBioskopskuSalu(sala);


                ClearAll();

            }
            catch (SalaException ex)
            {
                if (ex.Code == 0)
                {
                    MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, UcSingleBioskopskaSala.TxtNazivsale, ex.Message);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC dodaj salu");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void IzmeniBioskopskuSalu(object sender, EventArgs e)
        {
            try
            {
                BioskopskaSala sala = new BioskopskaSala()
                {
                    Naziv_Sale = UcSingleBioskopskaSala.TxtNazivsale.Text
                };

                BioskopskaSala.ListSedista = ListSediste.ToList();
                BioskopskaSala.Naziv_Sale = sala.Naziv_Sale;
                BioskopskaSala.ListaSedistaZaBrisanje = this.ListSedisteZaBrisanje;
                /*foreach (Sediste s in ListSediste)
                {
                    s.BioskopskaSala = sala;
                }*/

                CommunicationClient.Instance.IzmeniBioskopskuSalu(BioskopskaSala);



                ClearAll();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    if (ex.Message.Contains("DELETE"))
                        MessageBox.Show("Neko je rezervisao sediste koje zelite da obrisete!");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (SalaException ex)
            {
                if (ex.Code == 0)
                {
                    MainCoordinator.Instance.ValidateTb(UcSingleBioskopskaSala.validationDictionary, UcSingleBioskopskaSala.TxtNazivsale, ex.Message);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC dodaj salu");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Sve bioskopske sale

        UcAllBioskopskeSale ucAllBioskopskeSale;
        BindingList<BioskopskaSala> ListSale;
        DataGridView dgvSale;
        public UcAllBioskopskeSale CreateAllBioskopskeSale()
        {
            ucAllBioskopskeSale = new UcAllBioskopskeSale();
            dgvSale = ucAllBioskopskeSale.DgvBioskopskeSale;



            ListSale = new BindingList<BioskopskaSala>(CommunicationClient.Instance.VratiSveBioskopskeSale());
            ucAllBioskopskeSale.DgvBioskopskeSale.DataSource = ListSale;

            ucAllBioskopskeSale.DgvBioskopskeSale.Columns[0].Visible = false;
            ucAllBioskopskeSale.DgvBioskopskeSale.Columns["Naziv_Sale"].HeaderText = "Naziv sale";

            ucAllBioskopskeSale.BtnIzmeni.Click += VratiSaluIOtvoriProzorZaIzmenu;
            ucAllBioskopskeSale.TxtPretraga.TextChanged += PretragaOnTextChange;

            return ucAllBioskopskeSale;

        }
        public void VratiSaluIOtvoriProzorZaIzmenu(object sender, EventArgs e)
        {
            try
            {
                if (dgvSale.SelectedRows.Count <= 0) throw new Exception("Izaberite salu za izmenu!");

                BioskopskaSala sala = (BioskopskaSala)dgvSale.SelectedRows[0].DataBoundItem;

                sala = CommunicationClient.Instance.VratiBioskopskuSalu(sala);

                MainCoordinator.Instance.ShowAzurirajBioskopskaSala(sala);

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void PretragaOnTextChange(object sender, EventArgs e)
        {
            try
            {
                string txt = ucAllBioskopskeSale.TxtPretraga.Text;

                if (txt.Length > 0)
                {
                    BioskopskaSala filterSala = new BioskopskaSala();
                    filterSala.Naziv_Sale = txt;
                    filterSala.FilterFields = new FilterField[] { new FilterField("Naziv_Sale", "upper(Naziv_Sale) like @Naziv_Sale + '%'") };

                    List<BioskopskaSala> listSala = CommunicationClient.Instance.NadjiBioskopskeSale(filterSala);
                    ucAllBioskopskeSale.DgvBioskopskeSale.DataSource = listSala;
                }
                else
                {
                    List<BioskopskaSala> listSala = CommunicationClient.Instance.VratiSveBioskopskeSale();
                    ucAllBioskopskeSale.DgvBioskopskeSale.DataSource = listSala;
                }



            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXC nadji sale");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion



    }
}
