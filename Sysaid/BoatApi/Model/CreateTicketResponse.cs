using System;

namespace BoatApi.Model
{
    public class CreateTicketResponse
    {
        public CreateTicketResponse(string ticketNumber, DateTime createdDate, string status)
        {
            TicketNumber = ticketNumber;
            CreatedDate = createdDate;
            Status = status;
        }

        public String TicketNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public String Status { get; set; }

    }
}
