using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiSveBioskopskeSaleSystemOperation : SystemOperationBase
    {
        public List<BioskopskaSala> ListSale;
        protected override void ExecuteConcreteOperation()
        {
            ListSale = repository.VratiSve(new BioskopskaSala()).Cast<BioskopskaSala>().ToList();
        }
    }
}
