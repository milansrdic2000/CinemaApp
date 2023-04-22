using Bioskop.Common;

namespace Bioskop.SystemOperations
{
    public class DodajProjekcijuFilmaSystemOperation : SystemOperationBase
    {
        public ProjekcijaFilma Projekcija;
        protected override void ExecuteConcreteOperation()
        {
            repository.Dodaj(Projekcija);
        }
    }
}
