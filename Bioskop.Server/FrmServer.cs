using Bioskop.Common;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Bioskop.Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {

            InitializeComponent();
            this.lblPovezaniKlijenti.Width = this.Width;

        }
        private BindingList<ClientHandler> listClients = new BindingList<ClientHandler>();
        private void FrmServer_Load(object sender, EventArgs e)
        {

            try
            {
                Controller.Instance.IsClientLogged = IsClientLogged;
                Server.Instance.addClientToDgv = AddClientToDgv;
                Server.Instance.RemoveClientFromDgv = RemoveClientFromDgv;
                Server.Instance.refreshDgv = RefreshClientDgv;

                int port = Int32.Parse(ConfigurationManager.AppSettings["port"]);
                string ip = ConfigurationManager.AppSettings["ip"];

                Server.Instance.StartServer(ip, port);

                dgvPovezaniKlijenti.DataSource = listClients;

                HandleServerButtons(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnZaustaviServer_Click(object sender, EventArgs e)
        {
            try
            {

                Server.Instance.Stop();
                HandleServerButtons(false);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btnPokreniServer_Click(object sender, EventArgs e)
        {
            try
            {


                Server.Instance.StartServer("127.0.0.1", 5000);
                HandleServerButtons(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void AddClientToDgv(ClientHandler client)
        {
            Action a = () =>
            {
                listClients.Add(client);
            };

            this.Invoke(a);
        }
        public void RemoveClientFromDgv(ClientHandler client)
        {
            Action a = () =>
            {
                listClients.Remove(client);
            };

            this.Invoke(a);
        }
        public bool IsClientLogged(Korisnik korisnik)
        {
            bool isLogged = false;
            Action a = () =>
            {
                foreach (ClientHandler handler in listClients)
                {
                    if (handler.isAdmin) continue;
                    if (handler.korisnik != null && handler.korisnik.Equals(korisnik))
                    {
                        isLogged = true;
                        break;
                    }
                }
            };
            this.Invoke(a);
            return isLogged;
        }

        public void RefreshClientDgv()
        {
            Action a = () =>
            {
                dgvPovezaniKlijenti.Refresh();
            };
            this.Invoke(a);
        }

        public void HandleServerButtons(bool Start)
        {
            btnPokreniServer.Enabled = !Start;
            btnZaustaviServer.Enabled = Start;

            if (Start)
            {
                tbStatus.BackColor = Color.Lime;
                tbStatus.Text = "Pokrenut!";
            }
            else
            {
                tbStatus.BackColor = Color.Red;
                tbStatus.Text = "Zaustavljen!";
            }
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
