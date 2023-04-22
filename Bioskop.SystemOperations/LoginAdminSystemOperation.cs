using Bioskop.Common;
using Bioskop.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.SystemOperations
{
    public class LoginAdminSystemOperation : SystemOperationBase
    {
        public Administrator Administrator;
        protected override void ExecuteConcreteOperation()
        {
            if (Administrator == null) throw new Exception("Greska, nema admina!");

            List<Administrator> listAdmin;


            listAdmin = repository.Pretrazi(Administrator, new FilterField("Email")).Cast<Administrator>().ToList();

            if (listAdmin.Count <= 0)
            {
                throw new KorisnikException("Ne postoji administrator sa tim Emailom", 404);
            }
            else
            {

                Administrator admin = listAdmin[0];
                if (admin.Sifra != Administrator.Sifra)
                {
                    throw new KorisnikException("Sifra je netacna!", 405);
                }

                Administrator = admin;
            }
        }
    }
}
