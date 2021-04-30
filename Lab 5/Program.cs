using System;

namespace Lab_5
{
    struct user
    {
        public int height;
        public int experience;
    }

    class Program
    {
        public static void StructShow(user personS)
        {
            Console.WriteLine($"Height: {personS.height}");
            Console.WriteLine($"Work Experience: {personS.experience}");
        }

        static void Main(string[] args)
        {
            user personS = new user();
            people Tom = new people();
            Console.WriteLine("Write Fist name");
            Tom.FirstName=Console.ReadLine();
            Console.WriteLine("Write Last name");
            Tom.LastName = Console.ReadLine();
            Console.WriteLine("Write father name");
            Tom.FatherName = Console.ReadLine();
            Console.WriteLine("Enter age");
            bool check = true;
            string bufS;
            int bufInt;
            do
            {                       
                bufS = Console.ReadLine();
                check = int.TryParse(bufS, out bufInt);
                Tom.Age = bufInt;
            }  while(Tom.Age <18 && !check);

            Console.WriteLine("Enter your height");
            do
            {
                 bufS = Console.ReadLine();
                check = int.TryParse(bufS, out bufInt);
                personS.height = bufInt;
            } while (!check);
            Console.WriteLine("Enter your work experience");
            do
            {
                bufS = Console.ReadLine();
                check = int.TryParse(bufS, out bufInt);
                personS.experience = bufInt;
            } while (!check);
            Console.WriteLine("Choose your profession\n1:Builder\n2:Programmer\nElse:WorkLess");
            int ProfBuf=Convert.ToInt32(Console.ReadLine());
            switch(ProfBuf)
            {
                case 1: Builder TomB = new Builder();                   
                    TomB.EnterCategory();
                    TomB.StartWork();
                    people.Print(Tom);
                    StructShow(personS);
                    TomB.Profession();
                    TomB.ShowCategory(); break;
                case 2: Programmer TomP = new Programmer();
                    TomP.EnterCategory();
                    Tom.StartWork();
                    people.Print(Tom);
                    StructShow(personS);
                    TomP.Profession();
                    TomP.ShowCategory(); break;
                default: WotkLess TomW = new WotkLess();
                    TomW.StartWork();
                    people.Print(Tom);
                    StructShow(personS);
                    TomW.Profession();
                    TomW.ShowCategory(); break;
            }
        }
    }
}
