using Bioskop.Common;
using Bioskop.Common.Exceptions;
using System;

namespace Bioskop.SystemOperations
{
    public class DodajFilmSystemOperation : SystemOperationBase
    {

        public Film Film { get; set; }
        protected override void ExecuteConcreteOperation()
        {


            if (Film == null) throw new Exception("Niste obezbedili film, greska sys operation");

            if (Film.Naziv_Filma == "") throw new FilmException("Niste uneli naziv filma!", 1);


            Film VecPostoji = (Film)repository.Vrati(Film, new FilterField[] { new FilterField("Naziv_Filma") });


            if (VecPostoji != null)
            {
                if (VecPostoji.Id != Film.Id)
                    throw new FilmException("Vec postoji ovakav film", 1);
            }

            repository.Dodaj(Film);
        }
    }
}
