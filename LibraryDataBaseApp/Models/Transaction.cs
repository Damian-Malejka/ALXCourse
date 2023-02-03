using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataBaseApp.Models
{
    public class Transaction
    {
        public int IdTransaction { get; set; }
        public int IdBook { get; set; }
        public int IdClient { get; set; }
    }
}
