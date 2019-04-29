using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC_TrainTicket
{
    public class Login
    {
        public Login()
        {
            using (var context = new TicketContext())
            {
                Console.Write("Введите логин: ");
                var login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();



                foreach (var user in context.Users)
                {
                    if (login == user.Login && password == user.Password)
                    {

                        //    Console.WriteLine(user.Id + "   " + user.Login+"   " + user.Password + "   "+user.Orders.Id);

                        // Не выводит инофрамцию
                        Console.WriteLine(user.Orders.Ticket.Way + user.Orders.Ticket.Price + user.Orders.Ticket.Time);
                    }
                }

                /* 2 способ   */
                //foreach (var user in context.Users)
                //{
                //    if (login == user.Login && password == user.Password)
                //    {
                //        foreach (var order in context.Orders)
                //        {
                //            if (order == user.Orders)
                //            {
                //                foreach (var ticket in )
                //                {
                //                    Console.WriteLine(ticket.Way); 
                //                }
                //            }
                //        }
                //    }

                //}

                /* 3 способ   */
                //var results = context.Users.ToList().Where(x => x.Login == login);
                //foreach (var user in results)
                //{

                //    var res2 = context.Tickets.ToList().Where(y => y.Orders == user.Orders);

                //   foreach(var ticket in res2)
                //    {
                //        Console.WriteLine(ticket.Way); 
                //    }
                //}


                /* 4 способ   */
                //var results = context.Users.ToList().Where(x => x.Login == login);
                //foreach (var user in results)
                //{

                //    var res2 = context.Orders.ToList().Where(y => y.Id == user.Orders.Id);

                //    foreach (var order in res2)
                //    {
                //        var res3 = context.Tickets.ToList().Where(z => z.Orders == user.Orders);
                //        foreach (var ticket in res3)
                //        {
                //            Console.WriteLine(ticket.Way + ticket.Time + ticket.Price);
                //        }
                //    }
                //}



                Console.Read();
            }
        }
    }
}
