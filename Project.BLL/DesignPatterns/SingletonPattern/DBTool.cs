using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.SingletonPattern
{// singleton pattern bir design patterdir. Repository bir design pattern olarak kabul edilmemiştir. Çünkü farklı projelerde değişir. Repositories olarak yer almaz. 
    public class DBTool
    {
        public DBTool()
        {

        }
        static MyContext _dbInstance;
        public static MyContext DbInstance
        { 
            get
            {
                if (_dbInstance == null) _dbInstance = new MyContext();
                return _dbInstance; 
            }
        }
    }
}
