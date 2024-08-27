using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMFINAL.BUS.Utils.Validation
{
    public static class BaseValidation
    {
        public static string CheckEmpty(string propertyName, string propertyValue)
        {
            if(string.IsNullOrWhiteSpace(propertyValue))
            {
                return $"Không đc để trống {propertyName}\n";
                
            }
            return string.Empty;
        }
    }
}
