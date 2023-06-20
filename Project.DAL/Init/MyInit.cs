using Project.COMMON.Tools;
using Project.DAL.Context;
using Project.ENTITIES.Models;
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
     // todo gerekirse ürün(stand) içinde tekrardan seed e ekleme yap.
        protected override void Seed(MyContext context)
        {
            base.Seed(context);
            #region RoleForSuperAdmin
            EmployeeRole eRole= new EmployeeRole();
            eRole.TitleName = "SuperAdmin";
            eRole.Department = "Board";
            eRole.Description = "Tüm işlemleri yapma yetkisine sahiptir.";
            context.EmployeeRoles.Add(eRole);
            context.SaveChanges();
            #endregion

            #region RoleForBoard
            EmployeeRole eRole1 = new EmployeeRole();
            eRole1.TitleName = "MemberOfBoard";
            eRole1.Department = "Board";
            eRole1.Description = "Tüm işlemleri kontrol etme yetkisine sahiptir.";
            context.EmployeeRoles.Add(eRole1);
            context.SaveChanges();
            #endregion

            #region RoleForSalesManager
            EmployeeRole eRole2 = new EmployeeRole();
            eRole2.TitleName = "Sales Manager";
            eRole2.Department = "Sale Department";
            eRole2.Description = "Yetkisi altında bulunan personellerin müşterilerini görebilir, işlem yapabilir onlarla ilgili";
            context.EmployeeRoles.Add(eRole2);
            context.SaveChanges();
            #endregion

            #region RoleForSalesEmployee
            EmployeeRole eRole3 = new EmployeeRole();
            eRole3.TitleName = "Sales Employee";
            eRole3.Department = "Sale Department";
            eRole3.Description = "Müşterilerini görebilir, işlem yapabilir onlarla ilgili";
            context.EmployeeRoles.Add(eRole3);
            context.SaveChanges();
            #endregion

            #region RoleForIT
            EmployeeRole eRole4 = new EmployeeRole();
            eRole4.TitleName = "IT";
            eRole4.Department = "Data Processing Department";
            eRole4.Description = "Gerekli olan tüm güncelleme, ekleme ve silme işlemlerini yapabilir.";
            context.EmployeeRoles.Add(eRole4);
            context.SaveChanges();
            #endregion

            #region RoleForBookKeeping
            EmployeeRole eRole5 = new EmployeeRole();
            eRole5.TitleName = "BookKeeper";
            eRole5.Department = "BookKeeping";
            eRole5.Description = "Finansal işlemleri yapar.";
            context.EmployeeRoles.Add(eRole5);
            context.SaveChanges();
            #endregion

            #region RoleForOperationManager
            EmployeeRole eRole6 = new EmployeeRole();
            eRole6.TitleName = "Operation Manager";
            eRole6.Department = "Operation Department";
            eRole6.Description = "Fuarla ilgili tüm aktif saha çalışmasını yönetir";
            context.EmployeeRoles.Add(eRole6);
            context.SaveChanges();
            #endregion

            #region RoleForExtraEmployee
            EmployeeRole eRole7 = new EmployeeRole();
            eRole7.TitleName = "Extra Employee";
            eRole7.Department = "Sale Department";
            eRole7.Description = "Gelen ziyaretçilerin kayıtları alınır ve bilgileri güncellenir.";
            context.EmployeeRoles.Add(eRole7);
            context.SaveChanges();
            #endregion

            // yukarıda eklemiş olduğum rollere birer tane personel atmasını daha seedteyken yaptım. Sistemin test edilebilirliğinde daha rahat hareket edebilmek için
            #region SuperAdmin
            Employee e = new Employee();
            e.FirstName = "Veli";
            e.LastName = "Toraman";
            e.UserName = "VToraman";
            e.Password = DantexCrypt.Crypt("1234");
            e.EmployeeRole= eRole;
            context.Employees.Add(e);
            context.SaveChanges();
            #endregion

            #region MemberOfBoard
            Employee e1 = new Employee();
            e1.FirstName = "Özgür";
            e1.LastName = "Belül";
            e1.UserName = "OBelul";
            e1.Password = DantexCrypt.Crypt("1234");
            e1.EmployeeRole = eRole1;
            context.Employees.Add(e1);
            context.SaveChanges();
            #endregion

            #region SalesManager
            Employee e2 = new Employee();
            e2.FirstName = "Fenasi";
            e2.LastName = "Parlak";
            e2.UserName = "FParlak";
            e2.Password = DantexCrypt.Crypt("1234");
            e2.EmployeeRole = eRole2;
            context.Employees.Add(e2);
            context.SaveChanges();
            #endregion

            #region SalesEmployee
            Employee e3 = new Employee();
            e3.FirstName = "Can";
            e3.LastName = "Toparlak";
            e3.UserName = "CToparlak";
            e3.Password = DantexCrypt.Crypt("1234");
            e3.EmployeeRole = eRole3;
            context.Employees.Add(e3);
            context.SaveChanges();
            #endregion

            #region IT
            Employee e4 = new Employee();
            e4.FirstName = "Celil";
            e4.LastName = "Deliçip";
            e4.UserName = "CDelicip";
            e4.Password = DantexCrypt.Crypt("1234");
            e4.EmployeeRole = eRole4;
            context.Employees.Add(e4);
            context.SaveChanges();
            #endregion

            #region BookKeeper
            Employee e5 = new Employee();
            e5.FirstName = "Hüsmen";
            e5.LastName = "Nakit";
            e5.UserName = "HNakit";
            e5.Password = DantexCrypt.Crypt("1234");
            e5.EmployeeRole = eRole5;
            context.Employees.Add(e5);
            context.SaveChanges();
            #endregion

            #region OperationManager
            Employee e6 = new Employee();
            e6.FirstName = "Toraman";
            e6.LastName = "AtılKurt";
            e6.UserName = "TAtilkurt";
            e6.Password = DantexCrypt.Crypt("1234");
            e6.EmployeeRole = eRole6;
            context.Employees.Add(e6);
            context.SaveChanges();
            #endregion

            #region ExtraEmployee
            Employee e7 = new Employee();
            e7.FirstName = "Mücahit";
            e7.LastName = "Temizpak";
            e7.UserName = "MTemizpak";
            e7.Password = DantexCrypt.Crypt("1234");
            e7.EmployeeRole = eRole7;
            context.Employees.Add(e7);
            context.SaveChanges();
            #endregion

            #region CompanyType
            CompanyType cType= new CompanyType();
            cType.CompanyTypeName = "üretici";
            
            CompanyType cType2 = new CompanyType();
            cType2.CompanyTypeName = "ithalatçı";
            #endregion

            #region Company
            Company c= new Company();
            c.CompanyName = "alıngan a.s";
            c.Address = "kordon boyu cad.";
            c.City = "izmir";
            c.PhoneNumber = "1234566777";
            c.UserName = "alingan";
            c.Password = DantexCrypt.Crypt("1234");
            #endregion

            #region CompanyAndCompanyType
            CompanyAndCompanyType cCType = new CompanyAndCompanyType();
            cCType.CompanyTypeID = 1;
            cCType.CompanyID = 1;

            CompanyAndCompanyType eType = new CompanyAndCompanyType();
            eType.CompanyTypeID = 2;
            eType.CompanyID = 1;
            #endregion

        }
    }
}
