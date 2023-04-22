using Bioskop.Common;
using Bioskop.Repository;
using Bioskop.SystemOperations;
using System;
using System.Collections.Generic;

namespace Bioskop.Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();

                }
                return instance;
            }
        }
        IRepository<Korisnik> korisnikRepository;
        IRepository<IEntity> genericRepository;

        public delegate bool ClientLoggedDelegate(Korisnik client);
        public ClientLoggedDelegate IsClientLogged;
        private Controller()
        {

            genericRepository = new GenericDbRepository();
        }
        #region Login funkcionalnost


        public Korisnik Login(Korisnik k)
        {

            if (IsClientLogged(k))
            {
                throw new Exception("Klijent je vec ulogovan!");
            }
            LoginKorisnikSystemOperation loginSystemOperation = new LoginKorisnikSystemOperation();
            loginSystemOperation.Korisnik = k;
            loginSystemOperation.Execute();

            return loginSystemOperation.Korisnik;


        }
        public void Register(Korisnik k)
        {
            RegistrujKorisnikaSystemOperation registrujKorisnikaSystemOperation = new RegistrujKorisnikaSystemOperation();
            registrujKorisnikaSystemOperation.Korisnik = k;
            registrujKorisnikaSystemOperation.Execute();
        }
        public Administrator Login(Administrator a)
        {

            /*if (IsClientLogged(k))
            {
                throw new Exception("Klijent je vec ulogovan!");
            }*/
            LoginAdminSystemOperation loginSystemOperation = new LoginAdminSystemOperation();
            loginSystemOperation.Administrator = a;
            loginSystemOperation.Execute();

            return loginSystemOperation.Administrator;


        }
        #endregion

        #region Korisnik funkcionalnost


        public Korisnik GetKorisnik(int id)
        {
            GetKorisnikSystemOperation getKorisnikSystemOperation = new GetKorisnikSystemOperation();
            //getKorisnikSystemOperation.Id = id;
            getKorisnikSystemOperation.Korisnik = new Korisnik() { Id = id };
            getKorisnikSystemOperation.Execute();
            return getKorisnikSystemOperation.Korisnik;

        }
        #endregion

        #region Film funkcionalnosti


        public void DodajFilm(Film film)
        {
            DodajFilmSystemOperation dodajFilmSystemOperation = new DodajFilmSystemOperation();
            dodajFilmSystemOperation.Film = film;
            dodajFilmSystemOperation.Execute();
        }
        public void IzmeniFilm(Film film)
        {
            IzmeniFilmSystemOperation izmeniFilmSystemOperation = new IzmeniFilmSystemOperation();
            izmeniFilmSystemOperation.Film = film;
            izmeniFilmSystemOperation.Execute();

        }
        public Film VratiFilm(Film film)
        {
            VratiFilmSystemOperation vratiFilmSystemOperation = new VratiFilmSystemOperation();
            vratiFilmSystemOperation.Film = film;
            vratiFilmSystemOperation.Execute();
            return vratiFilmSystemOperation.Film;
        }
        public List<Film> NadjiFilmove(Film filterFilm)
        {
            NadjiFilmoveSystemOperation nadjiFilmoveSystemOperation = new NadjiFilmoveSystemOperation();
            nadjiFilmoveSystemOperation.FilterFilm = filterFilm;
            nadjiFilmoveSystemOperation.Execute();
            return nadjiFilmoveSystemOperation.ListFilm;
        }
        public List<Zanr> VratiSveZanrove()
        {
            VratiSveZanroveSystemOperation vratiZanroveSystemOperation = new VratiSveZanroveSystemOperation();
            vratiZanroveSystemOperation.Execute();
            return vratiZanroveSystemOperation.listaZanrova;
        }
        public List<Reziser> VratiSveRezisere()
        {
            VratiSveRezisereSystemOperation vratiRezisereSystemOperation = new VratiSveRezisereSystemOperation();
            vratiRezisereSystemOperation.Execute();
            return vratiRezisereSystemOperation.listReziser;

        }
        public List<Film> VratiSveFilmove()
        {
            VratiSveFilmoveSystemOperation vratiFilmoveSystemOperation = new VratiSveFilmoveSystemOperation();
            vratiFilmoveSystemOperation.Execute();
            return vratiFilmoveSystemOperation.ListFilmova;

        }
        #endregion

        #region BioskopskaSala funkcionalnosti

        public void DodajBioskopskuSalu(BioskopskaSala sala)
        {
            DodajBioskopskuSaluSystemOperation dodajBioskopskuSaluSystemOperation = new DodajBioskopskuSaluSystemOperation();
            dodajBioskopskuSaluSystemOperation.sala = sala;
            dodajBioskopskuSaluSystemOperation.Execute();
        }
        public List<BioskopskaSala> VratiSveBioskopskeSale()
        {
            VratiSveBioskopskeSaleSystemOperation vratiBioskopskeSaleSystemOperation = new VratiSveBioskopskeSaleSystemOperation();
            vratiBioskopskeSaleSystemOperation.Execute();
            return vratiBioskopskeSaleSystemOperation.ListSale;
        }
        public List<BioskopskaSala> NadjiBioskopskeSale(BioskopskaSala sala)
        {
            NadjiBioskopskeSaleSystemOperation nadjiBioskopskeSaleSystemOperation = new NadjiBioskopskeSaleSystemOperation();
            nadjiBioskopskeSaleSystemOperation.filterSala = sala;
            nadjiBioskopskeSaleSystemOperation.Execute();
            return nadjiBioskopskeSaleSystemOperation.ListSale;
        }
        public BioskopskaSala VratiBioskopskuSalu(BioskopskaSala sala)
        {
            VratiBioskopskuSaluSystemOperation vratiBioskopskuSaluSystemOperation = new VratiBioskopskuSaluSystemOperation();
            vratiBioskopskuSaluSystemOperation.Sala = sala;
            /*vratiBioskopskuSaluSystemOperation.IdSale = id;*/
            vratiBioskopskuSaluSystemOperation.Execute();
            return vratiBioskopskuSaluSystemOperation.Sala;
        }
        public void IzmeniBioskopskuSalu(BioskopskaSala sala)
        {
            IzmeniBioskopskuSaluSystemOperation izmeniBioskopskuSaluSystemOperation = new IzmeniBioskopskuSaluSystemOperation();
            izmeniBioskopskuSaluSystemOperation.Sala = sala;
            izmeniBioskopskuSaluSystemOperation.Execute();
        }

        #endregion

        #region Projekcije filma funkcionalnosti

        public List<ProjekcijaFilma> VratiSveProjekcije()
        {
            VratiSveProjekcijeSystemOperation vratiSveProjekcijeSystemOperation = new VratiSveProjekcijeSystemOperation();
            vratiSveProjekcijeSystemOperation.Execute();
            return vratiSveProjekcijeSystemOperation.listProjekcija;
        }
        public void DodajProjekcijuFilma(ProjekcijaFilma projekcija)
        {
            DodajProjekcijuFilmaSystemOperation dodajProjekcijuFilmaSystemOperation = new DodajProjekcijuFilmaSystemOperation();
            dodajProjekcijuFilmaSystemOperation.Projekcija = projekcija;
            dodajProjekcijuFilmaSystemOperation.Execute();
        }
        public ProjekcijaFilma VratiProjekcijuFilma(ProjekcijaFilma projekcija)
        {
            VratiProjekcijuSystemOperation vratiProjekcijuSystemOperation = new VratiProjekcijuSystemOperation();
            vratiProjekcijuSystemOperation.Projekcija = projekcija;
            vratiProjekcijuSystemOperation.Execute();
            return vratiProjekcijuSystemOperation.Projekcija;
        }
        public void IzmeniProjekciju(ProjekcijaFilma projekcija)
        {
            IzmeniProjekcijuSystemOperation izmeniProjekcijuSystemOperation = new IzmeniProjekcijuSystemOperation();
            izmeniProjekcijuSystemOperation.Projekcija = projekcija;
            izmeniProjekcijuSystemOperation.Execute();
        }
        public List<ProjekcijaFilma> NadjiProjekcije(ProjekcijaFilma projekcija)
        {
            NadjiProjekcijeFilmaSystemOperation nadjiProjekcijeFilmaSystemOperation = new NadjiProjekcijeFilmaSystemOperation();
            nadjiProjekcijeFilmaSystemOperation.ProjekcijaFilter = projekcija;
            nadjiProjekcijeFilmaSystemOperation.Execute();
            return nadjiProjekcijeFilmaSystemOperation.ListProjekcija;
        }
        #endregion

        #region Rezervacije funkcionalnosti

        public void DodajRezervaciju(Rezervacija rezervacija)
        {
            DodajRezervacijuSystemOperation dodajRezervacijuSystemOperation = new DodajRezervacijuSystemOperation();
            dodajRezervacijuSystemOperation.Rezervacija = rezervacija;
            dodajRezervacijuSystemOperation.Execute();
        }
        public void IzmeniRezervaciju(Rezervacija rezervacija)
        {
            IzmeniRezervacijuSystemOperation izmeniRezervacijuSystemOperation = new IzmeniRezervacijuSystemOperation();
            izmeniRezervacijuSystemOperation.Rezervacija = rezervacija;
            izmeniRezervacijuSystemOperation.Execute();
        }
        public List<Rezervacija> NadjiRezervacije(Rezervacija rezervacija)
        {
            NadjiRezervacijeSystemOperation nadjiRezervacijeSystemOperation = new NadjiRezervacijeSystemOperation();
            nadjiRezervacijeSystemOperation.RezervacijaFilter = rezervacija;
            nadjiRezervacijeSystemOperation.Execute();
            return nadjiRezervacijeSystemOperation.ListRezervacije;
        }
        public Rezervacija VratiRezervaciju(Rezervacija rezervacija)
        {
            VratiRezervacijuSystemOperation vratiRezervacijuSystemOperation = new VratiRezervacijuSystemOperation();
            vratiRezervacijuSystemOperation.Rezervacija = rezervacija;
            vratiRezervacijuSystemOperation.Execute();
            return vratiRezervacijuSystemOperation.Rezervacija;
        }
        public List<Karta> NadjiKarte(Rezervacija rezervacija)
        {
            NadjiKarteSystemOperation nadjiKarteSystemOperation = new NadjiKarteSystemOperation();
            nadjiKarteSystemOperation.Rezervacija = rezervacija;
            nadjiKarteSystemOperation.Execute();
            return nadjiKarteSystemOperation.ListKarte;
        }

        public bool IsSedisteZauzeto(Sediste s, ProjekcijaFilma p)
        {
            IsSedisteRezervisanoSystemOperation isSedisteRezervisanoSystemOperation = new IsSedisteRezervisanoSystemOperation();
            isSedisteRezervisanoSystemOperation.s = s;
            isSedisteRezervisanoSystemOperation.p = p;

            isSedisteRezervisanoSystemOperation.Execute();
            return isSedisteRezervisanoSystemOperation.Zauzeto;

        }
        public Rezervacija VratiDostupnaSedista(Rezervacija rez)
        {
            VratiDostupnaSedistaSystemOperation vratiDostupnaSedistaSystemOperation = new VratiDostupnaSedistaSystemOperation();
            vratiDostupnaSedistaSystemOperation.rez = rez;
            vratiDostupnaSedistaSystemOperation.Execute();
            return vratiDostupnaSedistaSystemOperation.rez;



        }
        #endregion
    }
}
