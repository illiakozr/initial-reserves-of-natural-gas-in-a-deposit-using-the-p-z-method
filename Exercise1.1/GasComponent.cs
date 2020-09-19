using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1._1
{
    public struct GasComponent
    {
        public double Pc { get; set; }
        public double Tc { get; set; }
        public double U { get; set; }

        public GasComponent(double U, double Pc, double Tc)
        {
            this.U = U;
            this.Pc = Pc;
            this.Tc = Tc;
        }
    }
}
