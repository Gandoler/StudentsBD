using BDAPP.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.appui.Login.Model
{
    public class User
    {
        private static User instance = new();
        public int UserId { get; set; }
        public string Username { get; set; } = String.Empty;
        public string Role { get; set; } = String.Empty;


        private User()
        {

        }

        public static User Instance { get => instance; }
    }
}
