using System;
using System.Collections.Generic;

namespace Phase1Proj
{
    class Program{
        static void Main(string[] args){
            TeacherBO bo = new TeacherBO();
            string choice = "-1";
            while (choice != "6"){
                Console.WriteLine();
                Console.WriteLine("1.Display All Teachers");
                Console.WriteLine("2.Display Teacher By Id");
                Console.WriteLine("3.Add Teacher");
                Console.WriteLine("4.Edit Teacher");
                Console.WriteLine("5.Delete Teacher");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your option");
                Console.WriteLine();
                choice = Console.ReadLine();
                if (choice.Equals("1")){
                    List<Teacher> teachers = bo.GetAllTeachers();
                    foreach(Teacher t in teachers)
                    {
                        Console.WriteLine("Teacher details are : ");
                        Console.WriteLine("Id : "+t.id+" Name: "+t.name+" Subject: "+t.subject+" Email: "+t.email);
                    } 
                }
                else if (choice.Equals("2")) {

                    Console.WriteLine("Enter Teacher id ");
                    string id = Console.ReadLine();
                    int teacherId = Convert.ToInt32(id);
                    Teacher t =bo.GetTeacherById(teacherId);
                    if (t != null)
                    {
                        Console.WriteLine("Teacher details are :");
                        Console.WriteLine("Id : "+t.id);
                        Console.WriteLine("Name : " + t.name);
                        Console.WriteLine("Subject : " + t.subject);
                        Console.WriteLine("Email : " + t.email);
                    }
                    else
                    {
                        Console.WriteLine("No Teacher with entered Id exists ");
                    }
                }

                else if (choice.Equals("3")) {
                    Console.WriteLine("Enter teacher's id :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter teacher's name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter teacher's subject :");
                    string subject = Console.ReadLine();
                    Console.WriteLine("Enter teacher's email id :");
                    string email = Console.ReadLine();
                    Teacher newTeacher = new Teacher(id, name, subject, email);
                    bo.AddTeacher(newTeacher);
                    Console.WriteLine("Teacher Added ");
                }

                else if (choice.Equals("4")) {
                    Console.WriteLine("Enter teacher's id :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter teacher's name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter teacher's subject :");
                    string subject = Console.ReadLine();
                    Console.WriteLine("Enter teacher's email id :");
                    string email = Console.ReadLine();
                    bo.EditTeacher(id, name, subject, email);
                    Console.WriteLine("Details Updated");

                }
                else if (choice.Equals("5")) {
                    Console.WriteLine("Enter teacher's id :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    bo.DeleteTeacher(id);
                    Console.WriteLine("Teacher Deleted");
                }
                else if (choice.Equals("6")) { }
                else
                {
                    Console.WriteLine("Wrong choice");
                }
            }
            
        }
    }
}
