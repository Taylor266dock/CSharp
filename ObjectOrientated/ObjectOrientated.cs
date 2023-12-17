using System;

namespace Demo
{
    class Student
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
    class Program
    {
        static void Main(string[]args)
        {
            string ID;

            //Creating an object of the Student Class
            Student stud = new Student();
            stud.setID(1);
            ID = "The ID of the student is " + stud.getID();
            //Display ID to Console
            Console.WriteLine(ID);
            Console.Read();
        }
    }
}