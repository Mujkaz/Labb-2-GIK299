using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace GIK299_Laboration_2_h23vilmu
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Samling av variablar.
            int[] familyMemberAges;
            string[] familyMemberNames;
            int totalAge = 0;


            //Skapande av arrayer före meny för att ha globala varianblar
            Console.WriteLine("Skriv antal familjemedlemmar du vill lägga till.");
            int numberOfMember = Int32.Parse(Console.ReadLine());
            familyMemberAges = new int[numberOfMember];
            familyMemberNames = new string[numberOfMember];
            Console.WriteLine("Du har skrivit in " + numberOfMember + " st familjemedlemmar, var god välj det första alternativet i menyn.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            //Meny
            int menuSelect = 0;
            while (menuSelect != 5)
            {

                Console.WriteLine("Välj följande alternativ." +
            "\n [1] Skriv familjemedlemmars ålder och namn." +
            "\n [2] Visa alla tillagda familjemedlemmar." +
            "\n [3] Visa totalålder" +
            "\n [4] Visa medelålder" +
            "\n [5] Avsluta programmet");
                menuSelect = Int32.Parse(Console.ReadLine());


                //Switch sats för att meny ska få funktioner.
                switch (menuSelect)
                {
                    case 1:

                        //Här fyller jag arrayerna med data som användaren skriver.
                        Console.Clear();
                        Console.WriteLine("Skriv familjemedlemmarnas namn och ålder.");

                        for (int i = 0; i < numberOfMember; i++)
                        {
                            Console.WriteLine($"Skriv medlem: {i + 1} namn:");
                            familyMemberNames[i] = Console.ReadLine();

                            Console.WriteLine($"Skriv medlem: {i + 1} ålder:");
                            familyMemberAges[i] = int.Parse(Console.ReadLine());
                        }


                        //beräknar totalålder om den är noll till andra case för att få fram totalålder.
                        if (totalAge == 0)
                        {
                            for (int i = 0; i < numberOfMember; i++)
                            {
                                totalAge += familyMemberAges[i];
                            }
                        }

                        Console.Clear();
                        Console.WriteLine("Alla namn och ålder har nu sparats. Var god återgå till meny och välj det andra alternativet.");

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("Sammanställning:");
                        Console.WriteLine("");

                        //for loop för att kunna sammanställa familjemedlemmarna. Tar från arrayerna som jag skapat sedan tidigare.
                        for (int i = 0; i < numberOfMember; i++)
                        {

                            string compilationMembers = "Namn: " + familyMemberNames[i] + "\t" + "Ålder: " + familyMemberAges[i];

                            Console.WriteLine(compilationMembers);

                        }

                        Console.WriteLine("");

                        Console.WriteLine("Var god återgå till meny och välj det tredje alternativet.");
                        Console.WriteLine("");

                        break;

                    case 3:

                        //Här tar jag fram data från if satsen jag gjorde i case 1 för att visa totalålder.
                        Console.Clear();
                        Console.WriteLine("Totalålder:");
                        Console.WriteLine("");

                        Console.WriteLine();

                        Console.WriteLine("Totala åldern är: " + totalAge + " år");
                        Console.WriteLine("");

                        break;

                    case 4:

                        //Här har jag också tagit fram totalåldern från if-satsen jag gjorde i case 1 för att kunna presentera medelålder.
                        Console.Clear();

                        double averageAge = totalAge / numberOfMember;
                        Console.WriteLine("Medelåldern är: " + averageAge.ToString("##.00") + " år.");

                        Console.WriteLine("");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Tack för visat intresse. :)");
                        break;

                    default:

                        break;
                }

            }
        }


    }



}

















