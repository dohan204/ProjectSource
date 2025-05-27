using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Entitie
{
    public class UserAccount
    {
        public int UserId { get; set; }
        public string RoleId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Note { get; set; }
        public string CreateBy {  get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
