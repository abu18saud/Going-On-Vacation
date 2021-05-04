using System;

namespace Going_On_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            try
            {
                Console.WriteLine(tours[choice].Trim());
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Wrong number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
