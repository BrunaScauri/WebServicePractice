using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CodingCafeWebApplication
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://WebServicePractive.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public enum CalculationType
        {
            Sum = 1,
            Subtract = 2,
            Multiply = 3,
            Division = 4
        }

        [WebMethod(Description ="Simple calculator Web Service.")]
        public decimal Calculate(decimal decValue1, decimal decValue2, CalculationType calculationType)
        {
            decimal decResult;
            switch (calculationType)
            {
                case CalculationType.Sum:
                    decResult = decValue1 + decValue2;
                    break;
                case CalculationType.Subtract:
                    decResult = decValue1 - decValue2;
                    break;
                case CalculationType.Multiply:
                    decResult = decValue1 * decValue2;
                    break;
                case CalculationType.Division:
                    decResult = decValue1 % decValue2;
                    break;
                default:
                    decResult = 0;
                    break;
            }
            return decResult;
        }
    }
}
