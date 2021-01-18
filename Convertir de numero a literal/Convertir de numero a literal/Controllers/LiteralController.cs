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

        private string Millon(char x)
        {
            if (x == '1')
            { return "Millon "; }
            if (x == '2')
            { return "Dos Millones "; }
            if (x == '3')
            { return "Tres Millones "; }
            if (x == '4')
            { return "Cuatro Millones "; }
            if (x == '5')
            { return "Cinco Millones "; }
            if (x == '6')
            { return "Seis Millones "; }
            if (x == '7')
            { return "Siete Millones "; }
            if (x == '8')
            { return "Ocho Millones "; }

            return "Nueve Millones ";

        }

        private string Centena(char x)
        {

            if (x == '1')
            { return "Ciento "; }
            if (x == '2')
            { return "Doscientos "; }
            if (x == '3')
            { return "Trescientos "; }
            if (x == '4')
            { return "Cuatrocientos "; }
            if (x == '5')
            { return "Quinientos "; }
            if (x == '6')
            { return "Seiscientos "; }
            if (x == '7')
            { return "Sietecientos "; }
            if (x == '8')
            { return "Ochocientos "; }
            if (x == '9')
            { return "Novecientos "; }
            return " ";

        }

        private string Decena(char x)
        {
            if (x == '1')
            { return "Diez "; }
            if (x == '2')
            { return "Veinte "; }
            if (x == '3')
            { return "Treinta "; }
            if (x == '4')
            { return "Cuarenta "; }
            if (x == '5')
            { return "Cincuenta "; }
            if (x == '6')
            { return "Sesenta "; }
            if (x == '7')
            { return "Setenta "; }
            if (x == '8')
            { return "Ochenta "; }
            if (x == '9')
            { return "Noventa "; }
            return " ";
        }

        private string Unidad(char x)
        {
            if (x == '1')
            { return "Uno"; }
            if (x == '2')
            { return "Dos"; }
            if (x == '3')
            { return "Tres"; }
            if (x == '4')
            { return "Cuatro"; }
            if (x == '5')
            { return "Cinco"; }
            if (x == '6')
            { return "Seis"; }
            if (x == '7')
            { return "Siete"; }
            if (x == '8')
            { return "Ocho"; }
            if (x == '9')
            { return "Nueve"; }
            return "";
        }

        private string MayorADiez(char x)
        {

            if (x == '1')
            { return "Once"; }
            if (x == '2')
            { return "Doce"; }
            if (x == '3')
            { return "Trece"; }
            if (x == '4')
            { return "Catorce"; }
            if (x == '5')
            { return "Quince"; }

            return "";
        }


        [HttpGet]

        public string NumeroGet(string num1)
        {

            string respuesta = "";

            /* if (num1[0] == '-')
             {
                 respuesta += "Menos ";
                 for (int i = 0; i < num1.Length; i++)
                 {
                     num1[i] = num1[i + 1];
                 }

             }*/

            if (num1.Length > 7)
            { return "Numero muy grande"; }
            if (num1.Length == 0)
            { return "Vacio"; }
            if (num1.Length == 7)
            {
                respuesta += Millon(num1[0]);

                if (num1[0] == '1' && num1[1] == '0' && num1[2] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[1]);
                }
                respuesta += Decena(num1[2]);
                if (num1[2] != '0' || num1[3] != '1')
                { respuesta += " y"; }

                if (num1[2] == '0' && num1[3] == '1')
                {
                    respuesta += " un";

                }
                else
                { 
                respuesta += Unidad(num1[3]);
                }

                if (num1[1] != '0' || num1[2] != '0' || num1[3] != '0')
                {
                    respuesta += " mil ";
                }

                if (num1[4] == '1' && num1[5] == '0' && num1[6] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[4]);
                }

                respuesta += Decena(num1[5]);
                if (num1[6] != '0')
                { respuesta += " y "; }
                respuesta += Unidad(num1[6]);


            }

            if (num1.Length == 6)
            {

                if (num1[0] == '1' && num1[1] == '0' && num1[2] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[0]);
                }

                respuesta += Decena(num1[1]);
                if (num1[2] != '0')
                { respuesta += " y "; }

                if (num1[1] == '0' && num1[2] == '1')
                {
                    respuesta += "un";

                }

                else
                {
                    respuesta += Unidad(num1[3]);

                }

                    if (num1[0] != '0' || num1[1] != '0' || num1[2] != '0')
                {
                    respuesta += " mil ";
                }

                if (num1[3] == '1' && num1[4] == '0' && num1[5] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[3]);
                }

                respuesta += Decena(num1[4]);
                if (num1[5] != '0')
                { respuesta += " y"; }
                respuesta += Unidad(num1[5]);


            }

            if (num1.Length == 5)
            {


                respuesta += Decena(num1[0]);
                if (num1[1] != '0')
                { respuesta += "y "; }

                if (num1[0] == '0' && num1[1] == '1')
                {
                    respuesta += "un";

                }

                else
                {
                    respuesta += Unidad(num1[1]);

                }


                if (num1[0] != '0' || num1[1] != '0')
                {
                    respuesta += " mil ";
                }

                if (num1[2] == '1' && num1[3] == '0' && num1[4] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[2]);
                }

                respuesta += Decena(num1[3]);
                if (num1[4] != '0')
                { respuesta += " y"; }
                respuesta += Unidad(num1[4]);


            }

            if (num1.Length == 4)
            {

                respuesta += Unidad(num1[0]);


                if (num1[0] != '0')
                {
                    respuesta += " mil ";
                }

                if (num1[1] == '1' && num1[2] == '0' && num1[3] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[1]);
                }

                respuesta += Decena(num1[2]);
                if (num1[3] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num1[3]);


            }


            if (num1.Length == 3)
            {

                if (num1[0] == '1' && num1[1] == '0' && num1[2] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[0]);
                }

                respuesta += Decena(num1[1]);
                if (num1[2] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num1[2]);


            }

            if (num1.Length == 2)
            {

                if (num1[1] == '0' || (num1[1] >= '6' && num1[1] <= '9'))
                {
                    respuesta += Decena(num1[0]);
                    if (num1[1] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[1]);
                }

                if (num1[0] == '1' && num1[1] < '6' && num1[1] >= '1')
                {
                    respuesta += MayorADiez(num1[1]);

                }

            }

            if (num1.Length == 1)
            {

                if (num1[0] == '0')
                {
                    return "Cero";
                }

                else
                {
                    respuesta += Unidad(num1[0]);
                }


            }



            return respuesta;
        }




        [HttpPost]
        public string NumeroPost([FromHeader] string num1)
        {
            string respuesta = "";

            if (num1.Length > 7)
            { return "Numero muy grande"; }
            if (num1.Length == 0)
            { return "Vacio"; }
            if (num1.Length == 7)
            {
                respuesta += Millon(num1[0]);

                if (num1[0] == '1' && num1[1] == '0' && num1[2] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[1]);
                }
                respuesta += Decena(num1[2]);
                if (num1[2] != '0' || num1[3] != '1')
                { respuesta += " y"; }

                if (num1[2] == '0' && num1[3] == '1')
                {
                    respuesta += " un";

                }
                else
                {
                    respuesta += Unidad(num1[3]);
                }

                if (num1[1] != '0' || num1[2] != '0' || num1[3] != '0')
                {
                    respuesta += " mil ";
                }

                if (num1[4] == '1' && num1[5] == '0' && num1[6] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[4]);
                }

                respuesta += Decena(num1[5]);
                if (num1[6] != '0')
                { respuesta += " y "; }
                respuesta += Unidad(num1[6]);


            }

            if (num1.Length == 6)
            {

                if (num1[0] == '1' && num1[1] == '0' && num1[2] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[0]);
                }

                respuesta += Decena(num1[1]);
                if (num1[1] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num1[2]);
                if (num1[0] != '0' || num1[1] != '0' || num1[2] != '0')
                {
                    respuesta += " mil ";
                }

                if (num1[3] == '1' && num1[4] == '0' && num1[5] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[3]);
                }

                respuesta += Decena(num1[4]);
                if (num1[5] != '0')
                { respuesta += " y"; }
                respuesta += Unidad(num1[5]);


            }

            if (num1.Length == 5)
            {

                
                respuesta += Decena(num1[0]);
                if (num1[0] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num1[1]);
                if (num1[0] != '0' || num1[1] != '0')
                { 
                    respuesta += " mil ";
                }

                if (num1[2] == '1' && num1[3] == '0' && num1[4] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[2]);
                }

                respuesta += Decena(num1[3]);
                if (num1[4] != '0')
                { respuesta += " y"; }
                respuesta += Unidad(num1[4]);


            }

            if (num1.Length == 4)
            {

                respuesta += Unidad(num1[0]);
                if (num1[0] != '0')
                {
                    respuesta += " mil ";
                }

                if (num1[1] == '1' && num1[2] == '0' && num1[3] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[1]);
                }

                respuesta += Decena(num1[2]);
                if (num1[3] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num1[3]);


            }


            if (num1.Length == 3)
            {

                if (num1[0] == '1' && num1[1] == '0' && num1[2] == '0')
                {

                    respuesta += "Cien";
                }
                else
                {
                    respuesta += Centena(num1[0]);
                }

                respuesta += Decena(num1[1]);
                if (num1[2] != '0')
                { respuesta += "y "; }
                respuesta += Unidad(num1[2]);


            }

            if (num1.Length == 2)
            {

                if (num1[1] == '0' || (num1[1] >= '6' && num1[1] <= '9'))
                {
                    respuesta += Decena(num1[0]);
                    if (num1[1] != '0')
                    { respuesta += "y "; }
                    respuesta += Unidad(num1[1]);
                }

                if (num1[0] == '1' && num1[1] < '6' && num1[1] >= '1')
                {
                    respuesta += MayorADiez(num1[1]);

                }

            }

            if (num1.Length == 1)
            {

                if (num1[0] == '0')
                {
                    return "Cero";
                }

                else
                {
                    respuesta += Unidad(num1[0]);
                }


            }

            

            return respuesta;
        }




    }
}
