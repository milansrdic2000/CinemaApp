using System;

namespace Bioskop.Common
{
    [Serializable]
    public class JoinHelper
    {
        public string ForeignKeyName { get; set; }

        public IEntity JoinTable { get; set; }

        public string[] FilterFieldsJoin
        {
            get; set;
        }


    }
}
