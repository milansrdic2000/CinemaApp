using Bioskop.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class GetKorisnikSystemOperation : SystemOperationBase
    {
        public Korisnik Korisnik { get; set; }
        public int Id { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            List<Korisnik> listKorisnik;


            List<SqlParameter> listParameters = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter("id", Id);

            listParameters.Add(idParam);
            listKorisnik = repository.Pretrazi(Korisnik, new FilterField("Id")).Cast<Korisnik>().ToList();

            if (listKorisnik.Count <= 0)
            {
                throw new Exception("Trazeni korisnik ne postoji!");
            }
            else
            {
                Korisnik = listKorisnik[0];
            }


        }
    }
}
