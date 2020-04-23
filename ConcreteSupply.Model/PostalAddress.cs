namespace ConcreteSupply.Model
{
    public class PostalAddress: BaseResource
    {
        public int Id { get; set; }
        public int ContactPointId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressLine5 { get; set; }
        public string PostCode { get; set; }
    }
}
