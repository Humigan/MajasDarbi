using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _avaible;
        private List<double> _rating;
        public Video(string title)
        {
            _title = title;
            _avaible = true;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _avaible = false;
        }

        public void BeingReturned()
        {
            _avaible = true;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            var sum = 0.0;
            foreach (var item in _rating)
            {
                sum += item;
            }
            return sum;
        }

        public bool Available()
        {
            return _avaible;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
