using Bioskop.Common;
using Bioskop.Common.CommunicationProtocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;

namespace Bioskop.Server
{
    public class ClientHandler
    {
        [Browsable(false)]
        private Socket clientSocket;
        [Browsable(false)]
        private Sender sender;
        [Browsable(false)]
        private Reciever reciever;


        public Korisnik korisnik;
        public Administrator administrator;
        public string ClientIP
        {
            get
            {
                return clientSocket.RemoteEndPoint.ToString();
            }
        }
        public string ClientEmail
        {
            get
            {
                if (!isAdmin)
                    return korisnik?.Email;
                else return administrator?.Email;
            }
        }
        public bool isAdmin
        {
            get; set;
        }

        public Action refreshClientsDgv;
        public Action<ClientHandler> RemoveClientDgv;
        public ClientHandler(Socket socket)
        {
            this.clientSocket = socket;
            sender = new Sender(socket);
            reciever = new Reciever(socket);


        }
        public void StopClient()
        {
            sender.socket.Close();
        }
        public void HandleRequest()
        {
            try
            {
                while (Server.Instance.serverRunning)
                {
                    Request req = reciever.Recieve<Request>();
                    Response res = new Response();
                    try
                    {
                        res.Success = true;
                        // ************KORISNIK**************
                        #region Korisnik operacije


                        if (req.Operation == Operation.Login)
                        {
                            Korisnik kk = (Korisnik)req.Body;
                            Korisnik k = Controller.Instance.Login(kk);
                            res.Data = k;
                            res.Message = "Uspesno prijavljivanje!";
                            this.korisnik = k;
                            this.isAdmin = false;
                            refreshClientsDgv();

                        }
                        else if (req.Operation == Operation.RegisterKorisnik)
                        {
                            Korisnik k = (Korisnik)req.Body;
                            Controller.Instance.Register(k);
                            res.Message = "Sistem je kreirao korisnicki nalog";
                        }
                        else if (req.Operation == Operation.GetKorisnik)
                        {
                            Korisnik k = Controller.Instance.GetKorisnik((int)req.Body);

                            res.Message = "Nadjen korisnik";
                            res.Data = k;
                        }
                        else if (req.Operation == Operation.Logout)
                        {
                            Korisnik k = (Korisnik)req.Body;
                            this.korisnik = null;
                            res.Message = "Izlogovan";
                            refreshClientsDgv();
                        }
                        #endregion
                        // ************ADMINISTRATOR**************
                        #region Administrator operacije
                        else if (req.Operation == Operation.LoginAdmin)
                        {
                            Administrator a = (Administrator)req.Body;
                            Administrator aa = Controller.Instance.Login(a);

                            res.Message = "Uspesan login";
                            res.Data = aa;
                            this.isAdmin = true;
                            this.administrator = aa;
                            refreshClientsDgv();
                        }
                        else if (req.Operation == Operation.LogoutAdmin)
                        {
                            this.administrator = null;
                            this.isAdmin = false;
                            res.Message = "Izlogovan";
                            refreshClientsDgv();
                        }
                        #endregion
                        // ************FILMOVI**************
                        #region Filmovi operacije
                        else if (req.Operation == Operation.DodajFilm)
                        {
                            Film f = (Film)req.Body;
                            Controller.Instance.DodajFilm(f);
                            res.Message = "Uspesno kreiran film";
                        }
                        else if (req.Operation == Operation.VratiSveFilmove)
                        {

                            res.Data = Controller.Instance.VratiSveFilmove();
                            res.Message = "Vraceni filmovi";
                        }
                        else if (req.Operation == Operation.VratiFilm)
                        {
                            Film f = (Film)req.Body;
                            res.Data = Controller.Instance.VratiFilm(f);
                            res.Message = "Vracen film!";
                        }
                        else if (req.Operation == Operation.NadjiFilmove)
                        {
                            Film f = (Film)req.Body;
                            List<Film> listFilm = Controller.Instance.NadjiFilmove(f);
                            res.Message = "Nadjeni trazeni filmovi!";
                            res.Data = listFilm;
                        }
                        else if (req.Operation == Operation.IzmeniFilm)
                        {

                            Film f = (Film)req.Body;
                            Controller.Instance.IzmeniFilm(f);
                            res.Message = "Sistem je izmenio film!";
                        }
                        #endregion
                        // ************ZANROVI I REZISERI**************
                        #region Zanrovi operacije
                        else if (req.Operation == Operation.VratiSveZanrove)
                        {

                            res.Data = Controller.Instance.VratiSveZanrove();
                            res.Message = "Vraceni zanrovi";
                        }
                        #endregion
                        #region Reziser operacije
                        else if (req.Operation == Operation.VratiSveRezisere)
                        {

                            res.Data = Controller.Instance.VratiSveRezisere();
                            res.Message = "Vraceni reziseri";
                        }
                        #endregion

                        // ************Bioskopske sale**************
                        #region Bioskospka sala operacije
                        else if (req.Operation == Operation.DodajBioskopskuSalu)
                        {
                            BioskopskaSala sala = (BioskopskaSala)req.Body;
                            Controller.Instance.DodajBioskopskuSalu(sala);
                            res.Message = "Sistem je zapamtio bioskopsku salu!";

                        }
                        else if (req.Operation == Operation.VratiSveBioskopskeSale)
                        {

                            List<BioskopskaSala> lista = Controller.Instance.VratiSveBioskopskeSale();
                            res.Data = lista;
                            res.Message = "Vracene bioskopske sale";

                        }
                        else if (req.Operation == Operation.NadjiBioskopskeSale)
                        {
                            BioskopskaSala sala = (BioskopskaSala)req.Body;
                            List<BioskopskaSala> lista = Controller.Instance.NadjiBioskopskeSale(sala);

                            res.Data = lista;
                            res.Message = "Nadjene sale!";

                        }
                        else if (req.Operation == Operation.VratiBioskopskuSalu)
                        {

                            BioskopskaSala sala = Controller.Instance.VratiBioskopskuSalu((BioskopskaSala)req.Body);
                            res.Data = sala;
                            res.Message = "Sistem je uspesno ucitao salu!";

                        }
                        else if (req.Operation == Operation.IzmeniBioskopskuSalu)
                        {

                            Controller.Instance.IzmeniBioskopskuSalu((BioskopskaSala)req.Body);

                            res.Message = "Sistem je uspesno izmenio salu!";

                        }
                        #endregion

                        // ************Projekcije**************
                        #region Projekcije filma operacije
                        else if (req.Operation == Operation.VratiSveProjekcije)
                        {
                            res.Data = Controller.Instance.VratiSveProjekcije();
                            res.Message = "vracene sve projekcije!";
                        }
                        else if (req.Operation == Operation.NadjiProjekcije)
                        {
                            ProjekcijaFilma filter = (ProjekcijaFilma)req.Body;
                            res.Data = Controller.Instance.NadjiProjekcije(filter);
                            res.Message = "Nadjene projekcije!";
                        }
                        else if (req.Operation == Operation.DodajProjekciju)
                        {
                            ProjekcijaFilma projekcija = (ProjekcijaFilma)req.Body;
                            Controller.Instance.DodajProjekcijuFilma(projekcija);
                            res.Message = "Dodata projekcija!";

                        }
                        else if (req.Operation == Operation.VratiProjekciju)
                        {
                            ProjekcijaFilma projekcija = (ProjekcijaFilma)req.Body;
                            ProjekcijaFilma nova = Controller.Instance.VratiProjekcijuFilma(projekcija);
                            res.Data = nova;
                            res.Message = "Vracena projekcija!";
                        }
                        else if (req.Operation == Operation.IzmeniProjekciju)
                        {
                            ProjekcijaFilma projekcija = (ProjekcijaFilma)req.Body;
                            Controller.Instance.IzmeniProjekciju(projekcija);
                            res.Message = "Izmenjena projekcija!";
                        }

                        #endregion

                        // ************Rezervacije**************
                        #region Rezervacije operacije

                        else if (req.Operation == Operation.DodajRezervaciju)
                        {
                            Rezervacija rezervacija = (Rezervacija)req.Body;
                            Controller.Instance.DodajRezervaciju(rezervacija);
                            res.Message = "Dodata rezervacija!";
                        }
                        else if (req.Operation == Operation.IzmeniRezervaciju)
                        {
                            Rezervacija rezervacija = (Rezervacija)req.Body;
                            Controller.Instance.IzmeniRezervaciju(rezervacija);
                            res.Message = "Izmenjena rezervacija!";
                        }
                        else if (req.Operation == Operation.VratiRezervaciju)
                        {
                            Rezervacija rezervacija = (Rezervacija)req.Body;
                            rezervacija = Controller.Instance.VratiRezervaciju(rezervacija);
                            res.Data = rezervacija;
                            res.Message = "Vracena rezervacija!";

                        }
                        else if (req.Operation == Operation.NadjiRezervacije)
                        {
                            Rezervacija rezervacija = (Rezervacija)req.Body;
                            List<Rezervacija> lista = Controller.Instance.NadjiRezervacije(rezervacija);
                            res.Message = "Nadjene rezervacije";
                            res.Data = lista;
                        }
                        else if (req.Operation == Operation.NadjiKarte)
                        {
                            Rezervacija rezervacija = (Rezervacija)req.Body;
                            res.Data = Controller.Instance.NadjiKarte(rezervacija);
                            res.Message = "Nadjene karte";
                        }
                        else if (req.Operation == Operation.IsSedisteReservisano)
                        {
                            IEntity[] niz = (IEntity[])req.Body;
                            Sediste s = (Sediste)niz[0];
                            ProjekcijaFilma p = (ProjekcijaFilma)niz[1];

                            res.Data = Controller.Instance.IsSedisteZauzeto(s, p);
                            res.Message = "Nadjene karte";
                        }
                        else if (req.Operation == Operation.VratiSedistaSaDostupnosti)
                        {



                            res.Data = Controller.Instance.VratiDostupnaSedista((Rezervacija)req.Body);
                            res.Message = "Vracena sedista sa dostupnosti!";
                        }
                        #endregion
                        else
                        {
                            res.Success = false;
                            res.Message = "nepostojeca ruta";
                        }


                        sender.Send(res);
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.GetType());
                        Console.WriteLine(">>EXC in client operation: " + ex.Message);
                        res.Success = false;


                        res.Message = ex.Message;
                        res.Exception = ex;
                        sender.Send(res);

                    }
                    finally
                    {

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(">>EXC in client thread: " + ex.Message);
                RemoveClientDgv(this);
            }
            finally
            {
                Console.WriteLine("Klijentska nit zavrsila sa radom!");
            }
        }
    }
}
