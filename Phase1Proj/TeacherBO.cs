using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Proj
{
    class TeacherBO
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<Teacher> GetAllTeachers()
        {
            return teachers;
        }
        public Teacher GetTeacherById(int id)
        {
            foreach(Teacher t in teachers)
            {
                if (id == t.id)
                {
                    return t;
                }
            }
            return null;
        }

        public void AddTeacher(Teacher t)
        {
            teachers.Add(t);
        }
        public void EditTeacher(int id, String name ,String subject,String email)
        {
            foreach(Teacher t in teachers)
            {
                if (id == t.id)
                {
                    t.name = name;
                    t.subject = subject;
                    t.email = email;
                }
            }
          
        }

        public void DeleteTeacher(int id)
        {
            for(int i=0;i<teachers.Count;i++)
            {
                Teacher t = teachers[i];
                if (id == t.id)
                {
                    teachers.Remove(t);
                    return;
                }
            }
        }
    }
}
