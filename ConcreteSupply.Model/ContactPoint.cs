namespace ConcreteSupply.Model
{
    public class ContactPoint: BaseResource
    {
        public int Id { get; set; }
        public string ContactPointLabel { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
    }
}
