namespace BowlingBall
{
    public class FinalFrame : BowlingFrame
    {
        private readonly int _pinsThirdRoll;

        public FinalFrame(int pinsFirstRoll, int pinsSecondRoll, int pinsThirdRoll) : base(pinsFirstRoll, pinsSecondRoll)
        {
            _pinsThirdRoll = pinsThirdRoll;
        }

        public override void AddBonus(BowlingFrame framePlusOne, BowlingFrame framePlusTwo)
        {
            _frameScore += _pinsThirdRoll;
        }

    }
}
