using System;
using System.Collections.Generic;
using System.Text;

namespace AgileOgi_Chap1.BowlingGame
{
    public class Game
    {
        private int[] itsThrows = new int[21];
        private int itsCurrentThrow = 0;
        private int itsCurrentFrame = 1;
        private bool firstThrow = true;

        public int Score()
        {
            return ScoreForFrame(GetCurrentFrame() - 1);
        }

        public void Add(int pins)
        {
            itsThrows[itsCurrentThrow++] = pins;
            AdjustCurrentFrame(pins);
        }
        private void AdjustCurrentFrame(int pins)
        {
            if (firstThrow)
            {
                if (pins == 10) itsCurrentFrame++;
                else firstThrow = false;
            }
            else
            {
                firstThrow = true;
                itsCurrentFrame++;
            }
            itsCurrentFrame = Math.Min(11, itsCurrentFrame);

        }
        public int ScoreForFrame(int theFrame)
        {
            int score = 0;
            int ball = 0;
            for(int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                int firstThrow = itsThrows[ball++];
                // ストライクの場合
                if(firstThrow == 10)
                {
                    score += 10 + itsThrows[ball] + itsThrows[ball + 1];
                }
                else
                {
                    int secondThrow = itsThrows[ball++];
                    int frameScore = firstThrow + secondThrow;
                    // スペアの場合は次のフレームの第一投目の点数を加算
                    if (frameScore == 10) score += frameScore + itsThrows[ball];
                    else score += frameScore;
                }
            }
            return score;
        }
        public int GetCurrentFrame()
        {
            return itsCurrentFrame;
        }
    }
}
