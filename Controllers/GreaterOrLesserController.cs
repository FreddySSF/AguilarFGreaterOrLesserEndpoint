// Fernando Aguilar
// 10-25-22
// Greater Than Or Less Than Endpoint
// The program takes mini challenge 4 and converts it to API format.
// The user will type their inputs into the url and when posted into 
// Postman, will tell the user whether the first number is greater than, less than,
// or equal too the second number.
// Peer Reviewed By: Jovann Contreras: Code looks good and is easy to read, works on postman tells me if it is greater than less than or equal too.
using Microsoft.AspNetCore.Mvc;

namespace AguilarFGreaterOrLesserEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLesserController : ControllerBase
{
    [HttpGet]
    [Route("BiggerOrSmaller/{number1}/{number2}")]

    public string GreaterOrLesser(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        if (convertNum1 > convertNum2)
        {
            return convertNum1 + " is greater than " + convertNum2 + " and " + convertNum2 + " is less than " + convertNum1;
        }
        else if (convertNum1 < convertNum2)
        {
            return convertNum1 + " is less than " + convertNum2 + " and " + convertNum2 + " is greater than " + convertNum1;
        }
        else
        {
            return convertNum1 + " is equal to " + convertNum2;
        }

    }

}