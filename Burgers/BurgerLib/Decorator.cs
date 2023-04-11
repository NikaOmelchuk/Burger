using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerLib
{
    public abstract class Decorator : Burger
    {
        protected Burger B;
        public int codD;

        public void SetBurger(Burger B)
        {
            this.B = B;
        }

        public abstract int GetCode();
        public abstract string Name();
    }

    public class Box : Decorator
    {
        public override int GetCode()
        {
            if (B != null)
            {
                codD = 1;
                return B.GetCode();
            }
            else
                return 0;
        }
        public override string Name()
        {
            if (B != null)
                return B.Name() + " в коробці";
            else
                return "";
        }
    }

    public class Package : Decorator
    {
        public override int GetCode()
        {
            if (B != null)
            {
                codD = 2;
                return B.GetCode();
            }
            else
                return 0;
        }
        public override string Name()
        {
            if (B != null)
                return B.Name() + " в упаковці";
            else
                return "";
        }
    }
}
