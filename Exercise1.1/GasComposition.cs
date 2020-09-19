using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1._1
{
    public class GasComposition
    {
        private const double R = 8.314;
       // public double T { get; set; } = 291;
        private double sumTemp { get; set; }
        private double sumPress { get; set; }

        public double a { get; set; }
        public double b { get; set; }

        public double[] Pc_data = { 4590000, 4850000, 4210000, 7390000, 3390000 };
        public double[] Tc_data = { 190.56, 305.32, 369.83, 304.21, 126.2 };
        
     
        public List<GasComponent> components;

        public GasComposition()
        {
            
        }

        private void InitializeComponents()
        {
            components = new List<GasComponent>();
            for (int i = 0; i < Pc_data.Length; i++)
            {
                GasComponent comp = new GasComponent(InputData.U_data[i], Pc_data[i], Tc_data[i]);
                components.Add(comp);
            }
        }

        public void SummarizePressure()
        {
            double result = 0;

            foreach (GasComponent c in components)
            {
                result += c.Pc * c.U;
            }

            sumPress = result;
        }

        public void SummarizeTemperature()
        {
            double result = 0;

            foreach (GasComponent c in components)
            {
                result += c.Tc * c.U;
            }

            sumTemp = result;
        }

        public void Compute_a()
        {
            a = (27 * Math.Pow(R, 2) * Math.Pow(sumTemp, 2))
                / (64 * sumPress);
        }

        public void Compute_b()
        {
            b = (R * sumTemp) / (8 * sumPress);
        }

        public void ComputeAll()
        {
            InitializeComponents();
            SummarizePressure();
            SummarizeTemperature();
            Compute_a();
            Compute_b();
        }
    }
}
