using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatApi.Model
{
    public partial class TicketParam
    {
        public TicketParam()
        {
        }      
        public String UserName { get; set; }      
        public String Question { get; set; }        
        public String Devision { get; set; }       
        public String QuestionCategory { get; set; }
    }
}
