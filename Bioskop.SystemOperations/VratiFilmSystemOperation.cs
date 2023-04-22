using Bioskop.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiFilmSystemOperation : SystemOperationBase
    {
        public Film Film;
        protected override void ExecuteConcreteOperation()
        {
            List<Film> listFilm = repository.VratiJoin(Film, new FilterField[] { new FilterField("Id") }, new Reziser(), new Zanr(), new Administrator()).Cast<Film>().ToList();

            if (listFilm.Count == 0) throw new Exception("Nepostojeci film!");



            Film = listFilm[0];


        }
    }
}
