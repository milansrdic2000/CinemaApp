using Bioskop.Common;
using Bioskop.Common.Exceptions;
using Bioskop.Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class DodajBioskopskuSaluSystemOperation : SystemOperationBase
    {
        public BioskopskaSala sala;
        protected override void ExecuteConcreteOperation()
        {
            /*foreach (Sediste s in sala.ListSedista)
            {
                List<Sediste> listSediste = repository.Pretrazi(s, "Red", "Kolona").Cast<Sediste>().ToList();
                if (listSediste.Count > 0)
                {
                    throw new System.Exception("Vec postoji ovakvo sediste!");
                }
            }*/

            if (sala.Naziv_Sale == "") throw new SalaException("Morate uneti naziv sale!", 0);

            BioskopskaSala VecPostoji = (BioskopskaSala)repository.Vrati(sala, new FilterField[] { new FilterField("Naziv_Sale") });

            if (VecPostoji != null)
            {
                throw new SalaException("Vec postoji sala sa ovim imenom!", 0);
            }

            repository.Dodaj(sala);
            if (sala.Id == 0) { throw new System.Exception("Greska u dodavanju sale!"); }
            foreach (Sediste s in sala.ListSedista)
            {
                s.Sala_Id = sala.Id;
                List<Sediste> listSediste = repository.Pretrazi(s, new FilterField("Red"), new FilterField("Kolona"), new FilterField("Sala_Id")).Cast<Sediste>().ToList();
                if (listSediste.Count > 0)
                {
                    throw new System.Exception($"Vec postoji sediste: ({s.Red},{s.Kolona})!");
                }

                if (s.CrudStatus == CrudStatus.Create)
                    repository.Dodaj(s);

            }


            //repository.DodajSaSlabim(sala, sala.ListSedista.Cast<IEntity>().ToList());

        }
    }
}
