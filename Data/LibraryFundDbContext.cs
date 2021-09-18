using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Data.Dto;

#nullable disable

namespace Data
{
    public partial class LibraryFundDbContext : DbContext
    {
        public LibraryFundDbContext()
        {
        }

        public LibraryFundDbContext(DbContextOptions<LibraryFundDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<AuthorToFund> AuthorToFunds { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Fund> Funds { get; set; }
        public virtual DbSet<FundCategory> FundCategories { get; set; }
        public virtual DbSet<FundCopy> FundCopies { get; set; }
        public virtual DbSet<FundEntity> FundEntities { get; set; }
        public virtual DbSet<FundOther> FundOthers { get; set; }
        public virtual DbSet<FundUsage> FundUsages { get; set; }
        public virtual DbSet<FundUsageRule> FundUsageRules { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<LibraryVisit> LibraryVisits { get; set; }
        public virtual DbSet<OtherUser> OtherUsers { get; set; }
        public virtual DbSet<PeriodicalLiterature> PeriodicalLiteratures { get; set; }
        public virtual DbSet<ReadingRoom> ReadingRooms { get; set; }
        public virtual DbSet<Retiree> Retirees { get; set; }
        public virtual DbSet<Schoolchild> Schoolchildren { get; set; }
        public virtual DbSet<Scientist> Scientists { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<StorageRoom> StorageRooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCategory> UserCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=citylibraryfundapp;password=4kQ32_sSq$;database=citylibraryfund", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("birth_date");

                entity.Property(e => e.Country)
                    .HasMaxLength(64)
                    .HasColumnName("country")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DeathDate)
                    .HasColumnType("date")
                    .HasColumnName("death_date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("first_name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("last_name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .HasColumnName("middle_name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<AuthorToFund>(entity =>
            {
                entity.HasKey(e => new { e.AuthorId, e.FundId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("author_to_fund");

                entity.HasIndex(e => e.FundId, "fund_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.FundId).HasColumnName("fund_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.AuthorToFunds)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("author_to_fund_ibfk_1");

                entity.HasOne(d => d.Fund)
                    .WithMany(p => p.AuthorToFunds)
                    .HasForeignKey(d => d.FundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("author_to_fund_ibfk_2");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.FundId)
                    .HasName("PRIMARY");

                entity.ToTable("book");

                entity.Property(e => e.FundId)
                    .ValueGeneratedNever()
                    .HasColumnName("fund_id");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("isbn")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Fund)
                    .WithOne(p => p.Book)
                    .HasForeignKey<Book>(d => d.FundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("book_ibfk_1");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("employee");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("position")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employee_ibfk_1");
            });

            modelBuilder.Entity<Fund>(entity =>
            {
                entity.ToTable("fund");

                entity.HasIndex(e => e.CategoryId, "category_id");

                entity.HasIndex(e => e.EntityId, "entity_id");

                entity.HasIndex(e => e.UsageRuleId, "usage_rule_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PublishDate)
                    .HasColumnType("date")
                    .HasColumnName("publish_date");

                entity.Property(e => e.UsageRuleId).HasColumnName("usage_rule_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Funds)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_ibfk_2");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Funds)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_ibfk_1");

                entity.HasOne(d => d.UsageRule)
                    .WithMany(p => p.Funds)
                    .HasForeignKey(d => d.UsageRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_ibfk_3");
            });

            modelBuilder.Entity<FundCategory>(entity =>
            {
                entity.ToTable("fund_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<FundCopy>(entity =>
            {
                entity.HasKey(e => new { e.FundId, e.CopyId, e.LibraryId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("fund_copy");

                entity.HasIndex(e => e.LibraryId, "library_id");

                entity.Property(e => e.FundId).HasColumnName("fund_id");

                entity.Property(e => e.CopyId).HasColumnName("copy_id");

                entity.Property(e => e.LibraryId).HasColumnName("library_id");

                entity.HasOne(d => d.Fund)
                    .WithMany(p => p.FundCopies)
                    .HasForeignKey(d => d.FundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_copy_ibfk_1");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.FundCopies)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_copy_ibfk_2");
            });

            modelBuilder.Entity<FundEntity>(entity =>
            {
                entity.ToTable("fund_entity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<FundOther>(entity =>
            {
                entity.HasKey(e => e.FundId)
                    .HasName("PRIMARY");

                entity.ToTable("fund_other");

                entity.Property(e => e.FundId)
                    .ValueGeneratedNever()
                    .HasColumnName("fund_id");

                entity.Property(e => e.UniqueNumber)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("unique_number")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.HasOne(d => d.Fund)
                    .WithOne(p => p.FundOther)
                    .HasForeignKey<FundOther>(d => d.FundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_other_ibfk_1");
            });

            modelBuilder.Entity<FundUsage>(entity =>
            {
                entity.ToTable("fund_usage");

                entity.HasIndex(e => new { e.FundId, e.CopyId, e.LibraryId }, "fund_id");

                entity.HasIndex(e => e.IssueDate, "idx_fund_usage_1");

                entity.HasIndex(e => e.ReturnDate, "idx_fund_usage_2");

                entity.HasIndex(e => e.LibrarianId, "librarian_id");

                entity.HasIndex(e => e.SubscriptionId, "subscription_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CopyId).HasColumnName("copy_id");

                entity.Property(e => e.FundId).HasColumnName("fund_id");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issue_date");

                entity.Property(e => e.LibrarianId).HasColumnName("librarian_id");

                entity.Property(e => e.LibraryId).HasColumnName("library_id");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");

                entity.HasOne(d => d.Librarian)
                    .WithMany(p => p.FundUsages)
                    .HasForeignKey(d => d.LibrarianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_usage_ibfk_3");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.FundUsages)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_usage_ibfk_1");

                entity.HasOne(d => d.FundCopy)
                    .WithMany(p => p.FundUsages)
                    .HasForeignKey(d => new { d.FundId, d.CopyId, d.LibraryId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fund_usage_ibfk_2");
            });

            modelBuilder.Entity<FundUsageRule>(entity =>
            {
                entity.ToTable("fund_usage_rules");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InternalUsage).HasColumnName("internal_usage");

                entity.Property(e => e.MaxBorrowDays).HasColumnName("max_borrow_days");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("lecturer");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("user_id");

                entity.Property(e => e.AcademicDegree)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("academic_degree")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Position)
                    .HasMaxLength(64)
                    .HasColumnName("position")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.University)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("university")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Lecturer)
                    .HasForeignKey<Lecturer>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lecturer_ibfk_1");
            });

            modelBuilder.Entity<Librarian>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("librarian");

                entity.HasIndex(e => e.ReadingRoomId, "reading_room_id");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.ReadingRoomId).HasColumnName("reading_room_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.ReadingRoom)
                    .WithMany(p => p.Librarians)
                    .HasForeignKey(d => d.ReadingRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("librarian_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Librarian)
                    .HasForeignKey<Librarian>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("librarian_ibfk_1");
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.ToTable("library");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("city")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<LibraryVisit>(entity =>
            {
                entity.ToTable("library_visit");

                entity.HasIndex(e => e.LibraryId, "library_id");

                entity.HasIndex(e => e.ReadingRoomId, "reading_room_id");

                entity.HasIndex(e => e.SubscriptionId, "subscription_id");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LibraryId).HasColumnName("library_id");

                entity.Property(e => e.ReadingRoomId).HasColumnName("reading_room_id");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.VisitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("visit_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.LibraryVisits)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("library_visit_ibfk_4");

                entity.HasOne(d => d.ReadingRoom)
                    .WithMany(p => p.LibraryVisits)
                    .HasForeignKey(d => d.ReadingRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("library_visit_ibfk_3");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.LibraryVisits)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("library_visit_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LibraryVisits)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("library_visit_ibfk_1");
            });

            modelBuilder.Entity<OtherUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("other_user");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.OtherUser)
                    .HasForeignKey<OtherUser>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("other_user_ibfk_1");
            });

            modelBuilder.Entity<PeriodicalLiterature>(entity =>
            {
                entity.HasKey(e => e.FundId)
                    .HasName("PRIMARY");

                entity.ToTable("periodical_literature");

                entity.Property(e => e.FundId)
                    .ValueGeneratedNever()
                    .HasColumnName("fund_id");

                entity.Property(e => e.Issn)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("issn")
                    .IsFixedLength(true);

                entity.Property(e => e.Issue).HasColumnName("issue");

                entity.HasOne(d => d.Fund)
                    .WithOne(p => p.PeriodicalLiterature)
                    .HasForeignKey<PeriodicalLiterature>(d => d.FundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("periodical_literature_ibfk_1");
            });

            modelBuilder.Entity<ReadingRoom>(entity =>
            {
                entity.ToTable("reading_room");

                entity.HasIndex(e => e.LibraryId, "library_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LibraryId).HasColumnName("library_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.ReadingRooms)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reading_room_ibfk_1");
            });

            modelBuilder.Entity<Retiree>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("retiree");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("user_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Retiree)
                    .HasForeignKey<Retiree>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("retiree_ibfk_1");
            });

            modelBuilder.Entity<Schoolchild>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("schoolchild");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("user_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.School)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("school")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Schoolchild)
                    .HasForeignKey<Schoolchild>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("schoolchild_ibfk_1");
            });

            modelBuilder.Entity<Scientist>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("scientist");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("user_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.ResearchField)
                    .HasMaxLength(255)
                    .HasColumnName("research_field")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.WorkPlace)
                    .HasMaxLength(255)
                    .HasColumnName("work_place")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Scientist)
                    .HasForeignKey<Scientist>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scientist_ibfk_1");
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.ToTable("storage");

                entity.HasIndex(e => new { e.FundId, e.CopyId, e.LibraryId }, "fund_id");

                entity.HasIndex(e => e.ShelfNumber, "idx_storage_1");

                entity.HasIndex(e => e.StorageRoomId, "storage_room_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnType("date")
                    .HasColumnName("arrival_date");

                entity.Property(e => e.CopyId).HasColumnName("copy_id");

                entity.Property(e => e.DecommissionDate)
                    .HasColumnType("date")
                    .HasColumnName("decommission_date");

                entity.Property(e => e.FundId).HasColumnName("fund_id");

                entity.Property(e => e.LibraryId).HasColumnName("library_id");

                entity.Property(e => e.RackNumber).HasColumnName("rack_number");

                entity.Property(e => e.RoomNumber).HasColumnName("room_number");

                entity.Property(e => e.ShelfNumber).HasColumnName("shelf_number");

                entity.Property(e => e.StorageRoomId).HasColumnName("storage_room_id");

                entity.HasOne(d => d.StorageRoom)
                    .WithMany(p => p.Storages)
                    .HasForeignKey(d => d.StorageRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("storage_ibfk_1");

                entity.HasOne(d => d.FundCopy)
                    .WithMany(p => p.Storages)
                    .HasForeignKey(d => new { d.FundId, d.CopyId, d.LibraryId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("storage_ibfk_2");
            });

            modelBuilder.Entity<StorageRoom>(entity =>
            {
                entity.ToTable("storage_room");

                entity.HasIndex(e => e.LibraryId, "idx_storage_room_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Floor).HasColumnName("floor");

                entity.Property(e => e.LibraryId).HasColumnName("library_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.StorageRooms)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("storage_room_ibfk_1");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("student");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("user_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Faculty)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("faculty")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GroupNumber)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("group_number")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.University)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("university")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("student_ibfk_1");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("subscription");

                entity.HasIndex(e => e.LibraryId, "idx_subscription_1");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExtendDate)
                    .HasColumnType("date")
                    .HasColumnName("extend_date");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issue_date");

                entity.Property(e => e.LibraryId).HasColumnName("library_id");

                entity.Property(e => e.Number)
                    .HasMaxLength(16)
                    .HasColumnName("number")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ValidDays).HasColumnName("valid_days");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subscription_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subscription_ibfk_1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.CategoryId, "category_id");

                entity.HasIndex(e => e.LastName, "idx_user_1");

                entity.HasIndex(e => e.FirstName, "idx_user_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("birth_date");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("city")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(8)
                    .HasColumnName("country_code");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .HasColumnName("middle_name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("user_ibfk_1");
            });

            modelBuilder.Entity<UserCategory>(entity =>
            {
                entity.ToTable("user_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
