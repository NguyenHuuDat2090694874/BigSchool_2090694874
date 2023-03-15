using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool_2090694874.ViewModels
{
    public class FutureDate :ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isVaid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyy", 
                CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);
            return (isVaid && dateTime > DateTime.Now);
        }
    }
}