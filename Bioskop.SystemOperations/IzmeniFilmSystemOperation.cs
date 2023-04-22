using Bioskop.Common;
using Bioskop.Common.Exceptions;

namespace Bioskop.SystemOperations
{
    public class IzmeniFilmSystemOperation : SystemOperationBase
    {
        public Film Film { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            if (Film == null) throw new System.Exception("Niste uneli koji film!");

            if (Film.Naziv_Filma == "") throw new FilmException("Unesite naziv filma", 1);

            Film VecPostoji = (Film)repository.Vrati(Film, new FilterField[] { new FilterField("Naziv_Filma") });

            if (VecPostoji != null)
            {
                if (VecPostoji.Id != Film.Id)
                    throw new FilmException("Vec postoji ovakav film", 1);
            }

            repository.Azuriraj(Film, new FilterField("Id"));
        }
    }
}
