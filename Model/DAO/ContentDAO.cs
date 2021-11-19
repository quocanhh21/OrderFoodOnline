using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ContentDAO
    {
        OnlineFoodDbContext db = null;
        //public static string USER_SESSION = "USER_SESSION";
        public ContentDAO()
        {
            db = new OnlineFoodDbContext();
        }
        public Content GetByID(long id)
        {
            return db.Contents.Find(id);
        }
       
    }
}
