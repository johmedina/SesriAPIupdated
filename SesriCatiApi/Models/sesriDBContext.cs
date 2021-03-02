using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SesriCatiApi.Models
{
    public partial class sesriDBContext : DbContext
    {

        public sesriDBContext(DbContextOptions<sesriDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<ActivityLog1> ActivityLog1 { get; set; }
        public virtual DbSet<ActivityLogView> ActivityLogView { get; set; }
        public virtual DbSet<ActivityRoleView> ActivityRoleView { get; set; }
        public virtual DbSet<ActivityRoleView1> ActivityRoleView1 { get; set; }
        public virtual DbSet<AllCaseData> AllCaseData { get; set; }
        public virtual DbSet<AllCaseData1> AllCaseData1 { get; set; }
        public virtual DbSet<AllCaseDataView> AllCaseDataView { get; set; }
        public virtual DbSet<AppSettings> AppSettings { get; set; }
        public virtual DbSet<AppSettings1> AppSettings1 { get; set; }
        public virtual DbSet<AppTranslate> AppTranslate { get; set; }
        public virtual DbSet<AppTranslate1> AppTranslate1 { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Appointment1> Appointment1 { get; set; }
        public virtual DbSet<AppointmentVue> AppointmentVue { get; set; }
        public virtual DbSet<Availability> Availability { get; set; }
        public virtual DbSet<Availability1> Availability1 { get; set; }
        public virtual DbSet<AvailabilityView> AvailabilityView { get; set; }
        public virtual DbSet<CasesAppointmentView> CasesAppointmentView { get; set; }
        public virtual DbSet<DailyReport> DailyReport { get; set; }
        public virtual DbSet<DailyReport1> DailyReport1 { get; set; }
        public virtual DbSet<DailyReportDoctors> DailyReportDoctors { get; set; }
        public virtual DbSet<DailyReportDoctors1> DailyReportDoctors1 { get; set; }
        public virtual DbSet<DailyReportView> DailyReportView { get; set; }
        public virtual DbSet<DeviceHistory> DeviceHistory { get; set; }
        public virtual DbSet<DeviceHistoryView> DeviceHistoryView { get; set; }
        public virtual DbSet<DialHistory> DialHistory { get; set; }
        public virtual DbSet<DialHistory1> DialHistory1 { get; set; }
        public virtual DbSet<DialHistoryView> DialHistoryView { get; set; }
        public virtual DbSet<DimActivity> DimActivity { get; set; }
        public virtual DbSet<DimActivity1> DimActivity1 { get; set; }
        public virtual DbSet<DimActivityView> DimActivityView { get; set; }
        public virtual DbSet<DimActivityView1> DimActivityView1 { get; set; }
        public virtual DbSet<DimDevice> DimDevice { get; set; }
        public virtual DbSet<DimDeviceManufacturer> DimDeviceManufacturer { get; set; }
        public virtual DbSet<DimDeviceModel> DimDeviceModel { get; set; }
        public virtual DbSet<DimDeviceStatus> DimDeviceStatus { get; set; }
        public virtual DbSet<DimDialStatus> DimDialStatus { get; set; }
        public virtual DbSet<DimDialStatus1> DimDialStatus1 { get; set; }
        public virtual DbSet<DimEvaluationCriteria> DimEvaluationCriteria { get; set; }
        public virtual DbSet<DimEvaluationCriteria1> DimEvaluationCriteria1 { get; set; }
        public virtual DbSet<DimIndicator> DimIndicator { get; set; }
        public virtual DbSet<DimIndicator1> DimIndicator1 { get; set; }
        public virtual DbSet<DimIssue> DimIssue { get; set; }
        public virtual DbSet<DimIssue1> DimIssue1 { get; set; }
        public virtual DbSet<DimProjectSetting> DimProjectSetting { get; set; }
        public virtual DbSet<DimProjectSetting1> DimProjectSetting1 { get; set; }
        public virtual DbSet<DimQcflag> DimQcflag { get; set; }
        public virtual DbSet<DimQcflag1> DimQcflag1 { get; set; }
        public virtual DbSet<DimQcflagCategory> DimQcflagCategory { get; set; }
        public virtual DbSet<DimQcflagCategory1> DimQcflagCategory1 { get; set; }
        public virtual DbSet<DimRole> DimRole { get; set; }
        public virtual DbSet<DimRole1> DimRole1 { get; set; }
        public virtual DbSet<DoctorDailyReportView> DoctorDailyReportView { get; set; }
        public virtual DbSet<EvaluationScore> EvaluationScore { get; set; }
        public virtual DbSet<EvaluationScore1> EvaluationScore1 { get; set; }
        public virtual DbSet<EvaluationScoreView> EvaluationScoreView { get; set; }
        public virtual DbSet<EvaluationSheet> EvaluationSheet { get; set; }
        public virtual DbSet<EvaluationSheet1> EvaluationSheet1 { get; set; }
        public virtual DbSet<EvaluationSheetView> EvaluationSheetView { get; set; }
        public virtual DbSet<FieldWorkActivitiesView> FieldWorkActivitiesView { get; set; }
        public virtual DbSet<FieldWorkActivity> FieldWorkActivity { get; set; }
        public virtual DbSet<FieldWorkActivity1> FieldWorkActivity1 { get; set; }
        public virtual DbSet<FlagData> FlagData { get; set; }
        public virtual DbSet<FlagDataHistory> FlagDataHistory { get; set; }
        public virtual DbSet<HouseholdVerificationVisit> HouseholdVerificationVisit { get; set; }
        public virtual DbSet<HouseholdVerificationVisit1> HouseholdVerificationVisit1 { get; set; }
        public virtual DbSet<HouseholdVerificationVisitView> HouseholdVerificationVisitView { get; set; }
        public virtual DbSet<IndicatorView> IndicatorView { get; set; }
        public virtual DbSet<Indicators> Indicators { get; set; }
        public virtual DbSet<Indicators1> Indicators1 { get; set; }
        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<IssueView> IssueView { get; set; }
        public virtual DbSet<OptionSet> OptionSet { get; set; }
        public virtual DbSet<OptionSet1> OptionSet1 { get; set; }
        public virtual DbSet<ProjctIssuesView> ProjctIssuesView { get; set; }
        public virtual DbSet<ProjctUserFlagsView> ProjctUserFlagsView { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Project1> Project1 { get; set; }
        public virtual DbSet<ProjectEmployee> ProjectEmployee { get; set; }
        public virtual DbSet<ProjectEmployee1> ProjectEmployee1 { get; set; }
        public virtual DbSet<ProjectSettingView> ProjectSettingView { get; set; }
        public virtual DbSet<ProjectSettings> ProjectSettings { get; set; }
        public virtual DbSet<ProjectSettings1> ProjectSettings1 { get; set; }
        public virtual DbSet<ProjectUsersView> ProjectUsersView { get; set; }
        public virtual DbSet<ProjectUsersView1> ProjectUsersView1 { get; set; }
        public virtual DbSet<ProjectUsersView2> ProjectUsersView2 { get; set; }
        public virtual DbSet<ProjectUsersView3> ProjectUsersView3 { get; set; }
        public virtual DbSet<QcIssueView> QcIssueView { get; set; }
        public virtual DbSet<QcflagData> QcflagData { get; set; }
        public virtual DbSet<QcflagData1> QcflagData1 { get; set; }
        public virtual DbSet<Sample> Sample { get; set; }
        public virtual DbSet<Sample1> Sample1 { get; set; }
        public virtual DbSet<SampleView> SampleView { get; set; }
        public virtual DbSet<Scidshift> Scidshift { get; set; }
        public virtual DbSet<Scidshift1> Scidshift1 { get; set; }
        public virtual DbSet<ScidshiftEmployeeVue> ScidshiftEmployeeVue { get; set; }
        public virtual DbSet<ScidshiftEmployees> ScidshiftEmployees { get; set; }
        public virtual DbSet<ScidshiftEmployees1> ScidshiftEmployees1 { get; set; }
        public virtual DbSet<SelectedCases> SelectedCases { get; set; }
        public virtual DbSet<SelectedCases1> SelectedCases1 { get; set; }
        public virtual DbSet<ServiceRequest> ServiceRequest { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Shift1> Shift1 { get; set; }
        public virtual DbSet<ShiftEmployees> ShiftEmployees { get; set; }
        public virtual DbSet<ShiftEmployees1> ShiftEmployees1 { get; set; }
        public virtual DbSet<ShiftEmployeesView> ShiftEmployeesView { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<TeamRandomVerification> TeamRandomVerification { get; set; }
        public virtual DbSet<TeamRandomVerification1> TeamRandomVerification1 { get; set; }
        public virtual DbSet<TeamRandomVerificationView> TeamRandomVerificationView { get; set; }
        public virtual DbSet<TeamRandomVisit> TeamRandomVisit { get; set; }
        public virtual DbSet<TeamRandomVisit1> TeamRandomVisit1 { get; set; }
        public virtual DbSet<TempSampleLoading> TempSampleLoading { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserProfile1> UserProfile1 { get; set; }
        public virtual DbSet<UserQcflagPermission> UserQcflagPermission { get; set; }
        public virtual DbSet<WorkRequest> WorkRequest { get; set; }
        public virtual DbSet<WorkRequest1> WorkRequest1 { get; set; }
        public virtual DbSet<WorkRequestView> WorkRequestView { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("ActivityLog", "ctt");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.BegTs)
                    .HasColumnName("BegTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.ActivityLogLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityLog_UserProfile");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityLogUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityLog_UserProfile1");
            });

            modelBuilder.Entity<ActivityLog1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActivityLog", "History");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.BegTs)
                    .HasColumnName("BegTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ActivityLogView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActivityLogView", "ctt");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ActivityArabicDisplayName).HasMaxLength(150);

                entity.Property(e => e.ActivityEnglishDisplayName).HasMaxLength(150);

                entity.Property(e => e.ArRequestStatus).HasMaxLength(250);

                entity.Property(e => e.ArRequestType).HasMaxLength(250);

                entity.Property(e => e.ArabicShiftName).HasMaxLength(100);

                entity.Property(e => e.BegTs)
                    .HasColumnName("BegTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EngRequestStatus).HasMaxLength(250);

                entity.Property(e => e.EngRequestType).HasMaxLength(250);

                entity.Property(e => e.EnglishShiftName).HasMaxLength(100);

                entity.Property(e => e.ShiftEnd).HasColumnType("datetime");

                entity.Property(e => e.ShiftStart).HasColumnType("datetime");

                entity.Property(e => e.UserArabicName).HasMaxLength(150);

                entity.Property(e => e.UserEnglishName).HasMaxLength(150);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ActivityRoleView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActivityRoleView", "ctt");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Role).HasMaxLength(15);
            });

            modelBuilder.Entity<ActivityRoleView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActivityRoleView", "fop");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Role).HasMaxLength(15);
            });

            modelBuilder.Entity<AllCaseData>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.CaseId });

                entity.ToTable("AllCaseData", "ctt");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.AllCaseData)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AllCaseData_UserProfile");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AllCaseData)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AllCaseData_Project");
            });

            modelBuilder.Entity<AllCaseData1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AllCaseData", "History");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AllCaseDataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllCaseDataView", "ctt");

                entity.Property(e => e.CaseIdphoneNumber)
                    .IsRequired()
                    .HasColumnName("CaseIDPhoneNumber")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppSettings>(entity =>
            {
                entity.Property(e => e.AppCode).HasMaxLength(10);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasMaxLength(25);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.AppSettings)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppSettings_UserProfile");
            });

            modelBuilder.Entity<AppSettings1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppSettings", "History");

                entity.Property(e => e.AppCode).HasMaxLength(10);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasMaxLength(25);
            });

            modelBuilder.Entity<AppTranslate>(entity =>
            {
                entity.HasIndex(e => new { e.AppCode, e.Key })
                    .HasName("UQ_TanslateAppKey")
                    .IsUnique();

                entity.Property(e => e.AppCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ArabicValue)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishValue)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.AppTranslate)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppTranslate_UserProfile");
            });

            modelBuilder.Entity<AppTranslate1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppTranslate", "History");

                entity.Property(e => e.AppCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ArabicValue)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishValue)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Appointment", "History");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hmciwv)
                    .IsRequired()
                    .HasColumnName("HMCIwv")
                    .HasMaxLength(20);

                entity.Property(e => e.HmciwvEmail)
                    .HasColumnName("HMCIwvEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartTs)
                    .HasColumnName("StartTS")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Appointment1>(entity =>
            {
                entity.ToTable("Appointment", "scid");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hmciwv)
                    .IsRequired()
                    .HasColumnName("HMCIwv")
                    .HasMaxLength(20);

                entity.Property(e => e.HmciwvEmail)
                    .HasColumnName("HMCIwvEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.StartTs)
                    .HasColumnName("StartTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.HmciwvNavigation)
                    .WithMany(p => p.Appointment1)
                    .HasForeignKey(d => d.Hmciwv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_UserProfile");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Appointment1)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_Project");
            });

            modelBuilder.Entity<AppointmentVue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AppointmentVue", "scid");

                entity.Property(e => e.ArStatus).HasMaxLength(250);

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EnStatus).HasMaxLength(250);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnglishName).HasMaxLength(150);

                entity.Property(e => e.Hmciwv)
                    .IsRequired()
                    .HasColumnName("HMCIwv")
                    .HasMaxLength(20);

                entity.Property(e => e.HmciwvArName)
                    .HasColumnName("HMCIwvArName")
                    .HasMaxLength(150);

                entity.Property(e => e.HmciwvEngName)
                    .HasColumnName("HMCIwvEngName")
                    .HasMaxLength(150);

                entity.Property(e => e.SesriiwvArName)
                    .HasColumnName("SESRIIwvArName")
                    .HasMaxLength(150);

                entity.Property(e => e.SesriiwvEngName)
                    .HasColumnName("SESRIIwvEngName")
                    .HasMaxLength(150);

                entity.Property(e => e.StartTs)
                    .HasColumnName("StartTS")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Availability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Availability", "History");

                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.AvailableTo).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Availability1>(entity =>
            {
                entity.ToTable("Availability", "scid");

                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.AvailableTo).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Availability1)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Availability_Project");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Availability1)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Availability_SCIDShift");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Availability1)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Availability_UserProfile");
            });

            modelBuilder.Entity<AvailabilityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AvailabilityView", "scid");

                entity.Property(e => e.ArDoctorName).HasMaxLength(150);

                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.AvailableTo).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DoctorUserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.EngDoctorName).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<CasesAppointmentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CasesAppointmentView", "scid");

                entity.Property(e => e.AltPhone).HasMaxLength(8);

                entity.Property(e => e.ArAppointmentStatus).HasMaxLength(250);

                entity.Property(e => e.ArFinalCaseStatus).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DoctorArName).HasMaxLength(150);

                entity.Property(e => e.DoctorEngName).HasMaxLength(150);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EngAppointmentStatus).HasMaxLength(250);

                entity.Property(e => e.EngFinalCaseStatus).HasMaxLength(250);

                entity.Property(e => e.FactSheet).IsRequired();

                entity.Property(e => e.Hmciwv)
                    .HasColumnName("HMCIwv")
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.StartTs)
                    .HasColumnName("StartTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.SurveyDate).HasColumnType("date");
            });

            modelBuilder.Entity<DailyReport>(entity =>
            {
                entity.ToTable("DailyReport", "fop");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisedBy).HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailyReportCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyReport_UserProfile");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.DailyReportLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyReport_UserProfile2");

                entity.HasOne(d => d.SupervisedByNavigation)
                    .WithMany(p => p.DailyReportSupervisedByNavigation)
                    .HasForeignKey(d => d.SupervisedBy)
                    .HasConstraintName("FK_DailyReport_UserProfile1");
            });

            modelBuilder.Entity<DailyReport1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DailyReport", "History");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisedBy).HasMaxLength(20);
            });

            modelBuilder.Entity<DailyReportDoctors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DailyReportDoctors", "History");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DailyReportDoctors1>(entity =>
            {
                entity.ToTable("DailyReportDoctors", "scid");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DailyReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DailyReportView", "fop");

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisedBy).HasMaxLength(20);
            });

            modelBuilder.Entity<DeviceHistory>(entity =>
            {
                entity.ToTable("DeviceHistory", "History");

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Qutag)
                    .HasColumnName("QUTag")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<DeviceHistoryView>(entity =>
            {
                //entity.HasNoKey();
                entity.HasKey(e => e.Id);

                entity.ToView("DeviceHistoryView", "History");

                entity.Property(e => e.ArAssignedTo).HasMaxLength(150);

                entity.Property(e => e.ArCreatedByName).HasMaxLength(150);

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.Cpu)
                    .HasColumnName("CPU")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EngAssignedTo).HasMaxLength(150);

                entity.Property(e => e.EngCreatedByName).HasMaxLength(150);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Manufacturer).HasMaxLength(50);

                entity.Property(e => e.ManufacturerName).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ModelName).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.OperatingSystem).HasMaxLength(50);

                entity.Property(e => e.Qutag)
                    .HasColumnName("QUTag")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.Property(e => e.Rownr).HasColumnName("ROWNR");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusLabel).HasMaxLength(50);
            });

            modelBuilder.Entity<DialHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DialHistory", "History");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DialHistory1>(entity =>
            {
                entity.ToTable("DialHistory", "scid");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DialHistory1)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DialHistory_Project");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DialHistory1)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DialHistory_UserProfile");
            });

            modelBuilder.Entity<DialHistoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DialHistoryView", "scid");

                entity.Property(e => e.ArIwvName).HasMaxLength(150);

                entity.Property(e => e.ArabicDialStatus).HasMaxLength(200);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EngIwvName).HasMaxLength(150);

                entity.Property(e => e.EnglishDialStatus).HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DimActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityCode);

                entity.Property(e => e.ActivityCode).HasMaxLength(25);

                entity.Property(e => e.ActivityRole).HasMaxLength(15);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsPaid)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.DimActivity)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DimActivity_UserProfile");
            });

            modelBuilder.Entity<DimActivity1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimActivity", "History");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ActivityRole).HasMaxLength(15);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DimActivityView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DimActivityView", "ctt");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ActivityRole).HasMaxLength(15);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DimActivityView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DimActivityView", "fop");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ActivityRole).HasMaxLength(15);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DimDevice>(entity =>
            {
                entity.Property(e => e.Cpu)
                    .IsRequired()
                    .HasColumnName("CPU")
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OperatingSystem)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qutag)
                    .IsRequired()
                    .HasColumnName("QUTag")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DimDeviceManufacturer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DimDeviceModel>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DimDeviceStatus>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DimDialStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimDialStatus", "History");

                entity.Property(e => e.ArabicDialStatus)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EnglishDialStatus)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DimDialStatus1>(entity =>
            {
                entity.ToTable("DimDialStatus", "scid");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabicDialStatus)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EnglishDialStatus)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");
            });

            modelBuilder.Entity<DimEvaluationCriteria>(entity =>
            {
                entity.Property(e => e.ArabicDescription).IsRequired();

                entity.Property(e => e.ArabicDispalyName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDescription).IsRequired();

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.DimEvaluationCriteria)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DimEvaluationCriteria_UserProfile");
            });

            modelBuilder.Entity<DimEvaluationCriteria1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimEvaluationCriteria", "History");

                entity.Property(e => e.ArabicDescription).IsRequired();

                entity.Property(e => e.ArabicDispalyName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnglishDescription).IsRequired();

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DimIndicator>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IndicatorArabic)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IndicatorEnglish)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReportingFrequency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.DimIndicator)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DimIndicator_UserProfile");
            });

            modelBuilder.Entity<DimIndicator1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimIndicator", "History");

                entity.Property(e => e.IndicatorArabic)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IndicatorEnglish)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReportingFrequency)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DimIssue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ComponentArabic).HasMaxLength(50);

                entity.Property(e => e.ComponentEnglish)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.TypeArabic)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeEnglish)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserLevel)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<DimIssue1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimIssue", "History");

                entity.Property(e => e.ComponentArabic).HasMaxLength(50);

                entity.Property(e => e.ComponentEnglish)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.TypeArabic)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeEnglish)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserLevel)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<DimProjectSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.DimProjectSetting)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DimProjectSetting_UserProfile");
            });

            modelBuilder.Entity<DimProjectSetting1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimProjectSetting", "History");

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DimQcflag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimQCFlag", "History");

                entity.Property(e => e.ArabicDescription)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishDescription)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FlagCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DimQcflag1>(entity =>
            {
                entity.HasKey(e => new { e.FlagId, e.ProjectId });

                entity.ToTable("DimQCFlag", "qcf");

                entity.HasIndex(e => new { e.ProjectId, e.FlagCode })
                    .HasName("IX_DimQCFlags")
                    .IsUnique();

                entity.Property(e => e.ArabicDescription)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishDescription)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FlagCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.DimQcflagCategory1)
                    .WithMany(p => p.DimQcflag1)
                    .HasForeignKey(d => new { d.Category, d.ProjectId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DimQCFlag_DimQCFlagCategory");
            });

            modelBuilder.Entity<DimQcflagCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimQCFlagCategory", "History");

                entity.Property(e => e.CategoryArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryEnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PkProjectId).HasColumnName("PK_ProjectId");
            });

            modelBuilder.Entity<DimQcflagCategory1>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PkProjectId });

                entity.ToTable("DimQCFlagCategory", "qcf");

                entity.Property(e => e.PkProjectId).HasColumnName("PK_ProjectId");

                entity.Property(e => e.CategoryArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryEnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");
            });

            modelBuilder.Entity<DimRole>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");
            });

            modelBuilder.Entity<DimRole1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimRole", "History");

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);
            });

            modelBuilder.Entity<DoctorDailyReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DoctorDailyReportView", "scid");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DrArName).HasMaxLength(150);

                entity.Property(e => e.DrEngName).HasMaxLength(150);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EvaluationScore>(entity =>
            {
                entity.ToTable("EvaluationScore", "ctt");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.EvaluationSheet)
                    .WithMany(p => p.EvaluationScore)
                    .HasForeignKey(d => d.EvaluationSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationScore_EvaluationSheet");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.EvaluationScore)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationScore_UserProfile");
            });

            modelBuilder.Entity<EvaluationScore1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EvaluationScore", "History");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EvaluationScoreView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EvaluationScoreView", "ctt");

                entity.Property(e => e.ArabicDescription).IsRequired();

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.EnglishDescription).IsRequired();

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.RatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EvaluationSheet>(entity =>
            {
                entity.ToTable("EvaluationSheet", "ctt");

                entity.Property(e => e.CatiManagerComment).HasMaxLength(250);

                entity.Property(e => e.InterviewerComments).HasMaxLength(500);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.RatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupervisorComments).HasMaxLength(500);

                entity.Property(e => e.SupervisorFinalComment).HasMaxLength(250);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.EvaluationSheetLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .HasConstraintName("FK_EvaluationSheet_UserProfile");

                entity.HasOne(d => d.RatedByNavigation)
                    .WithMany(p => p.EvaluationSheetRatedByNavigation)
                    .HasForeignKey(d => d.RatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationSheet_UserProfile2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EvaluationSheetUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationSheet_UserProfile1");
            });

            modelBuilder.Entity<EvaluationSheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EvaluationSheet", "History");

                entity.Property(e => e.CatiManagerComment).HasMaxLength(250);

                entity.Property(e => e.InterviewerComments).HasMaxLength(500);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.RatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupervisorComments).HasMaxLength(500);

                entity.Property(e => e.SupervisorFinalComment).HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EvaluationSheetView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EvaluationSheetView", "ctt");

                entity.Property(e => e.ArSheetStatus).HasMaxLength(250);

                entity.Property(e => e.CatiManagerComment).HasMaxLength(250);

                entity.Property(e => e.EngSheetStatus).HasMaxLength(250);

                entity.Property(e => e.InterviewerComments).HasMaxLength(500);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.RatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupervisorComments).HasMaxLength(500);

                entity.Property(e => e.SupervisorFinalComment).HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<FieldWorkActivitiesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FieldWorkActivitiesView", "fop");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ActivityCode).HasMaxLength(25);

                entity.Property(e => e.ActivityRole).HasMaxLength(15);

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(150);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EnglishDisplayName).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<FieldWorkActivity>(entity =>
            {
                entity.ToTable("FieldWorkActivity", "fop");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.ActivityNavigation)
                    .WithMany(p => p.FieldWorkActivity)
                    .HasForeignKey(d => d.Activity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FieldWorkActivity_DimActivity");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FieldWorkActivity)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FieldWorkActivity_UserProfile1");
            });

            modelBuilder.Entity<FieldWorkActivity1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FieldWorkActivity", "History");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<FlagData>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__FlagData__7AD04FF15E1ECC6C");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.AnnualSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlagDataHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.AnnualSalary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HouseholdVerificationVisit>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.ProjectId });

                entity.ToTable("HouseholdVerificationVisit", "fop");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Qc1).HasColumnName("QC1");

                entity.Property(e => e.Qc2).HasColumnName("QC2");

                entity.Property(e => e.Qc3).HasColumnName("QC3");

                entity.Property(e => e.Qc4).HasColumnName("QC4");

                entity.Property(e => e.Qc5).HasColumnName("QC5");

                entity.Property(e => e.Qc6).HasColumnName("QC6");

                entity.Property(e => e.Qc7).HasColumnName("QC7");

                entity.Property(e => e.Qc8).HasColumnName("QC8");

                entity.Property(e => e.Qc9).HasColumnName("QC9");

                entity.Property(e => e.SupervisedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.VerificationVisitDate).HasColumnType("datetime");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.HouseholdVerificationVisitLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseholdVerificationVisit_UserProfile1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.HouseholdVerificationVisit)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseholdVerificationVisit_Project");

                entity.HasOne(d => d.SupervisedByNavigation)
                    .WithMany(p => p.HouseholdVerificationVisitSupervisedByNavigation)
                    .HasForeignKey(d => d.SupervisedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseholdVerificationVisit_UserProfile");
            });

            modelBuilder.Entity<HouseholdVerificationVisit1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HouseholdVerificationVisit", "History");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Qc1).HasColumnName("QC1");

                entity.Property(e => e.Qc2).HasColumnName("QC2");

                entity.Property(e => e.Qc3).HasColumnName("QC3");

                entity.Property(e => e.Qc4).HasColumnName("QC4");

                entity.Property(e => e.Qc5).HasColumnName("QC5");

                entity.Property(e => e.Qc6).HasColumnName("QC6");

                entity.Property(e => e.Qc7).HasColumnName("QC7");

                entity.Property(e => e.Qc8).HasColumnName("QC8");

                entity.Property(e => e.Qc9).HasColumnName("QC9");

                entity.Property(e => e.SupervisedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VerificationVisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HouseholdVerificationVisitView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HouseholdVerificationVisitView", "fop");

                entity.Property(e => e.ArVerifStatus).HasMaxLength(250);

                entity.Property(e => e.BuildingmunNo).HasMaxLength(50);

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.EnVerifStatus).HasMaxLength(250);

                entity.Property(e => e.Hhtype).HasColumnName("HHType");

                entity.Property(e => e.InterviewerId).HasMaxLength(20);

                entity.Property(e => e.Qc1).HasColumnName("QC1");

                entity.Property(e => e.Qc2).HasColumnName("QC2");

                entity.Property(e => e.Qc3).HasColumnName("QC3");

                entity.Property(e => e.Qc4).HasColumnName("QC4");

                entity.Property(e => e.Qc5).HasColumnName("QC5");

                entity.Property(e => e.Qc6).HasColumnName("QC6");

                entity.Property(e => e.Qc7).HasColumnName("QC7");

                entity.Property(e => e.Qc8).HasColumnName("QC8");

                entity.Property(e => e.Qc9).HasColumnName("QC9");

                entity.Property(e => e.SupervisedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VerificationVisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IndicatorView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IndicatorView");

                entity.Property(e => e.IndicatorArabic).HasMaxLength(100);

                entity.Property(e => e.IndicatorEnglish).HasMaxLength(100);

                entity.Property(e => e.ReportingFrequencyAr).HasMaxLength(250);

                entity.Property(e => e.ReportingFrequencyEng).HasMaxLength(250);
            });

            modelBuilder.Entity<Indicators>(entity =>
            {
                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");
            });

            modelBuilder.Entity<Indicators1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Indicators", "History");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(8);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IssueCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_UserProfile1");

                entity.HasOne(d => d.IssueType)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.IssueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_DimIssue");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.IssueLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Issue_UserProfile");
            });

            modelBuilder.Entity<IssueView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IssueView");

                entity.Property(e => e.ArabicStatus).HasMaxLength(250);

                entity.Property(e => e.ComponentArabic).HasMaxLength(50);

                entity.Property(e => e.ComponentEnglish).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EnglishStatus).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(8);

                entity.Property(e => e.Rownr).HasColumnName("ROWNR");

                entity.Property(e => e.TypeArabic).HasMaxLength(100);

                entity.Property(e => e.TypeEnglish).HasMaxLength(100);

                entity.Property(e => e.UserLevel).HasMaxLength(25);
            });

            modelBuilder.Entity<OptionSet>(entity =>
            {
                entity.Property(e => e.AppCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ArabicLabel)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishLabel)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.VariableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.OptionSet)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OptionSet_UserProfile");
            });

            modelBuilder.Entity<OptionSet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OptionSet", "History");

                entity.Property(e => e.AppCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ArabicLabel)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishLabel)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VariableName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProjctIssuesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProjctIssuesView", "qcf");

                entity.Property(e => e.ComponentArabic).HasMaxLength(50);

                entity.Property(e => e.ComponentEnglish)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedNamebyArb)
                    .HasColumnName("createdNAmebyArb")
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedbyNameEng)
                    .IsRequired()
                    .HasColumnName("createdbyNameEng")
                    .HasMaxLength(150);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ModifybyNameArb)
                    .HasColumnName("modifybyNameArb")
                    .HasMaxLength(150);

                entity.Property(e => e.ModifybyNameEng)
                    .IsRequired()
                    .HasColumnName("modifybyNameEng")
                    .HasMaxLength(150);

                entity.Property(e => e.PhoneNumber).HasMaxLength(8);

                entity.Property(e => e.ReqStatusArb)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ReqStatusEng)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TypeArabic)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeEnglish)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserLevel)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ProjctUserFlagsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProjctUserFlagsView", "qcf");

                entity.Property(e => e.ArabicCategory)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ArabicDescription)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ArabicDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ArabicFlagStatus)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.CaseId).HasMaxLength(50);

                entity.Property(e => e.EnglishCategory)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishDescription)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishFlagStatus)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FlagCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InterviewerId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).ValueGeneratedNever();

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(250);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_UserProfile");
            });

            modelBuilder.Entity<Project1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Project", "History");

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(250);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ProjectEmployee>(entity =>
            {
                entity.HasIndex(e => new { e.ProjectId, e.UserId })
                    .HasName("IX_ProjectEmployee_USPR")
                    .IsUnique();

                entity.Property(e => e.AssignedDevice).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.ProjectEmployeeLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEmployee_UserProfile1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectEmployee)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEmployee_Project");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.ProjectEmployee)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEmployee_DimRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectEmployeeUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEmployee_UserProfile");
            });

            modelBuilder.Entity<ProjectEmployee1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProjectEmployee", "History");

                entity.Property(e => e.AssignedDevice).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectSettingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProjectSettingView");

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(100);

                entity.Property(e => e.EnglishDisplayName).HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasMaxLength(25);

                entity.Property(e => e.UserId).HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectSettings>(entity =>
            {
                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasMaxLength(25);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId).HasMaxLength(20);

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.ProjectSettingsLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSettings_UserProfile");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectSettings)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSettings_Project");

                entity.HasOne(d => d.ProjectSetting)
                    .WithMany(p => p.ProjectSettings)
                    .HasForeignKey(d => d.ProjectSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSettings_DimProjectSetting");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectSettingsUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProjectSettings_UserProfile1");
            });

            modelBuilder.Entity<ProjectSettings1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProjectSettings", "History");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasMaxLength(25);

                entity.Property(e => e.UserId).HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectUsersView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProjectUsersView", "ctt");

                entity.Property(e => e.ArRole).HasMaxLength(25);

                entity.Property(e => e.ArUserName).HasMaxLength(150);

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(250);

                entity.Property(e => e.ArabicPhase).HasMaxLength(250);

                entity.Property(e => e.AssignedDevice).HasMaxLength(50);

                entity.Property(e => e.EngRole).HasMaxLength(25);

                entity.Property(e => e.EngUserName).HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishPhase).HasMaxLength(250);

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UserId).HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectUsersView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProjectUsersView", "fop");

                entity.Property(e => e.ArRole).HasMaxLength(25);

                entity.Property(e => e.ArUserName).HasMaxLength(150);

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(250);

                entity.Property(e => e.ArabicPhase).HasMaxLength(250);

                entity.Property(e => e.AssignedDevice).HasMaxLength(50);

                entity.Property(e => e.EngRole).HasMaxLength(25);

                entity.Property(e => e.EngUserName).HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishPhase).HasMaxLength(250);

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UserId).HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectUsersView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProjectUsersView", "qcf");

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(250);

                entity.Property(e => e.ArabicPhase)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ArabicRole)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishPhase)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishRole)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectUsersView3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProjectUsersView", "scid");

                entity.Property(e => e.ArRole).HasMaxLength(25);

                entity.Property(e => e.ArUserName).HasMaxLength(150);

                entity.Property(e => e.ArabicDisplayName).HasMaxLength(250);

                entity.Property(e => e.ArabicPhase).HasMaxLength(250);

                entity.Property(e => e.AssignedDevice).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.EngRole).HasMaxLength(25);

                entity.Property(e => e.EngUserName).HasMaxLength(150);

                entity.Property(e => e.EnglishDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EnglishPhase).HasMaxLength(250);

                entity.Property(e => e.Groups).HasMaxLength(150);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UserId).HasMaxLength(20);
            });

            modelBuilder.Entity<QcIssueView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qc_IssueView");

                entity.Property(e => e.Component).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IssueTypeDesc).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(8);

                entity.Property(e => e.RequestStatusDesc).HasMaxLength(250);
            });

            modelBuilder.Entity<QcflagData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QCFlagData", "History");

                entity.Property(e => e.CaseId).HasMaxLength(50);

                entity.Property(e => e.InterviewerId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ModifiedBy).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QcflagData1>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProjectId });

                entity.ToTable("QCFlagData", "qcf");

                entity.Property(e => e.CaseId).HasMaxLength(50);

                entity.Property(e => e.InterviewerId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ModifiedBy).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.HasOne(d => d.DimQcflag1)
                    .WithMany(p => p.QcflagData1)
                    .HasForeignKey(d => new { d.FlagId, d.ProjectId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QCFlagData_DimQCFlag");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.CaseId });

                entity.ToTable("Sample", "fop");

                entity.Property(e => e.BuildingmunNo).HasMaxLength(50);

                entity.Property(e => e.DeviceId).HasMaxLength(50);

                entity.Property(e => e.HeadId).HasMaxLength(15);

                entity.Property(e => e.Hhtype).HasColumnName("HHType");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewerId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(8);

                entity.Property(e => e.SupervisedById).HasMaxLength(15);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.Sample)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sample_UserProfile");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Sample)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sample_Project");
            });

            modelBuilder.Entity<Sample1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sample", "History");

                entity.Property(e => e.BuildingmunNo).HasMaxLength(50);

                entity.Property(e => e.DeviceId).HasMaxLength(50);

                entity.Property(e => e.HeadId).HasMaxLength(15);

                entity.Property(e => e.Hhtype).HasColumnName("HHType");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewerId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(8);

                entity.Property(e => e.SupervisedById).HasMaxLength(15);
            });

            modelBuilder.Entity<SampleView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SampleView", "fop");

                entity.Property(e => e.ArabicLabel).HasMaxLength(250);

                entity.Property(e => e.BuildingmunNo).HasMaxLength(50);

                entity.Property(e => e.DeviceId).HasMaxLength(50);

                entity.Property(e => e.EnglishLabel).HasMaxLength(250);

                entity.Property(e => e.HeadId).HasMaxLength(15);

                entity.Property(e => e.Hhtype).HasColumnName("HHType");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewerId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupervisedById).HasMaxLength(15);
            });

            modelBuilder.Entity<Scidshift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCIDShift", "History");

                entity.Property(e => e.BegTs).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EndTs).HasColumnType("datetime");

                entity.Property(e => e.LastModify)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Scidshift1>(entity =>
            {
                entity.ToTable("SCIDShift", "scid");

                entity.Property(e => e.BegTs).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EndTs).HasColumnType("datetime");

                entity.Property(e => e.LastModify)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Scidshift1)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCIDShift_Project");
            });

            modelBuilder.Entity<ScidshiftEmployeeVue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SCIDShiftEmployeeVue", "scid");

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.BegTs).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.EmployeeAddedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EndTs).HasColumnType("datetime");

                entity.Property(e => e.EnglishName).HasMaxLength(150);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SignedInTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ScidshiftEmployees>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCIDShiftEmployees", "History");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SignedInTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ScidshiftEmployees1>(entity =>
            {
                entity.ToTable("SCIDShiftEmployees", "scid");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SignedInTime).HasColumnType("datetime");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.ScidshiftEmployees1)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCIDShiftEmployees_SCIDShift");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ScidshiftEmployees1)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCIDShiftEmployees_UserProfile");
            });

            modelBuilder.Entity<SelectedCases>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SelectedCases", "History");

                entity.Property(e => e.AltPhone).HasMaxLength(8);

                entity.Property(e => e.FactSheet).IsRequired();

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.SurveyDate).HasColumnType("date");
            });

            modelBuilder.Entity<SelectedCases1>(entity =>
            {
                entity.ToTable("SelectedCases", "scid");

                entity.Property(e => e.AltPhone).HasMaxLength(8);

                entity.Property(e => e.FactSheet).IsRequired();

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.SurveyDate).HasColumnType("date");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SelectedCases1)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AllCaseData_Project");
            });

            modelBuilder.Entity<ServiceRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceRequest", "History");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(8);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift", "ctt");

                entity.HasIndex(e => new { e.ProjectId, e.EnglishName, e.ArabicName, e.CustomLabel })
                    .HasName("UC_Shift")
                    .IsUnique();

                entity.Property(e => e.ArabicName).HasMaxLength(100);

                entity.Property(e => e.BegTs)
                    .HasColumnName("BegTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomLabel).HasMaxLength(100);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ShiftCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shift_UserProfile1");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.ShiftLastModifiedByNavigation)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shift_UserProfile");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Shift)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityShift_Project");
            });

            modelBuilder.Entity<Shift1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Shift", "History");

                entity.Property(e => e.ArabicName).HasMaxLength(100);

                entity.Property(e => e.BegTs)
                    .HasColumnName("BegTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomLabel).HasMaxLength(100);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ShiftEmployees>(entity =>
            {
                entity.ToTable("ShiftEmployees", "ctt");

                entity.HasIndex(e => new { e.UserId, e.ShiftId })
                    .HasName("UQ_ShiftEmployees")
                    .IsUnique();

                entity.Property(e => e.BlworkedHours).HasColumnName("BLWorkedHours");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.IsBlvalidated).HasColumnName("IsBLValidated");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.ShiftEmployees)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .HasConstraintName("FK_ShiftEmployees_UserProfile");

                entity.HasOne(d => d.ProjectEmployee)
                    .WithMany(p => p.ShiftEmployees)
                    .HasPrincipalKey(p => new { p.ProjectId, p.UserId })
                    .HasForeignKey(d => new { d.ProjectId, d.UserId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShiftEmployees_ProjectEmployee");
            });

            modelBuilder.Entity<ShiftEmployees1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ShiftEmployees", "History");

                entity.Property(e => e.BlworkedHours).HasColumnName("BLWorkedHours");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.IsBlvalidated).HasColumnName("IsBLValidated");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ShiftEmployeesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ShiftEmployeesView", "ctt");

                entity.Property(e => e.ArShiftName).HasMaxLength(100);

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.BegTs)
                    .HasColumnName("BegTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomLabel).HasMaxLength(100);

                entity.Property(e => e.EmployeeAddedBy).HasMaxLength(20);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EngShiftName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnglishName).HasMaxLength(150);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B617E881423");

                entity.ToTable("sysdiagrams");

                entity.HasIndex(e => new { e.PrincipalId, e.Name })
                    .HasName("UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<TeamRandomVerification>(entity =>
            {
                entity.ToTable("TeamRandomVerification", "fop");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupervisedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.TempEmployee)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TeamRandomVerification)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRandomVerification_Project");

                entity.HasOne(d => d.SupervisedByNavigation)
                    .WithMany(p => p.TeamRandomVerificationSupervisedByNavigation)
                    .HasForeignKey(d => d.SupervisedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRandomVerification_UserProfile1");

                entity.HasOne(d => d.TempEmployeeNavigation)
                    .WithMany(p => p.TeamRandomVerificationTempEmployeeNavigation)
                    .HasForeignKey(d => d.TempEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRandomVerification_UserProfile");
            });

            modelBuilder.Entity<TeamRandomVerification1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TeamRandomVerification", "History");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupervisedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TempEmployee)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TeamRandomVerificationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TeamRandomVerificationView", "fop");

                entity.Property(e => e.ArabicLabel).HasMaxLength(250);

                entity.Property(e => e.EnglishLabel).HasMaxLength(250);

                entity.Property(e => e.IwvArName).HasMaxLength(150);

                entity.Property(e => e.IwvEngName).HasMaxLength(150);

                entity.Property(e => e.SupArName).HasMaxLength(150);

                entity.Property(e => e.SupEngName).HasMaxLength(150);

                entity.Property(e => e.SupervisedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TempEmployee)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TeamRandomVisit>(entity =>
            {
                entity.ToTable("TeamRandomVisit", "fop");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.SupervisedBy).HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.TempEmployee).HasMaxLength(20);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.TeamRandomVisit)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRandomVisit_UserProfile");
            });

            modelBuilder.Entity<TeamRandomVisit1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TeamRandomVisit", "History");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.SupervisedBy).HasMaxLength(20);

                entity.Property(e => e.TempEmployee).HasMaxLength(20);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempSampleLoading>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AreaSqM).HasColumnName("Area Sq#m#");

                entity.Property(e => e.BlockNo).HasColumnName("Block No");

                entity.Property(e => e.HeadId).HasMaxLength(20);

                entity.Property(e => e.InterviewerId).HasMaxLength(20);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(20);

                entity.Property(e => e.MainActivity)
                    .HasColumnName("Main Activity")
                    .HasMaxLength(255);

                entity.Property(e => e.MunicipalityNo).HasColumnName("Municipality No");

                entity.Property(e => e.OwnName).HasMaxLength(255);

                entity.Property(e => e.SupervisedById).HasMaxLength(20);

                entity.Property(e => e.TypesOfEzba)
                    .HasColumnName("Types of Ezba")
                    .HasMaxLength(255);

                entity.Property(e => e.ZoneNo).HasColumnName("Zone No");

                entity.Property(e => e.رقمالحيازةالتعدادي)
                    .HasColumnName("رقم الحيازة التعدادي")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Employee");

                entity.Property(e => e.UserId).HasMaxLength(20);

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MainGroup).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");
            });

            modelBuilder.Entity<UserProfile1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserProfile", "History");

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MainGroup).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<UserQcflagPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserQCFlagPermission", "qcf");

                entity.HasIndex(e => new { e.UserId, e.ProjectId, e.CategoryId })
                    .HasName("UQ_UserCategory")
                    .IsUnique();

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.DimQcflagCategory1)
                    .WithMany()
                    .HasForeignKey(d => new { d.CategoryId, d.ProjectId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserQCFlagPermission_DimQCFlagCategory");
            });

            modelBuilder.Entity<WorkRequest>(entity =>
            {
                entity.ToTable("WorkRequest", "fop");

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Groups)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartTs).HasColumnType("datetime");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WorkRequestCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkRequest_UserProfile");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.WorkRequestModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkRequest_UserProfile1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.WorkRequest)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkRequest_Project");
            });

            modelBuilder.Entity<WorkRequest1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkRequest", "History");

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Groups)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartTs).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkRequestView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WorkRequestView", "fop");

                entity.Property(e => e.ArStatus).HasMaxLength(250);

                entity.Property(e => e.ArabicName).HasMaxLength(150);

                entity.Property(e => e.CaseId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EndTs)
                    .HasColumnName("EndTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.EngStatus).HasMaxLength(250);

                entity.Property(e => e.EnglishName).HasMaxLength(150);

                entity.Property(e => e.Groups)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.RequestModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartTs).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
