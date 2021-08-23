namespace AdApp
{
    public class TVAd: Advert
    {
        private int _rate;
        private int _numSec;
        private bool _peak;
        public TVAd(int fee, int rate, int numSec, bool peak) : base(fee)
        {
            _rate = rate;
            _numSec = numSec;
            _peak = peak;
        }
        
        public new int Cost() 
        {
            if(_peak == true) 
            {
                return base.Cost() + (_rate*_rate * _numSec);
            }
            else
            {
                return base.Cost() + (_rate * _numSec);
            }
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}