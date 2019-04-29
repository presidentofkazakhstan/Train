using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC_TrainTicket
{
    public class Orders
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        

        public Tickets Ticket { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
