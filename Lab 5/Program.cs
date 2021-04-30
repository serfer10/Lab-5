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

            do
            {
                Tom.Age = Convert.ToInt32(Console.ReadLine());
            }  while(Tom.Age <18);

            Console.WriteLine("Enter your height");
            personS.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your work experience");
            personS.experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your profession\n1:Builder\n2:Programmer\nElse:WorkLess");
            int ProfBuf=Convert.ToInt32(Console.ReadLine());
            switch(ProfBuf)
            {
                case 1: Builder TomB = new Builder();                   
                    TomB.EnterCategory();
                    people.Print(Tom);
                    StructShow(personS);
                    TomB.Profession();
                    TomB.ShowCategory(); break;
                case 2: Programmer TomP = new Programmer();
                    TomP.EnterCategory();
                    people.Print(Tom);
                    StructShow(personS);
                    TomP.Profession();
                    TomP.ShowCategory(); break;
                default: WotkLess TomW = new WotkLess();
                    people.Print(Tom);
                    StructShow(personS);
                    TomW.Profession();
                    TomW.ShowCategory(); break;
            }
        }
    }
}
