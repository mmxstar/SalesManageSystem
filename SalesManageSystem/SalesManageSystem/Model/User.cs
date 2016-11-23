using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManageSystem.Model
{
    class User
    {
        private string mstrName;
        public string Name
        {
            get { return mstrName; }
            set { mstrName = value; }
        }

        private string mstrSex;
        public string Sex
        {
            get { return mstrSex; }
            set { mstrSex = value; }
        }

        private string mstrUserName;
        public string UserName
        {
            get { return mstrUserName; }
            set { mstrUserName = value; }
        }

        private string mstrPassword;
        public string Password
        {
            get { return mstrPassword; }
            set { mstrPassword = value; }   
        }
    }
}
