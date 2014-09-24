using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeControlPoliciaco
{
    public static class Variables
    {
        public static string apePat;
        public static string apeMat;
        public static string nomAsp;
        public static string fecNac;
        public static string entFed;
        public static string sexAsp;
        public static string curAsp;
        public static string rfcAsp;

        public static void DatosPersonales(string aPat, string aMat, string nAsp, string fNac, string eFed, string sAsp, string cAsp, string rAsp)
        {
            apePat = aPat;
            apeMat = aMat;
            nomAsp = nAsp;
            fecNac = fNac;
            entFed = eFed;
            sexAsp = sAsp;
            curAsp = cAsp;
            rfcAsp = rAsp;
        }
    }
}
