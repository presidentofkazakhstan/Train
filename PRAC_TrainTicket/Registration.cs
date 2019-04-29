using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC_TrainTicket
{
    public class Registration
    {
        public Registration()
        {
            using (var context = new TicketContext())
            {
                Console.Write("Введите логин: ");
                var login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();

                foreach (var ticket in context.Tickets)
                {
                    Console.WriteLine($"Номер - {ticket.Id} \nПуть: {ticket.Way} \nВремя в пути: {ticket.Time} \nЦена: {ticket.Price}");
                    Console.WriteLine("-----------------------------------------");
                }
                Console.WriteLine("Выберите номер билета(1-6): ");
                int selectNumber = int.Parse(Console.ReadLine());


                var results = context.Tickets.ToList().Where(x => x.Id == selectNumber);
                foreach (var tickets in results)
                {
                    var order = new Orders
                    {
                        Ticket = tickets
                    };

                    var user = new Users
                    {
                        Login = login,
                        Password = password,
                        Orders = order

                    };

                    context.Orders.Add(order);
                    context.Users.Add(user);

                    context.SaveChanges();
                }

            }

        }
    }
}
