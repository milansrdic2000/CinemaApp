using Bioskop.Common;
using Bioskop.Common.CommunicationProtocol;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
namespace Bioskop.UserInterface
{
    public class CommunicationClient
    {
        private static CommunicationClient instance;

        public static CommunicationClient Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommunicationClient();
                };
                return instance;
            }
        }



        private Socket socket;


        private Sender sender;
        private Reciever reciever;
        private CommunicationClient()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);



        }


        #region Konekcija i upravljanje konekcijom
        public bool ConnectedToServer = false;
        public void Connect()
        {
            try
            {
                int port = Int32.Parse(ConfigurationManager.AppSettings["port"]);
                string ip = ConfigurationManager.AppSettings["ip"];
                socket.Connect(ip, port);
                sender = new Sender(socket);
                reciever = new Reciever(socket);

                ConnectedToServer = true;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }
        public bool SocketConnected()
        {
            if (!ConnectedToServer) return false;
            if (socket == null) return false;
            if (socket.Connected == false) return false;
            bool part1 = socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (socket.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }
        public void Reconnect()
        {
            try
            {

                if (SocketConnected()) throw new Exception("Vec ste konektovani na server!");
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 5000);
                sender = new Sender(socket);
                reciever = new Reciever(socket);

                ConnectedToServer = true;



            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        public void ObaviRekonekciju()
        {
            if (!SocketConnected())
            {

                DialogResult dr = MessageBox.Show("Niste konektovani na server. Da li zelite ponovo da se konektujete?", "Rekonekcija", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    Reconnect();
                    MessageBox.Show("Uspesno ste se rekonektovali!");
                }
                else
                {
                    MainCoordinator.Instance.frmLogin.Close();
                }

                MainCoordinator.Instance.VratiSeNaLogin();
            }
        }
        #endregion

        #region Korisnicke operacije
        public Korisnik Login(Korisnik korisnik)
        {
            try
            {
                if (!ConnectedToServer) throw new IOException("Niste konektovani na server");
                Request req = new Request()
                {
                    Body = korisnik,
                    Operation = Operation.Login
                };
                sender.Send(req);
                Response res = reciever.Recieve<Response>();

                korisnik = res.ConvertResponse<Korisnik>();

                MessageBox.Show(res.Message);

                return korisnik;
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public void Register(Korisnik korisnik)
        {
            try
            {
                if (!ConnectedToServer) throw new IOException("Niste konektovani na server");
                Request req = new Request()
                {
                    Body = korisnik,
                    Operation = Operation.RegisterKorisnik
                };
                sender.Send(req);
                Response res = reciever.Recieve<Response>();

                korisnik = res.ConvertResponse<Korisnik>();


                System.Windows.Forms.MessageBox.Show(res.Message);

            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        public Administrator Login(Administrator administrator)
        {
            try
            {
                if (!ConnectedToServer) throw new IOException("Niste konektovani na server");
                Request req = new Request()
                {
                    Body = administrator,
                    Operation = Operation.LoginAdmin
                };
                sender.Send(req);
                Response res = reciever.Recieve<Response>();

                administrator = res.ConvertResponse<Administrator>();

                MessageBox.Show("Uspesno ste se prijavili!");

                return (Administrator)res.Data;
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        public void Logout(Korisnik korisnik)
        {
            try
            {
                Request req = new Request()
                {
                    Body = korisnik,
                    Operation = Operation.Logout
                };
                sender.Send(req);

                reciever.Recieve<object>();

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXCEPTION LOGOUT");
                // return null;
                //throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Logout(Administrator administrator)
        {
            try
            {
                Request req = new Request()
                {
                    Body = administrator,
                    Operation = Operation.LogoutAdmin
                };
                sender.Send(req);

                reciever.Recieve<object>();

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOEXCEPTION LOGOUT");
                // return null;
                //throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Korisnik GetKorisniK(int id)
        {
            try
            {
                Request req = new Request();
                req.Operation = Operation.GetKorisnik;
                req.Body = id;

                sender.Send(req);
                Response res = reciever.Recieve<Response>();



                return res.ConvertResponse<Korisnik>();

            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion


        //Genericka operacija TEST
        public Response OperacijaGeneric(object body, Operation operacija)
        {
            Request request = new Request()
            {
                Body = body,
                Operation = operacija,
            };
            sender.Send(request);

            Response response = reciever.Recieve<Response>();

            if (!response.Success) throw new Exception(response.Message);

            return response;
        }

        #region Filmovi i operacije za njih

        public void DodajFilm(Film f)
        {
            try
            {
                Request request = new Request()
                {
                    Body = f,
                    Operation = Operation.DodajFilm,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                response.ConvertResponse<Film>();

                System.Windows.Forms.MessageBox.Show(response.Message);
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
        }
        public void IzmeniFilm(Film f)
        {
            try
            {
                Request request = new Request()
                {
                    Body = f,
                    Operation = Operation.IzmeniFilm,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                response.ConvertResponse<Film>();

                System.Windows.Forms.MessageBox.Show(response.Message);
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }

        }
        public Film VratiFilm(Film f)
        {
            try
            {
                Request request = new Request()
                {
                    Body = f,
                    Operation = Operation.VratiFilm,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<Film>();

            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
        }
        public List<Film> VratiSveFilmove()
        {
            try
            {
                Request request = new Request()
                {

                    Operation = Operation.VratiSveFilmove,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<List<Film>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
        }
        public List<Film> NadjiFilmove(Film film)
        {
            try
            {
                Request request = new Request()
                {
                    Body = film,
                    Operation = Operation.NadjiFilmove,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();





                return response.ConvertResponse<List<Film>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
        }

        public List<Zanr> VratiSveZanrove()
        {
            try
            {
                Request request = new Request()
                {

                    Operation = Operation.VratiSveZanrove,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<List<Zanr>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
        }
        public List<Reziser> VratiSveRezisere()
        {
            Request request = new Request()
            {

                Operation = Operation.VratiSveRezisere,
            };
            sender.Send(request);

            Response response = reciever.Recieve<Response>();

            if (!response.Success) throw new Exception(response.Message);

            return (List<Reziser>)response.Data;
        }


        #endregion

        #region Requestovi za Bioskopske sale
        public List<BioskopskaSala> VratiSveBioskopskeSale()
        {
            try
            {
                Request request = new Request()
                {

                    Operation = Operation.VratiSveBioskopskeSale,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<List<BioskopskaSala>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
        }
        public List<BioskopskaSala> NadjiBioskopskeSale(BioskopskaSala sala)
        {
            try
            {
                Request request = new Request()
                {
                    Body = sala,
                    Operation = Operation.NadjiBioskopskeSale,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();
                return response.ConvertResponse<List<BioskopskaSala>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                // return null;
                throw ex;
            }
        }
        public void DodajBioskopskuSalu(BioskopskaSala sala)
        {
            try
            {
                Request request = new Request()
                {
                    Body = sala,
                    Operation = Operation.DodajBioskopskuSalu,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();


                response.ConvertResponse<BioskopskaSala>();



                System.Windows.Forms.MessageBox.Show(response.Message);
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }
        public void IzmeniBioskopskuSalu(BioskopskaSala sala)
        {
            try
            {
                Request request = new Request()
                {
                    Body = sala,
                    Operation = Operation.IzmeniBioskopskuSalu,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                response.ConvertResponse<BioskopskaSala>();



                MessageBox.Show(response.Message);
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }
        public BioskopskaSala VratiBioskopskuSalu(BioskopskaSala sala)
        {
            try
            {
                Request request = new Request()
                {
                    Body = sala,
                    Operation = Operation.VratiBioskopskuSalu,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<BioskopskaSala>();

            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }


        #endregion

        #region Requestovi za Projekcije Filma

        public List<ProjekcijaFilma> VratiSveProjekcije()
        {
            try
            {
                Request request = new Request()
                {

                    Operation = Operation.VratiSveProjekcije,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<List<ProjekcijaFilma>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ProjekcijaFilma> NadjiProjekcije(ProjekcijaFilma projekcija)
        {

            try
            {
                Request request = new Request()
                {
                    Body = projekcija,
                    Operation = Operation.NadjiProjekcije,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<List<ProjekcijaFilma>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }
        public ProjekcijaFilma VratiProjekciju(ProjekcijaFilma projekcija)
        {
            try
            {
                Request request = new Request()
                {
                    Body = projekcija,
                    Operation = Operation.VratiProjekciju,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<ProjekcijaFilma>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }
        public void DodajProjekciju(ProjekcijaFilma projekcija)
        {
            try
            {
                Request request = new Request()
                {
                    Body = projekcija,
                    Operation = Operation.DodajProjekciju,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                response.ConvertResponse<ProjekcijaFilma>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }


        }
        public void izmeniProjekciju(ProjekcijaFilma projekcija)
        {
            try
            {
                Request request = new Request()
                {
                    Body = projekcija,
                    Operation = Operation.IzmeniProjekciju,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                response.ConvertResponse<ProjekcijaFilma>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }


        }

        #endregion

        #region Req za Rezervacije

        public void DodajRezervaciju(Rezervacija rezervacija)
        {
            try
            {
                Request request = new Request()
                {
                    Body = rezervacija,
                    Operation = Operation.DodajRezervaciju,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                response.ConvertResponse<Rezervacija>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }


        }
        public Rezervacija VratiRezervaciju(Rezervacija rezervacija)
        {
            try
            {
                Request request = new Request()
                {
                    Body = rezervacija,
                    Operation = Operation.VratiRezervaciju,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<Rezervacija>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }

        }
        public void IzmeniRezervaciju(Rezervacija rezervacija)
        {
            try
            {
                Request request = new Request()
                {
                    Body = rezervacija,
                    Operation = Operation.IzmeniRezervaciju,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                response.ConvertResponse<Rezervacija>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }
        public List<Rezervacija> NadjiRezervacije(Rezervacija rezervacija)
        {
            try
            {

                Request request = new Request()
                {
                    Body = rezervacija,
                    Operation = Operation.NadjiRezervacije,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<List<Rezervacija>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }

        }
        public List<Karta> NadjiKarte(Rezervacija rezervacija)
        {
            try
            {
                Request request = new Request()
                {
                    Body = rezervacija,
                    Operation = Operation.NadjiKarte,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<List<Karta>>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }

        }
        public bool IsSedisteReservisano(Sediste s, ProjekcijaFilma proj)
        {
            try
            {
                Request request = new Request()
                {
                    Body = new IEntity[] { s, proj },
                    Operation = Operation.IsSedisteReservisano,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<bool>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }
        public Rezervacija VratiSedistaSaDostupnosti(Rezervacija rez)
        {
            try
            {
                Request request = new Request()
                {
                    Body = rez,
                    Operation = Operation.VratiSedistaSaDostupnosti,
                };
                sender.Send(request);

                Response response = reciever.Recieve<Response>();

                return response.ConvertResponse<Rezervacija>();
            }
            catch (IOException ex)
            {
                ObaviRekonekciju();
                throw ex;
            }
        }
        #endregion





    }
}
