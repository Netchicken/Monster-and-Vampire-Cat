using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffUNeedToKnow
{
    // we need to create a class 
  public  class GameCode
    {
      public  int count =0;

        public int RNDGenerator()
        {
            Random rndNumber = new Random();
            int rnd = rndNumber.Next(1, 7);
            return rnd;
        }



    }
}
