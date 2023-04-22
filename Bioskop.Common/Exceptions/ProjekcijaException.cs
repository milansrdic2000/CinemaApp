using System;
using System.Runtime.Serialization;

namespace Bioskop.Common.Exceptions
{
    [Serializable]
    public class ProjekcijaException : Exception, ISerializable
    {
        public int Code;

        public ProjekcijaException(string message, int code) : base(message)
        {
            Code = code;

            // 1 -  datum
            // 2 - cena
            // 
        }
        public ProjekcijaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

            this.Code = info.GetInt32("ProjekcijaException.Code");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("ProjekcijaException.Code", this.Code);

        }
    }
}
