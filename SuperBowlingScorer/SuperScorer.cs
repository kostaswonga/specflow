using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperBowlingScorer
{
    public class SuperScorer
    {
        public int Frame { get; set; }
        public string BowlerMessage { get; set; }
        public string Score { get; set; }

        public SuperScorer()
        {
            Frame = 1;
        }

        bool IsStrike(bool isFirstBall, int pinsKnockedDown)
        {
            return isFirstBall && pinsKnockedDown == 10;
        }

        public void ScoreFirstBall(int pinsKnockedDown)
        {
            if(IsStrike(true, pinsKnockedDown))
            {
                BowlerMessage = "Good job!";
                Score = "X";
            }
        }
    }
}
