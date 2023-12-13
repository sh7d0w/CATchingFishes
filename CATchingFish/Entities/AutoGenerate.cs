using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATchingFish
{
    public class AutoGenerate
    {
        // Constructor
        public AutoGenerate()
        {
            generateRandomNumber();
        }

        public int generateRandomNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(2000, 3500);
            return num;
        }
    }
}
