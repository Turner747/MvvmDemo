using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>()
        {
            new User{ Name = "John Howard", Email = "john@email.com"},
            new User{ Name = "Mike Swain", Email = "mike@email.com"},
            new User{ Name = "Steeve Harvyye", Email = "steeve@email.com"},
            new User{ Name = "Darron Lanom", Email = "darron@email.com"},
            new User{ Name = "Norm Howard", Email = "norm@email.com"},
            new User{ Name = "Lee Face", Email = "lee@email.com"},
            new User{ Name = "Jane Ostain", Email = "jane@email.com"},
            new User{ Name = "Paul Runner", Email = "paul@email.com"},
            new User{ Name = "Will Billson", Email = "will@email.com"}
        };

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }
    }
}
