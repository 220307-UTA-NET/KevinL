namespace BankAccounts
{
    public class Transaction
    {
        //Fields
        [XmlAttribute]
        
        public double Amount {get; set;}

        public DateTime Date {get; set;}

        public string? Note {get; set;}

        public Transaction() {}
        public Transaction(double amount, DateTime Date, string Note = "")
        {
            this.Amount = Amount;
            this.Date = Date;
            this.Note = Note;
        }
    }
}