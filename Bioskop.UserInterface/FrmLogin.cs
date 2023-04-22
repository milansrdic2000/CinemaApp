using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Bioskop.UserInterface
{
    public partial class FrmLogin : Form
    {
        public Dictionary<Control, Label> ValidationDictionary = new Dictionary<Control, Label>();
        // public List<Label> ListErrorLabels = new List<Label>();
        public FrmLogin()
        {
            InitializeComponent();
            ValidationDictionary.Add(TxtEmail, lblEmailError);
            ValidationDictionary.Add(TxtSifra, lblSifraError);

            /*ListErrorLabels.Add(this.lblEmailError);
            ListErrorLabels.Add(this.lblSifraError);*/

        }
        /* public void ValidateTb(Control errorText, string text)
         {
             foreach (KeyValuePair<TextBox, Label> pair in this.ValidationDictionary)
             {
                 if (errorText == pair.Key)
                 {
                     pair.Value.Visible = true;
                     pair.Value.Text = text;
                 }
                 else
                 {
                     pair.Value.Visible = false;
                 }
             }
         }*/
        public void ChangeRightPanel(Control c)
        {
            pnlRight.Controls.Clear();
            c.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(c);
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                CommunicationClient.Instance.Connect();


                //odmah se uloguj kao admin da ne bi gubio vreme
                /*Administrator admin = new Administrator()
                {

                    Email = "234",
                    Sifra = "234",
                };
                admin = CommunicationClient.Instance.Login(admin);
                MainCoordinator.Instance.ulogovaniAdministrator = admin;
                MainCoordinator.Instance.ShowMainFormFromLogin();*/



                /*Korisnik k = new Korisnik()
                {
                    Email = "123",
                    Sifra = "123",
                };
                k = CommunicationClient.Instance.Login(k);
                MainCoordinator.Instance.ulogovaniKorisnik = k;
                MainCoordinator.Instance.ShowMainFormFromLogin();*/

            }
            catch (SocketException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            try
            {
                /* if (!cbAdmin.Checked)
                 {
                     Korisnik kor = new Korisnik()
                     {
                         Email = tbEmail.Text,
                         Sifra = tbSifra.Text,
                     };
                     kor = CommunicationClient.Instance.Login(kor);

                     MainCoordinator.Instance.ulogovaniKorisnik = kor;
                 }
                 else
                 {
                     Administrator admin = new Administrator()
                     {

                         Email = tbEmail.Text,
                         Sifra = tbSifra.Text,
                     };
                     admin = CommunicationClient.Instance.Login(admin);
                     MainCoordinator.Instance.ulogovaniAdministrator = admin;
                 }


                 MainCoordinator.Instance.ShowMainFormFromLogin();*/


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
