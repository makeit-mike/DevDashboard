using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DevDashboard.Classes
{
    public static class Extensions
    {
        public static string ToProperNoun(this string noun)
        {
            try
            {
                return (noun.Length > 1) ? $"{noun[0].ToString().ToUpper()}{noun[1..]}" : noun.ToUpper();
            }
            catch
            {
                return noun;
            }
        }

        public static int? ToOptionalInt(this string input, int? defualt = null)
        {
            try
            {
                return input is null || input.Length == 0 ? defualt : Convert.ToInt32(input);
            }
            catch
            {
                return defualt;
            }
        }
    }
}
