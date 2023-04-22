using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class IsSedisteRezervisanoSystemOperation : SystemOperationBase
    {
        public Sediste s;
        public ProjekcijaFilma p;

        public bool Zauzeto = false;
        protected override void ExecuteConcreteOperation()
        {
            Rezervacija rez = new Rezervacija();
            rez.ProjekcijaFilma = p;
            rez.FilterFieldsJoin = new FilterField[] { new FilterField("Projekcija_Id") };

            Karta kartaFilter = new Karta()
            {
                Projekcija_Id = p.Id,
                Sediste = s,
            };
            List<Karta> listKarte = repository.Pretrazi(kartaFilter, new FilterField[] { new FilterField("Projekcija_Id"), new FilterField("Sediste_Id"), new FilterField("Sala_Id") }).Cast<Karta>().ToList();

            if (listKarte.Count > 0) Zauzeto = true;


        }
    }
}
