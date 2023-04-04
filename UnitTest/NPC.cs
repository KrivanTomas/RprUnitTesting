using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class NPC : HerniPostava
    {
        public enum Work { 
            Obchodnik,
            Nepritel,
            Obyvatel
        };



        public Work Prace { get; set; }
        public int Sila { get; set; }
        public bool Boss { get; set; }

        public NPC (string jmeno, Work prace) : base (jmeno)
        {
            this.Prace = prace;
            this.Sila = 0;
            this.Boss = false;
        }

        public NPC(string jmeno, Work prace, int sila, bool boss) : base(jmeno)
        {
            this.Prace = prace;
            this.Sila = sila;
            this.Boss = boss;
        }

        public override void ZmenaPozice(double x, double y)
        {
            this.X = y;
            this.Y = x;
        }

        public override string ToString()
        {
            return base.ToString() +
                String.Format(
                    "Prace: {0}\n" +
                    "Sila: {1}\n" +
                    "Boss: {2}",
                    Prace.ToString(), Sila, Boss ? "ANO" : "NE");
        }
    }
}
