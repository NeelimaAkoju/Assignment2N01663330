using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Assignment2N01663330.Controllers
{
    
    public class J3HarpTuningController : ApiController
    {
        /// <summary>
        /// Receives input string which contains message and converts the message to list of strings which is readable ouput message.
        /// </summary>
        /// <param name="inputMessage">The input string</param>
        /// <returns>A list of string with readable output message</returns>
        /// <example>
        /// GET api/J3/HarpTuningOutput/AC-8FKB-10 -> AC loosen 8
        ///                                           FKB loosen 10
        /// </example>
        /// <example>
        /// GET api/J3/HarpTuningOutput/AC-8FKB+10 -> AC loosen 8
        ///                                           FKB tighten 10
        /// </example>   

        [HttpGet]
        [Route("api/J3/HarpTuningOutput/{inputMessage}")]
        public List<string> HarpTuningOutput(string inputMessage)
        {
            int lengthOfInputMsg = inputMessage.Length;
            Debug.WriteLine(lengthOfInputMsg);
            List<string> outputMessage = new List<string>();
            StringBuilder tempMsg = new StringBuilder();
            int i = 0;
            while (i < lengthOfInputMsg)
            {
               char tempChar =  inputMessage[i]; 
                Boolean numberFound = false;
                if (tempChar >= 'A' && tempChar <= 'T')
                {
                    if (numberFound)
                    {
                        outputMessage.Add(tempChar.ToString());
                        tempMsg.Clear();
                        tempMsg.Append(tempChar);
                    }
                    else
                    {
                        tempMsg.Append(tempChar);
                    }
                }
                else if (tempChar == '+')
                {
                    tempMsg.Append(" tighten ");
                }
                else if (tempChar == '-')
                {
                    tempMsg.Append(" loosen ");
                }
                else if (Char.IsNumber(tempChar))
                {
                    tempMsg.Append(tempChar);
                    numberFound = true;
                }

                if (numberFound)
                {
                    outputMessage.Add(tempMsg.ToString());
                    tempMsg.Clear();
                    Debug.WriteLine("Order Name");
                }
                i++;
            }
            return outputMessage;
        }
         
    }
}
