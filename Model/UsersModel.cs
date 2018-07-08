using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsersModel
    {
        [System.ComponentModel.DisplayName("User ID")]
        public int UserId { get; set; }
        [System.ComponentModel.DisplayName("User Name")]
        public string Username { get; set; }
        [System.ComponentModel.DisplayName("User Type")]
        public string Usertype  { get; set; }
        [System.ComponentModel.DisplayName("Password")]
        public string Password { get; set; }
        [System.ComponentModel.DisplayName("Date")]
        public DateTime Date { get; set; }

    }
}
