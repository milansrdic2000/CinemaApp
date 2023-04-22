using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class NadjiKarteSystemOperation : SystemOperationBase
    {
        public Rezervacija Rezervacija;

        public List<Karta> ListKarte;
        protected override void ExecuteConcreteOperation()
        {
            Sediste s = new Sediste()
            {
                Sala_Id = Rezervacija.ProjekcijaFilma.BioskopskaSala.Id,
            };
            Rezervacija.FilterFieldsJoin = new FilterField[] { new FilterField("Projekcija_Id") };

            ListKarte = repository.VratiJoin(new Karta() { Sediste = s }, new FilterField[] { new FilterField("Sala_Id") }, Rezervacija).Cast<Karta>().ToList();

        }
    }
}
