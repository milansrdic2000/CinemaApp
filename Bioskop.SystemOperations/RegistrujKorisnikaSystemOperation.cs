using Bioskop.Common;
using Bioskop.Common.Exceptions;
using System;

namespace Bioskop.SystemOperations
{
    public class RegistrujKorisnikaSystemOperation : SystemOperationBase
    {
        public Korisnik Korisnik;
        protected override void ExecuteConcreteOperation()
        {
            if (Korisnik == null) throw new System.Exception("korisnik nije prosledjen");

            if (Korisnik.Ime == "") throw new KorisnikException("Unesite ime korisnika!", 1);
            if (Korisnik.Prezime == "") throw new KorisnikException("Unesite prezime korisnika!", 2);
            if (Korisnik.Datum_Rodjenja > DateTime.Now) throw new KorisnikException("Ne mozete uneti datum u buducnosti", 3);


            if (!Korisnik.Email.IsValidEmail()) throw new KorisnikException("Email mora da sadrzi @ i .", 404);

            if (Korisnik.Sifra == "") throw new KorisnikException("Unesite sifru korisnika!", 4);

            Korisnik emailConstraint = (Korisnik)repository.Vrati(Korisnik, new FilterField[] { new FilterField("Email") });
            if (emailConstraint != null) throw new KorisnikException("Vec postoji korisnik sa ovakvim emailom!", 404);

            repository.Dodaj(Korisnik);
        }
    }
}
