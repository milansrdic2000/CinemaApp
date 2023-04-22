using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiProjekcijuSystemOperation : SystemOperationBase
    {
        public ProjekcijaFilma Projekcija;
        protected override void ExecuteConcreteOperation()
        {
            List<ProjekcijaFilma> lista = repository.VratiJoin(Projekcija, new FilterField[] { new FilterField("Id") }, new BioskopskaSala(), new Film()).Cast<ProjekcijaFilma>().ToList();

            if (lista.Count <= 0) throw new System.Exception("Nije pronadjena zadata projekcija");

            Projekcija = lista[0];

        }
    }
}
