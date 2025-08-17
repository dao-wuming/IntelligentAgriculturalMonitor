using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramDAL;
using Entity;

namespace ProgramBLL
{
    public class LoadBLL
    {
        LoadDAL dal = new LoadDAL();

        public UsersEntity UserLoad(string Username, int Password)
        {
            UsersEntity entity = dal.LoadButton(Username, Password);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                throw new ArgumentException("用户不存在!");
            }

        }

    }
}
