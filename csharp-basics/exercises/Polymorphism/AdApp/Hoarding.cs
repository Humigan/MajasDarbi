namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;

        public Hoarding(int fee, int numDays, int rate) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
        }

        public new int Cost() 
        {
            var sum = base.Cost() + (_numDays * _rate);
            return sum;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}