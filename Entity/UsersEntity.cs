using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 创建用户实体
    /// </summary>
    public class UsersEntity
    {
        /// <summary>
        /// 初始化构造函数
        /// </summary>
        public UsersEntity()
        {
            this.Id = 0;
            this.Username = "";
            this.Password = 0;
            this.Role = "";
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public int Password { get; set; }

        public string Role { get; set; }
    }
}
