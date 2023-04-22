using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiSveRezisereSystemOperation : SystemOperationBase
    {
        public List<Reziser> listReziser;
        protected override void ExecuteConcreteOperation()
        {
            listReziser = repository.VratiSve(new Reziser()).Cast<Reziser>().ToList();
        }
    }
}
