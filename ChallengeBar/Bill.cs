using System.Globalization;

namespace ChallengeBar
{
    class Bill
    {
        public char gender;
        public int beer;
        public int barbecue;
        public int softDrink;

        public double Cover()
        {
            return this.Feeding() > 30.00 ? 0.0 : 4.00;
        }
        public double Feeding()
        {
            return (this.beer * 5.00) + (this.barbecue * 7.00) + (this.softDrink * 3.00);
        }
        public double Ticket()
        {
            if (Char.ToUpper(this.gender) == 'M')
                return 10.00;
            else
                return 8.00;
        }
        public double Total()
        {
            double total = this.Ticket() + this.Feeding() + this.Cover();
            return total;
        }
    }
}
