using System;
using System.Runtime.Serialization;

namespace Bioskop.Common.Exceptions
{
    [Serializable]
    public class KorisnikException : Exception, ISerializable
    {

        public int Code;

        public KorisnikException(string message, int code) : base(message)
        {
            Code = code;

            //404 - Email
            //405 - sifra netacna
            //1 - Ime
            //2 - Prezime
            //3 - Datum
            //4 - Sifra
        }
        public KorisnikException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

            this.Code = info.GetInt32("KorisnikException.Code");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("KorisnikException.Code", this.Code);

        }
    }
}
