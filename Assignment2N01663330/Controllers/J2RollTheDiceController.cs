using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2N01663330.Controllers
{
    public class J2RollTheDiceController : ApiController
    {
        /// <summary>
        /// Receives two input parameters, sides of dice 1 and sides of dice 2, and caculates the total number of ways to roll 10 using both dice.
        /// </summary>
        /// <param name="sidesDice1">The integer input</param>
        /// <param name="sidesDice2">The integer input</param>
        /// <returns>A string output with number of ways the dices can be rolled to get sum 10</returns>
        /// <example>
        /// GET api/J2/WaysToRoll10/6/8 -> There are 5 ways to get the sum 10.
        /// </example>
        /// <example>
        /// GET api/J2/WaysToRoll10/5/5 -> There is 1 way to get the sum 10.
        /// </example>   
        /// <example>
        /// GET api/J2/WaysToRoll10/12/4 -> There are 4 ways to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/WaysToRoll10/{sidesDice1}/{sidesDice2}")]
        public string WaysToRoll10(int sidesDice1, int sidesDice2)
        {
            int waysToGetTen = 0;
            for (int i = 1; i <= sidesDice1; i++)
            {
                if((10 - i) >= 1 && (10 - i)<= sidesDice2)
                {
                    waysToGetTen = waysToGetTen + 1;
                }
            }
            string outputText ;
            if (waysToGetTen == 1)
            {
                outputText = "There is " + waysToGetTen + " way to get the sum 10.";
            }
            else
            {
                outputText = "There are " + waysToGetTen + " ways to get the sum 10.";
            }
            return outputText;
        }
        
    }
}
