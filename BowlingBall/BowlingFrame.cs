namespace BowlingBall
{
    public abstract class BowlingFrame
    {
        protected int _pinsFirstRoll;
        protected int _pinsSecondRoll;
        protected int _frameScore;

        protected BowlingFrame(int pinsFirstRoll, int pinsSecondRoll)
        {
            _pinsFirstRoll = pinsFirstRoll;
            _pinsSecondRoll = pinsSecondRoll;
        }

        public int Score() { return _pinsFirstRoll + _pinsSecondRoll + _frameScore; }

        public int FirstRoll() { return _pinsFirstRoll; }

        public int SecondRoll() { return _pinsSecondRoll; }

        public static BowlingFrame Create(int firstRoll, int secondRoll)
        {
            if (firstRoll == 10)
                return new Strike();

            if ((firstRoll + secondRoll) == 10)
                return new Spare(firstRoll, secondRoll);

            return new OpenFrame(firstRoll, secondRoll);
        }

        public static BowlingFrame Create(int firstRoll, int secondRoll, int thirdRoll)
        {
            return new FinalFrame(firstRoll, secondRoll, thirdRoll);
        }

        public virtual void AddBonus(BowlingFrame framePlusOne, BowlingFrame framePlusTwo) { }

    }
}
