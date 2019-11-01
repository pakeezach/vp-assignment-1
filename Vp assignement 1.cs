using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp15
{
    class Student
    {

        public string Id, Name, Semester, CGPA  , Department , uni;
        public int n;

       
            public static void Add(Student s1)
             {
            
            StreamWriter sw = new StreamWriter("C:\\Users\\hp hai\\Desktop\\studentFile.txt");
            Console.WriteLine("Enter no of students:");
            s1.n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < s1.n; i++)
            {
                sw.WriteLine("Student Name:");
                Console.WriteLine("Enter the name of Student:");
                s1.Name = Console.ReadLine();
                sw.WriteLine(s1.Name);
                sw.WriteLine(" ");

                sw.WriteLine("University:");
                Console.WriteLine("Enter university:");
                s1.uni = Console.ReadLine();
                sw.WriteLine(s1.uni);
                sw.WriteLine(" ");

                sw.WriteLine("Student  ID:");
                Console.WriteLine("Enter ID:");
                s1.Id = Console.ReadLine();
                sw.WriteLine(s1.Id);
                sw.WriteLine(" ");

                sw.WriteLine("Semester:");
                Console.WriteLine("Enter semester:");
               s1.Semester= Console.ReadLine();
                sw.WriteLine(s1.Semester);
                sw.WriteLine(" ");

                sw.WriteLine("Student CGPA:");
                Console.WriteLine("Enter CGPA:");
                s1.CGPA = Console.ReadLine();
                sw.WriteLine(" "); sw.WriteLine(s1.CGPA);


                sw.WriteLine("Department:");
                Console.WriteLine("Enter department:");
                s1.Department = Console.ReadLine();
                sw.WriteLine(s1.Department)
;            }
            sw.Flush();

            sw.Close();
        }

        public static void Search(Student s)
        {

            string line;
            int ch, counter = 0;
            Console.WriteLine("Search by ID:");
            Console.WriteLine("Search by Name:");

            Console.WriteLine("Enter your choice:");
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                string[] words = File.ReadAllText("C:\\Users\\hp hai\\Desktop\\studentFile.txt").Split(' ');
                string std_Id;
                Console.WriteLine("Enter ID:");
                std_Id = Console.ReadLine();
                bool condition = false;
                for (int i = 0; i < words.Length; i++)
                {

                    if (words[i].Contains(std_Id) == true)
                    {
                        Console.WriteLine(words[i] + " ");
                        condition = true;
                        break;
                    }
                    else
                    {
                        condition = false;
                        break;

                    }

                }
            }
            else if (ch == 2)
            {
                string[] words = File.ReadAllText("C:\\Users\\hp hai\\Desktop\\studentFile.txt").Split(' ');
                string std_Name;
                Console.WriteLine("Enter Name:");
                std_Name = Console.ReadLine();
                bool condition = false;
                for (int i = 0; i < words.Length; i++)
                {

                    if (words[i].Contains(std_Name) == true)
                    {
                        Console.WriteLine(words[i] + " ");
                        condition = true;
                        break;

                    }
                    else
                    {
                        condition = false;
                        break;

                    }

                }

            }

            else if (ch == 3)
            {
                string[] words = File.ReadAllText("C:\\Users\\hp hai\\Desktop\\studentFile.txt").Split(' ');
                foreach (string word in words)
                    Console.WriteLine(word);


            }
        }
        public static void Attendance(Student s)
        {
            string[] words = File.ReadAllText(@"C:\\Users\\hp hai\\Desktop\\studentFile.txt").Split(' ');
            foreach (string word in words)
                Console.WriteLine(word);
            Console.WriteLine("Enter Number of Students to Mark Attendance:");
             s.n = Convert.ToInt32(Console.ReadLine());
            StreamWriter SW = new StreamWriter(@"C:\\Users\\hp hai\\Desktop\\plz.txt");
            for (int i = 0; i < s.n; i++)
            {
                
                SW.WriteLine("Attendance:");
                Console.WriteLine("Present Student ID:");
                string Id = Console.ReadLine();
                Console.WriteLine("Present Student Name:");
                s.Name = Console.ReadLine();
                SW.WriteLine("Present Students:");
                SW.WriteLine(s.Id);
                SW.WriteLine(s.Name);
                SW.WriteLine(" ");
                Console.WriteLine("Absent Student ID:");
                s.Id = Console.ReadLine();
                Console.WriteLine("Absent Student Name:");
                s.Name = Console.ReadLine();
                SW.WriteLine("Absent Students:");
                SW.WriteLine(s.Id);
                SW.WriteLine(s.Name);
                SW.WriteLine(" ");
            }
            SW.Flush();
            SW.Close();

        }
        public static void viewAttendance(Student prof)
        {
            string[] words = File.ReadAllText(@"C:\Users\hp hai\Desktop\plz.txt").Split(' ');
            foreach (string word in words)
                Console.WriteLine(word);
        }


        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("press 1 for create student profile:");
            Console.WriteLine("press 2 for search student:");
            Console.WriteLine("press 3 for delete student record:");
            Console.WriteLine("press 4 for list top 3 student of class:");
            Console.WriteLine("press 5 Mark student attendance:");
            Console.WriteLine("press 6 view student attendance :");
            Console.WriteLine("ENTER CHOICE :");
            choice = Convert.ToInt32(Console.ReadLine());
           Student s = new Student();

            if (choice == 1)
            {
                Add(s);
            }
            else if (choice == 2)
            {
                Search(s);
            }
            else if (choice == 5)
            {
                Attendance(s);
            }
            else if (choice == 6
                
                )
            {
                viewAttendance(s);
            }

            Console.Read();
        }

    }
}
