using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class NadjiProjekcijeFilmaSystemOperation : SystemOperationBase
    {
        public ProjekcijaFilma ProjekcijaFilter;
        public List<ProjekcijaFilma> ListProjekcija = new List<ProjekcijaFilma>();
        protected override void ExecuteConcreteOperation()
        {
            Film f = new Film();

            if (ProjekcijaFilter.Film != null) f = ProjekcijaFilter.Film;

            ListProjekcija = repository.VratiJoin(ProjekcijaFilter, ProjekcijaFilter.FilterFields, new BioskopskaSala(), f).Cast<ProjekcijaFilma>().ToList();

        }
    }
}
