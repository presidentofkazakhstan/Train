using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC_TrainTicket
{

    public class Users
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
