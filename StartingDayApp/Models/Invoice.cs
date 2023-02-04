using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingDayApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int SeriesNumber { get; set; }
        public string ClientCompanyName { get; set; }
        public string ClientNIP { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public int Amount { get; set; }
    }
}
