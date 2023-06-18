using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {// todo init kısmını yarat database e eklemeden önce en azından bir süper adminin olmalı
        protected override void Seed(MyContext context)
        {
            base.Seed(context);
        }
    }
}
