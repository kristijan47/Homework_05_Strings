using System;

namespace Homework_05
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Task1
            //Task 1
            //*Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew 
            //string something = "we love c#";
            //char[] array = something.ToCharArray();
            //Array.Reverse(array);
            //foreach (char a in array)
            //{
            //    Console.Write(a);
            //}
            //Console.ReadLine();
            #endregion
            #region Task2
            //Task 2
            //* Count the total number of words in a string entered by the user. * Example: user enters "I love C#" * Expected output: "I love c#" contains 3 words.

            //Console.WriteLine("Type your message");
            //string userMessage = Console.ReadLine();

            //int word = 0;
            //if (string.IsNullOrEmpty(userMessage))
            //{
            //    Console.WriteLine("the string is empty");
            //}
            //else
            //{
            //    foreach (char s in userMessage)
            //    {
            //       if (s == ' ' || s == '\n' || s == '\t' || s == '.')
            //        {
            //            word++;
            //        }                  
            //    }
            //    // Ako go trgnam +1 mi dava edn zbor pomalku. I ako stavam tocka i posle space mi go broi pak kako zbor
            //    Console.WriteLine($"The Total Number Of Words In The String Is {word + 1}");
            //}


            #endregion
            #region Task3

            // Task 3
            //* Find maximum occurring character in a string* Example: "We want this situation with covid-19 to ends!" * 
            //  Expected Output: The highest frequency of character 't' appears number of times : 6 

            //Console.WriteLine("Type Something");
            //String str = Console.ReadLine(); ;
            //int[] charCount = new int[256];
            //int length = str.Length;
            //// Ja resiv so pomos od google iskreno :) Beshe dobro objasneto, no malku me zbuni za kreiranjeto na niza charCount = new int [256] zosto 256?. A mislam deka ja kreirame taa niza
            //// za da gi memorira characterite sto se povtoruvaat od inputot na userot charCount[str[i]]++;;
            //for (int i = 0; i < length; i++)
            //{
            //    charCount[str[i]]++;
            //}

            //int maxCount = 0;
            //char character = ' ';
            //for (int i = 0; i < length; i++)
            //{
            //    if (maxCount < charCount[str[i]])
            //    {
            //        maxCount = charCount[str[i]];
            //        character = str[i];
            //    }

            //}
            //Console.WriteLine("The string is: " + str);
            //Console.WriteLine("The highest frequency of character appearing in the above string is: " + character);
            //Console.WriteLine("Number of times this character occurs: " + maxCount);


            #endregion
            #region Task4
            //Task 4
            //"The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!"
            //* Print the whole text after "," in the console. *Bonus - Try to do that without counting the characters till "," by yourself :) 
            //string newStr = "The whole group of G1 loves C#, we are sure that with their dedication and passion they will be successfull programers soon!";

            //string groupG1 = newStr.Substring(31);
            //Console.WriteLine(groupG1);

            #endregion
            #region Task5
            // Task 5
            //* Display the Day properties(year, month, day, hour, minute, second) from the today's date. *Expected Output : *year = 2020
            //* month = 3
            //* day = 26
            //* hour = 23
            //* minute = 12
            //* second = 22 
            //var today = DateTime.Now;
            //string dateFormat = today.ToString("MM/dd/yyyy");
            //Console.WriteLine(dateFormat);
            //var year = today.Year;
            //var month = today.Month;       
            //var day = today.Day;
            //var hour = today.Hour;
            //var minute = today.Minute;
            //var second = today.Second;
            //Console.WriteLine($" Year = {year}\n Month = {month}\n Day = {day}\n Hour = {hour}\n Minute = {minute}\n Seconds = {second} ");


            //Console.ReadLine();
            #endregion
            #region Task6
            //            Task 6
            ////* Find the leap years between 2008 and 2020. * Expected output: *2008 is a leap year. * 2012 is a leap year. * 2016 is a leap year. * 2020 is a leap year.   
            ////     * Hint - make some researches of DateTime methods, you will find interesting ones that might help you;) 

            //// Najdeno na google ovaa reshenie so mali modifikaci
            //for (int year = 2008; year <= 2020; year++)
            //{
            //    if (DateTime.IsLeapYear(year))
            //    {
            //        Console.WriteLine("{0} is a leap year.", year);

            //    }

            //}

            //Console.ReadLine();

            ////Vtor nachin
            //for (int leapYear = 2008; leapYear <=2020; leapYear++)
            //{
            //    if (leapYear % 400 == 0)
            //    {
            //        Console.WriteLine("{0} is a leap year.", leapYear);
            //    }
            //    if (leapYear % 4 == 0 && leapYear % 100 != 0)
            //    {
            //        Console.WriteLine("{0} is a leap year.", leapYear);
            //    }

            //}
            //Console.ReadLine();

            #endregion
            #region Task7
            //Task 7
            //            Create a class Dog
            //Add properties: Name, race, color
            //The dog needs to have:
            //Eat method that returns message: The dog is now eating
            //Play method returning a message : The dog is now playing
            //ChaseTail method that returns a message: Dog is now chasing its tail.
            //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above. 
        
        #endregion

    
    }

    }
}