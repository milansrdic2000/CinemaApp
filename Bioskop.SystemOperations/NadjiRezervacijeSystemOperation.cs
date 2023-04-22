using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class NadjiRezervacijeSystemOperation : SystemOperationBase
    {
        public List<Rezervacija> ListRezervacije;
        public Rezervacija RezervacijaFilter;
        protected override void ExecuteConcreteOperation()
        {

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

            ListRezervacije = repository.VratiJoin(RezervacijaFilter, RezervacijaFilter.FilterFields, new Korisnik(), projekcijaFilma).Cast<Rezervacija>().ToList();
        }
    }
}
