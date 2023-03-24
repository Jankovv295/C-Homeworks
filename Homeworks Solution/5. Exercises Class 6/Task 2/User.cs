using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User (int id ,string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
        public void Messages()
        {
            string[] messages = { "Message from your friend Bob", "Message from Academy Seavus", "Missed call" };

            Console.WriteLine($"Welcome {Username} here are your messages:");
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }
        public string UserInfo()
        {
            return $"Id: {Id} Username: {Username}";
        }
    }
}
