using Bioskop.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class VratiDostupnaSedistaSystemOperation : SystemOperationBase
    {
        public Rezervacija rez;
        protected override void ExecuteConcreteOperation()
        {
            // trazimo sve karte (preko rezervacije) na zadatoj projekciji
            Karta kartaFilter = new Karta()
            {
                Projekcija_Id = rez.Projekcija_Id
            };
            List<Karta> listKarteSveProjekcije = repository.Pretrazi(kartaFilter, new FilterField[] { new FilterField("Projekcija_Id") }).Cast<Karta>().ToList();

            // vracamo bioskopsku salu na koju se odnosi projekcija (koju dobijamo iz rezervacije)
            VratiBioskopskuSaluSystemOperation vratiBioskopskuSaluSystemOperation = new VratiBioskopskuSaluSystemOperation();
            vratiBioskopskuSaluSystemOperation.Sala = rez.ProjekcijaFilma.BioskopskaSala;
            vratiBioskopskuSaluSystemOperation.Execute();


            //
            List<Sediste> listaSedista = vratiBioskopskuSaluSystemOperation.ListSediste;

            //karte od prosledjene rezervacije, poredimo ih sa svim kartama za projekciju
            List<Karta> mojeKarte = rez.ListKarta;
            foreach (Karta k in listKarteSveProjekcije)
            {
                bool mojaKarta = false;
                if (mojeKarte != null)
                {
                    foreach (Karta mk in mojeKarte)
                    {
                        if (mk.Karta_Id == k.Karta_Id) mojaKarta = true;
                    }
                }
                foreach (Sediste sed in listaSedista)
                {
                    if (k.Sediste_Id == sed.Sediste_Id)
                    {
                        sed.Rezervisano = true;

                        if (mojaKarta)
                            sed.MojeRezervisano = true;
                    }

                }


            }


            rez.ListSedistaSaDostupnosti = listaSedista;
            // rez.UkupnaCena = rez.ProjekcijaFilma.Cena_Karte * rez.ListKarta.Count;


        }
    }
}
