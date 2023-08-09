using MvvmDemo.Commands;
using MvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MvvmDemo.ViewModels
{
    public class AddUserViewModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public ICommand AddUserCommand { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            var addUserWindow = obj as Window;
            UserManager.AddUser(new User { Name = this.Name, Email = this.Email });
            addUserWindow.Close();
        }
    }
}
