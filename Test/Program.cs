using BankruptModel;
using BankruptServiceImplementDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BunkruptDbContext db = new BunkruptDbContext())
            {
                // создаем два объекта User
                //User user1 = new User { Name = "Tom", Age = 33 };
                //User user2 = new User { Name = "Sam", Age = 26 };

                //// добавляем их в бд
                //db.Users.Add(user1);
                //db.Users.Add(user2);
                db.Providers.Add(new Provider
                {
                    Id = 0,
                    Email = "hui@mail.ru",
                    PasswordHash = "blabla",
                    ProviderFIO = "ivan"
                });

                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                /*var users = db.Users;
                Console.WriteLine("Список объектов:");

                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }*/
            }
        }
    }
}
