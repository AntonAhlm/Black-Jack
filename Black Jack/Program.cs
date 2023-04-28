using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Avsluta = false; //Loop-villkor för hela programmet. 
            Random slump=new Random();
            int SpelarePoäng = 0;
            int DatorPoäng = 0;
            string SenasteVinnare ="";
            while(Avsluta!=true) //Loop för hela progammet.
            { 
            Console.WriteLine("Välkommen til 21:an! \n" + //Menyn
                "Välj ett alternativ      \n " +
                "1. Spela 21:an           \n " +
                "2. Visa senaste vinnaren \n " +
                "3. Spelets regler        \n " +
                "4. Avsluta programmet    \n ");

            string val=Console.ReadLine();
             

                switch (val)
                {
                    case "1":

                        SpelarePoäng = 0; //Nollar poängen
                        DatorPoäng= 0;

                        SpelarePoäng = SpelarePoäng + slump.Next(1, 11); //Drar 2 kort till dig 
                        SpelarePoäng = SpelarePoäng + slump.Next(1, 11);

                        DatorPoäng = DatorPoäng + slump.Next(1, 11); //Drar 2 kort till datorn
                        DatorPoäng = DatorPoäng + slump.Next(1, 11);

                       
                        Console.WriteLine("Du drog 2 kort och har " + SpelarePoäng + " poäng"); //Skriver ut hur många poäng du och datorn har
                        Console.WriteLine("Datorn drog 2 kort och har " + DatorPoäng + " poäng");
                        string svar = "j";
                        

                        while (svar != "n")
                        {
                            Console.WriteLine("Vill du dra att till kort? j/n"); //Frågar om du vill dra ett kort 
                            svar = Console.ReadLine();

                            if (svar != "n" && SpelarePoäng<=21) //Om Svaret inte är n och du inte har över 21 poäng:
                            {
                                SpelarePoäng = SpelarePoäng + slump.Next(1, 11);
                                Console.WriteLine("Du drog ett kort och har " + SpelarePoäng + " poäng");
                                Console.WriteLine("Datorn har " + DatorPoäng + " poäng \n");


                            }

                            if (SpelarePoäng > 21) //Om du har över 21 poäng
                            {
                                svar = "n";
                                DatorPoäng = DatorPoäng + slump.Next(1, 11);
                                Console.WriteLine("Datorn drog ett kort och har " + DatorPoäng + " poäng \n");
                            }

                            else if (svar == "n") //Eller om Svaret är nej
                            {
                                svar = "n";
                                DatorPoäng = DatorPoäng + slump.Next(1, 11);
                                Console.WriteLine("Datorn drog ett kort och har " + DatorPoäng + " poäng \n");


                            }
                            
                        }

                        Console.WriteLine("Du har " + SpelarePoäng + " poäng"); //Skriver hur många poäng spelarna har
                        Console.WriteLine("Datorn har " + DatorPoäng + " poäng");

                        if (SpelarePoäng > DatorPoäng && SpelarePoäng <= 21) // Om du har mer än datorn och under 21 : vinst
                        {
                            Console.WriteLine("Du Vann!");
                            SenasteVinnare = "Du";
                        }

                        else if (SpelarePoäng <= 21 && DatorPoäng <= 21 && DatorPoäng > SpelarePoäng) //Om båda har under 22 och datorn har mer än du : förlust
                        {
                            Console.WriteLine("Du Förlorade!!");
                            SenasteVinnare = "Datorn";
                        }

                        else if (SpelarePoäng > 21 && DatorPoäng < 21)  //Om du har över 21 och datorn under 21 : förlust
                        {
                            Console.WriteLine("Du Förlorade!!");
                            SenasteVinnare = "Datorn";
                        }

                        else if (SpelarePoäng > 21 && DatorPoäng > 21) //Om båda har över 21: ingen vann
                            Console.WriteLine("Ingen Vann!");

                        else if (SpelarePoäng > 21) //Om du har över 21 poäng: förlust
                        {
                            Console.WriteLine("Du Förlorade!!");
                            SenasteVinnare = "Datorn";
                        }

                        else //Testkod ifall det inte skriver ut något annat
                            Console.WriteLine(" :( ????????");

                        Thread.Sleep(2000);

                        Console.WriteLine("\n");
                        break;

                    case "2": //Senaste vinnaren

                        if(SenasteVinnare=="") //Ingen vinnare / Gör ingenting
                        {
                            break;
                        }

                        else  //Skriver ut vinnaren
                        {
                            Console.WriteLine("Senaste vinnaren är : " + SenasteVinnare + "\n");
                        }

                        Thread.Sleep(2000);
                        break;

                    case "3": //Reglerna
                        Console.WriteLine(" \n Ditt mål är att tvinga datorn att få mer än 21 poäng, \n" +
                            "Du får poäng genom att dra kort, varje kort har 1-10 poäng. \n" +
                            "Om du får mer än 21 poäng har du förlorat. \n" +
                            "Både du och datorn får två kort i början. Därefter får du \n" +
                            "dra fler kort tills du är nöjd eller får över 21. \n" +
                            "När du är färdig drar datorn kort tills den har \n" +
                            "mer poäng än dig eller över 21 poäng. \n\n ");
                        Thread.Sleep(4000);
                        break;

                    case "4": //Avslutar
                        Avsluta = true;
                        break;
                        
                }
            }
                

        }
    }
}
