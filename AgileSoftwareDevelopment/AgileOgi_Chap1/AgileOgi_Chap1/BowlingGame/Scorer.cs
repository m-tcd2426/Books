using System;
using System.Collections.Generic;
using System.Text;

namespace AgileOgi_Chap1.BowlingGame
{
    public class Scorer
    {
        private int ball;
        private int[] itsThrows = new int[21];
        private int itsCurrentThrow = 0;

        public void AddThrow(int pins)
        {
            itsThrows[itsCurrentThrow++] = pins;
        }
        public int ScoreForFrame(int theFrame)
        {
            ball = 0;
            int score = 0;
            for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                if (Strike())
                {
                    score += 10 + NextTwoBallsForStrike();
                    ball++;
                }
                else if (Spare())
                {
                    score += 10 + NextBallForSpare();
                    ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame();
                    ball += 2;
                }
            }
            return score;
        }
        private bool Strike()
        {
            return itsThrows[ball] == 10;
        }
        private int NextTwoBallsForStrike()
        {
            return itsThrows[ball + 1] + itsThrows[ball + 2];
        }
        private int TwoBallsInFrame()
        {
            return itsThrows[ball] + itsThrows[ball + 1];
        }
        private bool Spare()
        {
            return (itsThrows[ball] + itsThrows[ball + 1]) == 10;
        }
        private int NextBallForSpare()
        {
            return itsThrows[ball + 2];
        }
    }
}
