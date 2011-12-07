using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperBowlingScorer;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Specs
{
    [Binding]
    public class ScoringSteps
    {
        private SuperScorer _scorer;

        [Given(@"I am on the first frame")]
        public void GivenIAmOnTheFirstFrame()
        {
            _scorer = new SuperScorer();    
            Assert.AreEqual(1, _scorer.Frame);
        }


        [When(@"I bowl a strike")]
        public void WhenIBowlAStrike()
        {
            _scorer.ScoreFirstBall(10);
        }

        [Then(@"I should see an ""(.*)"" and a message that says ""(.*)""")]
        public void ThenIShouldSeeAnXAndAMessageThatSaysGoodJob(string score, string message)
        {
            Assert.AreEqual(message, _scorer.BowlerMessage);
            Assert.AreEqual(score, _scorer.Score);
        }
    }
}
