using System;

namespace GIK299_Laboration_2_h23vilmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array



            Console.WriteLine("Hur många familjemedlemmar har du?");
            int numberOfMember = int.Parse(Console.ReadLine());

            string[] familyMember = new string[numberOfMember];




            for (int i = 0; i < numberOfMember; i++)

            {
                Console.WriteLine("Vad heter" + familyMember[i]);
                Console.ReadLine()
            }

            //Familjemedlem 1
            Console.WriteLine("Skriv namnet på familjemedlem 1.");
            string PersonOne = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string PersonOneAgestr = Console.ReadLine();
            int PersonOneAge = Convert.ToInt32(PersonOneAgestr);
            Console.WriteLine("");


            //Familjemedlem 2
            Console.WriteLine("Skriv namnet på familjemedlem 2.");
            string PersonTwo = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string PersonTwoAgestr = Console.ReadLine();
            int PersonTwoAge = Convert.ToInt32(PersonTwoAgestr);
            Console.WriteLine("");


            //Familjemedlem 3
            Console.WriteLine("Skriv namnet på familjemedlem 3.");
            string PersonThree = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string PersonThreeAgestr = Console.ReadLine();
            int PersonThreeAge = Convert.ToInt32(PersonThreeAgestr);
            Console.WriteLine("");


            //Familjemedlem 3
            Console.WriteLine("Skriv namnet på familjemedlem 4.");
            string PersonFour = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string PersonFourAgestr = Console.ReadLine();
            int PersonFourAge = Convert.ToInt32(PersonFourAgestr);
            Console.WriteLine("");


            //Sammanställning av åldrarna
            Console.WriteLine(PersonOne + " är " + PersonOneAge + " år gammal.");
            Console.WriteLine(PersonTwo + " är " + PersonTwoAge + " år gammal.");
            Console.WriteLine(PersonThree + " är " + PersonThreeAge + " år gammal.");
            Console.WriteLine(PersonFour + " är " + PersonFourAge + " år gammal.");
            Console.WriteLine("");

            //Total åldern för alla medlemmar
            int TotalAge = PersonOneAge + PersonTwoAge + PersonThreeAge + PersonFourAge;
            Console.WriteLine("Sammanlagda åldern är:" + TotalAge + " år.");

            //Median ålder för alla medlemmar
            double AvrageAge = TotalAge / 4.0; //
            Console.WriteLine("Median ålder är: " + AvrageAge + "år.");





            Console.ReadKey();
        }
    }
}
