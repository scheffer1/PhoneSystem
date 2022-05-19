using PhoneSystem___LOLDESIGN.Controllers;

namespace PhoneSystem___LOLDESIGN.Models
{
    public class Relation
    {
        public Relation() { }
        public Relation(int id, int from, int to, double pricePerMin)
        {
            this.id = id;
            this.from = from;
            this.to = to;
            this.PricePerMin = pricePerMin;
        }
        
        public int id { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public double PricePerMin { get; set; }
    }
}

    