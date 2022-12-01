using AB102_Console_App.Models;
using AB102_Console_App.Utils;

namespace AB102_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ferqli classa cixardin
           


            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                     Xos gelmusuz                              ");
            
            do
            {
                Console.WriteLine("1.Classrom yarat");
                Console.WriteLine("2.Student yarat");
                Console.WriteLine("0.out");
                var choose=Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        CreateClass();
                        break;
                    case "2":

                    default:
                        break;
                }


            } while (true);
        }





        public static void CreateClass()
        {
            Console.WriteLine("Classroom adi daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Type secin back/front");
            string type=Console.ReadLine();
            string nameNew=Helper.CheckClassName(name);
            if(nameNew!=null)
            {
                if (type.ToLower() == "back")
                {

                    Classroom classroom = new Classroom(nameNew, Enums.BackEnd);
                    Data.Addclassrooms(classroom);
                }
                else
                {
                    Classroom classroom = new Classroom(Helper.CheckClassName(name), Enums.FrontEnd);
                    Data.Addclassrooms(classroom);
                }
            }
            else
            {
                Console.WriteLine("Class yaranmadi");
            }
         
        }
    }
}