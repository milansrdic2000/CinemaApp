using System;

namespace Bioskop.Common
{

    public enum FilterType
    {
        FieldEquality, //ako je klasicno poredjenje kolonaA = 2, kolonaB = 'string'
        ManualComparation, //korisnik sam definise where clausulu

    }
    [Serializable]
    public class FilterField
    {
        public string FieldName { get; set; }

        public FilterType FilterType { get; set; }

        // ako je manualcomparation, korisnik sam definise sta je sa leve strane upita, 
        //npr upper(ime) like ....
        public string LeftSideCondition { get; set; }

        public FilterField(string fieldName)
        {
            this.FieldName = fieldName;
        }
        public FilterField(string fieldName, string LeftSideCondition)
        {
            this.FieldName = fieldName;
            this.FilterType = FilterType.ManualComparation;
            this.LeftSideCondition = LeftSideCondition;
        }
    }
}
