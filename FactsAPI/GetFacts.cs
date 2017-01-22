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
        public static async Task<String> GetDateFact(string month,string day)
        {
           return await Helpers.WebHelper.GetJSONDate(month, day);
        }
        public static async Task<String> GetMathFact(string number)
        {
            return await Helpers.WebHelper.GetJSONMath(number);
        }
        public static async Task<String> GetTriviaFact(string number)
        {
            return await Helpers.WebHelper.GetTrivia(number);
        }
        public static async Task<MonthFact> GetYearFact()
        {
            return null;
        }

    }
}
