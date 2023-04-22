using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiSveZanroveSystemOperation : SystemOperationBase
    {
        public List<Zanr> listaZanrova;
        protected override void ExecuteConcreteOperation()
        {
            this.listaZanrova = repository.VratiSve(new Zanr()).Cast<Zanr>().ToList();


        }
    }
}
