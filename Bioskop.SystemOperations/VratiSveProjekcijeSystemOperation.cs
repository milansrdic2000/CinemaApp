using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiSveProjekcijeSystemOperation : SystemOperationBase
    {
        public List<ProjekcijaFilma> listProjekcija;
        protected override void ExecuteConcreteOperation()
        {
            listProjekcija = repository.VratiSveJoin(new ProjekcijaFilma(), new BioskopskaSala(), new Film()).Cast<ProjekcijaFilma>().ToList();

        }
    }
}
