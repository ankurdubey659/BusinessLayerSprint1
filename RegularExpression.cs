using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace BusinessLayerSprint1
{
    class RegularExpression
    {
        //public static bool isValidMobileNumber(string valMobileNumber)
        //{
        //    string strRegex1 = @"(^[0-9]{10}$|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

        //    Regex re1 = new Regex(strRegex1);

        //    if (re1.IsMatch(valMobileNumber))
        //        return (true);
        //    else
        //        return (false);
        //}

        public static bool isValidEmailId(string valEmailId)
        {
            string strRegex2 = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";// We can find it on net i.e regex of emails

            Regex re2 = new Regex(strRegex2, RegexOptions.IgnoreCase);
            if (re2.IsMatch(valEmailId))
                return (true);
            else
                return (false);
        }
    }
}
