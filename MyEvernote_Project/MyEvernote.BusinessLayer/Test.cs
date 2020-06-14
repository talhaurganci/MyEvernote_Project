using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.BusinessLayer
{
    public class Test
    {
        public Test()
        {
            DataAccessLayer.EntityFramework.DatabaseContext db = new DataAccessLayer.EntityFramework.DatabaseContext();
            db.Categories.ToList();
        }
           
        
    }
}
