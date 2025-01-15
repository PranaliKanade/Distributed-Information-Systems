using System;
using System.Linq;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("QUESTION 1: PrintPattern");
            PrintPattern(n);
            //Self-reflection: time taken-40 min, learning- understanding of recursion , recommendations-would be possible to implement in one method if two variable allowed as input
            
            int n2 = 6;
            Console.WriteLine("QUESTION 2: PrintSeries");
            PrintSeries(n2);
            //Self-reflection: time taken-35 min, learning- understanding of iteration, recommendations- NA
            
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine("QUESTION 3: UsfTime");
            Console.WriteLine(t);
            //Self-reflection: time taken-35 min, learning- understanding of string manipulation, recommendations- NA
            
            int n3 = 110;
            int k = 11;
            Console.WriteLine("QUESTION 4: UsfNumbers");
            UsfNumbers(n3, k);
            //Self-reflection: time taken-30 min, learning- understanding of conditions, recommendations- efficient way to check conditions
            
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            Console.WriteLine("QUESTION 5: PalindromePairs");
            PalindromePairs(words);
            //Self-reflection: time taken-45 min, learning- understanding of inbuilt methods like Reverse in array recommendation: same could be implemented using string manipulation 
            
            int n4 = 5;
            Console.WriteLine("QUESTION 6: Stones");
            Stones(n4);
            //Self-reflection: time taken-135min, learning- understanding of logical analysis, recommendation- array manipulation could used to get all combination of wins

        }

        private static void Printn(int j)
        {
            if (j == 0)
                return;
            //printing number in one line
            Console.Write(j);

            //recursively calling Printn to print sequence of number
            Printn(j - 1);
        }

        private static void PrintPattern(int n)
        {
            try
            {
                //check condition of n=0 and return back to call
                if (n == 0)
                    return;
                // if n<0 then do not execute and print message
                if (n < 0)
                    Console.WriteLine("Entered negative integer Number ");

                else
                    //calling method Printn to print series in decreasing order in one line
                    Printn(n);
                Console.WriteLine();
                //calling method PrintPattern to print series in decreasing order in vertical sequence recursively
                PrintPattern(n - 1);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                // if number is less than 1 print negative number error
                if (n2 < 1)
                    Console.Write("Entered negative integer Number ");
                //initialised sum =0 and s as string to store the output
                int sum = 0;
                String s = "";
                // executing for loop from 1 to n2 to get series
                for (int i = 1; i <= n2; i++)
                {
                    //adding i to sum to get i'th number of series and appending it to s with ','
                    sum = sum + i;
                    s = s + Convert.ToString(sum) + ",";

                }
                //print s except last ',' using substring
                Console.WriteLine(s.Substring(0, (s.Length - 1)));
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                // spliting time with delimiter : and storing in array timeE and using substring to extract seconds and meridiem from last part
                string[] timeE = s.Split(":");
                int hh = Convert.ToInt32(timeE[0]);
                int mm = Convert.ToInt32(timeE[1]);
                int ss = Convert.ToInt32(timeE[2].Substring(0, 2));
                string timeM = timeE[2].Substring(2, 2);

                // if hours >12, minutes>59 and seconds>59 return with message of invalid time
                if (hh > 12 || mm > 59 || ss > 59)
                {
                    return "Entered invalid time";
                }

                // if meridiem is pm and hours not equal to 12 then add 12 hours in hh
                if ((timeM == "PM" || timeM == "pm") && hh != 12)
                    hh = hh + 12;
                //Console.WriteLine(hh + timeE[1] + ss + timeM);

                // calculate total seconds for given time of day
                int totalss1 = ss + mm * 60 + hh * 60 * 60;

                //calculate usf hours by diving earth time seconds with 60*45
                int UU = Convert.ToInt32(totalss1 / (60 * 45));
                //calculate usf minutes suntracting usf hours from number obtained by dividing 60 * 45 and multiply by 60. Using truncate to get floor of number after division
                int SS = Convert.ToInt32(Math.Truncate((Convert.ToDecimal(totalss1) / (60 * 45) - UU) * 60));
                // calculated usf seconds by subtracting total usf hour and minute seconds with total seconds of earth time
                int FF = totalss1 - UU * 60 * 45 - SS * 45;

                // returning USF time in required format
                String USF = UU + ":" + SS + ":" + FF;
                return USF;

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                if (n3 < 1 || k < 1)
                {
                    Console.WriteLine("Entered invalid number");
                    return;
                }
                //initialized s1 with 0 and increment it by 1 until it matches count k to print pattern in new line
                int s1 = 0;
                //iterate loop from 1 to n3 for printing the series
                for (int i = 1; i <= n3; i++)
                {
                    s1 = s1 + 1;

                    //checking i if it is divisible by 3, 5 and 7 in all combination and print U, S, F, US, UF, SF and USF if satisfy that condition
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write("USF ");
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("US ");
                    }
                    else if (i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write("SF ");
                    }
                    else if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.Write("UF ");
                    }

                    else if (i % 3 == 0)
                    {
                        Console.Write("U ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("S ");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write("F ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                    //printing new line when s1 is equal to k counter and reset it to 0
                    if (s1 == k)
                    {
                        s1 = 0;
                        Console.WriteLine();
                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {

                string[] str = words;

                // initialise k with 0 ans string s with "["
                int k = 0;
                string s = "[";
                //iterate using two for loops to generate new words by concatinating words from list
                for (int i = 0; i <= str.Length - 1; i++)
                {
                    for (int j = 0; j <= str.Length - 1; j++)
                    {
                        //checking if i!=j to not concatinate same word
                        if (i != j)
                        {
                            //new word formed by concatinating two words from list
                            var original1 = str[i] + str[j];
                            //using Reverse to get reverse word of new word formed
                            var reversed1 = new string(original1.Reverse().ToArray());
                            //checking if new word is palindrome using below condition if its truw then store index of words in string
                            if (original1 == reversed1)
                            {

                                //storing index in s and increment counter if match found
                                s += ("[" + (i) + "," + (j) + "],");
                                k = k + 1;
                                //[0 1][1 0][2 4][3 2]
                            }

                        }
                    }
                }
                //  if counter is more than 0 then print combination of index found otherwise return
                if (k > 0)
                {
                    Console.WriteLine(s.Substring(0, s.Length - 1) + "]");
                }
                else if (k == 0)
                {
                    return;
                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing  PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                if (n4 < 1)
                {
                    Console.WriteLine("Entered invalid number");
                    return;
                }

                // if number of stones is divisible by then player1 will always lose print false and return
                if (n4 % 4 == 0)
                {
                    Console.WriteLine("false");
                    return;
                }
                //if number is less than 4 player 1 will always win
                if (n4 < 4)
                {
                    Console.WriteLine("[" + Convert.ToString(n4) + "]");
                }

                // initialize s1 with 3 and sum with n4
                int s1 = 3;
                int sum = n4;
                // player 1 will pick stones remaining after division of 4
                int r = sum % 4;
                string str = "[";

                //while will until sum>0 to exit from loop
                while (sum > 0)
                {
                    //when remaining stones are not divisible by 4 store reminder of number/4 and subtract that from sum
                    if (sum % 4 != 0)
                    {
                        r = sum % 4;
                        sum = sum - r;
                        str = str + r + ",";

                    }
                    // when stones are divisible by subtract s1 from sum and store s1 value in str
                    else if (sum % 4 == 0)
                    {
                        sum = sum - s1;
                        str = str + s1 + ",";
                    }

                }
                //print str with wining combination of player1
                Console.WriteLine(str.Substring(0, str.Length - 1) + "]");


            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
