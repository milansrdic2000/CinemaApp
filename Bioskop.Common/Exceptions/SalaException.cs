using System;
using System.Runtime.Serialization;

namespace Bioskop.Common.Exceptions
{
    [Serializable]
    public class SalaException : Exception, ISerializable
    {

        public int Code;

        public SalaException(string message, int code) : base(message)
        {
            Code = code;

            //0 - naziv sale
            //1 - generisi red
            //2 - generisi kolonu
            //3 - dodaj red
            //4 - dodaj kolonu

        }
        public SalaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

            this.Code = info.GetInt32("SalaException.Code");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("SalaException.Code", this.Code);

        }
    }
}
