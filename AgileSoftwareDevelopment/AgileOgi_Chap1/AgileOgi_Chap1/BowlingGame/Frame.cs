using System;
using System.Collections.Generic;
using System.Text;

namespace AgileOgi_Chap1.BowlingGame
{
    public class Frame
    {
        private int itsScore = 0;
        public int GetScore()
        {
            return itsScore;
        }
        public void Add(int pins)
        {
            itsScore += pins;
        }
    }
}
