using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda
{
    internal class Conversor
    {


        public static double Iof = 6.0;


        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total + total * Iof / 100.0;

        }



        //Como eu havia feito antes da correção;

        //public static double Iof = 6.0;


        //public static double CotacaDollar(double cotacao)
        //{
        //    return cotacao;
        //}

        //public static double QuantidadeDollarCompra(double quantidade) 
        //{

        //    return quantidade;

        //}


        //public static double TotalEmReais(double total)
        //{
        //    return total + total* Iof/ 100 ;

        //}

    }
}
