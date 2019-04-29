using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC_TrainTicket
{
    public class Tickets
    {
        public int Id { get; set; }

        public string Way { get; set; }

        public string Time { get; set; }

        public int CountPlaces { get; set; }

        public int Price { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
