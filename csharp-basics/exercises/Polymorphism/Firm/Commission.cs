using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Commission : Hourly
    {
        private double totalSales = 0;
        private double commissionRate = 0;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            this.commissionRate = commissionRate;
        }

        public void addSales(double totalSales) 
        {
            this.totalSales += totalSales;
        }

        public override double Pay()
        {
            var paymant = base.Pay() + (base.Pay() * commissionRate);
            totalSales = 0;
            return paymant;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result +=totalSales;
            return result;
        }
    }
}
