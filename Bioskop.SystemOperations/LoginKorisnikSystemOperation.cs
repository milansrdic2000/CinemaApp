using Bioskop.Common;
using Bioskop.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class LoginKorisnikSystemOperation : SystemOperationBase
    {

        public Korisnik Korisnik { get; set; }
        protected override void ExecuteConcreteOperation()
        {

            if (Korisnik == null) throw new Exception("Korisnik null :(");
            if (Korisnik.Email == "") throw new KorisnikException("Ne postoji korisnik sa zadatim emailom!", 404);
            if (Korisnik.Sifra == "") throw new KorisnikException("Uneta sifra nije tacna!", 405);

            /*SqlParameter sp = new SqlParameter("email", Korisnik.Email);
            List<SqlParameter> listParameters = new List<SqlParameter>();
            listParameters.Add(sp);*/



            List<Korisnik> listKorisnik = repository.Pretrazi(Korisnik, new FilterField("Email")).Cast<Korisnik>().ToList();

            if (listKorisnik.Count <= 0)
            {
                throw new KorisnikException("Ne postoji korisnik sa zadatim emailom!", 404);
            }
            else
            {
                Korisnik korisnik = listKorisnik[0];


                if (korisnik.Sifra != Korisnik.Sifra)
                {
                    throw new KorisnikException("Uneta sifra nije tacna!", 405);
                }
                Korisnik = korisnik;
            }

        }
    }
}
