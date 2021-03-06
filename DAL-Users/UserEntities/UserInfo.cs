using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Users.UserEntities
{
    public class UserInfo
    {
        //[ForeignKey("User")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //[ForeignKey("Id")]
        //[Required]
        public virtual User User { get; set; }
    }
}
