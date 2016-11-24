using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManageSystem.Model
{
    class Goods
    {
        private string mstrGoodsNumber;
        public string GoodsNumber
        {
            get { return mstrGoodsNumber; }
            set { mstrGoodsNumber = value; }
        }

        private string mstrCategory;
        public string Category
        {
            get { return mstrCategory; }
            set { mstrCategory = value; }
        }

        private string mstrName;
        public string Name 
        {
            get { return mstrName; }
            set { mstrName = value; }
        }

        private string mstrBarCode;
        public string BarCode
        {
            get { return mstrBarCode; }
            set { mstrBarCode = value; }
        }

        private string mstrUnit;
        public string Unit
        {
            get { return mstrUnit; }
            set { mstrUnit = value; }
        }

        private string mstrSpecification;
        public string Specification
        {
            get { return mstrSpecification; }
            set { mstrSpecification = value; }
        }

        private string mstrProductionPlace;
        public string ProductionPlace
        {
            get { return mstrProductionPlace; }
            set { mstrProductionPlace = value; }
        }

        private string mstrVersion;
        public string Version
        {
            get { return mstrVersion; }
            set { mstrVersion = Version; }
        }

        private string mstrRemark;
        public string Remark
        {
            get { return mstrRemark; }
            set { mstrRemark = value; }
        }
    }
}
