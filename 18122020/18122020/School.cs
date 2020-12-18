using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18122020
{
    class School
    {
        public string Name { get; set; }
        public Group[] Groups { get; set; }
        public School()
        {
            Groups = new Group[0];
        }
        public void AddGroup(Group group)
        {
            bool isExistGroup = false;
            foreach (Group group1 in this.Groups)
            {
                if (group1.Name == group.Name)
                {
                    isExistGroup = true;
                }
            }
            if (!isExistGroup)
            {
                var arr = this.Groups;
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = group;
                this.Groups = arr;
            }
            else
            {
                Console.WriteLine("Bu adli qrup artiq movcuddur");
            }
           
        }
        public void GetAllClass()
        {
            foreach (Group group in this.Groups)
            {
                Console.WriteLine(group.Name);
            }
        }
        public void GetAllStudentsSchool()
        {
            foreach (Group group in this.Groups)
            {
                foreach (Student student in group.Students)
                {
                    Console.WriteLine($"Telebenin adi :{student.FullName} \n Telebenin yashi:{student.Age}");
                }
            }
        }

    }
}
