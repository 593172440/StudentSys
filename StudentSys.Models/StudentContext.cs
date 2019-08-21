namespace StudentSys.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public class StudentContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“StudentContext”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“StudentSys.Models.StudentContext”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“StudentContext”
        //连接字符串。
        public StudentContext()
            : base("name=StudentContext")
        {
            Database.SetInitializer<DbContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }
        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。
        /// <summary>
        /// 班级表
        /// </summary>
        public DbSet<Class> Classes { get; set; }
        /// <summary>
        /// 班主任表
        /// </summary>
        public DbSet<ClassTeacherHasClass> ClassTeacherHasClasses { get; set; }
        /// <summary>
        /// 员工表
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
        /// <summary>
        /// 员工类型表
        /// </summary>
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        /// <summary>
        /// 考试表
        /// </summary>
        public DbSet<Exam> Exams { get; set; }
        /// <summary>
        /// 年级表
        /// </summary>
        public DbSet<Grade> Grades { get; set; }
        /// <summary>
        /// 成绩表
        /// </summary>
        public DbSet<Score> Scores { get; set; }
        /// <summary>
        /// 学生表
        /// </summary>
        public DbSet<Student> Students { get; set; }
        /// <summary>
        /// 档案表
        /// </summary>
        public DbSet<StudentDoc> studentDocs { get; set; }
        /// <summary>
        /// 毕业表
        /// </summary>
        public DbSet<StudentGraduteInfo> StudentGraduteInfos { get; set; }
        /// <summary>
        /// 作业提交表
        /// </summary>
        public DbSet<StudentJob> studentJobs { get; set; }
        /// <summary>
        /// 上机完成率
        /// </summary>
        public DbSet<StudentLabComplete> studentLabCompletes { get; set; }
        /// <summary>
        /// 亲属表
        /// </summary>
        public DbSet<StudentRelative> StudentRelatives { get; set; }
        /// <summary>
        /// 签到表
        /// </summary>
        public DbSet<StudentSigned> StudentSigneds { get; set; }
        /// <summary>
        /// 学生谈话提醒表
        /// </summary>
        public DbSet<StudentTalked> StudentTalkeds { get; set; }
        /// <summary>
        /// 科目表
        /// </summary>
        public DbSet<Subject> Subjects { get; set; }
        /// <summary>
        /// 系统设置表
        /// </summary>
        public DbSet<SysSetting> SysSettings { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}