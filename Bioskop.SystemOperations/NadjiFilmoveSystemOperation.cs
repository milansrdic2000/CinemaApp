using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class NadjiFilmoveSystemOperation : SystemOperationBase
    {
        public Film FilterFilm;
        public List<Film> ListFilm;
        protected override void ExecuteConcreteOperation()
        {
            ListFilm = repository.VratiJoin(FilterFilm, FilterFilm.FilterFields, new Reziser(), new Zanr(), new Administrator()).Cast<Film>().ToList();
        }
    }
}
