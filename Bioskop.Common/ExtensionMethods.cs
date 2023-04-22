using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Bioskop.Common
{
    public static class ExtensionMethods
    {
        public static bool DaLiSedistePostojiUsali(this IList<Sediste> list, Sediste s)
        {
            foreach (Sediste s2 in list)
            {
                if (s2.Red == s.Red && s2.Kolona == s.Kolona)
                {
                    return true;
                }

            }

            return false;
        }
        public static T ConvertResponse<T>(this Response res)
        {
            if (res.Exception != null) throw res.Exception;
            if (res.Success == false) throw new System.Exception(res.Message);
            return (T)res.Data;
        }
        public static bool IsValidEmail(this string email)
        {
            var regexPattern = @"^.{3,}@\w{3,}\.\w+$";
            var regex = new Regex(regexPattern);
            return regex.IsMatch(email);
        }
        public static bool IsNumber(this string number)
        {
            var regexPattern = @"^\d+$";
            var regex = new Regex(regexPattern);
            return regex.IsMatch(number);
        }


    }
}
