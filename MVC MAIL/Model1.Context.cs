
namespace mail
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ASSESMENTEntities3 : DbContext
    {
        public ASSESMENTEntities3()
            : base("name=ASSESMENTEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MAIL> MAILs { get; set; }
        public virtual DbSet<MailDetail> MailDetails { get; set; }
    }
}
