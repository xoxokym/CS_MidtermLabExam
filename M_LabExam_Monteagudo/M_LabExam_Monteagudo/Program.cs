using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_LabExam_Monteagudo
{
    class Program
    {
        static void Main(string[] args)
        {
            // wala pong arrays, havent mastered it pa po :((

            for (int x = 0; x < 5; x++)
            {
                Console.Write("Greetings! What is your application number?: ");
                string appNum = (Console.ReadLine());

                Console.WriteLine();

                Console.Write("[1]: Yes, [2]: No. Would you like to start?: ");
                int choice = Int32.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine();

                if (choice == 1)
                {
                    Console.WriteLine("                (Surname, Given Name, and Middle Initial)");
                    Console.Write("Enter your name: ");
                    string uName = string.Copy(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("    Test 1!: Mathemathics");
                    Console.WriteLine("------------------------------");

                    Console.WriteLine();

                    int score = 0;

                    Console.WriteLine("First Question: What 1 + 1?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: 2");
                    Console.WriteLine("[2]: 3");
                    Console.WriteLine("[3]: 4");
                    Console.WriteLine("[4]: 5");
                    Console.Write("Your Answer: ");
                    int fQ = Int32.Parse(Console.ReadLine());

                    if (fQ == 1)
                    {
                        score++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Second Question: What is the square root of 4?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: 1.14");
                    Console.WriteLine("[2]: 2");
                    Console.WriteLine("[3]: 2.14");
                    Console.WriteLine("[4]: 3");
                    Console.Write("Your Answer: ");
                    int sQ = Int32.Parse(Console.ReadLine());

                    if (sQ == 2)
                    {
                        score++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Third Question: In the meme of ''What is 9 + 10?'', What is the said answer?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: 19");
                    Console.WriteLine("[2]: 20");
                    Console.WriteLine("[3]: 21");
                    Console.WriteLine("[4]: 22");
                    Console.Write("Your Answer: ");
                    int tQ = Int32.Parse(Console.ReadLine());

                    if (tQ == 3)
                    {
                        score++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Fourth Question: What is 100000000 x 0?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: 100000000");
                    Console.WriteLine("[2]: 10000000");
                    Console.WriteLine("[3]: 1000000");
                    Console.WriteLine("[4]: 0");
                    Console.Write("Your Answer: ");
                    int frQ = Int32.Parse(Console.ReadLine());

                    if (frQ == 4)
                    {
                        score++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();


                    Console.WriteLine("Fifth Question: What is 0 x 100000000?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: 0");
                    Console.WriteLine("[2]: 1000000");
                    Console.WriteLine("[3]: 10000000");
                    Console.WriteLine("[4]: 100000000");
                    Console.Write("Your Answer: ");
                    int ftQ = Int32.Parse(Console.ReadLine());

                    if (ftQ == 1)
                    {
                        score++;
                    }

                    else
                    {

                    }

                    Console.Clear();

                    Console.WriteLine();

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("       Test 2!: Reading");
                    Console.WriteLine("------------------------------");

                    Console.WriteLine();

                    int score1 = 0;

                    Console.WriteLine("First Question: Which of the following is an example of a close reading strategy?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Examining the sound patterns of a poem.");
                    Console.WriteLine("[2]: Discerning the main theme of the poem.");
                    Console.WriteLine("[3]: Researching the historical background of the poem.");
                    Console.WriteLine("[4]: Determining the author's overall message.");
                    Console.Write("Your Answer: ");
                    int fQ2 = Int32.Parse(Console.ReadLine());

                    if (fQ2 == 1)
                    {
                        score1++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Second Question: Which of the following BEST demonstrates a reader who is using a big picture reading strategy?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Jim hones in on the first paragraph of Tolstoy's War and Peace.");
                    Console.WriteLine("[2]: Jim keeps the idea of redemption and Shakespeare's treatment of that idea in mind as he reads Hamlet.");
                    Console.WriteLine("[3]: Jim pays close attention to the many times that different characters wear sneakers in A Dog's Life.");
                    Console.WriteLine("[4]: Jim reads a graphic novel that is filled with finely detailed drawings of all of the characters and situations.");
                    Console.Write("Your Answer: ");
                    int sQ2 = Int32.Parse(Console.ReadLine());

                    if (sQ2 == 2)
                    {
                        score1++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Third Question: Tom is guiding a group of his students through a big picture reading of Romeo and Juliet. Which of the scenarios below should NOT be included as part of this guided reading?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Instructions to reflect on how small details add up and connect to the larger story.");
                    Console.WriteLine("[2]: Study questions that guide students in considering overarching themes while reading.");
                    Console.WriteLine("[3]: Instructions for identifying places where the author made interesting word choices.");
                    Console.WriteLine("[4]: Instructions to consider the author's intent while reading.");
                    Console.Write("Your Answer: ");
                    int tQ2 = Int32.Parse(Console.ReadLine());

                    if (tQ2 == 3)
                    {
                        score1++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Fourth Question: Which is the best definition for the connotation of a word?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Alternate meanings of a word, such as slang.");
                    Console.WriteLine("[2]: A word's literal meaning.");
                    Console.WriteLine("[3]: A word's former literal meaning, before it was re-defined to mean something different.");
                    Console.WriteLine("[4]: Underlying meanings we associate with a word.");
                    Console.Write("Your Answer: ");
                    int frQ2 = Int32.Parse(Console.ReadLine());

                    if (frQ2 == 4)
                    {
                        score1++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();


                    Console.WriteLine("Fifth Question: Which of the following is NOT a connotation associated with the word grave?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Warmth");
                    Console.WriteLine("[2]: Finality");
                    Console.WriteLine("[3]: Sadness");
                    Console.WriteLine("[4]: Death");
                    Console.Write("Your Answer: ");
                    int ftQ2 = Int32.Parse(Console.ReadLine());

                    if (ftQ2 == 1)
                    {
                        score1++;
                    }

                    else
                    {

                    }

                    Console.Clear();

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("       Test 3!: History");
                    Console.WriteLine("------------------------------");

                    Console.WriteLine();

                    int score11 = 0;

                    Console.WriteLine("First Question: How many wives did Henry VIII have?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: 6.");
                    Console.WriteLine("[2]: 7.");
                    Console.WriteLine("[3]: 8.");
                    Console.WriteLine("[4]: 9.");
                    Console.Write("Your Answer: ");
                    int fQ22 = Int32.Parse(Console.ReadLine());

                    if (fQ22 == 1)
                    {
                        score11++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Second Question: Francisco Franco ruled which European country from 1939 to 1975?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Japan.");
                    Console.WriteLine("[2]: Spain.");
                    Console.WriteLine("[3]: Korea.");
                    Console.WriteLine("[4]: China.");
                    Console.Write("Your Answer: ");
                    int sQ22 = Int32.Parse(Console.ReadLine());

                    if (sQ22 == 2)
                    {
                        score11++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Third Question: What type of boats did the Vikings use when exploring and raiding?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Yatch.");
                    Console.WriteLine("[2]: Fishing Vessel.");
                    Console.WriteLine("[3]: Longships.");
                    Console.WriteLine("[4]: Fishing trawler.");
                    Console.Write("Your Answer: ");
                    int tQ22 = Int32.Parse(Console.ReadLine());

                    if (tQ22 == 3)
                    {
                        score11++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.WriteLine("Fourth Question: In what year was the Concorde’s first flight?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: 1979.");
                    Console.WriteLine("[2]: 1989.");
                    Console.WriteLine("[3]: 1999.");
                    Console.WriteLine("[4]: 1969.");
                    Console.Write("Your Answer: ");
                    int frQ22 = Int32.Parse(Console.ReadLine());

                    if (frQ22 == 4)
                    {
                        score11++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();


                    Console.WriteLine("Fifth Question: Which country did Germany invade to kickstart World War II?");
                    Console.WriteLine();

                    Console.WriteLine("[1]: Poland");
                    Console.WriteLine("[2]: Philippines");
                    Console.WriteLine("[3]: Canada");
                    Console.WriteLine("[4]: Australia");
                    Console.Write("Your Answer: ");
                    int ftQ22 = Int32.Parse(Console.ReadLine());

                    if (ftQ22 == 1)
                    {
                        score11++;
                    }

                    else
                    {

                    }

                    Console.WriteLine();

                    Console.Clear();

                    int sum = score + score1 + score11;

                    Console.Write("Would you like to see your score? [1]: Yes or [2]: No: ");
                    int fScore = Int32.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (fScore == 1)
                    {
                        Console.WriteLine("Congratulations, " + uName + "! Your score is " + sum + ".");
                    }

                    else if (fScore == 2)
                    {
                        Console.WriteLine("Thank you!");
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                    Console.WriteLine();

                    Console.Write("Press 1 to exit: ");
                    int blank = Int32.Parse(Console.ReadLine());

                    Console.Clear();
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Let me know when your ready, thank you!");
                }

                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
