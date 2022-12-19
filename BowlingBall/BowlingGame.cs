using System;
using System.Collections.Generic;

namespace BowlingBall
{
    public class BowlingGame
    {
        private readonly List<BowlingFrame> _frames = new List<BowlingFrame>();
        int numberOfFrame = 10;
        public int GetScore()
        {
            Add(new OpenFrame(0, 0));
            Add(new OpenFrame(0, 0));

            for (int i = 0; i < numberOfFrame; i++)
            {
                _frames[i].AddBonus(_frames[i + 1], _frames[i + 2]);
            }

            int _totalScore = 0;
            _frames.ForEach(frame => _totalScore += frame.Score());
            return _totalScore;
        }

        public void Roll(int firstRoll, int secondRoll)
        {
            if (GameFinished())
                throw new Exception("Game finished");

            Add(BowlingFrame.Create(firstRoll, secondRoll));
        }

        public void RollStrike()
        {
            Roll(10, 0);
        }

        private bool GameFinished()
        {
            return _frames.Count.Equals(numberOfFrame);
        }

        private void Add(BowlingFrame frame)
        {
            _frames.Add(frame);
        }

        public void RollFinalFrame(int firstRoll, int secondRoll, int thirdRoll)
        {
            Add(BowlingFrame.Create(firstRoll, secondRoll, thirdRoll));
        }
    }
}
