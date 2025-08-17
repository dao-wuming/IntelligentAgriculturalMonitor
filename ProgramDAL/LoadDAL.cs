using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDAL
{
    public class LoadDAL
    {
        public UsersEntity LoadButton(string Username,int Password)
        {
            // 使用参数化SQL查询防止SQL注入
            string sql = string.Format(@"select * from Users where Username= @Username AND Password = @Password");

            // 构建参数列表
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                // 参数赋值
                new SqlParameter("@Username",Username),
                new SqlParameter("Password",Password)
            };

            UsersEntity entity = null;

            using (SqlDataReader dr = DbHelper.GetReader(sql, parameters))
            {
                // 检查是否有查询结果
                if (dr != null && dr.Read())
                {
                    entity = new UsersEntity
                    {
                        // 读取数据
                        Id = dr.GetInt32(dr.GetOrdinal("Id")),
                        Username = dr.GetString(dr.GetOrdinal("Username")),
                        Password = dr.GetInt32(dr.GetOrdinal("Password")),
                        Role = dr.GetString(dr.GetOrdinal("Role"))
                    };
                }
            }

            return entity;
        }
    }
}
