using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{

    public class VratiBioskopskuSaluSystemOperation : SystemOperationBase

    {
        public BioskopskaSala Sala = new BioskopskaSala();
        public int IdSale;
        public List<Sediste> ListSediste;
        protected override void ExecuteConcreteOperation()
        {

            ListSediste = repository.Pretrazi(new Sediste() { Sala_Id = Sala.Id }, new FilterField("Sala_Id")).Cast<Sediste>().ToList();
            Sala.ListSedista = ListSediste;
        }
    }
}
