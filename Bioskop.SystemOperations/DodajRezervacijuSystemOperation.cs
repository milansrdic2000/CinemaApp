using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class DodajRezervacijuSystemOperation : SystemOperationBase
    {
        public Rezervacija Rezervacija;
        protected override void ExecuteConcreteOperation()
        {
            List<Rezervacija> list = repository.VratiJoin(Rezervacija, new FilterField[] { new FilterField("Korisnik_Id"), new FilterField("Projekcija_Id") }, new Korisnik(), new ProjekcijaFilma()).Cast<Rezervacija>().ToList();
            if (list.Count > 0) throw new System.Exception("Vec imate rezervaciju na ovu projekciju!!");

            if (Rezervacija.ListKarta == null) throw new System.Exception("Morate uneti barem jedno sediste");
            if (Rezervacija.ListKarta.Count == 0) throw new System.Exception("Morate uneti barem jedno sediste");

            repository.Dodaj(Rezervacija);



            foreach (Karta k in Rezervacija.ListKarta)
            {
                //izmeni izmeni
                // k.
                k.Projekcija_Id = Rezervacija.Projekcija_Id;
                k.Korisnik_Id = Rezervacija.Korisnik_Id;
                repository.Dodaj(k);
            }
        }
    }
}
