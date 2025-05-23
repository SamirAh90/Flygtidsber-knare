
/* Information om flygtidsberäknare.
         Detta consoleapplikation beräknar och visar avgångs och ankomsttider för flygresor mellan Stockholm -  New York - Stockholm.

         Programmet börjar med hälsning till användaren.

         Funktioner:
         1.Användaren kan välja mellan två resor:
            - Stockholm till New York
            - New York till Stockholm
         2. Beräknar restider baserat på givna data på labb uppgiften:
            - Restid: 7 timmar och 25 minuter
            - Tidsskillnad: 6 timmar och 0 minuter
         3. Programmet avslutas om användaren väljer alternativ tre.
         4. Programmet hanterar ogiltig inmatning och körs kontinuerligt tills användaren väljer att avsluta.      

Refernser: 1- Complete C# Masterclass course på Udemy (https://www.udemy.com/course/complete-csharp-masterclass/?srsltid=AfmBOoqbgM31iC73NSkYRMTya0gbuziFMaxYnT-xdGn0gEw6oyiyrezW&couponCode=KEEPLEARNING)
           2- Troelsen, A., & Japikse, P. (2022). Pro C# 10 with .NET 6 : foundational principles and practices in programming (11 uppl.). New York: APress. ISBN: 9781484278680.
           3- Land, R. (2024). Introduktion till programmering (1 uppl.). Borlänge.
           4- Uppgifts flödesschema.

Consoleapplikation utvecklare: Samir Ahmad och Ludwig Lindfors, lappgrup 32.

 */


//Programmet börjar härifrån:
using System;

namespace Lapp_1__Labbgrupp_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)  //  Använder oss av ett while-loop för att köra programmet tills användaren väljer att avsluta.
            {
                // Skriver ut ett välkomstmeddelande och snyggar det med asterisker till användaren.
                Console.WriteLine("\n******************************************************************************\n");
                Console.WriteLine("Välkommen till flygtidsberäknaren!\n");
                Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)");

                // Skriver ut en lista med valbara destinationer och ger användaren alternativt att avsluta progrmmaet om den önskar så.            
                Console.WriteLine("1. Stockholm - New York");
                Console.WriteLine("2. New York - Stockholm");
                Console.WriteLine("3. Avsluta programmet");
                Console.Write("Skriv ditt val här: ");


                //Data (Restiden är 7 timmar och 25 minuter, tidsskillnaden är 6 timmar och 0 minuter. Använder tre variabler av typen int). 
                //för tidsskillnaden - kunde vi även interia en int variable för minuter här med värde 0 men vi unvikte det i detta program efterosm tidsskillnaden alltid är 0 minuter i det här fallet.
                int flightDurationHours = 7;
                int flightDurationMinutes = 25;
                int timeDifferenceHours = 6;


                //Avgångstiden från New York – Stockholm är 10:10. Använder två variabler av typen int.
                int departureTimeNYHours = 10;
                int departureTimeNYMinutes = 10;

                //Lägger till restiden till avgångstiden
                int consumedTimeNYToSTHours = departureTimeNYHours + flightDurationHours;
                int consumedTimeNYToSTMinutes = departureTimeNYMinutes + flightDurationMinutes;


                // Beräknar ankomsttiden i Stockholm (lokal tid):
                // Eftersom Stockholm ligger 6 timmar före New York, adderar vi tidsskillnaden.
                int arrivalTimeSTHours = consumedTimeNYToSTHours + timeDifferenceHours;
                int arrivalTimeSTMinutes = consumedTimeNYToSTMinutes;

                // Formaterar avgångstiden från New York och ankomsttiden till Stockholm som en sträng. Vi kunde även använda .ToString("00") men det påverkar kodförstålese negtivt.
                string departureTimeNYToST = String.Format("Avgångstid från New York: {0:D2}:{1:D2}", departureTimeNYHours, departureTimeNYMinutes);
                string arrivalTimeNYToST = String.Format("Ankomsttid till Stockholm: {0:D2}:{1:D2}", arrivalTimeSTHours, arrivalTimeSTMinutes);


                // Avgångstiden från Stockholm till New York är 14:03. Använder två variabler av typen int.
                int departureTimeSTHours = 14;
                int departureTimeSTMinutes = 3;

                // Lägger till restiden till avgångstiden
                int consumedTimeSTToNYHours = departureTimeSTHours + flightDurationHours;
                int consumedTimeSTToNYMinutes = departureTimeSTMinutes + flightDurationMinutes;


                // Beräknar ankomsttiden i New York (lokal tid):
                // Eftersom New York ligger 6 timmar efter Stockholm, subtraherar vi tidsskillnaden.
                int arrivalTimeNYHours = consumedTimeSTToNYHours - timeDifferenceHours;
                int arrivalTimeNYMinutes = consumedTimeSTToNYMinutes;

                // Formaterar avgångstiden från New York och ankomsttiden till Stockholm som en sträng. Vi kunde även använda .ToString("00") men det påverkar kodförstålese negtivt.
                string departureTimeSTToNY = String.Format("Avgångstid från Stockholm: {0:D2}:{1:D2}", departureTimeSTHours, departureTimeSTMinutes);
                string arrivalTimeSTToNY = String.Format("Ankomsttid till New York: {0:D2}:{1:D2}", arrivalTimeNYHours, arrivalTimeNYMinutes);

                while (true)
                {

                    // läser in och konverterar användarens val från string till int - heltal.
                    if (int.TryParse(Console.ReadLine(), out int userChoice))
                    {
                        // // Kontrollerar om valet är giltigt och baserat på användarens val, körs IF-sats koden. 
                        if (userChoice == 1)
                        {
                            // Användaren valde destination 1: Visar avgångs- och ankomsttider för resan ST till NY och programmet avslutas när användaren trycker på en tangent
                            Console.WriteLine("\n******************************************************************************\n");
                            Console.WriteLine(departureTimeSTToNY); // Visar avgångstid
                            Console.WriteLine(arrivalTimeSTToNY);  // Visar ankomsttid
                            Console.WriteLine("\n******************************************************************************\n");
                            Console.WriteLine("Programmet avslutas när du trycker på valfri tangent.... Tack för att du använde Flygtidsberäknaren!");
                            Console.ReadLine();
                            break;

                        }

                        else if (userChoice == 2)
                        {
                            // Användaren valde destination 2: Visar avgångs- och ankomsttider för resan NY till ST och programmet avslutas när användaren trycker på en tangent
                            Console.WriteLine("\n******************************************************************************\n");
                            Console.WriteLine(departureTimeNYToST);
                            Console.WriteLine(arrivalTimeNYToST);
                            Console.WriteLine("\n******************************************************************************\n");
                            Console.WriteLine("Programmet avslutas när du trycker på valfri tangent.... Tack för att du använde Flygtidsberäknaren!");
                            Console.ReadLine();
                            break;

                        }
                        else if (userChoice == 3)
                        {
                            // Användaren valde att avsluta programmet
                            Console.WriteLine("\n******************************************************************************\n");
                            Console.WriteLine("Programmet avslutas när du trycker på valfri tangent.... Tack för att du använde Flygtidsberäknaren!");
                            Console.ReadLine();  // Väntar på att användaren trycker på en tangent
                            Console.Beep(); // Spelar upp en ton vid avslutning
                            Environment.Exit(0);  // Avsluta programmet

                        }
                        else
                        {
                            // Hanterar ogiltig inmattning (som är inte 1, 2, or 3).
                            Console.WriteLine("\n******************************************************************************\n");
                            Console.WriteLine("Felaktig inmatning. Vänligen ange en siffra mellan 1 och 3.");



                        }
                    }
                    else
                    {
                        // Hanterar ogiltig inmattning (som är inte siffra).
                        Console.WriteLine("\n******************************************************************************\n");
                        Console.WriteLine("Välj en destination eller tryck 3 för att avsluta!");

                    }
                }


            }
        }
    }
}



