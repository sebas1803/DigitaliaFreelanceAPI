namespace DigitaliaFreelanceAPI.Models {
    public class Receipt {
        public int Id { get; set; }
        public string LogoURL { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
    }
}
