using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment7
{
    class Program
    {
        private const char V = '5';

        static int CountPrimes(int n)
        {

            int Counter = 0;

            if (n <= 1)
                return Counter;

            for (int i = 2; i < n; i++)
            {
                if (isprime(i))
                    Counter++;
            }
            return Counter;

        }

        static bool isprime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;


        }
        static List<string> FizzBuzz(int n)
        {


            string[] s = new string[n + 1];
            int j = 0;
            List<string> w = new List<string>();


            for (int i = 3; i <= n; i = i + 3)
            {
                s[i] = "Fizz";

            }
            for (int i = 5; i <= n; i = i + 5)
            {
                s[i] = s[i] + "Buzz";

            }

            for (int i = 1; i <= n; i++)
            {
                if (s[i] == null)

                {
                    j = i % 5;
                    s[i] = Convert.ToString(j);
                }
                w.Add(s[i]);
            }
            return w;

        }
        static void Rotate(int[] nums, int k)
        {




            int count = 0;
            int index = 0;
            int kindex = 0;
            int Prev = nums[0];
            int Current = nums[0];
            int n = nums.Length;
            int[] numsmeet = new int[n];

            while (count < n)

            {


                if (numsmeet[(kindex + k) % n] == 1)
                {
                    kindex = kindex + 1;//(kindex + 1 + k) % n;
                    Prev = nums[kindex];
                }
                // else

                kindex = (kindex + k) % n;
                numsmeet[kindex] = numsmeet[kindex] + 1;
                Current = nums[kindex];
                nums[kindex] = Prev;
                Prev = Current;
                index = kindex;
                //index = kindex;

                count++;



            }



        }

        static int[] PlusOne(int[] digits)
        {

            int n = digits.Length;
            int[] Res = new int[n + 1];

            string a = "";
            int num;
            int carry = 1;
            for (int i = n - 1; i >= 0; i--)
            {

                a =  (digits[i] + carry)+a;
                if (digits[i] == 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

            }


            if (carry == 1)
            {

                a = "1" + a;

            }
                int[] R = new int[a.Length];

                for (int i = 0; i < a.Length; i++)
                {

                    R[i] = a[i];

                }
                return R;
           
                //int carry = 0;
                //for (int i = n - 1 ; i >= 0 ; i--)
                //{

                //    Res[i] = digits[i] + carry;
                //    if (digits[i] > 9)
                //    {
                //        carry = 1;
                //    }
                //    else
                //    {
                //        carry = 0;
                //    }

                //}
                //Convert.ToString
                //if (carry == 1)
                //{
                //    for (int i = n; i >= 0; i++)
                //    {
                //        Res[i + 1] = Res[i];

                //    }
                //    Res[0] = carry;


                //}
                //else {
                //    Array.Copy(Res, digits, n);
                //}
                //return Res;




                //for (int i = 0; i<n; i++)
                //{
                //    res = res * 10 + digits[i];//* Math.Pow( 10 , (n - i - 1));

                //}

                //res++;

                //n = res.ToString().Length;
                //int[] ArrRes = new int[n];
                //int count = 0;



                //for (int i = n - 1; i >= 0; i--)
                //{

                //    ArrRes[i] = Convert.ToInt32( res % 10);
                //    res =(res / 10);



                //}

                //return ArrRes;

            }


        static IList<int> AddToArrayForm(int[] num, int k)
        {

            int carry = 0;
            int m = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {

                m = k % 10;

                if ((num[i] + m + carry) > 9)
                {

                    num[i] = (num[i] + m + carry) % 10;
                    carry = 1;
                }
                else
                {

                    num[i] = num[i] + m + carry;
                    carry = 0;
                }

                k = k / 10;

            }


            int[] R = new int[num.Length + 1];

            if (carry == 1)
            {
                Array.Copy(num,R, num.Length);
                R[0] = 1;
                return R;

            }
            return num;
        }

            static int[] TwoSum(int[] nums, int target)
        {
         
            int n = nums.Length;
            int Result = 0;
            int Sindex = 0;
            int[] Twosum = new int[2];

            

            Dictionary<int, int > aList = new Dictionary<int, int > ();

            for (int i = 0; i < n; i++)
            {
                aList.Add(i, nums[i]);
            }

           for (int i = 0; i < nums.Length; i++)
           
            {
                if (aList.ContainsValue(target - nums[i]))
                {
                     aList.TryGetValue(target - nums[i], out Sindex);
                    //aList.TryGetKey(target - nums[i], out Sindex);

                    var a=aList.FirstOrDefault(x => x.Value == target - nums[i]).Key;

                    //if ( != i)
                    //{
                        Twosum[0] = i;
                        Twosum[1] = aList[a];
                        break;
                    //}

                }   
                        
                        
                       


            }
            
            return Twosum;



        }

        static int[] TwoSum1(int[] nums, int target)
        {
            var numsDictionary = new Dictionary<int, int>();

            var complement = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                var index = 0;
                if (complement >= 0 && numsDictionary.TryGetValue(complement, out index))
                {
                   
                        return new int[] { index, i };
                }

                if (numsDictionary.ContainsKey(nums[i]) == false)
                {
                    numsDictionary.Add(nums[i], i);
                }
            }

            return null;
        }

        static int Reverse(int x)
        {

            string s = x.ToString();
            int n = s.Length;
            string a="";
            bool IsNegative = false;
            int minlen=0;

            if (s[0] == '-')
            {
                IsNegative = true;
                 minlen = 1;
            }

            for (int i = n - 1; i >= minlen ; i--)
            {
                a += s[i]  ;

            }

            if (IsNegative) a = "-" + a;


            if (int.TryParse(a, out x))
                return x;
            else
                return 0;

            string ch;
            ch = new string(ch.Where(c => Char.IsLetterOrDigit(c)).ToArray());
        }


        static bool IsAnagram(string s, string t)
        {

            Dictionary<int, char> SWord = new Dictionary<int, char>();
            int i = 0;
            bool R = false;
            foreach (char ch in s)
            {
                SWord.Add(i, ch);
                i++;
            }

            for (i = 0; i < t.Length; i++)
            {
                if (SWord.ContainsValue(t[i]))
                {
                    var mykey = SWord.FirstOrDefault(x => x.Value == t[i]).Key;

                    SWord[mykey] = '0';
                }
                

            }
            Dictionary<int, char>.KeyCollection Keys = SWord.Keys;

            foreach (int key in Keys)
            {
                if (SWord[key] == '0')
                {
                    R = true;
                }
                else
                {
                    R = false;
                    break;
                }
            }


            if (R && s.Length == t.Length)
            {
                R = true;
            }

            return R;
        }


        static bool IsPalindrome(string s)
        {
            int n;
            string d = "1";
            n = Convert.ToInt32(d);


            bool flag = false;
            
            string s1 = "";

            s = s.Trim();
            int n1 = s.Length;

            if (n1 <= 1 || s == "")
                return true;

            s = s.ToLower();


            for (int i = 0; i < n1; i++)
            {
                int val = (int)s[i];
                if ((val <= 122 && val >= 97) || (val <= 57 && val >= 48))
                {
                    s1 = s1 + s[i];
                }
            }
            n1 = s1.Length;
            if (n <= 1 || s == "")
                return true;
            for (int i = 0; i < n1 / 2; i++)
                if (s1[i] != s1[n1 - i - 1])
                {
                    flag = false;
                    break;

                }
                else
                {
                    flag = true;
                }

            return flag;
        }


        static int MyAtoi1(string s)
        {

            

            s = s.Trim(' ');
            int n = s.Length;
            string r = "";

            for (int i = 0; i < n; i++)
            {
              
                if ((s[i] == '-' || s[i] == '+'))
                    r = s[i].ToString();
                else if (Char.IsDigit(s[i])) r = r + s[i].ToString();
                else if (String.IsNullOrEmpty(r)) return 0;
            }

            int F;
            Int32.TryParse(r, out F);

            if (F < Math.Pow(-2, 31))
                return Int32.MinValue;
            if (F > Math.Pow(2, 31) - 1)
                return Int32.MaxValue;

            return F;

        }

        static int StrStr(string haystack, string needle)
        {

            if (String.IsNullOrEmpty(needle))
                return 0;

            char d = needle[0];
            int pos = 0;
            int Fpos = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && i < haystack.Length)
                {
                    Fpos = i;
                    while ( i < haystack.Length && pos < needle.Length && haystack[i] == needle[pos] )
                    {
                        i++;
                        pos++;
                    }

                }
                else
                {
                    Fpos = 0;
                    pos = 0;
                }
            }
            if (pos == needle.Length)
                return Fpos;
            return -1;
        }


        static int MyAtoi(string s)
        {

            int sign = 1, Base = 0, i = 0;

            // if whitespaces then ignore.
            while (s[i] == ' ')
            {
                i++;
            }

            // sign of number
            if (s[i] == '-' || s[i] == '+')
            {
                sign = 1 - 2 * (s[i++] == '-' ? 1 : 0);
            }

            // checking for valid input
            while (
                i < s.Length
                && s[i] >= '0'
                && s[i] <= '9')
            {

                // handling overflow test case
                if (Base > int.MaxValue / 10 || (Base == int.MaxValue / 10 && s[i] - '0' > 7))
                {
                    if (sign == 1)
                        return int.MaxValue;
                    else
                        return int.MinValue;
                }
                Base = 10 * Base + (s[i++] - '0');
            }
            return Base * sign;

        }

        static string LongestCommonPrefix(string[] strs)
        {

            int n = strs.Length;
            if (n < 1)
                return "";

            int min = strs[0].Length;
            string least = strs[0];
            string prefix = "";

            for (int i = 1; i < n; i++)
            {
                if (min > strs[i].Length)
                {
                    min = strs[i].Length;
                    least = strs[i];
                }
            }

            bool flag = true;


            for (int j = 0; j < min; j++)
            {
                
                    for (int i = 0; i < n; i++)
                    {
                    if (flag)
                    {
                        string d = strs[i];
                        if (least[j] == d[j])
                            flag = true;
                        else
                        {
                            flag = false;
                        }
                    }
                    }
                    if (flag)
                        prefix = prefix + least[j];
               
            }

            return prefix;
        }


        static int BaseballScore(string[] ops)
        {
            

                Stack<int> f1 = new Stack<int>();

            int y = 0;
                foreach (string w in ops)
                {
                if (w == "C")
                {
                    f1.Pop();
                }
                else if (w == "D")
                {
                    f1.Push(f1.Peek() * 2);
                }
                else if (w == "+")
                {
                    int g = f1.Pop();
                    int ss = f1.Peek();
                    f1.Push(g);
                    f1.Push(g + ss);
                }
                else if (int.TryParse(w, out y))
                  {
                    f1.Push(y);
                }
                }

                int c = 0;
                while (f1.Count >0)
                {
                    c = f1.Pop() + c;
                }

                return c;
            

        }


        static ListNode ReverseList(ListNode head)
        {

            ListNode Current = head;
            ListNode Prev = null;
            ListNode Next = Current.next;
            if (head == null || Current.next == null)
                return head;

            while (Current.next != null)
            {
                Current.next = Prev;
                Prev = Current;
                Current = Next;
                Next = Next.next;




            }
            Current.next = Prev;

            return Current;

        }
        static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode a = list1;
            ListNode b = list2;

            ListNode NewList;
            ListNode NewListHead;
            ListNode Temp = null;

            if (list1 == null)
                return list2;
            else if (list2 == null)
                return list1;


            if (a.val <= b.val)
            {
                NewListHead = a;
                a = a.next;
            }
            else
            {
                NewListHead = b;
                b = b.next;
            }



            NewList = NewListHead;
            while (a != null && b != null)
            {
                Temp = new ListNode();
                if (a.val >= b.val)
                {

                    Temp.val = b.val;
                    Temp.next = null;
                    b = b.next;
                }

                else if (a.val <= b.val)
                {

                    Temp.val = a.val;
                    Temp.next = null;
                    a = a.next;
                }

                NewList.next = Temp;
                NewList = Temp;


            }
            if (a != null)
            {
                NewList.next = a;
            }
            else if (b != null)
            {
                NewList.next = b;
            }


            return NewListHead;







        }


        static ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            var result = new ListNode();
            var curr = result;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                curr = curr.next;
            }
            if (list1 != null)
                curr.next = list1;
            else
                curr.next = list2;

            return result.next;
        }


        static  bool IsPalindrome(ListNode head)
        {

            ListNode Temphead = head;
            ListNode SecondHalf = head;
            int ListCount = 0;

            while (Temphead != null)
            {
                ListCount++;
                Temphead = Temphead.next;
            }

            ListCount = ListCount / 2;
            int Counter = 0;
            while (Counter < ListCount)
            {
                Counter++;
                SecondHalf = SecondHalf.next;
            }

            ListNode Current;
            ListNode Prev = null;
            ListNode Next = SecondHalf;
            Current = SecondHalf;
            SecondHalf = null;
            while (Current != null)
            {
                Next = Current.next;
                Current.next = Prev;
                Prev = Current;
                Current = Next;
            }

            SecondHalf =Prev;

            Temphead = head;
            Counter = 1;
            while (Counter <= ListCount)
            {
                if (Temphead.val != SecondHalf.val)
                    return false;
                Counter++;
                Temphead = Temphead.next;
                SecondHalf = SecondHalf.next;
            }
            return true;


        }

        static int MaxDepth(TreeNode root)
        {



            if (root == null)
                return 0;


            int Ldepth = MaxDepth(root.left);
            int Rdepth = MaxDepth(root.right);

            if (Ldepth > Rdepth)
                return (Ldepth + 1);
            else
                return (Rdepth + 1);

        }


        static bool IsValidBST(TreeNode root)
        {
            //if (root.right == null && root.left == null)
            //    return true;

            //if (IsValidBST(root.left) && IsValidBST(root.right))
            //    return true;

            //if (root.left == null && root.right.val > root.val)
            //    return true;
            //else if (root.right == null && root.left.val < root.val)
            //    return true;
            //else if (root.left.val > root.val || root.right.val < root.val)
            //    return false;


            //return true;

            return isBSTUtil(root, int.MinValue, int.MaxValue);
        }
       static bool isBSTUtil(TreeNode node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null)
            {
                return true;
            }

            /* false if this node val the min/max constraints */
            if (node.val < min || node.val > max)
            {
                return false;
            }

            /* otherwise check the subtrees recursively
            tightening the min/max constraints */
            // Allow only distinct values
            return (isBSTUtil(node.left, min, node.val - 1) && isBSTUtil(node.right, node.val + 1, max));
        }


        public int majorityElement(List<int> A)
        {

            Dictionary<int, int> MyDic = new Dictionary<int, int>();
            int n = A.Count / 2;
            foreach (int b in A)
            {
                if (MyDic.ContainsKey(b))
                {
                    MyDic[b] ++;
                }
                else
                {
                    MyDic.Add(b, 1);
                }

            }
            //if (MyDic.ContainsValue(n))
                return 1;
        }
        static void Merge(int[] nums1, int m1, int[] nums2, int n1)
        {
            //int[] R = new int[m1+n1];

            //int p1 = 0;
            //int p2 = 0;
            //int p3 = 0;

            //while (p3 < m1 + n1 && p1 < m1 && p2 < n1)
            //{

            //    if (nums1[p1] < nums2[p2])
            //    {

            //        R[p3] = nums1[p1];
            //        p1++;
            //        p3++;

            //    }
            //    else if (nums1[p1] > nums2[p2])
            //    {

            //        R[p3] = nums2[p2];
            //        p1++;
            //        p3++;

            //    }
            //    else if (nums1[p1] == nums2[p2])
            //    {

            //        R[p3] = nums1[p1];
            //        p3++;
            //        R[p3] = nums2[p2];
            //        p1++;
            //        p2++;
            //        p3++;
            //    }

            //}
            //p3--;
            //if (p1 == m1 && p2 < n1)
            //    for (int i = p2; i < n1; i++)
            //    {
            //        R[p3] = nums2[i];
            //        p3++;
            //    }
            //else if (p2 == n1 && p1 < m1)
            //    for (int i = p1; i <m1; i++)
            //    {
            //        R[p3] = nums1[i];
            //        p3++;
            //    }


            //nums1 = R;
        }

        static int FirstBadVersion(int n)
        {

            bool isbadv = false;
            int first = 0;
            int last = n;
            int w = 0;

            if (n == 1)
                return n;

            while (last > first)
            {

                w = (first + last) / 2;
                if (!IsBadVersion(w))
                {
                    first = w;
                }
                else
                {
                    isbadv = true;
                    last = w;
                }

            }

            if (IsBadVersion(first))
                w = first;

            return w;

        }

        static bool IsBadVersion(int n)
        {
            if (n >= 4)
                return true;
            return false;
        }


        static string ReverseString(string a)
        {
            int n = a.Length;
            string newString = string.Empty;
            for (int i = n - 1; i >= 0; i--)
            {

                newString += a[i];
            }
            return newString;
        }


         static void ReverseString1(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }



        static bool isprime1(int a)
        {
            for (int i = 3; i < Math.Sqrt(a); i += 2)
                if (a % i == 0)
                    return false;

            return true;
        }

        static int countprime(int b)
        {
            int count = 2;
            if (b <= 1) return 0;
            if (b == 2) return 1;
            if (b == 3) return 2;

            for (int i = 3; i < b; i++)
                if (i % 2 != 0 && i % 3 != 0)
                    if (isprime1(i)) count++;
            return count;
        }


        public static int SearchInsert(int[] nums, int target)
        {

            int n = nums.Length;

            int start = 0;
            int mid = (n - 1) / 2;
            if (target < nums[0])
                return 0;
            if (target > nums[n - 1])
            {
                return n;
            }


            while (target != nums[mid] && mid != start && mid != n)
            {

                if (target > nums[mid])
                {
                    start = mid;


                }
                else if (target < nums[mid])
                {

                    n = mid;
                }
                mid = (n + start) / 2;


            }

            if (mid == start)
                return mid + 1;
            if (mid == n)
                return mid ;
            return mid;


        }
        static Node AddTwoNumbers(Node l1, Node l2)
        {

            int carry = 0;
            Node L3 = null;
            Node Temp=null;
            Node L1Node = l1;
            Node L2Node = l2;



            while (L1Node != null && L2Node != null)
            {

                Node Node1 = new Node((L1Node.value + L2Node.value + carry) % 10);
                carry = (L1Node.value + L2Node.value + carry) / 10;
                 
                if (L3 == null)
                    L3 = Node1;
                else
                    Temp.next = Node1;


                Temp = Node1;
                L1Node = L1Node.next;
                L2Node = L2Node.next;

            }

            if (L1Node != null)
                while (L1Node != null)
                {
                    
                    carry = (L1Node.value + carry) / 10;
                    
                    Node Node1 = new Node((L1Node.value + carry) % 10);
                    L3.next = Node1;
                    L1Node = L1Node.next;
                }
            if (L2Node != null)
                while (L2Node != null)
                {
                    ListNode Node = new ListNode();
                    carry = (L2Node.value + carry) / 10;
                    Node Node1 = new Node((L2Node.value + carry) % 10);
                    
                    L3.next = Node1;
                    L2Node = L2Node.next;
                }

            return L3;

        }

        static bool IsValidSudoku(char[][] board)
        {

            int n = 0;
            int m = 0;
            Dictionary<char, int> Validate = new Dictionary<char, int>();

            while (n < 9 && m < 9)
            {


                Validate.Clear();
                for (int i = n; i < n + 3; i++)
                    for (int j = m; j < m + 3; j++)
                    {
                        if (board[i][j] != '0' && Validate.ContainsKey(board[i][j]))
                        {

                            return false;
                        }
                        else if (board[i][j] != '0')
                        {

                            Validate.Add(board[i][j], 0);
                        }


                    }

                n = n + 3;
                m += 3;




            }
            return true;
        }
        static int GetSum(int a, int b)
        {


            if (b == 0) return a;

            var noCarry = a ^ b;
            var carry = a & b;

            return GetSum(noCarry, carry << 1);
        }

        static int LengthOfLongestSubstring(string s)
        {


            int max = 0;
            int i = 0;
            Dictionary<char, int> MyDic = new Dictionary<char, int>();
            if (s == "")
                return 0;
            if (String.IsNullOrWhiteSpace(s))
                return 1;

            foreach (char c in s)
            {

                if (!MyDic.ContainsKey(c))
                {

                    MyDic.Add(c, i);
                }
                else
                {

                    

                        //max = MyDic.Count();

                        int m = MyDic[c];
                        int Len = 0;
                        foreach (KeyValuePair<char, int> K in MyDic)
                        {

                            if (K.Value <= m)
                            {
                                MyDic.Remove(K.Key);
                            Len++;
                            }
                              

                        }

                    if (Len > max) {
                        max = Len;
                    }



                        MyDic.Add(c, 1);
                    
                  
                }
                i++;
            }


            if (max < MyDic.Count)
            {

                max = MyDic.Count();
            }
            return max;

        }

        static bool IsIsomorphic(string s, string t)
        {

                if (String.IsNullOrEmpty(s) || String.IsNullOrEmpty(t))
                    return true;


                if (s.Length != t.Length)
                    return false;



                Dictionary<char, char> MyDic = new Dictionary<char, char>();




                char map;
                char[] r = t.ToArray();

                int j = 0;



                while (j < s.Length)
                {

                    map = r[j];

                    if (MyDic.ContainsKey(r[j]))

                        map = MyDic[r[j]];

                    else if (!MyDic.ContainsKey(r[j]) && !MyDic.ContainsValue(s[j]))
                    {
                    //var k =MyDic.FirstOrDefault(x => x.Value == 0).Key;

                        MyDic.Add(r[j], s[j]);
                        map = s[j];

                    }
                    else if (!MyDic.ContainsKey(r[j]) && MyDic.ContainsValue(s[j]))

                        return false;



                r[j] = map;
                  
                
                //for (int i = j; i < r.Length; i++)
                    //{

                //    if (r[i] == map)
                //    {

                //        r[i] = s[j];
                //    }

                //}

                j++;




            }
                string f = r.ToString();
                //for (int i = 0; i < r.Length; i++)
                //{

                //    f += r[i];
                //}


                if (f == s)

                    return true;
                else
                    return false;


           


        }
        static int LongestPalindrome(string s)
        {

            Dictionary<char, int> MyDic = new Dictionary<Char, int>();

            foreach (char c in s)
            {
                if (MyDic.ContainsKey(c))
                {
                    MyDic[c] = MyDic[c] + 1;
                }
                else
                {
                    MyDic.Add(c, 1);
                }
            }

            int oddcount = 0;
            int evencount = 0;
            foreach (int val in MyDic.Values)
            {
                if (val % 2 == 0)
                    evencount += val;
                else
                    oddcount += val;
            }

            if (oddcount > 1)
                evencount += oddcount;

            return oddcount;

        }

        static void  splitcharacter()
        {
            // This example demonstrates the String.Split() methods that use
            // the StringSplitOptions enumeration.
            string s1 = ",ONE,,TWO,,,THREE,,";
            string s2 = "[stop]" +
                        "ONE[stop][stop]" +
                        "TWO[stop][stop][stop]" +
                        "THREE[stop][stop]";
            char[] charSeparators = new char[] { ',' };
            string[] stringSeparators = new string[] { "[stop]" };
            string[] result;
            // ------------------------------------------------------------------------------
            // Split a string delimited by characters.
            // ------------------------------------------------------------------------------
            Console.WriteLine("1) Split a string delimited by characters:\n");

            // Display the original string and delimiter characters.
            Console.WriteLine($"1a) The original string is \"{s1}\".");
            Console.WriteLine($"The delimiter character is '{charSeparators[0]}'.\n");

            // Split a string delimited by characters and return all elements.
            Console.WriteLine("1b) Split a string delimited by characters and " +
                              "return all elements:");
            result = s1.Split(charSeparators, StringSplitOptions.None);
            Show(result);

            // Split a string delimited by characters and return all non-empty elements.
            Console.WriteLine("1c) Split a string delimited by characters and " +
                              "return all non-empty elements:");
            result = s1.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            Show(result);

            // Split the original string into the string and empty string before the
            // delimiter and the remainder of the original string after the delimiter.
            Console.WriteLine("1d) Split a string delimited by characters and " +
                              "return 2 elements:");
            result = s1.Split(charSeparators, 2, StringSplitOptions.None);
            Show(result);

            // Split the original string into the string after the delimiter and the
            // remainder of the original string after the delimiter.
            Console.WriteLine("1e) Split a string delimited by characters and " +
                              "return 2 non-empty elements:");
            result = s1.Split(charSeparators, 2, StringSplitOptions.RemoveEmptyEntries);
            Show(result);

            // ------------------------------------------------------------------------------
            // Split a string delimited by another string.
            // ------------------------------------------------------------------------------
            Console.WriteLine("2) Split a string delimited by another string:\n");

            // Display the original string and delimiter string.
            Console.WriteLine($"2a) The original string is \"{s2}\".");
            Console.WriteLine($"The delimiter string is \"{stringSeparators[0]}\".\n");

            // Split a string delimited by another string and return all elements.
            Console.WriteLine("2b) Split a string delimited by another string and " +
                              "return all elements:");
            result = s2.Split(stringSeparators, StringSplitOptions.None);
            Show(result);

            // Split the original string at the delimiter and return all non-empty elements.
            Console.WriteLine("2c) Split a string delimited by another string and " +
                              "return all non-empty elements:");
            result = s2.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            Show(result);

            // Split the original string into the empty string before the
            // delimiter and the remainder of the original string after the delimiter.
            Console.WriteLine("2d) Split a string delimited by another string and " +
                              "return 2 elements:");
            result = s2.Split(stringSeparators, 2, StringSplitOptions.None);
            Show(result);

            // Split the original string into the string after the delimiter and the
            // remainder of the original string after the delimiter.
            Console.WriteLine("2e) Split a string delimited by another string and " +
                              "return 2 non-empty elements:");
            result = s2.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries);
            Show(result);

            // Display the array of separated strings using a local function
            void Show(string[] entries)
            {
                Console.WriteLine($"The return value contains these {entries.Length} elements:");
                foreach (string entry in entries)
                {
                    Console.Write($"<{entry}>");
                }
                Console.Write("\n\n");
            }

            /*
            This example produces the following results:

            1) Split a string delimited by characters:

            1a) The original string is ",ONE,,TWO,,,THREE,,".
            The delimiter character is ','.

            1b) Split a string delimited by characters and return all elements:
            The return value contains these 9 elements:
            <><ONE><><TWO><><><THREE><><>

            1c) Split a string delimited by characters and return all non-empty elements:
            The return value contains these 3 elements:
            <ONE><TWO><THREE>

            1d) Split a string delimited by characters and return 2 elements:
            The return value contains these 2 elements:
            <><ONE,,TWO,,,THREE,,>

            1e) Split a string delimited by characters and return 2 non-empty elements:
            The return value contains these 2 elements:
            <ONE><TWO,,,THREE,,>

            2) Split a string delimited by another string:

            2a) The original string is "[stop]ONE[stop][stop]TWO[stop][stop][stop]THREE[stop][stop]".
            The delimiter string is "[stop]".

            2b) Split a string delimited by another string and return all elements:
            The return value contains these 9 elements:
            <><ONE><><TWO><><><THREE><><>

            2c) Split a string delimited by another string and return all non-empty elements:
            The return value contains these 3 elements:
            <ONE><TWO><THREE>

            2d) Split a string delimited by another string and return 2 elements:
            The return value contains these 2 elements:
            <><ONE[stop][stop]TWO[stop][stop][stop]THREE[stop][stop]>

            2e) Split a string delimited by another string and return 2 non-empty elements:
            The return value contains these 2 elements:
            <ONE><TWO[stop][stop][stop]THREE[stop][stop]>

            */
        }
        static void Main(string[] args)
        {

            splitcharacter();

            string sentence = "You win some. You lose some.";

            string[] subs = sentence.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }


            


            int Longestp = LongestPalindrome("abnnnn");


            char[][] issodo = new char[][] { new char []{ '.', '3', '.', '.', '7', '.', '.', '.', '.' }, new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' }, new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' }, new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' } , new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' }, new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' }, new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' }, new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' } } ;

            bool isvalidsudo = IsValidSudoku(issodo);



            bool isiso = IsIsomorphic("egg", "add");


            int word = LengthOfLongestSubstring("abcabcbb");



            int Gsum = GetSum(3, 2);
            Node N1 = new Node(2);
            Node N2 = new Node(4);
            N2.next = N1;
            Node N3 = new Node(3);
            N3.next = N2;




            Node N11 = new Node(4);
            Node N21 = new Node(6);
            N21.next = N11;
            Node N31 = new Node(4);
            N31.next = N21;


            Node l3 = AddTwoNumbers(N3, N31);












            int[] ff1 = new int[4];
            ff1[0] = 1;
            ff1[1] = 7;
            ff1[2] = 11;
            ff1[3] = 2;

            //ff1.OrderByDescending(b => b[0]);

           // Array.Sort(ff1, 2);

            int[] g = TwoSum(ff1, 9);


            int[] ar = new int[] { 2, 1, 5 };
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    ar[i] = ar.Length - 1 - i;

            //}


            IList<int> I = AddToArrayForm(ar ,806);





            ar = PlusOne(ar);
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + ",");

            }



            int c11=countprime(20);
             int c12=CountPrimes(20);

             ReverseString1("Hello");

            //int badv = FirstBadVersion(5);

            int[] f = new int[3];
            //for (int i = 0; i < f.Length; i++)
            //{
            //    f[i] = i+1; 
            //}

            f[0] = 1;
            f[1] = 3;
            f[2] = 5;
            //f[3] = 6;
            //f[4] = 0;
            //f[5] = 0;


            int yy = SearchInsert(f, 1);


            int[] f1 = new int[3];
            //for (int i = 0; i < f.Length; i++)
            //{
            //    f[i] = i+1; 
            //}
            f1[0] = 2;
            f1[1] = 5;
            f1[2] = 6;

            Merge(f, 4, f1, 3);


            Rotate(f, 3);





            TreeNode treenode6 = new TreeNode(1, null, null);
            TreeNode treenode7 = new TreeNode(3, null, null);
            TreeNode treenode8 = new TreeNode(2, treenode6, treenode7);
            

            bool IsBTS = IsValidBST(treenode8);





            TreeNode treenode1 = new TreeNode(9, null, null);
            TreeNode treenode2 = new TreeNode(15, null, null);
            TreeNode treenode3 = new TreeNode(7, null, null);
            TreeNode treenode4 = new TreeNode(20, treenode2, treenode3);
            TreeNode treenode5 = new TreeNode(3, treenode1, treenode4);

            int TreeDep = MaxDepth(treenode5);












            ListNode t1 = new ListNode(3,null);
           
            ListNode t2 = new ListNode(2, t1);
          
            ListNode t3 = new ListNode(1, t2);
           
            ListNode t4 = new ListNode(1, t3);
            ListNode t5 = new ListNode(2, t4);
            ListNode t6 = new ListNode(3, t5);





            ListNode NewList = new ListNode();
            // ReverseList(t4);

            bool Ispalindromic = IsPalindrome(t6);


            NewList = MergeTwoLists(t3, t4);

            NewList = MergeTwoLists1(t3, t5);
            string[] s11 = new string[] { "5", "2", "C" ,"D","+" };
            int fff= BaseballScore(s11);


            string[] s1 = new string[] { "Car", "Dog", "floCar" };
            string h=LongestCommonPrefix(s1);








            int ret = StrStr("a", "a");

            int tt1 = MyAtoi1("-91283472332");
            Console.WriteLine(IsAnagram("a", "ax"));
            IsPalindrome(" apG0i4maAs::sA0m4i0Gp0");
            int tt = Reverse(542);
            //int.TryParse("11", out g);

            string s="10";


            List<int> vs = new List<int>();
            vs.Add((Convert.ToInt32(s) * 2));




            //FindingLLMiddle FM = new FindingLLMiddle();


            //RotatingKClockwise b = new RotatingKClockwise() ;


            //ReverseKgroup b = new ReverseKgroup();

            //Test b = new Test();

            //FindingLoopinLL b = new FindingLoopinLL();

            //FindNthfromend b = new FindNthfromend();

            // MergTwoSortedLL b = new MergTwoSortedLL();
            // Flattering.List b = new Flattering.List();
            // SwapPair b = new SwapPair();
            //  AddTwoLists b = new AddTwoLists();

            PalindromicLL b = new PalindromicLL();
            b.main();

            double x = Math.Log(243, 3);
            var y = x - (Math.Truncate(Math.Round(x,5)));
            if (Math.Round(4.99,2) == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");



            List<string> a = new List<string>();
            a=FizzBuzz(15);


            //  bool c = isprime(5);
            foreach(var c in a)
                  {
                Console.Write(c +',');
            }
            //Console.WriteLine(CountPrimes(10));
           

            
           

          
        }

    }
}
