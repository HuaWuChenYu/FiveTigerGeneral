using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class Bll
    {
        CommodityBll cdal = DalFactory.GetDal<CommodityBll>("Commodity");
        public void Get()
        {
            cdal.Show();
        }
    }
}
