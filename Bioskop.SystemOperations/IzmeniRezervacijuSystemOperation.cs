using Bioskop.Common;
using Bioskop.Common.Model;
using System;
using System.Collections.Generic;

namespace Bioskop.SystemOperations
{
    public class IzmeniRezervacijuSystemOperation : SystemOperationBase
    {
        public Rezervacija Rezervacija;
        protected override void ExecuteConcreteOperation()
        {
            if (Rezervacija == null) throw new Exception("Nepravilna rezervacija! (null)");

            List<Karta> listKarta = Rezervacija.ListKarta;

            foreach (Karta karta in listKarta)
            {
                if (karta.Sediste.CrudStatus == CrudStatus.Delete)
                {
                    repository.Obrisi(karta, new FilterField("Projekcija_Id"), new FilterField("Korisnik_Id"), new FilterField("Sala_Id"), new FilterField("Sediste_Id"));
                }
                else if (karta.Sediste.CrudStatus == CrudStatus.Create)
                {
                    repository.Dodaj(karta);
                }
            }
        }
    }
}
