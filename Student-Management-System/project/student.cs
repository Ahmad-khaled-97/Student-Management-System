using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public class student
    {
        public int course_ind;
        WindowsFormsApplication1.courses SC = new courses();
        public List<student> objdata = new List<student>();
        public string name;
        public string Id;
        public string pass;
        public string finished_courses;
        public string course_prog;

        public string acadimc_year;
        public string space;
        public int student_Int_ID;
        public int edit_num= 0;
        private int a = 0;
        private string rs = "";
        public void loadfile()
        {
            StreamReader reader = new StreamReader("students.txt");

            while (!reader.EndOfStream)//while l file y5las
            {
                student temp = new student();
                temp.name = reader.ReadLine();

                temp.Id = reader.ReadLine();

                temp.pass = reader.ReadLine();

                temp.finished_courses = reader.ReadLine();

                temp.course_prog = reader.ReadLine();


                temp.acadimc_year = reader.ReadLine();

                temp.space = reader.ReadLine();

                objdata.Add(temp);

            }
            reader.Close();


        }

        public void string_edit()
        {
            for (int i = 0; i < objdata.Count; i++)
            {
                string s1 = objdata[i].name;
                string s2 = objdata[i].Id;
                string s3 = objdata[i].pass;
                string s4 = objdata[i].finished_courses;
                string s5 = objdata[i].course_prog;
                string s6 = objdata[i].acadimc_year;
                objdata[i].name = s1.Substring(15, (s1.Length - 15));
                objdata[i].Id = s2.Substring(15, (s2.Length - 15));
                objdata[i].pass = s3.Substring(15, (s3.Length - 15));
                objdata[i].finished_courses = s4.Substring(15, (s4.Length - 15));
                objdata[i].course_prog = s5.Substring(15, (s5.Length - 15));
                objdata[i].acadimc_year = s6.Substring(15, (s6.Length - 15));
                objdata[i].student_Int_ID = Int32.Parse(objdata[i].Id);

            }
        }

        public void dis()
        {
            Console.WriteLine(name);
            Console.WriteLine(Id);
            Console.WriteLine(pass);
            Console.WriteLine(finished_courses);
            Console.WriteLine(course_prog);
            Console.WriteLine(acadimc_year);
            Console.WriteLine(space);
        }

        public void display()
        {
            for (int i = 0; i < objdata.Count; i++)
            {
                objdata[i].dis();
            }
        }

        public bool login(string sname, string spass, ref int sindex)
        {
            Console.WriteLine("Enter your name and password :");
            string studentName = sname;

            string studentPassword = spass;
            for (int i = 0; i < objdata.Count; i++)
            {
                if (studentName == objdata[i].name)
                {
                    if (studentPassword == objdata[i].pass)
                    {
                        sindex = i;

                        return true;
                    }

                }

            }

            return false;


        }

        public List<Tuple<string, string>> ViewMyCourses(int i) //sent i as a parameter to minimize time as we don't have to loop on the array.
        {
            List<string> fcl = new List<string>(); //finished courses list.
            string tempsting1 = objdata[i].course_prog;
            string s = "";
            List<Tuple<string, string>> rlist = new List<Tuple<string, string>>();
            
            if (edit_num == 0)
            {
                SC.loadfile();
                SC.string_edit();
                edit_num++;
            }
            int counter = -1;
            while (true)
            {
                counter++;
                if (objdata[i].finished_courses[counter] == ' ') { fcl.Add(s); s = ""; continue; }
                s += objdata[i].finished_courses[counter];
                if (counter == objdata[i].finished_courses.Length - 1) { fcl.Add(s); break; }
            }
            List<string> cpl = new List<string>(); // courses progressed list.

            string spl = "";


            int count = -1;
            while (true)
            {
                count++;
                if (objdata[i].course_prog[count] == ' ') { cpl.Add(spl); spl = ""; continue; }
                spl += objdata[i].course_prog[count];
                if (count == objdata[i].course_prog.Length - 1) { cpl.Add(spl); break; }
            }


            for (int k = 0; k < SC.coursesdata.Count; k++)
            {
                for (int j = 0; j < fcl.Count; j++)
                {
                    if (fcl[j] == SC.coursesdata[k].course_code)
                    {

                        rlist.Add(new Tuple<string, string>(SC.coursesdata[k].course_name, SC.coursesdata[k].course_code));  //Console.Write(SC.coursesdata[k].course_name + "  ");



                    }
                }


            } for (int k = 0; k < SC.coursesdata.Count; k++)
            {
                for (int j = 0; j < cpl.Count; j++)
                {
                    if (cpl[j] == SC.coursesdata[k].course_code)
                    {

                        rlist.Add(new Tuple<string, string>(SC.coursesdata[k].course_name, SC.coursesdata[k].course_code));  //Console.Write(SC.coursesdata[k].course_name + "  ");



                    }
                }





            }





            return rlist;



        }

        public void EditDataByStudent(int i, string namee, string password)
        {
            if (namee != "0" && password == "0")
            {
                objdata[i].name = namee;
            }
            else if (password != "0" && namee == "0")
            {
                objdata[i].pass = password;
            }
            else if (namee != "0" && password != "0")
            {
                objdata[i].name = namee;
                objdata[i].pass = password;
            }
            WriteStudents();

        }

        public List<Tuple<string, string>> list_of_available(int i)
        {
            List<Tuple<string, string>> rl = new List<Tuple<string, string>>();
            rl = ViewMyCourses(i);



            List<Tuple<string, string>> av_list = new List<Tuple<string, string>>();
            for (int k = 0; k < SC.coursesdata.Count; k++)
            {
                for (int j = 0; j < rl.Count; j++)
                {
                    if ((rl[j].Item2 == SC.coursesdata[k].pre_required_courses && SC.coursesdata[k].maxi > SC.coursesdata[k].numstud))
                    {

                        av_list.Add(new Tuple<string, string>(SC.coursesdata[k].course_name, SC.coursesdata[k].course_code));

                    }


                }
            }
            for (int k = 0; k < SC.coursesdata.Count; k++)
            {

                if (SC.coursesdata[k].pre_required_courses == "-" && SC.coursesdata[k].maxi > SC.coursesdata[k].numstud)
                {

                    av_list.Add(new Tuple<string, string>(SC.coursesdata[k].course_name, SC.coursesdata[k].course_code));

                }



            }

            for (int j = 0; j < rl.Count; j++)
            {
                for (int l = 0; l < av_list.Count; l++)
                {
                    if (rl[j].Item2 == av_list[l].Item2)
                    {
                        av_list.RemoveAt(l);
                    }
                }
            }

            return av_list;
        }

        public string specific_course(int i, string cc,ref bool b)
        {
            string course_codee;
            course_codee = cc;
            string course = " ";
            for (int m = 0; m < SC.coursesdata.Count; m++)
            {
                if (course_codee == SC.coursesdata[m].course_code)
                {

                    course += "course name        :" + SC.coursesdata[m].course_name + "\n";
                    course += "course code        :" + SC.coursesdata[m].course_code + "\n";
                    course += "max num of students:" + SC.coursesdata[m].max_num_of_students + "\n";
                    course += "students in course :" + SC.coursesdata[m].num_of_students_in_course + "\n";
                    course += "prerequired course :" + SC.coursesdata[m].pre_required_courses + "\n";
                    course += "credit hours       :" + SC.coursesdata[m].credit_hours + "\n";

                    course_ind = m;
                    b = true;
                }
            }
            return course;
        }

        public void register(int m, int i)
        {
            SC.coursesdata[m].numstud++;
            objdata[i].course_prog += " " + SC.coursesdata[m].course_code;
            SC.WriteCourses();
            WriteStudents();
        }

        private string rf(string u)
        {


            for (int o = 0; o < SC.coursesdata.Count; o++)
            {
                if (SC.coursesdata[o].course_code == u)
                {

                    if (SC.coursesdata[o].pre_required_courses == "-") return rs += SC.coursesdata[o].course_name + " ";

                    else
                    {
                        a = o;

                    }
                }

            }
            return rs += SC.coursesdata[a].course_name + " " + rf(SC.coursesdata[a].pre_required_courses) + " ";
        }
        public string view_details_of_specefic_course(string ccodee)
        {
            string rstring = "";
            if (edit_num == 0)
            {
                SC.loadfile();
                SC.string_edit();
                edit_num++;
            }
            
            
            
            for (int i = 0; i < SC.coursesdata.Count; i++)
            {
                if (ccodee == SC.coursesdata[i].course_code)
                {
                    rstring += "course name        :" + SC.coursesdata[i].course_name + "\n";
                    rstring += "course code        :" + SC.coursesdata[i].course_code + "\n";
                    rstring += "max num of students:" + SC.coursesdata[i].max_num_of_students + "\n";
                    rstring += "students in course :" + SC.coursesdata[i].num_of_students_in_course + "\n";
                    rstring += "credit hours       :" + SC.coursesdata[i].credit_hours + "\n";

                    if (SC.coursesdata[i].pre_required_courses != "-")
                    {
                        rf(SC.coursesdata[i].pre_required_courses);
                        rstring += "Pre-required        :"+ rs;
                    }
                    else
                    {
                        rstring += "Pre-required        :"+SC.coursesdata[i].pre_required_courses;
                    }
                   
                }
                
                
            }
            rs = "";
            return rstring;
        }

        public void WriteStudents()
        {
            StreamWriter write = new StreamWriter("students.txt");

            for (int i = 0; i < objdata.Count; i++)
            {
                write.WriteLine("Name         : " + objdata[i].name);
                write.WriteLine("ID           : " + objdata[i].student_Int_ID);
                write.WriteLine("Password     : " + objdata[i].pass);
                write.WriteLine("finished Crs : " + objdata[i].finished_courses);
                write.WriteLine("course Prog  : " + objdata[i].course_prog);
                write.WriteLine("Academic Year: " + objdata[i].acadimc_year);
                write.WriteLine(objdata[i].space);
            }
            write.Close();
        }

    }
}



