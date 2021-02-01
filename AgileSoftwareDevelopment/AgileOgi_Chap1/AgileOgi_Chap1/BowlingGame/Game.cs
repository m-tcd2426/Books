using System;
using System.Collections.Generic;
using System.Text;

namespace AgileOgi_Chap1.BowlingGame
{
    public class Game
    {
        private int itsCurrentFrame = 1;
        private bool firstThrowInFrame = true;
        private Scorer itsScorer = new Scorer();

        public int Score()
        {
            return ScoreForFrame(itsCurrentFrame);
        }

        public void Add(int pins)
        {
            itsScorer.AddThrow(pins);
            AdjustCurrentFrame(pins);
        }
        private void AdjustCurrentFrame(int pins)
        {
            if (LastBallInFrame(pins)) AdvanceFrame();
            else firstThrowInFrame = false;
        }
        private bool LastBallInFrame(int pins)
        {
            return Strike(pins) || !(firstThrowInFrame);
        }
        private bool Strike(int pins)
        {
            return (firstThrowInFrame && pins == 10);
        }
        private void AdvanceFrame()
        {
            itsCurrentFrame = Math.Min(10, itsCurrentFrame + 1);
        }
        private int ScoreForFrame(int theFrame)
        {
            return itsScorer.ScoreForFrame(theFrame);
        }
    }
}
