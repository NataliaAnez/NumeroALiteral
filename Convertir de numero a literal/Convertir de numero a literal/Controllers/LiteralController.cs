using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Convertir_de_numero_a_literal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LiteralController : Controller
    {
     [HttpGet]

        [HttpGet]
        public string NumeroGet(int num1, string num2)
        {
            if (num1 == 0)
            { num2 = "Cero"; }
            if (num1 == 1)
            { num2 = "Uno"; }
            if (num1 == 2)
            { num2 = "Dos"; }
            if (num1 == 3)
            { num2 = "Tres"; }
            if (num1 == 4)
            { num2 = "Cuatro"; }
            if (num1 == 5)
            { num2 = "Cinco"; }
            if (num1 == 6)
            { num2 = "Seis"; }
            if (num1 == 7)
            { num2 = "Siete"; }
            if (num1 == 8)
            { num2 = "Ocho"; }
            if (num1 == 9)
            { num2 = "Nueve"; }
            if (num1 == 10)
            { num2 = "Diez"; }
            if (num1 == 11)
            { num2 = "Once"; }
            if (num1 == 12)
            { num2 = "Doce"; }
            if (num1 == 13)
            { num2 = "Trece"; }
            if (num1 == 14)
            { num2 = "Catorce"; }
            if (num1 == 15)
            { num2 = "Quince"; }     
            
          /*  if (num1 < 20)
            { num2 = "Dieci" + (num1 - 10);}
            if (num1 == 20)
            { num2 = "Veinte";}
            if (num1 < 30)
            { num2 = "Veinti" + (num1 - 10); }
          */

            return num2;


        }

        [HttpPost]
        public string NumeroPost([FromHeader] int num1, string num2)
        {
            if (num1 == 0)
            { num2 = "Cero"; }
            if (num1 == 1)
            { num2 = "Uno"; }
            if (num1 == 2)
            { num2 = "Dos"; }
            if (num1 == 3)
            { num2 = "Tres"; }
            if (num1 == 4)
            { num2 = "Cuatro"; }
            if (num1 == 5)
            { num2 = "Cinco"; }
            if (num1 == 6)
            { num2 = "Seis"; }
            if (num1 == 7)
            { num2 = "Siete"; }
            if (num1 == 8)
            { num2 = "Ocho"; }
            if (num1 == 9)
            { num2 = "Nueve"; }
            if (num1 == 10)
            { num2 = "Diez"; }
            if (num1 == 11)
            { num2 = "Once"; }
            if (num1 == 12)
            { num2 = "Doce"; }
            if (num1 == 13)
            { num2 = "Trece"; }
            if (num1 == 14)
            { num2 = "Catorce"; }
            if (num1 == 15)
            { num2 = "Quince"; }
            /*
            if (num1 < 20)
            { num2 = "Dieci" + (num1 - 10); }
             if (num1 == 20)
             { num2 = "Veinte"; }
             if (num1 < 30)
             { num2 = "Veinti" + (num1 - 10); }
            */
            return num2;
        }



    }
}
