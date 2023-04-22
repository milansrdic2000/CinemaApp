using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class NadjiBioskopskeSaleSystemOperation : SystemOperationBase
    {
        public BioskopskaSala filterSala;
        public List<BioskopskaSala> ListSale;
        protected override void ExecuteConcreteOperation()
        {

            ListSale = repository.Pretrazi(filterSala, filterSala.FilterFields).Cast<BioskopskaSala>().ToList();
        }
    }
}
