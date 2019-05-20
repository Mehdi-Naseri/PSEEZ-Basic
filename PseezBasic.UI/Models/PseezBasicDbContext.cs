using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseezBasic.UI.Models
{
    public class PseezBasicDbContext : DbContext
    {
        public PseezBasicDbContext() : base("name=PseezBasicConnection")
        {
            
        }

        public virtual DbSet<BloodType> BloodTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<DegreeState> DegreeStates { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAcademicalResume> EmployeeAcademicalResumes { get; set; }
        public virtual DbSet<EmployeeFamilialType> EmployeeFamilialTypes { get; set; }
        public virtual DbSet<EmployeeOrganChart> EmployeeOrganCharts { get; set; }
        public virtual DbSet<FamilialType> FamilialTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<OrganChart> OrganCharts { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<TimeTable> TimeTables { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<ReservationPersonList> ReservationPersonLists { get; set; }

        public virtual DbSet<EmploymentType> EmploymentTypes { get; set; }
        public virtual DbSet<EmploymentState> EmploymentStates { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DegreeType> DegreeTypes { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<DurationType> DurationTypes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}
