using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_first_task
{
    internal class Group
    {
        public string GroupName { get; set; }
        public int Limit { get; set; }
        public Student[] GroupMembers;


        public void AddStudent(Student student)
        {
            if(Limit >= GroupMembers.Length)
            {
                Array.Resize(ref GroupMembers, GroupMembers.Length + 1);
                GroupMembers[GroupMembers.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Qrupda yer yoxdur!");
            }
        }
        public void GetStudents()
        {
            foreach(Student student in GroupMembers)
            {
                Console.WriteLine($@"telebe {student.Id} --->
Ad : {student.Name}
Soyad : {student.Surname}
------------------------------------------------------------");
            }
        }
    }
}
