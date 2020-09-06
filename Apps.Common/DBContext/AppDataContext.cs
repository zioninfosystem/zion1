using Apps.Common.DBEntities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Apps.Common.DBContext
{
    public class AppDataContext : DbContext
    {
        public DbSet<UserType> UserTypes { get; set; }

        public DbSet<UserMaster> UserMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            //modelBuilder.Entity<PurchaseOrder>()
            //    .HasMany(e => e.ItemMaster)
            //    .WithOptional(e => e.ItemGroup)
            //    .HasForeignKey(e => e.ItemGroupID);

            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.Instructors).WithMany(i => i.Courses)
            //    .Map(t => t.MapLeftKey("CourseID")
            //        .MapRightKey("InstructorID")
            //        .ToTable("CourseInstructor"));

            //modelBuilder.Entity<Department>().MapToStoredProcedures();

            //string schema = "dbo";
            //var config = new DbContextConfig();
            //config.ApplicationContextConfig(modelBuilder, schema);

            //modelBuilder.Entity<AspNetRoles>()
            //    .HasMany(e => e.AspNetUsers)
            //    .WithMany(e => e.AspNetRoles)
            //    .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            //modelBuilder.Entity<AspNetUsers>()
            //    .HasMany(e => e.AspNetUserClaims)
            //    .WithRequired(e => e.AspNetUsers)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<AspNetUsers>()
            //    .HasMany(e => e.AspNetUserLogins)
            //    .WithRequired(e => e.AspNetUsers)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<Course>()
            //    .Property(e => e.RowVersion)
            //    .IsFixedLength();

            //modelBuilder.Entity<CourseAssignment>()
            //    .Property(e => e.RowVersion)
            //    .IsFixedLength();

            //modelBuilder.Entity<Department>()
            //    .Property(e => e.Budget)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<Department>()
            //    .Property(e => e.RowVersion)
            //    .IsFixedLength();

            //modelBuilder.Entity<Enrollment>()
            //    .Property(e => e.RowVersion)
            //    .IsFixedLength();

            //modelBuilder.Entity<ItemGroup>()
            //    .Property(e => e.GroupName)
            //    .IsUnicode(false);

            ////modelBuilder.Entity<ItemGroupMaster>()
            ////    .HasMany(e => e.ItemMaster)
            ////    .WithOptional(e => e.ItemGroup)
            ////    .HasForeignKey(e => e.ItemGroupID);

            //modelBuilder.Entity<OfficeAssignment>()
            //    .Property(e => e.RowVersion)
            //    .IsFixedLength();

            //modelBuilder.Entity<Person>()
            //    .Property(e => e.RowVersion)
            //    .IsFixedLength();

            //modelBuilder.Entity<Person>()
            //    .HasMany(e => e.CourseAssignment)
            //    .WithRequired(e => e.Person)
            //    .HasForeignKey(e => e.InstructorID);

            //modelBuilder.Entity<Person>()
            //    .HasMany(e => e.Department)
            //    .WithOptional(e => e.Person)
            //    .HasForeignKey(e => e.InstructorID);

            //modelBuilder.Entity<Person>()
            //    .HasMany(e => e.Enrollment)
            //    .WithRequired(e => e.Person)
            //    .HasForeignKey(e => e.StudentID);

            //modelBuilder.Entity<Person>()
            //    .HasMany(e => e.OfficeAssignment)
            //    .WithRequired(e => e.Person)
            //    .HasForeignKey(e => e.InstructorID);

            //modelBuilder.Entity<Role>()
            //    .HasMany(e => e.Users)
            //    .WithMany(e => e.Role)
            //    .Map(m => m.ToTable("UserRole").MapLeftKey("RoleId").MapRightKey("UserId"));

            ////modelBuilder.Entity<UnitMaster>()
            ////    .HasMany(e => e.ItemMaster)
            ////    .WithOptional(e => e.Unit)
            ////    .HasForeignKey(e => e.UnitID);

            //modelBuilder.Entity<UserMaster>()
            //    .Property(e => e.UserName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<UserMaster>()
            //    .Property(e => e.PWD)
            //    .IsUnicode(false);

            //modelBuilder.Entity<UserMaster>()
            //    .Property(e => e.UserFullName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<UserMaster>()
            //    .Property(e => e.UserEmailID)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Users>()
            //    .HasMany(e => e.UserClaim)
            //    .WithRequired(e => e.Users)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<Users>()
            //    .HasMany(e => e.UserLogin)
            //    .WithRequired(e => e.Users)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<Users>()
            //    .HasMany(e => e.UserToken)
            //    .WithRequired(e => e.Users)
            //    .HasForeignKey(e => e.UserId);
        }

        //public AppDataContext()
        //{
        //    this.Database.CommandTimeout = 7200;
        //}
    }
}
