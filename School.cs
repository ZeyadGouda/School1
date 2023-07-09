using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class School
{
    public List<Student> Students;
    public List<Student> StudentsSortedByRank;
    public School()
    {
        Students = new List<Student>();
        StudentsSortedByRank = new List<Student>();
    }

    public void UpdateRanks(Student ObjectStudent)
    {
        List<Student> temp = new List<Student>();
        //if list is empty, add student and  set rank = 1
        if (StudentsSortedByRank.Count == 0)
        {
            ObjectStudent.Rank = 1;
            StudentsSortedByRank.Add(ObjectStudent);
            return;
        }
        int x = 0;
       // int y = StudentsSortedByRank.Count;
        foreach (Student s in StudentsSortedByRank)
        {
            if (ObjectStudent.degree >= s.degree)
            {
                temp.Add(ObjectStudent);

                foreach (Student remaining in StudentsSortedByRank.Skip(x))
                {
                    remaining.Rank++;
                    temp.Add(remaining);
                }

                break;

            }
            x++;
            
        }
        ObjectStudent.Rank = StudentsSortedByRank.Count + 1;
        StudentsSortedByRank.Add(ObjectStudent);
        StudentsSortedByRank = temp;

    }
}
