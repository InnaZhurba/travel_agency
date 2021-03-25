using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Users.UserEntities
{
    public class User
    {
        //[ForeignKey("UserInfo")]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserInfoId { get; set; }

        //[ForeignKey("UserInfoId")]
        //[Required] 
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
