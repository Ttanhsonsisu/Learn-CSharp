using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lap41
{
    public class StudentAction
    {
        List<Student> students;

        public StudentAction()
        {
            students = new List<Student> {
                new Student(){Id = 1, Name="name1" , Age = 20},
                new Student(){Id = 2, Name="name2" , Age = 25},
                new Student(){Id = 3, Name="name3" , Age = 18},
                new Student(){Id = 4, Name="name4" , Age = 30},
                new Student(){Id = 5, Name="name5" , Age = 24},
            };
        }

        #region
        public List<Student> GetStudent()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    st = item;
                    break;
                }
                
            }
            return st;
        }

        public List<Student> GetStudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in students)
            {
                if (item.Age >= x && item.Age <= y)
                { 
                    result.Add(item);
                }
            }
            return result;
        }
#endregion
    }
}

