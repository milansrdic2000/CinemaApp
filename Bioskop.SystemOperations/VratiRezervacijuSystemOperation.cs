using Bioskop.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiRezervacijuSystemOperation : SystemOperationBase
    {
        public Rezervacija Rezervacija;
        protected override void ExecuteConcreteOperation()
        {
            if (Rezervacija.ProjekcijaFilma != null)
            {
                if (Rezervacija.ProjekcijaFilma.Datum_Projekcije < DateTime.Now)
                {
                    throw new Exception("Projekcija je prosla, rezervacija se ne moze menjati!");
                }
            }
            JoinHelper filmHelp = new JoinHelper()
            {
                JoinTable = new Film(),
                ForeignKeyName = "film_id"
            };
            JoinHelper salaHelp = new JoinHelper()
            {
                JoinTable = new BioskopskaSala(),
                ForeignKeyName = "sala_id"
            };
            ProjekcijaFilma projekcijaFilma = new ProjekcijaFilma()
            {
                JoinHelper = new JoinHelper[] { filmHelp, salaHelp }
            };


            List<Rezervacija> list = repository.VratiJoin(Rezervacija, Rezervacija.FilterFields, new Korisnik(), projekcijaFilma).Cast<Rezervacija>().ToList();

            if (list.Count <= 0)
            {

                Rezervacija = null;
                return;
            }

            Rezervacija = list[0];

            //izmeni izmeni izmein
            Karta kartaFilter = new Karta()
            {
                Korisnik_Id = Rezervacija.Korisnik_Id,
                Projekcija_Id = Rezervacija.Projekcija_Id,
            };
            List<Karta> listKarta = repository.Pretrazi(kartaFilter, new FilterField[] { new FilterField("Korisnik_Id"), new FilterField("Projekcija_Id") }).Cast<Karta>().ToList();



            Rezervacija.ListKarta = listKarta;
        }
    }
}
