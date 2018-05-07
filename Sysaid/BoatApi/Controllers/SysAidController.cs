using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoatApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace BoatApi.Controllers
{
    [Route("api/[controller]")]
    public class SysAidController : Controller
    {
        // GET api/values
        [HttpPost("[action]")]
        
        public CreateTicketResponse CreateTicket([FromBody]TicketParam param)
        {
            return new CreateTicketResponse("SYSAID000232", DateTime.Now, "Not Assign");
        }

        [HttpGet("[action]")]
        public IEnumerable<string> GetMyTicketNumbers(string userName)
        {
            return new string[] { "SYSAID000232", "SYSAID000763" };
        }

        [HttpGet("[action]")]
        public IEnumerable<CreateTicketResponse> GetAllTickets()
        {
            List<CreateTicketResponse> list = new List<CreateTicketResponse>();
            list.Add(new CreateTicketResponse("SYSAID000232", DateTime.Now, "Not Assign"));
            list.Add(new CreateTicketResponse("SYSAID000232", DateTime.Now, "Re Assign"));
            list.Add(new CreateTicketResponse("SYSAID000533", DateTime.Now, "Assign"));
            list.Add(new CreateTicketResponse("SYSAID000633", DateTime.Now, "Assign"));

            return list;
        }


    }
}
