using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using Webinar.Models.Utils;
using System;
using System.Linq;

namespace Webinar.Models
{
    public partial class RssDbContext : DbContext
    {
        public RssDbContext() { }

        public RssDbContext(DbContextOptions<RssDbContext> options) : base(options) { }

        #region Models
        public virtual DbSet<spWebinarAccess> spDocumentMainBlocks { get; set; }
        public virtual DbSet<spUserType> spKeyPhrases { get; set; }
        public virtual DbSet<spLanguage> spLanguages { get; set; }
        public virtual DbSet<spOnlinePayment> spOnlinePayments { get; set; }
        public virtual DbSet<spUserType> spUserTypes { get; set; }
        public virtual DbSet<spWebinarAccess> spWebinarAccess { get; set; }
        public virtual DbSet<spWebinarType> spWebinarType { get; set; }

        public virtual DbSet<tbBilling> tbBillings { get; set; }
        public virtual DbSet<tbGroup> tbGroups { get; set; }
        public virtual DbSet<tbRoom> tbRooms { get; set; }

        public virtual DbSet<tbSetup> tbSetups { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
        public virtual DbSet<tbWebinar> tbWebinar { get; set; }
        public virtual DbSet<tbLastPayment> tbLastPayments { get; set; }

        public IAuditService AuditService { get; }
        #endregion

        private IDbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                SaveChanges();
                _transaction.Commit();
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=mydb;Username=postgres;Password=2010")
                          .UseSnakeCaseNamingConvention();
           
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }

        // устанавливаем фабрику логгера
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddProvider(new MyLoggerProvider());    // указываем наш провайдер логгирования
        });

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            var modified = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted);
            var UserId = 1;// AuditService.GetUserId();

            foreach (var item in modified)
            {
                if (item.Entity is BaseModel entity)
                {
                    entity.CreateUser = UserId;
                    entity.CreateDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.BuildIndexesFromAnnotations();

            base.OnModelCreating(modelBuilder);
        }
    }
}