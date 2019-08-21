namespace StudentSys.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsGraduation = c.String(),
                        Grade_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.Grade_Id)
                .Index(t => t.Grade_Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassTeacherHasClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeType_Id = c.Int(nullable: false),
                        Class_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .ForeignKey("dbo.EmployeeTypes", t => t.EmployeeType_Id)
                .Index(t => t.EmployeeType_Id)
                .Index(t => t.Class_Id);
            
            CreateTable(
                "dbo.EmployeeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        EmployeeType_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeTypes", t => t.EmployeeType_Id)
                .Index(t => t.EmployeeType_Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Class_Id = c.Int(nullable: false),
                        ExamTime = c.DateTime(nullable: false),
                        Subject_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .Index(t => t.Class_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.Grade_Id)
                .Index(t => t.Grade_Id);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                        ExamScore = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .Index(t => t.Subject_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sex = c.String(),
                        BornDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        QQ = c.String(),
                        Email = c.String(),
                        ImagePath = c.String(),
                        Class_Id = c.Int(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .Index(t => t.Class_Id);
            
            CreateTable(
                "dbo.StudentDocs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        Content = c.String(),
                        ImagePath = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.StudentGraduteInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Studnet_Id = c.Int(nullable: false),
                        CopyName = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InTime = c.DateTime(nullable: false),
                        Position = c.String(),
                        Address = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Studnet_Id)
                .Index(t => t.Studnet_Id);
            
            CreateTable(
                "dbo.StudentJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        Class_Id = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        State = c.String(),
                        Achievement = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Class_Id);
            
            CreateTable(
                "dbo.StudentLabCompletes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        Class_Id = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        CompletePercent = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Class_Id);
            
            CreateTable(
                "dbo.StudentRelatives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        Name = c.String(),
                        TypeName = c.String(),
                        Phone = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.StudentSigneds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        Class_Id = c.Int(nullable: false),
                        InTime = c.DateTime(),
                        OutTime = c.DateTime(),
                        SignedType = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Class_Id);
            
            CreateTable(
                "dbo.StudentTalkeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        Class_Id = c.Int(nullable: false),
                        Content = c.String(),
                        isDone = c.Boolean(nullable: false),
                        Result = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Class_Id);
            
            CreateTable(
                "dbo.SysSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobScore = c.Int(nullable: false),
                        CompleteScore = c.Int(nullable: false),
                        ExamScore = c.Int(nullable: false),
                        TriggerScore = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentTalkeds", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentTalkeds", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.StudentSigneds", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentSigneds", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.StudentRelatives", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentLabCompletes", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentLabCompletes", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.StudentJobs", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentJobs", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.StudentGraduteInfoes", "Studnet_Id", "dbo.Students");
            DropForeignKey("dbo.StudentDocs", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Scores", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Scores", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Exams", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Subjects", "Grade_Id", "dbo.Grades");
            DropForeignKey("dbo.Exams", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Employees", "EmployeeType_Id", "dbo.EmployeeTypes");
            DropForeignKey("dbo.ClassTeacherHasClasses", "EmployeeType_Id", "dbo.EmployeeTypes");
            DropForeignKey("dbo.ClassTeacherHasClasses", "Class_Id", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Grade_Id", "dbo.Grades");
            DropIndex("dbo.StudentTalkeds", new[] { "Class_Id" });
            DropIndex("dbo.StudentTalkeds", new[] { "Student_Id" });
            DropIndex("dbo.StudentSigneds", new[] { "Class_Id" });
            DropIndex("dbo.StudentSigneds", new[] { "Student_Id" });
            DropIndex("dbo.StudentRelatives", new[] { "Student_Id" });
            DropIndex("dbo.StudentLabCompletes", new[] { "Class_Id" });
            DropIndex("dbo.StudentLabCompletes", new[] { "Student_Id" });
            DropIndex("dbo.StudentJobs", new[] { "Class_Id" });
            DropIndex("dbo.StudentJobs", new[] { "Student_Id" });
            DropIndex("dbo.StudentGraduteInfoes", new[] { "Studnet_Id" });
            DropIndex("dbo.StudentDocs", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "Class_Id" });
            DropIndex("dbo.Scores", new[] { "Student_Id" });
            DropIndex("dbo.Scores", new[] { "Subject_Id" });
            DropIndex("dbo.Subjects", new[] { "Grade_Id" });
            DropIndex("dbo.Exams", new[] { "Subject_Id" });
            DropIndex("dbo.Exams", new[] { "Class_Id" });
            DropIndex("dbo.Employees", new[] { "EmployeeType_Id" });
            DropIndex("dbo.ClassTeacherHasClasses", new[] { "Class_Id" });
            DropIndex("dbo.ClassTeacherHasClasses", new[] { "EmployeeType_Id" });
            DropIndex("dbo.Classes", new[] { "Grade_Id" });
            DropTable("dbo.SysSettings");
            DropTable("dbo.StudentTalkeds");
            DropTable("dbo.StudentSigneds");
            DropTable("dbo.StudentRelatives");
            DropTable("dbo.StudentLabCompletes");
            DropTable("dbo.StudentJobs");
            DropTable("dbo.StudentGraduteInfoes");
            DropTable("dbo.StudentDocs");
            DropTable("dbo.Students");
            DropTable("dbo.Scores");
            DropTable("dbo.Subjects");
            DropTable("dbo.Exams");
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeTypes");
            DropTable("dbo.ClassTeacherHasClasses");
            DropTable("dbo.Grades");
            DropTable("dbo.Classes");
        }
    }
}
