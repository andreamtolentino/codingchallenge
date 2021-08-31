namespace Challenge.Dtos
{
    public class AccountReadDto
    {
        public string User { get; set; }

        public int AccountBalance { get; set; }

        public string DateOfPayment { get; set; }

        public int AmountOfPayment { get; set; }

        public string Status { get; set; }
    }
}