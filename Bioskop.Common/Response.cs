using System;

namespace Bioskop.Common
{
    [Serializable]
    public class Response
    {

        public object Data { get; set; }
        public Operation Operation { get; set; }

        public bool Success { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }

        public Exception Exception { get; set; }

    }
}
