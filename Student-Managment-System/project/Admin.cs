using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public class Admin
    {
        //username and password of admin in function log in 

        WindowsFormsApplication1.courses css = new courses();

        WindowsFormsApplication1.student tmp = new student();
        public string s1 = "";
        public string s2 = "";
        public string s3 = "";
        public string s4 = "";
        public string s5 = "";
        public string s6 = "";
        public int code_in = 0;
        public int student_founder = 0;
        public int course_edit = 0;
        public int course_valid = 0;
        public List<string> courses_of_stu = new List<string>();
        public string view_students(string co_code)
        {
           
                tmp.loadfile();
                tmp.string_edit();
               
            
            Console.Write("Enter the Course code :");
            string code;
            code = co_code;
            string s = "";
            for (int i = 0; i < tmp.objdata.Count; i++)
            {
                if (tmp.objdata[i].course_prog.Length > 6)
                {
                    List<string> cpl = new List<string>(); // courses progressed list.

                    string spl = "";


                    int count = -1;
                    while (true)
                    {
                        count++;
                        if (tmp.objdata[i].course_prog[count] == ' ') { cpl.Add(spl); spl = ""; continue; }
                        spl += tmp.objdata[i].course_prog[count];
                        if (count == tmp.objdata[i].course_prog.Length - 1) { cpl.Add(spl); break; }
                    }
                   
                    for (int k = 0; k < cpl.Count; k++)
                    {
                        if (code == cpl[k])
                        {
                            s += tmp.objdata[i].name;
                            s += "     " + tmp.objdata[i].Id;
                            s += "\n";
                        }
                    }
                }
                else if (code == tmp.objdata[i].course_prog)
                {
                    s += tmp.objdata[i].name;
                    s += "     " + tmp.objdata[i].Id;
                    s += "\n";
                }


            }
            return s;
        }

        public void add_course(string CourseName, string CourseCode, string CourseStudents, string CoursePrereq, string CourseHours)
        {
         
                css.loadfile();
                css.string_edit();
               
            
            Console.Write("Enter the course name :");
            css.course_name = CourseName;

            Console.Write("Enter the course code :");
            css.course_code = CourseCode;

            Console.Write("Enter the number of students avalible in the course :");
            css.max_num_of_students = CourseStudents;

            Console.Write("Enter the number of students in the course :");
            css.num_of_students_in_course = "-";


            Console.Write("Enter the course pre_required courses for this course :");
            css.pre_required_courses = CoursePrereq;


            Console.Write("Enter the number of credit hours for the course :");
            css.credit_hours = CourseHours;
            css.space = "-------------------------------------------------";

            css.coursesdata.Add(css);
            css.WriteCourses();

        }

        public void Add_new_student(string StudentName, string StudentPass, string FinishedCourses, string AcademicYear)
        {
           
                tmp.loadfile();
                tmp.string_edit();
                
            
            Console.WriteLine("Enter student's name: ");
            tmp.name = StudentName;

            //student id
            int idindex = tmp.objdata.Count;
            tmp.student_Int_ID = (tmp.objdata[idindex - 1].student_Int_ID) + 1;

            Console.WriteLine("Enter student's Pass: ");
            tmp.pass = StudentPass;

            Console.WriteLine("Enter student's Finished Courses: ");
            tmp.finished_courses = FinishedCourses;

            Console.WriteLine("Enter student's Course program: ");
            tmp.course_prog = "-";

            Console.WriteLine("Enter student's Academic year: ");
            tmp.acadimc_year = AcademicYear;

            tmp.space = "---------------------------------------";


            tmp.objdata.Add(tmp);

            tmp.WriteStudents();


        }


        public int edit_course_data(string CourseCode)
        {
            if (course_edit == 0)
            {
                css.loadfile();
                css.string_edit();
                course_edit++;
            }
            
            string code;

            Console.Write("Please Enter cours's code :");
            code = CourseCode;
            for (int i = 0; i < css.coursesdata.Count; i++)
            {
                if (code == css.coursesdata[i].course_code)
                {
                    course_valid++;
                    s1 += "course name        :" + css.coursesdata[i].course_name;
                    s2 += "course code        :" + css.coursesdata[i].course_code;
                    s3 += "max num of students:" + css.coursesdata[i].max_num_of_students;
                    s4 += "students in course :" + css.coursesdata[i].num_of_students_in_course;
                    s5 += "prerequired course :" + css.coursesdata[i].pre_required_courses;
                    s6 += "credit hours       :" + css.coursesdata[i].credit_hours;
                    return i;

                }
              

            }
            return 0;
        }
        public void edit_course(int i, courses d)
        {
            if (d.course_name != " ")
                css.coursesdata[i].course_name = d.course_name;
            if (d.max_num_of_students != " ")
                css.coursesdata[i].max_num_of_students = d.max_num_of_students;
            if (d.pre_required_courses != " ")
                css.coursesdata[i].pre_required_courses = d.pre_required_courses;
            if (d.credit_hours != " ")
                css.coursesdata[i].credit_hours = d.credit_hours;
            css.WriteCourses();
        }


        public List<Tuple<string,string>>courses_of_a_student(string student_nam)
        {
            List<Tuple<string, string>>co_list = new List<Tuple<string, string>>();
            string tmp_stu_name;
            string courses_prog_tmp = ""; //in progress
            List<string> stu_courses = new List<string>(); //finished courses
            int counter = -1;
            string s = "";
            
                tmp.loadfile();
                tmp.string_edit();
                
          
                css.loadfile();
                css.string_edit();
                
            

            Console.WriteLine("Enter a student name to view his courses: ");

            tmp_stu_name = student_nam;

            for (int i = 0; i < tmp.objdata.Count; i++)
            {
                if (tmp.objdata[i].name == tmp_stu_name)
                {

                    student_founder++;
                   co_list=tmp.ViewMyCourses(i);
                   break;
                    }


                }

            
            List<string> stu_courses_in_progress = new List<string>(); //finished courses
            counter = -1;
            s = "";
            for (int i = 0; i < tmp.objdata.Count; i++)
            {
                if (tmp.objdata[i].name == tmp_stu_name)
                {
                    student_founder++;
                    while (true)
                    {
                        counter++;
                        if (tmp.objdata[i].finished_courses[counter] == ' ')
                        {
                            stu_courses_in_progress.Add(s);
                            s = "";
                            continue;
                        }

                        s += tmp.objdata[i].finished_courses[counter];

                        if (counter == tmp.objdata[i].finished_courses.Length - 1)
                        {
                            stu_courses_in_progress.Add(s);
                            break;
                        }
                    }

                    break;

                }

            }
            string courses = "";
            for (int k = 0; k < css.coursesdata.Count; k++)
            {
               
                for (int j = 0; j < stu_courses.Count; j++)
                {
                    
                    if (stu_courses[j] == css.coursesdata[k].course_code)
                    {


                    }


                }
            }

            for (int k = 0; k < css.coursesdata.Count; k++)
            {
                
                for (int j = 0; j < stu_courses_in_progress.Count; j++)
                {
                    
                    if (stu_courses_in_progress[j] == css.coursesdata[k].course_code)
                    {


                    }


                }
            }
            return co_list;

        }



    }
}






