using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1._1
{
    public class DefinitionOfZ
    {
        private const double R = 8.314;
        public double T { get; set; } 

        public List<double> A { get; set; }
        public List<double> B { get; set; }

        public List<double> Z_1 { get; set; }
        public List<double> Z_2 { get; set; }
        public List<double> Z_3 { get; set; }
        public List<double> Z_4 { get; set; }
        public List<double> Z_5 { get; set; }

        public List<double> P_z { get; set; }

        public GasComposition gazComposition = new GasComposition();

        public DefinitionOfZ()
        {
            
        }

        public void Compute_A()
        {
            A = new List<double>();

            foreach ( var item in InputData.Pressure)
            {
                A.Add((gazComposition.a * item) / (Math.Pow(R, 2) * Math.Pow(T, 2)));
            }
        }

        public void Compute_B()
        {
            B = new List<double>();
            foreach (var item in InputData.Pressure)
            {
                B.Add((gazComposition.b * item) / (R * T));
            }
        }

        public void Initialize_Z1()
        {
            Z_1 = new List<double>();

            for (int i = 0; i < InputData.Pressure.Count; i++)
            {
                Z_1.Add(1);
            }
        }

        public void Compute_Z2()
        {
            Z_2 = new List<double>();

            for (int i = 0; i < Z_1.Count; i++)
            {
                Z_2.Add(((Z_1[i]) / (Z_1[i] - B[i])) - (A[i] / Z_1[i]));
            }
        }

        public void Compute_Z3()
        {
            Z_3 = new List<double>();

            for (int i = 0; i < Z_1.Count; i++)
            {
                Z_3.Add(((Z_2[i]) / (Z_2[i] - B[i])) - (A[i] / Z_2[i]));
            }
        }

        public void Compute_Z4()
        {
            Z_4 = new List<double>();

            for (int i = 0; i < Z_1.Count; i++)
            {
                Z_4.Add(((Z_3[i]) / (Z_3[i] - B[i])) - (A[i] / Z_3[i]));
            }
        }

        public void Compute_Z5()
        {
            Z_5 = new List<double>();

            for (int i = 0; i < Z_1.Count; i++)
            {
                Z_5.Add(((Z_4[i]) / (Z_4[i] - B[i])) - (A[i] / Z_4[i]));
            }
        }

        public void Compute_Pz()
        {
            P_z = new List<double>();

            InputData.ConvertPressure();

            for (int i = 0; i < Z_5.Count; i++)
            {
                P_z.Add(InputData.ConvertedPressure[i] / Z_5[i]);
            }
        }

        public void ComputeAll()
        {
            Compute_A();
            Compute_B();
            Initialize_Z1();
            Compute_Z2();
            Compute_Z3();
            Compute_Z4();
            Compute_Z5();
            Compute_Pz();
        }
    }
}
