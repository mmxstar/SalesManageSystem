using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManageSystem.Model
{
    class Warehouse
    {
        private string mstrName;
        public string Name
        {
            get { return mstrName; }
            set { mstrName = value; }
        }

        private string mstrRemark;
        public string Remark
        {
            get { return mstrRemark; }
            set { mstrRemark = value; }
        }

        private string mstrCode;
        public string Code {
            get { return mstrCode; }
            set { mstrCode = value; }
        }
    }
}
