using FactsAPI.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactsAPI
{
    public static class GetFacts
    {
        public static async Task<MonthFact> GetDateFact(string month,string day)
        {
           return await Helpers.WebHelper.GetJSONDate(month, day);
        }
        public static async Task<MonthFact> GetMathFact()
        {
            return null;
        }
        public static async Task<MonthFact> GetTriviaFact()
        {
            return null;
        }
        public static async Task<MonthFact> GetYearFact()
        {
            return null;
        }

    }
}
