using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Avsluta = false;
            Random slump=new Random();
            int SpelarePoäng = 0;
            int DatorPoäng = 0; 
            while(Avsluta!=true)
            { 
            Console.WriteLine("Välkommen til 21:an! \n" +
                "Välj ett alternativ      \n " +
                "1. Spela 21:an           \n " +
                "2. Visa senaste vinnaren \n " +
                "3. Spelets regler        \n " +
                "4. Avsluta programmet");

            string val=Console.ReadLine();

                switch (val)
                {
                    case "1":

                        SpelarePoäng = 0;
                        DatorPoäng= 0;

                        SpelarePoäng = SpelarePoäng + slump.Next(1, 11);
                        SpelarePoäng = SpelarePoäng + slump.Next(1, 11);
                        DatorPoäng = DatorPoäng + slump.Next(1, 11);
                        DatorPoäng = DatorPoäng + slump.Next(1, 11);
                        Console.WriteLine("Du har " + SpelarePoäng + " poäng");
                        Console.WriteLine("Datorn har " + DatorPoäng + " poäng");
                        string svar = "";

                        do
                        {
                            Console.WriteLine("Vill du dra att till kort? j/n");
                            svar = Console.ReadLine();
                            if (svar == "j") ;
                            {
                                SpelarePoäng = SpelarePoäng + slump.Next(1, 11);
                                Console.WriteLine("Du har " + SpelarePoäng + " poäng");
                                Console.WriteLine("Datorn har " + DatorPoäng + " poäng");
                                if (SpelarePoäng > 21)
                                {
                                    svar = "n";
                                    DatorPoäng = DatorPoäng + slump.Next(1, 11);
                                }

                            }

                            

                        } while (svar != "n");

                                if (SpelarePoäng > DatorPoäng && SpelarePoäng <= 21)
                                    Console.WriteLine("Du Vann!");
                                else if (SpelarePoäng <= 21 && DatorPoäng <= 21 && DatorPoäng > SpelarePoäng)
                                    Console.WriteLine("Du Förlorade!!");

                                else if (SpelarePoäng<21 && DatorPoäng>21 )
                                    Console.WriteLine("Du Förlorade!!");

                                else if (SpelarePoäng > 21 && DatorPoäng > 21)
                                    Console.WriteLine("Ingen Vann!");

                        break;

                    case "2":
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine(" \n Ditt mål är att tvinga datorn att få mer än 21 poäng, \n" +
                            "Du får poäng genom att dra kort, varje kort har 1-10 poäng. \n" +
                            "Om du får mer än 21 poäng har du förlorat. \n" +
                            "Både du och datorn får två kort i början. Därefter får du \n" +
                            "dra fler kort tills du är nöjd eller får över 21. \n" +
                            "När du är färdig drar datorn kort tills den har \n" +
                            "mer poäng än dig eller över 21 poäng. \n\n ");
                        Thread.Sleep(4000);
                        break;

                    case "4":
                        Avsluta = true;
                        break;
                        
                }
            }
                

        }
    }
}
