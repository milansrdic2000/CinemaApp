using System;
using System.Runtime.Serialization;

namespace Bioskop.Common.Exceptions
{
    [Serializable]
    public class FilmException : Exception, ISerializable
    {
        public int Code;

        public FilmException(string message, int code) : base(message)
        {
            Code = code;

            // 1 -  naziv
            // 2 - trajanje
            // 
        }
        public FilmException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

            this.Code = info.GetInt32("FilmException.Code");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("FilmException.Code", this.Code);

        }
    }
}
