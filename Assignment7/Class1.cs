//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Assignment7
//{
//    class Class1
//    {
//        string sen = "good morning everyone";
//        int vowels = 0;
//        int cons = 0;
//        int space = 0;
//        char[] let = sen.ToCharArray();
//            for (int i = 0; i<sen.Length; i++)
//            {
//                if (let[i] == 'a' || let[i] == 'e' || let[i] == 'i' || let[i] == 'o' || let[i] == 'u')
//                {
//                    vowels++;
//                }
//                else if (let[i] == ' ') { 
//                    space++;
//                }
//            }
//            cons = let.Length - vowels - space;
//Console.WriteLine($"In this ( {sen} ) string we have {vowels} vowels and {cons} consonant ");
//From Nabil Mehari to Everyone 06:59 AM
//class Question7
//{
//    static void Main()
//    {
//        string str;
//        int wrd, l;


//        Console.Write("Input the string you want word-counted (again, careful about typos): ");
//        str = Console.ReadLine();

//        l = 0;
//        wrd = 1;

//        while (l <= str.Length - 1)
//        {
//            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
//            {
//                wrd++;
//            }

//            l++;
//        }

//        Console.Write("There are {0} words total in this string.\n", wrd);
//    }
//}

//    }
//}
