namespace BowlingBall
{
    public class Strike : BowlingFrame
    {
        public Strike() : base(10, 0) { }

        public override void AddBonus(BowlingFrame framePlusOne, BowlingFrame framePlusTwo)
        {
            if (framePlusOne is Strike)
                _frameScore += 10 + framePlusTwo.FirstRoll();
            else
                _frameScore += framePlusOne.FirstRoll() + framePlusOne.SecondRoll();
        }
    }
}
