using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class IzmeniProjekcijuSystemOperation : SystemOperationBase
    {
        public ProjekcijaFilma Projekcija;
        protected override void ExecuteConcreteOperation()
        {
            // proveravamo da li je promenjena sala za projekciju, jer ako jeste, mozemo imati neku rezervaciju vec za tu projekciju i onda ne bi bilo okej.
            List<Rezervacija> listRez = repository.VratiJoin(new Rezervacija() { ProjekcijaFilma = Projekcija }, new FilterField[] { new FilterField("Projekcija_Id") }, new Korisnik(), new ProjekcijaFilma()).Cast<Rezervacija>().ToList();

            if (listRez.Count > 0) throw new System.Exception("Ima rezervacija vec za ovu projekciju!");
            repository.Azuriraj(Projekcija, new FilterField("Id"));
        }
    }
}
