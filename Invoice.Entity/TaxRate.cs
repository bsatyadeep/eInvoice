namespace Invoice.Entity
{
    public class TaxRate
    {
        public int FRT { get; set; }
        public int ST { get; set; }
        public int EC { get; set; }
        public TaxRate()
        {
            this.FRT = 5;
            this.ST = 10;
            this.EC = 3;
        }
    }
}
