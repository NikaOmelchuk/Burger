using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerLib
{
    public interface Burger
    {
        string Name();
        int GetCode();
    }

    public class CheesBurger : Burger
    {
        public string Name()
        {
            return "Чізбургер";
        }
        public int GetCode()
        {
            return 1;
        }
    }

    public class ChickenBurger : Burger
    {
        public string Name()
        {
            return "Чікенбургер";
        }
        public int GetCode()
        {
            return 2;
        }
    }
    public class BigMac : Burger
    {
        public string Name()
        {
            return "Бігмак";
        }
        public int GetCode()
        {
            return 3;
        }
    }
}
