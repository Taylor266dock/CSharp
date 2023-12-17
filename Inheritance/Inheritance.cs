using System;

namespace Demo
{
    class Person
    {
        private
            int ID;
        public void setID(int pID)
        {
            ID = pID;
        }
        public string getID()
        {
            return ID.ToString();
        }
    }

    class Student:Person
    {
        private
            string Name;
        public void setName(string pName)
        {
            Name = pName;
        }
        public string getName()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[]args)
        {
            string ID, Name;

            Student stud = new Student();
            stud.setID(1);
            stud.setName("John");

            ID = "The ID of the student is "+ stud.getID();
            Name = "The Name of the student is "+ stud.getName();

            Console.WriteLine(ID);
            Console.WriteLine(Name);
            Console.Read();
        }
    }
}