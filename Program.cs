using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels:{0}", final_string);
            Console.WriteLine();
          
            //Question 2
            Console.WriteLine("Q2");
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();
           
            //Question 3
            Console.WriteLine("Q3");
            int[] bull_bucks = new int[] {1, 2, 3, 2};
            int unique_sum = SumOfUnique(bull_bucks);
            
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();
            
            //Question 4
            Console.WriteLine("Q4:");
            
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
          
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = new int[] { 3, 1, 4, 2, 0 };



            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is " + rotated_string);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Q6:");
            
            string bulls_string6 = "mumacollegeofbusiness";
            Console.WriteLine("Enter the character");
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            
            Console.WriteLine();
        }


        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
            { 
        // For this problem we are making using of a foreach loop to see if any vowels are present in the given string
        // By comparing each vowel with each character present in a string varaiable
        // if present we make use of a temporary string variable to store the characters which aren't vowels return the final string varaible for the function call
                try
                  {
                    string final_string = "";  //temp string varaible
                    foreach (char ch in s)     // comapre each character present in a string varaiable with a vowel
                    {
                       // Console.Write(ch);
                        if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u' && ch != 'A' && ch != 'E' && ch != 'I' && ch != 'O' && ch != 'U')
                        {
                            final_string+= ch;
                        }
                    }
                    return final_string;
                }
                catch (Exception)
                {
                    throw;
                }

        }

        /*<summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
        Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
        Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
        Output: true
       </summary>
       */

            private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
            {  //In this problem we make use of the property of strinng addition 
               //we add the each part of a string array and combine them to a single one and then we compare the combine string  if they are similar or not
               //The compared result is boolean value and this value is sent back to the function call
                try
                {
                    string bulls_string1_tot1 = string.Concat(bulls_string1); //Combining array elements of bulls_string1
                    string bulls_string2_tot2 = string.Concat(bulls_string2); //Combining array elements of bulls_string2
                if (bulls_string1_tot1 == bulls_string2_tot2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */
        private static int SumOfUnique(int[] bull_bucks)
            {  
                //For calculating the unique elements in a given array 

                try
                {
                   

                    int[] array = new int[100];
                    int post = 0;
                    int temp = 0;
                    foreach (int ip in bull_bucks)
                    {
                        array[ip-1] = array[ip-1]+1; //This is an array which stores the count of each input array element 
                    }

                    foreach (int i in array)  //looping through the count array and forming sum of elements which are unique(count=1)
                    {
                        post += 1;
                        if (i == 1)
                        {
                            temp += post;  
                        }
                    }
                    return temp; //returning the total sum of all unique elements 
                }
                
                catch (Exception)
                {
                    throw;
                }
            }

        /*
       <summary>
      Given a square matrix bulls_grid, return the sum of the matrix diagonals.
      Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
      Example 1:
      Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
      Output: 25
      Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
      Notice that element mat[1][1] = 5 is counted only once.
      Example 2:
      Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
      Output: 8
      Example 3:
      Input: bulls_grid = [[5]]
      Output: 5
      </summary>
       */

        private static int DiagonalSum(int[,] bulls_grid)
            {
            //For the given square matrix where i represents rows and j represent the columns
            // In this to calculate the diagonal elements 1st diagonal is calculated by using comapring i==j

            //The cross diagonal is calculate by comparing i+j with the value size-1 
            // the elements which satisfy these conditions will be added to a temp variable and this result will be sent back to the function call
            try
            { 
                    int sum = 0;
                    int size = bulls_grid.GetLength(0);

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i == j)   // Calucating the sum of first diagonal elements
                            {
                                sum = sum + bulls_grid[i, j];
                            }
                            if (i + j == size - 1 && i != j) // calculating the elements of cross diagonal elements ,
                                                             // we use i!=j so as to prevent repetivte add of same array element

                            {
                                sum = sum + bulls_grid[i, j];
                            }
                        }
                    }
                    return sum;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
        }

       /* <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */
            private static string RestoreString(string bulls_string, int[] indices)
            { //We use Array Index of property of arrange the elements of the string accordingly
                try
                {
                    
                    string x = "";  // Temporary string variable
                    for (int i = 0; i < indices.Length; i++)
                    {  //We use Array.IndexOf postion to arrange them accordingly 
                        x += bulls_string[Array.IndexOf(indices, i)];
                    }



                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }

            }
        /*
        <summary>
       Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
       For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
       Return the resulting string.
       Example 1:
       Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
       Output: "camumollegeofbusiness"
       Explanation: The first occurrence of "c" is at index 4. 
       Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
       Example 2:
       Input: bulls_string   = "xyxzxe", ch = "z"
       Output: "zxyxxe"
       Explanation: The first and only occurrence of "z" is at index 3.
       Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
       Example 3:
       Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
       Output: "zimmermanschoolofadvertising"
       Explanation: "x" does not exist in word.
       You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
       */

        private static string ReversePrefix(string bulls_string6, char ch)
            {
                try
                {
                    int i = 0;
                    string prefix_string = ""; //temp string varaiable
                    for (int k = 0; k < bulls_string6.Length; k++) //To check if the given character is present in the string or not
                    {

                        if (ch == bulls_string6[k])
                        {
                            i = k;
                            break;
                        }

                    }

                    for (int j = i; j >= 0; j--)         //To store the string part present before the character and arrange it in descending order to get the expected o/p
                    {
                        prefix_string = prefix_string + bulls_string6[j];

                    }
                    for (int j = i + 1; j < bulls_string6.Length; j++) //to add the the string part which is present after the character 
                    {
                        prefix_string = prefix_string + bulls_string6[j];
                    }

                    return prefix_string;


                }
                catch (Exception)
                {

                    throw;
                }

            }
        } } 