/*Standardbiblioteket i C#

När ni löser programmeringsuppgiften kommer ni sannolikt att ha nytta av följande funktionalitet i standardbiblioteket för C#:

********************** WriteLine() och/eller Console.Write() för att skriva output till konsolen. Done 
********************** Exit(0); för att stänga ner applikationen.
********************** Format() eller myInt.ToString() med lämpliga argument som ni skickar in till parameterlistan för att formatera output så den blir att se ut på ett visst sätt. Done
********************** Parse() för att parsa en sträng till en int. Done
 

Några saker som kan vara värda att ha i åtanke när ni gör labben

********************** Tidsskillnaden (i beräkningen)Done
********************** Ett tips är att ni beräknar timmarna för sig och minuterna för sig.Done
********************** Koden ska kommenteras på ett sätt så att det tydligt framgår vad som sker. Done
********************** När ni läser in data med Console.ReadLine() så tolkas detta som en sträng. Om ni vill göra om det till exempelvis en int så behöver ni parsa strängen. Done
 

Följande ska (minst) finnas med:

********************** Console-klassens Write() och WriteLine()-metod för att skriva ut instruktioner till användaren i konsolen Done
********************** Console-klassens ReadLine()-metod för att läsa in data som användaren skriver in i konsolen. Done
********************** Variabler av typen int för att spara data om t.ex. timmar, minuter och tidsskillnad Done
********************** Beräkningar med addition och subtraktion för ankomsttiden.Done
********************** Spara det ni läser in från användaren i en variabel av en lämplig datatyp.Done
********** gjort med annan funktion Done: Minuterna ska skriva ut med två positioner, t.ex. ”14:03”. Tips: använd er av .ToString("00") tillsammans med det värde som representerar minuter för att som säkerställer att minuterna visas korrekt om minuterna är färre än 10 (så att 3 minuter visas som ”03” och inte ”3”.Done
********************** If eller if-else-sats. Done
*/