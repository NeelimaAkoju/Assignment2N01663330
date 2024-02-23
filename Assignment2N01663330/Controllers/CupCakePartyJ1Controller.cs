using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2N01663330.Controllers
{
    public class CupCakePartyJ1Controller : ApiController
    {
        /// <summary>
        /// Receives two input parameters - number of regular cupcake boxes and number of small cupcake boxes, and caculates the number of cupcakes left after giving to 28 students.
        /// <param name="regularBoxes">The integer input</param>
        /// <param name="smallBoxes">The integer input</param>
        /// <returns>An integer output with number of cupcakes left.</returns>
        /// <example>
        /// GET api/CupCakesLeftCalculator/2/5 -> 3
        /// </example>
        /// <example>
        /// GET api/CupCakesLeftCalculator/2/4 -> 0
        /// </example>   
        /// <example>
        /// GET api/CupCakesLeftCalculator/3/5 -> 11
        /// </example>
        [HttpGet]
        [Route("api/CupCakesLeftCalculator/{regularBoxes}/{smallBoxes}")]
        public int CupCakesLeftCalculator(int regularBoxes, int smallBoxes)
        {
            int totalStudents = 28;
            int totalCupCakes = 0;
            if (regularBoxes >= 0 && smallBoxes >= 0)
            {
                int cupCakesRegular = regularBoxes * 8;
                int cupCakesSmall = smallBoxes * 3;
                totalCupCakes = ((cupCakesRegular + cupCakesSmall) - totalStudents);
;            }
            return totalCupCakes;
        }
    }
}
