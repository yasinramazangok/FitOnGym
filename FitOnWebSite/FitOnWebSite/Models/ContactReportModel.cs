namespace FitOnWebSite.Models
{
    public class ContactReportModel
    {
        public int ID { get; set; }

        public string PersonName { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}
