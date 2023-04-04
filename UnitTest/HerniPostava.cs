using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class HerniPostava
    {
        private string jmeno;
        public string Jmeno {
            get
            {
                return this.jmeno;
            }
            set
            {
                if (value.Length > 10) throw new Exception("NameLength");
                this.jmeno = value;
            }
        }

        public double X { get; set; }
        public double Y { get; set; }

        public int level;
        public HerniPostava(string jmeno)
        {
            this.Jmeno = jmeno;
            this.level = 1;
        }

        public virtual void ZmenaPozice(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return String.Format(
                "Jmeno: {0}\n" +
                "Level: {1}\n" +
                "X: {2}, Y: {4}",
                Jmeno, level, X, Y);
        }
    }
}
