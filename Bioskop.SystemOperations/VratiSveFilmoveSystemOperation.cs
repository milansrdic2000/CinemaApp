using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiSveFilmoveSystemOperation : SystemOperationBase
    {
        public List<Film> ListFilmova;
        protected override void ExecuteConcreteOperation()
        {
            ListFilmova = repository.VratiSveJoin(new Film(), new Reziser(), new Zanr(), new Administrator()).Cast<Film>().ToList();

        }
    }
}
