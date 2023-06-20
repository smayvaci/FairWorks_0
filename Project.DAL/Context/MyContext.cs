using Project.DAL.Init;
using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApproachDocumentMap());
            modelBuilder.Configurations.Add(new BiddingDocumentMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompanyAndCompanyTypeMap());
            modelBuilder.Configurations.Add(new CompanyTypeMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new ContractDocumentMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeRoleMap());
            modelBuilder.Configurations.Add(new FairMap());
            modelBuilder.Configurations.Add(new FairAndGuestMap());
            modelBuilder.Configurations.Add(new FairAndHallMap());
            modelBuilder.Configurations.Add(new GuestMap());
            modelBuilder.Configurations.Add(new HallMap());
            modelBuilder.Configurations.Add(new InvitedGuestMap());
            modelBuilder.Configurations.Add(new InvitedGuestAndCompanyMap());
            modelBuilder.Configurations.Add(new SaleMap());
            modelBuilder.Configurations.Add(new SectorMap());
            modelBuilder.Configurations.Add(new SectorAndCompanyMap());
            modelBuilder.Configurations.Add(new StandAreaMap());
            modelBuilder.Configurations.Add(new FairAndApproachDocumentMap());
            modelBuilder.Configurations.Add(new JobMap());
        }
        public DbSet<ApproachDocument> ApproachDocuments { get; set;}
        public DbSet<FairAndApproachDocument> FairAndApproachDocuments { get; set;}
        public DbSet<BiddingDocument> BiddingDocuments { get; set;}
        public DbSet<Company> Companies { get; set;}
        public DbSet<CompanyAndCompanyType> CompanyAndCompanyTypes{ get; set;}
        public DbSet<CompanyType> CompanyTypes { get; set;}
        public DbSet<ContractDocument> ContractDocuments { get; set;}
        public DbSet<Country> Countries { get; set;}
        public DbSet<Employee> Employees { get; set;}
        public DbSet<EmployeeRole> EmployeeRoles { get; set;}
        public DbSet<Fair> Fairs { get; set;}
        public DbSet<FairAndGuest> FairAndGuests { get; set;}
        public DbSet<FairAndHall> FairAndHalls { get; set;}
        public DbSet<Guest> Guests { get; set;}
        public DbSet<Hall> Halls { get; set;}
        public DbSet<InvitedGuest> InvitedGuests { get; set; }
        public DbSet<InvitedGuestAndCompany> InvitedGuestAndCompanies { get; set;}
        public DbSet<Sale>Sales { get; set;}
        public DbSet<Sector>Sectors { get; set;}
        public DbSet<SectorAndCompany>SectorAndCompanies { get; set;}
        public DbSet<StandArea> StandAreas { get; set;}
        public DbSet<Job> Jobs { get; set;}
       

    }
}
