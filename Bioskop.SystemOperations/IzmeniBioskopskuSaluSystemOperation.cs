using Bioskop.Common;
using Bioskop.Common.Exceptions;
using Bioskop.Common.Model;

namespace Bioskop.SystemOperations
{
    public class IzmeniBioskopskuSaluSystemOperation : SystemOperationBase
    {
        public BioskopskaSala Sala;
        protected override void ExecuteConcreteOperation()
        {

            if (Sala.Naziv_Sale == "") throw new SalaException("Morate uneti naziv sale!", 0);

            BioskopskaSala VecPostoji = (BioskopskaSala)repository.Vrati(Sala, new FilterField[] { new FilterField("Naziv_Sale") });

            if (VecPostoji != null)
            {
                if (VecPostoji.Id != Sala.Id)
                    throw new SalaException("Vec postoji sala sa ovim imenom!", 0);
            }

            repository.Azuriraj(Sala, new FilterField("Id"));

            if (Sala.ListaSedistaZaBrisanje != null)
                foreach (Sediste s in Sala.ListaSedistaZaBrisanje)
                {
                    repository.Obrisi(s, new FilterField("Sediste_Id"));
                }

            if (Sala.ListSedista != null)
                foreach (Sediste s in Sala.ListSedista)
                {
                    if (s.CrudStatus == CrudStatus.Update)
                        repository.Azuriraj(s, new FilterField("Sediste_Id"));

                    else if (s.CrudStatus == CrudStatus.Create)
                        repository.Dodaj(s);
                }

        }
    }
}
