using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioskop.Common
{
    [Serializable]
    public class Request
    {
        public object Body { get; set; }
        public Operation Operation { get; set; }

        public object Header { get; set; }
    }
}
