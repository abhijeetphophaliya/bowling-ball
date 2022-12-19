namespace BowlingBall
{
    public class Spare : BowlingFrame
    {
        public Spare(int firstRoll, int secondRoll) : base(firstRoll, secondRoll) { }

        public override void AddBonus(BowlingFrame framePlusOne, BowlingFrame framePlusTwo)
        {
            _frameScore += framePlusOne.FirstRoll();
        }
    }
}
