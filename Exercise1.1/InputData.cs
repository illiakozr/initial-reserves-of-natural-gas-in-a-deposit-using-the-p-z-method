using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1._1
{
    public static class InputData
    {
        //public static Dictionary<double, double> Pressure_Extraction = new Dictionary<double, double>();
        //{
        //    {3610000, 0 }, {2740000,  248.3}, { 2430000, 317.7}, {2390000, 355.3 },
        //    {2080000, 461.3 }, {1880000,  501}, {1860000, 515.1 }, {1820000, 524 },
        //    {1630000, 567 }, { 1640000, 578.1}, {1450000, 614.6 }, {1430000,  628.8},
        //    {1270000,  690}, { 1200000,  693.3}
        //};
        public static List<double> U_data = new List<double>() { 0.98, 0.005, 0.005, 0.005, 0.005 };

        public static List<double> ConvertedPressure { get; set; }

        public static void ConvertPressure()
        {
            ConvertedPressure = new List<double>();
            
            foreach (var item in Pressure)
            {
                ConvertedPressure.Add(item / Math.Pow(10, 6));
            }
        }

        public static List<double> Pressure = new List<double>();
        //{
        //        3610000, 2740000, 2430000 , 2390000 ,
        //        2080000 , 1880000 , 1860000 , 1820000,
        //        1630000, 1630000, 1450000, 1430000,
        //        1270000, 1200000
        //};

         public static List<double> GasExtraction = new List<double>();
        //{
        //    0, 248.3, 317.7, 355.3, 461.3, 501, 515.1, 524, 567, 578.1, 614.6, 628.8, 690, 693.3
        //};
    }
}
