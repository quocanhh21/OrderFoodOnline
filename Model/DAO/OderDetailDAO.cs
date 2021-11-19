using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class OderDetailDAO
    {
        OnlineFoodDbContext db = null;
        public OderDetailDAO()
        {
            db = new OnlineFoodDbContext();
        }
        public bool Insert(OrderDetail detail)
        {
            try
            {
                db.OrderDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch 
            {

                return false;
            }
        }
    }
}
