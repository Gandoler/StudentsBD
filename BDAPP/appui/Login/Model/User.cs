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
        public int UserId { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
    }
}
