using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Hrac : HerniPostava
    {
        public enum Oblicej
        {
            VelkyNos,
            Usoplesk,
            MakeUp
        };

        public enum Vlasy 
        { 
            Drdol,
            Culik,
            Pleska
        };

        public enum BarvaVlasu
        {
            Kastanova,
            Blond,
            Cervena
        };

        private string[] klasy = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };

        private string specializace;
        public string Specializace { 
            get
            {
                return specializace;
            }
            set
            {
                if (!klasy.Contains(value))
                {
                    throw new Exception("Špatné zadání klasy!");
                }
                specializace = value;
            }
        }

        private Oblicej oblicej = 0;
        private Vlasy vlasy = 0;
        private BarvaVlasu barvaVlasu = 0;
        public int XP = 0;

        public Hrac(string jmeno, string specializace, Oblicej oblicej, Vlasy vlasy, BarvaVlasu barvaVlasu) : base(jmeno)
        {
            this.Specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
        }

        public void PridejXP(int pocetXP)
        {
            XP += pocetXP;
            while (XP >= base.level * 100)
            {
                XP -= base.level * 100;
                base.level++;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                String.Format(
                "XP: {0}\n" +
                "Specializace: {1}\n" +
                "Obličej: {2}\n" +
                "Vlasy: {3}\n" +
                "Barva vlasů: {4}\n",
                XP, Specializace, oblicej.ToString(), vlasy.ToString(), barvaVlasu.ToString());
        }
    }
}
