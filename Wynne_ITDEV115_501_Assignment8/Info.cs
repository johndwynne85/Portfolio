using System;

namespace Wynne_ITDEV115_501_Assignment8
{
    class Info {
        public Info() { }
        public void DisplayInfo(string assignment) {
            Console.Title = assignment;
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Name: \t\t\tJohn Wynne");
            Console.WriteLine("Course: \t\tITDEV-115-501");
            Console.WriteLine("Instructor: \t\tJanese Christie");
            Console.WriteLine("Assignment: \t\t{0}", assignment);
            Console.WriteLine("Date: \t\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("**************************************************");
        }
    }
}
