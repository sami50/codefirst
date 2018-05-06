namespace WebApplication1.Migrations.Test
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        lectureID_LectureID = c.Int(),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.lectures", t => t.lectureID_LectureID)
                .Index(t => t.lectureID_LectureID);
            
            CreateTable(
                "dbo.lectures",
                c => new
                    {
                        LectureID = c.Int(nullable: false, identity: true),
                        LectureName = c.String(),
                    })
                .PrimaryKey(t => t.LectureID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.studentID);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_studentID = c.Int(nullable: false),
                        Course_CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_studentID, t.Course_CourseID })
                .ForeignKey("dbo.Students", t => t.Student_studentID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseID, cascadeDelete: true)
                .Index(t => t.Student_studentID)
                .Index(t => t.Course_CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", "Course_CourseID", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_studentID", "dbo.Students");
            DropForeignKey("dbo.Courses", "lectureID_LectureID", "dbo.lectures");
            DropIndex("dbo.StudentCourses", new[] { "Course_CourseID" });
            DropIndex("dbo.StudentCourses", new[] { "Student_studentID" });
            DropIndex("dbo.Courses", new[] { "lectureID_LectureID" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Students");
            DropTable("dbo.lectures");
            DropTable("dbo.Courses");
        }
    }
}
