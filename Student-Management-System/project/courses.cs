using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;
using System.IO;

namespace WindowsFormsApplication1
{
    public class courses
    {
        public List<courses> coursesdata = new List<courses>();
        public string course_name;
        public string course_code;
        public string max_num_of_students;
        public int maxi;
        public int numstud;
        public string num_of_students_in_course;
        public string pre_required_courses;
        public string credit_hours;
        public string space;



        public void loadfile()
        {
            StreamReader reader1 = new StreamReader("courses.txt");

            while (!reader1.EndOfStream)//while l file y5las
            {
                courses temp = new courses();
                temp.course_name = reader1.ReadLine();

                temp.course_code = reader1.ReadLine();

                temp.max_num_of_students = reader1.ReadLine();

                temp.num_of_students_in_course = reader1.ReadLine();

                temp.pre_required_courses = reader1.ReadLine();

                temp.credit_hours = reader1.ReadLine();

                temp.space = reader1.ReadLine();

                coursesdata.Add(temp);

            }
            reader1.Close();


        }

        public void string_edit()
        {
            for (int i = 0; i < coursesdata.Count; i++)
            {
                string s1 = coursesdata[i].course_name;
                string s2 = coursesdata[i].course_code;
                string s3 = coursesdata[i].max_num_of_students;
                string s4 = coursesdata[i].num_of_students_in_course;
                string s5 = coursesdata[i].pre_required_courses;
                string s6 = coursesdata[i].credit_hours;
                coursesdata[i].course_name = s1.Substring(21, (s1.Length - 21));
                coursesdata[i].course_code = s2.Substring(21, (s2.Length - 21));
                coursesdata[i].max_num_of_students = s3.Substring(21, (s3.Length - 21));
                coursesdata[i].num_of_students_in_course = s4.Substring(21, (s4.Length - 21));
                coursesdata[i].pre_required_courses = s5.Substring(21, (s5.Length - 21));
                coursesdata[i].credit_hours = s6.Substring(21, (s6.Length - 21));
                coursesdata[i].maxi = Int32.Parse(coursesdata[i].max_num_of_students);
                coursesdata[i].numstud = Int32.Parse(coursesdata[i].num_of_students_in_course);

            }
        }

        public void display()
        {
            for (int i = 0; i < coursesdata.Count; i++)
            {
                Console.WriteLine(coursesdata[i].course_name);
                Console.WriteLine(coursesdata[i].course_code);
                Console.WriteLine(coursesdata[i].max_num_of_students);
                Console.WriteLine(coursesdata[i].num_of_students_in_course);
                Console.WriteLine(coursesdata[i].pre_required_courses);
                Console.WriteLine(coursesdata[i].credit_hours);
                Console.WriteLine(coursesdata[i].space);

            }


        }

        public void WriteCourses()
        {

            StreamWriter write1 = new StreamWriter("courses.txt");
            for (int i = 0; i < coursesdata.Count; i++)
            {



                write1.WriteLine("course name        : " + coursesdata[i].course_name);
                write1.WriteLine("course code        : " + coursesdata[i].course_code);
                write1.WriteLine("max num of students: " + coursesdata[i].max_num_of_students);
                write1.WriteLine("students in course : " + coursesdata[i].numstud);
                write1.WriteLine("prerequired course : " + coursesdata[i].pre_required_courses);
                write1.WriteLine("credit hours       : " + coursesdata[i].credit_hours);
                write1.WriteLine(coursesdata[i].space);


            }
            write1.Close();
        }

    }
}
