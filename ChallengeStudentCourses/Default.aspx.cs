using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            resultLabel.Text = "";

            List<Course> courses = new List<Course>()
            {
                new Course() { CourseId = 101, Name = "Kindergarten: Everything in Life You Need to Know",
                Students = new List<Student>() { new Student() { StudentId = 1, Name = "Pihmp N. MacDaddie" }, new Student() { StudentId = 2, Name = "Boatie McBoatface" } } },
                { new Course() { CourseId = 102, Name = "Elementary: Everything Beyond This Is Optional",
                Students = new List<Student>() { new Student() { StudentId = 2, Name = "Boatie McBoatface" }, new Student() { StudentId = 3, Name = "Steve Gates" } } } },
                { new Course() { CourseId = 103, Name = "High School: Shmooze Your Way to College Admissions",
                Students = new List<Student>() { new Student() { StudentId = 3, Name = "Steve Gates" }, new Student() { StudentId = 4, Name = "Bill Jobs" } } } }
            };

            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("{0}: {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br>&nbsp&nbsp {0}: {1}", student.StudentId, student.Name);
                }
                resultLabel.Text += "<br><br>";
            }

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            resultLabel.Text = "";
            
            Course course1 = new Course
            {
                CourseId = 101,
                Name = "Kindergarten: Everything in Life You Need to Know"
            };

            Course course2 = new Course
            {
                CourseId = 102,
                Name = "Elementary: Everything Beyond This Is Optional"
            };

            Course course3 = new Course
            {
                CourseId = 103,
                Name = "High School: Shmooze Your Way to College Admissions"
            };

            
            Student student1 = new Student
            {
                Name = "Pihmp N. MacDaddie",
                StudentId = 111,
                Courses = new List<Course>() { course1, course2, course3 }
            };
            Student student2 = new Student
            {
                Name = "Boatie McBoatface",
                StudentId = 222,
                Courses = new List<Course>() { course2, course3 }
            };
            Student student3 = new Student
            {
                Name = "Steve Gates",
                StudentId = 333,
                Courses = new List<Course>() { course1, course3 }
            };
            Student student4 = new Student
            {
                Name = "Bill Jobs",
                StudentId = 444,
                Courses = new List<Course>() { course2 }
            };
            

            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(student1.StudentId, student1);
            students.Add(student2.StudentId, student2);
            students.Add(student3.StudentId, student3);
            students.Add(student4.StudentId, student4);

            for (int i = 0; i < students.Count; i++)
            {
                resultLabel.Text += String.Format("Student ID: " + students.ElementAt(i).Key + "<br>"
                    + "Student Name: " + students.ElementAt(i).Value.Name + "<br>Courses Enrolled:<br>");

                int j = 0;

                while (j < students.ElementAt(i).Value.Courses.Count)
                {
                    resultLabel.Text += String.Format("&nbsp&nbsp {0}. " + students.ElementAt(i).Value.Courses.ElementAt(j).Name 
                        + " (Course ID: {1})<br>", j+1, students.ElementAt(i).Value.Courses.ElementAt(j).CourseId);
                    j++;
                }
                
                resultLabel.Text += "<br><br>";
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            resultLabel.Text = "";

            Course course1 = new Course
            {
                CourseId = 101,
                Name = "Kindergarten: Everything in Life You Need to Know",
            };

            Course course2 = new Course
            {
                CourseId = 102,
                Name = "Elementary: Everything Beyond This Is Optional",
            };

            Course course3 = new Course
            {
                CourseId = 103,
                Name = "High School: Shmooze Your Way to College Admissions"
            };

            Grade stu111101 = new Grade
            {
                StudentId = 111,
                CourseID = 101,
                finalGrade = 90
            };

            Grade stu111102 = new Grade
            {
                StudentId = 111,
                CourseID = 102,
                finalGrade = 93
            };

            Grade stu111103 = new Grade
            {
                StudentId = 111,
                CourseID = 103,
                finalGrade = 87
            };

            Grade stu222102 = new Grade
            {
                StudentId = 222,
                CourseID = 102,
                finalGrade = 89
            };

            Grade stu222103 = new Grade
            {
                StudentId = 222,
                CourseID = 103,
                finalGrade = 95
            };

            Grade stu333101 = new Grade
            {
                StudentId = 333,
                CourseID = 101,
                finalGrade = 78
            };

            Grade stu333103 = new Grade
            {
                StudentId = 333,
                CourseID = 103,
                finalGrade = 66
            };

            Grade stu444102 = new Grade
            {
                StudentId = 444,
                CourseID = 102,
                finalGrade = 55
            };


            Student student1 = new Student
            {
                Name = "Pihmp N. MacDaddie",
                StudentId = 111,
                Courses = new List<Course>() { course1, course2, course3 },
                Grades = new List<Grade>() { stu111101, stu111102, stu111103 }
            };
            Student student2 = new Student
            {
                Name = "Boatie McBoatface",
                StudentId = 222,
                Courses = new List<Course>() { course2, course3 },
                Grades = new List<Grade>() { stu222102, stu222103 }
            };
            Student student3 = new Student
            {
                Name = "Steve Gates",
                StudentId = 333,
                Courses = new List<Course>() { course1, course3 },
                Grades = new List<Grade>() { stu333101, stu333103 }
            };
            Student student4 = new Student
            {
                Name = "Bill Jobs",
                StudentId = 444,
                Courses = new List<Course>() { course2 },
                Grades = new List<Grade>() { stu444102 }
            };

            

            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(student1.StudentId, student1);
            students.Add(student2.StudentId, student2);
            students.Add(student3.StudentId, student3);
            students.Add(student4.StudentId, student4);

            for (int i = 0; i < students.Count; i++)
            {
                resultLabel.Text += String.Format("Student ID: " + students.ElementAt(i).Key + "<br>"
                    + "Student Name: " + students.ElementAt(i).Value.Name + "<br>Courses Enrolled:<br>");

                for (int j = 0; j < students.ElementAt(i).Value.Courses.Count; j++)
                {
                    resultLabel.Text += String.Format("&nbsp&nbsp {0}. " + students.ElementAt(i).Value.Courses.ElementAt(j).Name
                        + " (Course ID: {1})<br>", j + 1, students.ElementAt(i).Value.Courses.ElementAt(j).CourseId);
                }

                for (int k = 0; k < students.ElementAt(i).Value.Grades.Count; k++)
                {
                    resultLabel.Text += String.Format("&nbsp&nbsp Course {0} Finale Grade: {1}.<br>", 
                        students.ElementAt(i).Value.Courses.ElementAt(k).CourseId, 
                        students.ElementAt(i).Value.Grades.ElementAt(k).finalGrade);
                }

                resultLabel.Text += "<br><br>";
            }
        }
    }
}