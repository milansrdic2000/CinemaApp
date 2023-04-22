using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bioskop.UserInterface
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();


            this.menuStrip1.ForeColor = Color.FromArgb(244, 176, 122);
            this.dodajFilmToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajFilm();
            this.izmeniFilmToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowViewAllFilms();

            this.dodajBioskopskuSaluToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajBioskopskaSala();
            this.izmeniBioskopskuSaluToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPrikazBioskopskaSala();

            this.izmeniProjekcijuToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPrikazSvihProjekcija();
            this.dodajProjekcijuToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajProjekciju();
            this.kreirajRezervacijuToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowKreirajRezervaciju();

            this.izmeniRezervacijuToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowAllRezervacija();

            this.pogledajProfilToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowDetaljiKorisnika();

            this.pretraziFilmoveToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowViewAllFilmsClientReadOnly();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;

                if (MainCoordinator.Instance.ulogovaniKorisnik != null)
                    CommunicationClient.Instance.Logout(MainCoordinator.Instance.ulogovaniKorisnik);
                else if (MainCoordinator.Instance.ulogovaniAdministrator != null)
                {
                    CommunicationClient.Instance.Logout(MainCoordinator.Instance.ulogovaniAdministrator);
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Dobrodosao, ${MainCoordinator.Instance.ulogovaniKorisnik.Ime}");
            try
            {

                //ako je korisnik usao na sistem
                if (MainCoordinator.Instance.ulogovaniKorisnik != null)
                {
                    dodajFilmToolStripMenuItem.Visible = false;
                    izmeniFilmToolStripMenuItem.Visible = false;
                    bioskopskeSaleToolStripMenuItem.Visible = false;
                    projekcijeToolStripMenuItem1.Visible = false;
                    rezervacijaFilmaToolStripMenuItem.Visible = true;
                    pretraziFilmoveToolStripMenuItem.Visible = true;
                    pogledajProfilToolStripMenuItem.Visible = true;
                }
                // ako je administrator upao na sistem
                else if (MainCoordinator.Instance.ulogovaniAdministrator != null)
                {
                    dodajFilmToolStripMenuItem.Visible = true;
                    izmeniFilmToolStripMenuItem.Visible = true;
                    bioskopskeSaleToolStripMenuItem.Visible = true;
                    projekcijeToolStripMenuItem1.Visible = true;
                    rezervacijaFilmaToolStripMenuItem.Visible = false;
                    pretraziFilmoveToolStripMenuItem.Visible = false;
                    pogledajProfilToolStripMenuItem.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pogledajProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*try
            {
                UcProfileView ucProfileView = new UcProfileView();

                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(ucProfileView);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/
        }
        public void ChangePanel(Control control)
        {
            try
            {
                pnlMain.Controls.Clear();
                control.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(control);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dodajProjekcijuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
