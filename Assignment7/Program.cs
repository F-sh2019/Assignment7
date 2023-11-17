using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                //index = kindex;
                //index = kindex;

                count++;



            }



        }

        static int[] RotateArray2(int[] nums, int k)
        {
            int n = nums.Length;

            k %= n;

            k = n - k;

            int[] origin = new int[n];
            Array.Copy(nums, 0, origin, 0, n);

            for (int i = 0; i < n; i++, k++)
            {
                if (k == n) k = 0;
                nums[i] = origin[k];

            }
            return nums;
        }

        static int[] RotateArray(int[] nums, int k)
        {
            int n = nums.Length;
            k %= n;
            int[] a = new int[k];
            int j = 0;
            for (int i = n - k; i < n; i++)
            {
                a[j] = nums[i];
                j++;
            }
            for (int i = n - k; i > 0; i--)
            {
                nums[i + k - 1] = nums[i - 1];

            }
            j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                nums[i] = a[j];
                j++;
            }
            return nums;

        }

        static int[] PlusOne(int[] digits)
        {

            int n = digits.Length;
            int[] Res = new int[n + 1];

            string a = "";

            int carry = 1;
            for (int i = n - 1; i >= 0; i--)
            {

                a = (digits[i] + carry) + a;
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
                Array.Copy(num, R, num.Length);
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



            Dictionary<int, int> aList = new Dictionary<int, int>();

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

                    var a = aList.FirstOrDefault(x => x.Value == target - nums[i]).Key;

                    //if ( != i)
                    //{
                    Twosum[0] = i;
                    // Twosum[1] = a. aList[a];
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
            string a = "";
            bool IsNegative = false;
            int minlen = 0;

            if (s[0] == '-')
            {
                IsNegative = true;
                minlen = 1;
            }

            for (int i = n - 1; i >= minlen; i--)
            {
                a += s[i];

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

        static int[] Intersect(int[] nums1, int[] nums2)
        {


            int[] Re = new int[nums1.Length + nums2.Length];

            Dictionary<int, int> M1 = new Dictionary<int, int>();

            Dictionary<int, int> M2 = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (M1.ContainsKey(nums1[i]) == false)
                {
                    M1.Add(nums1[i], 1);
                }
                else
                    M1[nums1[i]]++;
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (M2.ContainsKey(nums2[i]) == false)
                {
                    M2.Add(nums2[i], 1);
                }
                else
                    M2[nums2[i]]++;
            }
            int y = 0;
            foreach (var ind in M1)
            {
                if (M2.ContainsKey(ind.Key))
                {
                    int u = Math.Min(M2[ind.Key], ind.Value);
                    {
                        for (int i = 0; i < u; i++)
                        {
                            Re[y] = ind.Key;
                            y++;
                        }
                    }
                }
            }
            return Re;

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
                    while (i < haystack.Length && pos < needle.Length && haystack[i] == needle[pos])
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
            while (f1.Count > 0)
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


        static bool IsPalindrome(ListNode head)
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

            SecondHalf = Prev;

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



            //if (root == null)
            //    return 0;


            //int ldepth = maxdepth(root.left);
            //int rdepth = maxdepth(root.right);

            //if (ldepth > rdepth)
            //    return (ldepth + 1);
            //else
            //    return (rdepth + 1);

            if (root == null)
                return 0;

            //return (MaxDepth(root.left));

            return (Math.Max(MaxDepth(root.left), MaxDepth(root.right))) + 1;

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


        static int majorityElement(List<int> A)
        {

            /* Dictionary<int, int> MyDic = new Dictionary<int, int>();
             int n = A.Count / 2;
             foreach (int b in A)
             {
                 if (MyDic.ContainsKey(b))
                 {
                     MyDic[b]++;
                 }
                 else
                 {
                     MyDic.Add(b, 1);
                 }

             }
             if (MyDic.ContainsValue(n))
             return 1;
             return -1;*/
            int count = 0;
            int? candidate = null;

            foreach (int num in A)
            {
                if (count == 0) candidate = num;
                count += (num == candidate) ? 1 : -1;
                if (count > A.Count / 2) return candidate.Value;
            }

            return candidate.Value;
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
                return mid;
            return mid;


        }
        static Node AddTwoNumbers(Node l1, Node l2)
        {

            int carry = 0;
            Node L3 = null;
            Node Temp = null;
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
        static bool ContainsDuplicate(int[] nums)
        {

            Dictionary<int, int> MP = new Dictionary<int, int>();


            for (int i = 0; i <= nums.Length; i++)
            {
                if (MP.ContainsKey(nums[i]) == false)
                    MP.Add(nums[i], 0);
                else
                    return false;
            }

            return true;
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

        static int RemoveDuplicates(int[] nums)
        {

            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[k] != nums[i])

                {
                    k++;
                    nums[k] = nums[i];
                }
            }
            return k + 1;

        }
        static int GetSum(int a, int b)
        {


            if (b == 0) return a;

            var noCarry = a ^ b;
            var carry = a & b;

            return GetSum(noCarry, carry << 1);
        }

        static int MaxProfit(int[] prices)
        {

            int sum = 0;
            int k = 0;
            int n = prices.Length;

            for (int i = 1; i < n; i++)
            {
                if (prices[k] >= prices[i])
                {
                    k = i;
                }
                else
                {
                    sum += prices[i] - prices[k];
                    if (i + 1 < n)
                        k = i + 1;
                    //i++;
                }
            }
            return sum;

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

        static void splitcharacter()
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

        static IList<int> InorderTraversal(TreeNode root)
        {

            Stack<TreeNode> s = new Stack<TreeNode>();

            IList<int> l = new List<int>();

            TreeNode r = root;

            while (r != null || s.Count > 0)
            {
                while (r != null)
                {
                    s.Push(r);
                    r = r.left;
                }




                r = s.Pop();
                l.Add(r.val);


                r = r.right;



            }

            return l;


        }


        static ListNode InsertionSortList(ListNode head)
        {


            if (head == null)
                return head;

            ListNode node = head;
            ListNode current = head;
            while (node.next != null)
            {
                ListNode upperhalf = current;
                if (node.val > node.next.val)
                {
                    // current=node.next ;
                    ListNode Temp = node.next;




                    if (upperhalf.val > Temp.val)
                    {

                        node.next = Temp.next;
                        Temp.next = upperhalf;
                        current = Temp;
                    }
                    else
                    {

                        while (upperhalf.val < Temp.val && upperhalf.next != null && upperhalf.next.val < Temp.val)
                        {


                            upperhalf = upperhalf.next;

                        }
                        node.next = Temp.next;
                        Temp.next = upperhalf.next;
                        upperhalf.next = Temp;
                        //Temp.next = node;
                        //current=Temp ;

                    }


                }
                else
                {

                    node = node.next;
                }


            }

            return current;

        }

        static int[] SmallestTrimmedNumbers(string[] nums, int[][] queries)
        {

            //int[] output = new int[queries.Length];

            //int[,] nc = new int[nums.Length, nums.Length];
            //int[,] nco = new int[nums.Length, nums.Length];

            //int k = 0;
            //while (k < queries.Length)
            //{
            //    int u = queries[k][0];

            //    for (int i = 0; i < nums.Length/2; i++)
            //    {
            //        nc[i, 0] = i;
            //        nc[i, 1] = Int32.Parse(nums[i].Substring(nums[i].Length - queries[k][1], queries[k][1]));
            //    }

            //    int min = nc.Cast<int>().Min();
            //    int max = nc.Cast<int>().Max();

            //    int[] count = new int[max - min + 1];

            //    for (int i = 0; i < nc.GetLength(0); i++)
            //        count[nc[i, 1] - min]++;

            //    for (int i = 1; i < count.Length; i++)

            //        count[i] += count[i - 1];


            //    for (int i = nc.GetLength(0) - 1; i >= 0; i--)
            //    {
            //        nco[i, 0] = nc[count[nc[i, 1] - min] - 1, 0];
            //        nco[i, 1] = nc[count[nc[i, 1] - min] - 1, 1];
            //        count[i]--;

            //    }

            //    output[k] = nco[u, 0];
            //    k++;

            //    return output;
            //}
            int[] output = new int[queries.Length];

            int[] nc = new int[nums.Length];
            int[] nco = new int[nums.Length];

            int k = 0;
            while (k < queries.Length)
            {

                int u = queries[k][0];
                for (int i = 0; i < nums.Length; i++)
                {
                    nc[i] = i;
                    nc[i] = Int32.Parse(nums[i].Substring(nums[i].Length - queries[k][1], queries[k][1]));
                }

                // int min=nc.Cast<int>().Min() ;
                // int max=nc.Cast<int>().Max() ;

                int min = nc.Min();
                int max = nc.Max();

                int[] count = new int[max - min + 1];

                for (int i = 0; i < nc.Length; i++)
                    count[nc[i] - min]++;

                for (int i = 1; i < count.Length; i++)

                    count[i] += count[i - 1];


                for (int i = nc.Length - 1; i >= 0; i--)
                {
                    //nco[i] = nc[count[nc[i] - min] - 1];
                    //nco[i] = nc[count[nc[i] - min] - 1];
                    nco[count[nc[i] - min] - 1] = nc[i];


                    if (count[nc[i] - min] - 1 == u - 1)
                    {
                        output[k] = i;
                        break;
                    }
                    count[nc[i] - min]--;

                }

                //   output[k] = nco[u-1];
                k++;



            }

            return output;


        }

        static Boolean IsNumberEven(int num)
        {
            if (num == 0 || num % 2 == 1)
                return false;
            else
                return true;


        }

        static double CTOF(double degree)
        {
            return ((degree * 9) / 5) + 32;

        }

        static string Reversestring(string g)
        {
            string R = String.Empty;
            for (int i = g.Length - 1; i >= 0; i--)
            {
                R += g[i];
            }
            return R;
        }

        static int SumOfDigit(int num)
        {
            if (num > 0)
            {
                return (num % 10 + SumOfDigit(num / 10));
            }
            else
                return 0;
        }

        static char LowerorUpper(char a)
        {
            int c = (int)a;

            if (c >= 67 && c <= 90)
                a = char.ToUpper(a);
            else if (c >= 97 && c <= 122)
                a = char.ToLower(a);

            return a;
        }


        static void joggedarray()
        {
            int[][] a = new int[3][];

            a[0] = new int[2] { 1, 2 };
            a[1] = new int[1] { 10 };
            a[2] = new int[5] { 11, 12, 13, 14, 15 };




            for (int i = 0; i < a.Length; i++)
            {
                int[] b = a[i];
                for (int j = 0; j < b.Length; j++)
                {
                    Console.WriteLine(b[j]);

                }

            }
            Console.WriteLine("The array dimension rank is {0} ", a.Rank);


            Console.Write(a.GetLowerBound(0));
            Console.Write(a.GetUpperBound(1));
            //    Console.Write(a.GetLowerBound(2));



        }

        public static void FindObject(Array array, Object o)
        {
            int index = Array.BinarySearch(array, 0, array.Length, o);
            Console.WriteLine();
            if (index > 0)
            {
                Console.WriteLine("Object: {0} found at [{1}]", o, index);
            }
            else if (~index == array.Length)
            {
                Console.WriteLine("Object: {0} not found. "
                   + "No array object has a greater value.", o);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Object: {0} not found. "
                   + "Next larger object found at [{1}].", o, ~index);
            }
        }

        static void StringFuncs()
        {

            string str1 = "Hey How Are You Doing? \n see you \n  ";
            string str2 = " You How Do do ";

            Console.WriteLine(str1.Length);


            int s3 = string.Compare(str2, str1);

            long count = 0;
            int start = 0;
            while ((start = str1.IndexOf('\n', start)) != -1)
            {
                count++;
                start++;
            }
            string str3 = str1.Substring(1, 2);
            //str1.Contains()




            //  string a= """say " hello" to the world! """;
            //   string b= """Friends say "hello" as they pass by."""

            string[] email = new string[] {"One@aaa.com", "Two@aaa.com",
                        "Three@aaa.com", "Four@aaa.com",
                        "Five@aaa.com", "Six@aaa.com",
                        "Seven@aaa.com", "Eight@aaa.com"};

            //var d = email.Where(x => x == top.MaxDepth());


            var Grp = from i in Enumerable.Range(0, email.Length)
                      group email[i] by i / 3;
            foreach (var mail in Grp)
                string.Join(";", mail.ToArray());


            Console.WriteLine();

        }

        static void abbre(string str)
        {
            char[] c, result;
            int j = 0;
            c = new char[str.Length];
            result = new char[str.Length];
            c = str.ToCharArray();
            result[j++] = (char)((int)c[0] ^ 32);
            result[j++] = '.';
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (c[i] == ' ' || c[i] == '\t' || c[i] == '\n')
                {
                    int k = (int)c[i + 1] ^ 32;
                    result[j++] = (char)k;
                    result[j++] = '.';
                }
            }

            Console.Write("The Abbreviation for {0} is ", str);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static void allSubStr(string s)
        {
            int j = 1;
            List<string> l = new List<string>();
            while (j <= s.Length)
            {
                for (int i = 0; i < s.Length; i++)
                {

                    if (i + j <= s.Length)
                    {
                        l.Add(s.Substring(i, j));
                        //   i = i + j;
                    }

                }
                j++;

            }

            List<string> a = new List<string>();
            for (int i = 1; i <= s.Length; i++)
            {
                for (j = 0; j <= s.Length - i; j++)
                {
                    string substring = s.Substring(j, i);
                    a.Add(substring);
                    Console.WriteLine(a[j]);
                }
            }


        }

        static bool IsValidSudoku1(char[,] board)
        {

            Dictionary<int, int> Valid = new Dictionary<int, int>();


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.')
                    {
                        if (Valid.ContainsKey(Convert.ToInt32(board[i, j])))
                            return false;
                        Valid.Add(Convert.ToInt32(board[i, j]), 0);
                    }
                }
                Valid.Clear();

            }
            Valid.Clear();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[j, i] != '.')
                    {
                        if (Valid.ContainsKey(Convert.ToInt32(board[j, i])))
                            return false;
                        Valid.Add(Convert.ToInt32(board[j, i]), 0);
                    }
                }
                Valid.Clear();
            }
            Valid.Clear();
            int m = 0;

            for (int i = 0; i < 9 - 2; i += 3)
            {

                // j stores first column of
                // each 3 * 3 block
                for (int j = 0; j < 9 - 2; j += 3)
                {

                    // for (int j = m; j < 3+m; j++)
                    //{
                    if (Convert.ToInt32(board[i, j]) != '.')
                    {
                        if (Valid.ContainsKey(Convert.ToInt32(board[i, j])))
                            return false;
                        Valid.Add(Convert.ToInt32(board[i, j]), 0);
                    }
                    //}

                }
                //  m = m + 3;
                Valid.Clear();
            }



            return true;




        }


        static bool IsValidSudoku2(char[][] board)
        {

            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {

                    if (board[i][j] != '.')
                    {

                        char curr = board[i][j];
                        if (!seen.Add(curr + "at row " + i) || !seen.Add(curr + "at col " + j) || !seen.Add(curr + "at sub box " + i / 3 + " " + j / 3))
                        {

                            return false;
                        }
                    }
                }
            }

            return true;
        }

        static void MergeArray2(int[] nums1, int m, int[] nums2, int n)
        {

            int i = m - 1,
            j = n - 1,
            k = m + n - 1;

            while (i > -1 && j > -1)
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[k] = nums1[i--];
                }
                else
                {
                    // Console.WriteLine(nums2[j] );
                    nums1[k] = nums2[j];
                    //    Console.WriteLine(nums1[k] );
                }

                k--;
            }

            while (j > -1)
            {
                nums1[k--] = nums2[j--];
            }
        }
        static bool IsValids(string s)
        {
            //Stack<char> sign = new Stack<char>();

            /*   foreach (var item in s.ToCharArray())
                   if (item == '(')
                       sign.Push(')');
                   else if (item == '[')
                       sign.Push(']');
                   else if (item == '{')
                       sign.Push('}');
                   else if (sign.Count == 0 || sign.Pop() != item)
                       return false;

               return sign.Count == 0;*/
            Stack<char> sign = new Stack<char>();

            foreach (char i in s)
            {
                if (i == '(' || i == '[' || i == '{')
                    sign.Push(i);
                if (i == ')' || i == ']' || i == '}')
                {

                    if (sign.Count == 0)

                    {
                        Console.Write(sign.Count);
                        return false;
                    }

                    if (i == '(' && sign.Peek() != ')')
                    {
                        Console.Write("asd");
                        Console.Write(sign.Peek());
                        return false;
                    }
                    else
                        sign.Pop();

                    if (i == '{' && sign.Peek() != '}')
                        return false;
                    else
                        sign.Pop();
                    if (i == '[' && sign.Peek() != ']')
                        return false;
                    else
                        sign.Pop();


                }
            }
            Console.Write("tah");
            Console.Write(sign.Count);
            return sign.Count == 0;

        }



        static IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> s = new List<IList<int>>();

            Dictionary<int, int> m = new Dictionary<int, int>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
                m.Add(i, nums[i]);

            int l = 0;
            int sum = 0;

            for (int i = l; i < nums.Length - 1; i++)
            {
                Console.WriteLine("i is {0}", l);
                sum = nums[i] + nums[i + 1];
                Console.WriteLine("sum is {0}", sum);
                foreach (var key in m)
                    if (key.Value == -sum && key.Key > i + 1)
                    {
                        //List<int> j= new 
                        Console.WriteLine("num[i] is {0}", nums[i]);
                        s.Add(new List<int> { nums[i], nums[i + 1], key.Value });
                    }
                l++;

            }

            return s;

        }


        static int LengthOfLongestSubstring1(string s)
        {
            if (s == null || s == String.Empty)
                return 0;

            HashSet<char> set = new HashSet<char>();
            int currentMax = 0,
                i = 0,
                j = 0;

            while (j < s.Length)
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    currentMax = Math.Max(currentMax, j - i);
                }
                else
                {
                    set.Remove(s[i]);
                    i++;
                }

            return currentMax;
        }
        static int[] Intersect1(int[] nums1, int[] nums2)
        {


            var res = new List<int>();
            var dict = new Dictionary<int, int>();
            foreach (var n1 in nums1)
            {
                if (!dict.ContainsKey(n1))
                    dict.Add(n1, 0);
                dict[n1]++;
            }

            foreach (var n2 in nums2)
            {
                if (dict.ContainsKey(n2) && dict[n2] > 0)
                {
                    res.Add(n2);
                    dict[n2]--;
                }
            }
            return res.ToArray();





        }

        static int[] PlusOne1(int[] digits)
        {




            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;

        }

        static bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
                return false;

            int minIndex = Int32.MinValue;
            int midIndex = Int32.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                if ((midIndex != Int32.MinValue) && (currentNumber > nums[midIndex]))
                    return true;

                if ((minIndex == Int32.MinValue) || (currentNumber < nums[minIndex]))
                    minIndex = i;

                if (currentNumber > nums[minIndex])
                    midIndex = i;
            }

            return false;
        }

        static string LongestPalindrome1(string s)
        {

            if (s == "" || s.Length <= 1)
                return s;


            int length = 0, start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int evenLength = PalindromeLength(s, i, i + 1);
                int oddLength = PalindromeLength(s, i, i);
                int currentLength = Math.Max(evenLength, oddLength);

                if (currentLength > length)
                {
                    length = currentLength;
                    start = i - (length - 1) / 2;
                }
            }

            return s.Substring(start, length);
        }

        static int PalindromeLength(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1; // (right+1) - (left-1) - 1
        }

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {


            ListNode prenode = new ListNode();
            ListNode l3 = prenode;

            int val = 0;

            while (l1 != null || l2 != null || val != 0)
            {
                if (l1 != null)
                {
                    val += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    val += l2.val;
                    l2 = l2.next;
                }



                prenode.next = new ListNode(val % 10);
                val = val / 10;
                prenode = prenode.next;
            }
            return l3.next;
        }



        static ListNode OddEvenList(ListNode head)
        {

            if (head == null) return null;
            long EvenCount = 0;
            ListNode l = head;

            while (l != null)
            {
                EvenCount++;
                l = l.next;
            }



            if (EvenCount / 2 == 1)
                EvenCount /= 2 + 1;
            else
                EvenCount /= 2;



            Console.WriteLine("EvenCount{0}", EvenCount);
            long count = 0;
            l = head.next;
            ListNode m = l;
            while (count < EvenCount & m != null)
            {
                //Console.WriteLine("l value{0}",l.val ) ;
                l = m;
                while (l != null && l.next != null)
                {
                    int val = l.val;
                    l.val = l.next.val;
                    l.next.val = val;
                    l = l.next;
                    Console.WriteLine("l value{0}", l.val);
                }
                Console.WriteLine("m value{0}", m.val);
                m = m.next;
                count++;

            }

            // head.next= l;
            return head;

        }
        static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode refHead_A = headA, refHead_B = headB;

            while (refHead_A != refHead_B)
            {
                if (refHead_A == null)
                    refHead_A = headB;
                else
                    refHead_A = refHead_A.next;

                if (refHead_B == null)
                    refHead_B = headA;
                else
                    refHead_B = refHead_B.next;
            }
            return refHead_A;
        }

        static int kthlargestelement(int[] nums, int k)
        {
         return kthSmallest( nums,0,  nums.Length - 1, k) ;
               
        }
        public static int kthSmallest(int[] arr, int l, int r, int K)
        {
            // If k is smaller than number
            // of elements in array
            if (K > 0 && K <= r - l + 1)
            {
                // Partition the array around last
                // element and get position of pivot
                // element in sorted array
                int pos = partition(arr, l, r);

                // If position is same as k
                if (pos - l == K - 1)
                    return arr[pos];

                // If position is more, recur for
                // left subarray
                if (pos - l > K - 1)
                    return kthSmallest(arr, l, pos - 1, K);

                // Else recur for right subarray
                return kthSmallest(arr, pos + 1, r,
                                   K - pos + l - 1);
            }

            // If k is more than number
            // of elements in array
            return int.MaxValue;
        }
    

        public static int partition(int[] nums, int l, int r)
        {
            int x = nums[r];
            int i = l;
            int tmp = 0;
            for (int j = 0; j < r; j++)
            {
                if (x < nums[j])
                {
                    //tmp = nums[j];
                    //nums[j] = nums[i];
                    //nums[i] = tmp;
                    i++;
                
                }
            }
            tmp = nums[i];
            nums[i] = nums[r];
            nums[r] = tmp;

            return i;
        
        
        }
        static bool CanJump(int[] nums)
        {

            int farthest = nums[0];

            //         for(int i = 0; i < nums.Length; i++)
            //         {
            //             if(i > farthest)
            //                 return false;

            //             farthest = Math.Max(farthest, i + nums[i]);
            //             if(farthest > nums.Length)
            //                 return true;
            //         }

            //         return true;
            // dp[i] means whether index i be reached or not
            bool[] dp = new bool[nums.Length];
            dp[0] = true;

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // check whether we jump from index j to index i?
                    if (dp[j] && j + nums[j] >= i)
                        dp[i] = true;
                }
            }

            return dp[nums.Length - 1];
        }
        static int CoinChange(int[] coins, int amount)
        {
            /*  int[] d = new int[amount + 1];

              for (int i = 1; i <= amount; i++)
              {
                  d[i] = int.MaxValue;
                  for (int j = 0; j < coins.Length; j++)
                  {
                      if (i >= coins[j] && d[i - coins[j]] != int.MaxValue)
                      {
                          d[i] = Math.Min(d[i], 1 + d[i - coins[j]]);
                      }
                  }
              }

              return d[amount] == int.MaxValue ? -1 : d[amount];*/
            var dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;
            foreach (var coin in coins)
                for (int i = coin; i <= amount; i++)
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
            return dp[amount] != amount + 1 ? dp[amount] : -1;

            
        }
        static int CountSegments(string s)
        {
            int start = 0;
            int end = 0;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == ' '|| i==s.Length-1) && (end - start) != 0)
                {
                    count++;

                }
                else
                if (i > 0 && s[i] != ' ' && s[i - 1] != ' ')
                    end++;

                else if (s[i] != ' ' && ( i >= 0 || s[i - 1] == ' '))
                {
                    start = i;
                    end = i;
                }





            }
            return count;
        }

        static string Fraction(int no, int de)
        {
            long n = no;
            long d = de;
            StringBuilder res = new StringBuilder();

            res.Append((n < 0 || d < 0) ? "-" : "");
            long init = n / d;
            res.Append(init);
            long rem = n % d;
            if (rem == 0) return res.ToString();
            res.Append(".");
            var dic = new Dictionary<long, int>();
            while (rem > 0)
            { if (dic.ContainsKey(rem))
                {
                    res.Insert(dic[rem], '(');
                    res.Append(')');
                    break;


                }
                else
                {
                    dic[rem] = res.Length;
                    rem *= 10;
                    res.Append(rem / d);
                    rem = rem % d;

                
                }
            }

            return res.ToString();


        }

        static int GetSum1(int a, int b)
        {
            while (b != 0)
            {
                int carry = (a & b) << 1;
                a = a ^ b;
                b = carry;
            }

            return a;
        }
        static int MajorityElement(int[] nums)
        {
            int count = 0;
            int? candidate = null;

            foreach (int num in nums)
            {
                if (count == 0) candidate = num;
                count += (num == candidate) ? 1 : -1;
                if (count > nums.Length / 2) return candidate.Value;
            }

            return candidate.Value;
        }

        static  int LengthOfLastWord(string s)
        {

            int f = 0;
            int e = 0;
            int j = 0;


            while (j < s.Length)
            {

                
                if ((j == 0 && s[j] != ' ') || (s[j] != ' ' && s[j - 1] == ' '))
                {
                    f = j;
                    e = j;
                }
                else if (s[j] != ' ' && s[j - 1] != ' ')
                {
                    e = j;
                }

                j++;

            }
            return e - f+1;

        }
        static string AddBinary(string a, string b)
        {

            string tmp = "";
            if (a.Length < b.Length)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            tmp = "";
            for (int i = 0; i < a.Length - b.Length; i++)
                tmp += "0";
            b = tmp + b;
            int carry = 0;
            string res = "";
            int ai = 0;
            int bj = 0;

            for(int i=a.Length-1 ; i>=0;i--)
                {
                if (a[i] == '1') ai = 1; else ai = 0;
                if (b[i] == '1') bj = 1; else bj = 0;

                    int t= (ai ^ bj) ^ carry;
                   // res =Convert.ToString(t)  + res;
                if (ai == 1 && bj == 1)
                    carry = 1;
                else if ((ai == 1 || bj == 1) && carry == 1)
                    carry = 1;
                else carry = 0;
                }
            if (carry == 1) res = "1" + res;
            return res;
        }
        static string CountAndSay(int n)
        {
            /*  if (n == 1)
                   {
                       return "1";
                   }

                   var prevSolution = CountAndSay(n - 1);

                   // Convert
                   var prevChar = prevSolution[0];
                   int counter = 1;
                   var result = new StringBuilder();

                   for (int i = 1; i < prevSolution.Length; i++)
                   {
                       if (prevSolution[i] == prevChar)
                       {
                           counter++;
                       }
                       else
                       {
                           result.Append(counter);
                           result.Append(prevChar);
                           prevChar = prevSolution[i];
                           counter = 1;
                       }
                   }


                   result.Append(counter);
                   result.Append(prevChar);
                   return result.ToString();*/
            var current = "1";
            for (var i = 1; i < n; i++)
            {
                current = convert(current);
            }

            return current;

        }


        static string convert(string s)
        {
            var current = s[0];
            var count = 1;
            var result = new StringBuilder();
            for (var i = 1; i < s.Length; i++)
            {
                if (current != s[i])
                {
                    result.Append(count.ToString());
                    result.Append(current);
                    count = 1;
                    current = s[i];
                }
                else
                {
                    count++;
                }
            }

            result.Append(count.ToString());
            result.Append(current);

            return result.ToString();


        }

        static Dictionary<string, string> dict = new Dictionary<string, string>();
        static IList<string> res = new List<string>();

        static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length < 1)
                return res;

            dict.Add("2", "abc");
            dict.Add("3", "def");
            dict.Add("4", "ghi");
            dict.Add("5", "jkl");
            dict.Add("6", "mno");
            dict.Add("7", "pqrs");
            dict.Add("8", "tuv");
            dict.Add("9", "wxyz");

            combi(digits, 0, string.Empty);
            return res;
        }

        static void combi(string digits, int index, string str)
        {
            if (index > digits.Length - 1)
            {
                res.Add(str);
                return;
            }

            for (var i = 0; i < dict[digits[index].ToString()].Length; i++)
                combi(digits, index + 1, str + dict[digits[index].ToString()][i].ToString());
        }

        static List<string> l = new List<string>();
        static int maxlen = 0;

        static IList<string> GenerateParenthesis(int n)
        {

            //    if (n==0)
            //      return l ;
            maxlen = n;
            generatepara("", 0, 0);
            return l;



        }


        static void generatepara(string s, int open, int close)
        {
            if (open == close && maxlen == open)
            {
                l.Add(s);
                return;
            }
            if (open < maxlen)
                generatepara(s + "(", open + 1, close);
            if (close < open)
                generatepara(s + ")", open, close + 1);

           

        }

        static IList<IList<int>> res1 = new List<IList<int>>();
        static bool[] v;

        static IList<IList<int>> Permute(int[] nums)
        {
            v = new bool[nums.Length];

            DFS(nums, new List<int>());

            return res1;
        }

        static void DFS(int[] nums, List<int> cur)
        {
            if (nums.Length == cur.Count)
            {
                res1.Add(new List<int>(cur));
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!v[i])
                {
                    v[i] = true;
                    cur.Add(nums[i]);

                    DFS(nums, cur);

                    v[i] = false;
                    cur.RemoveAt(cur.Count - 1);
                }
            }
        }

        static IList<IList<int>> Permute1(int[] nums)
        {

            List<IList<int>> res = new List<IList<int>>();
            Backtracking(nums, new List<int>(), res);
            return res;
        }

        static void Backtracking(int[] nums, List<int> list, List<IList<int>> res)
        {
            if (list.Count == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (list.Contains(nums[i]))
                        continue;
                    list.Add(nums[i]);
                    Backtracking(nums, list, res);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }

        static ListNode RemoveElements(ListNode head, int val)
        {


            if (head == null) return null;




            ListNode h = head;

            while (h != null)
            {
                if (h.val == val)
                {
                    if (h.next != null)
                    {
                        h.val = h.next.val;
                        h.next = h.next.next;
                        h = h.next;
                    }
                    else
                    {
                        h = null;
                    }
                }
                else
                {
                    h = h.next;

                }
              
                


            }



            return head;
        }

        static bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix.GetLength(1) == 0)
                return false;

            int m = matrix.GetLength(0), n = matrix.GetLength(1);
            int i = 0, j = n - 1;

            while (i < m && j >= 0)
            {
                int num = matrix[i, j];

                if (num == target)
                    return true;
                else if (num > target)
                    j--;
                else
                    i++;
            }

            return false;
        }
        static int LengthOfLIS(int[] nums)
        {

            var dp = new int[nums.Length];
            Array.Fill(dp, 1);
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], 1 + dp[j]);
                    }
                }
            }

            return dp.Max();
        }
        static int FindKOr(int[] nums, int k)
        {
            int n = nums.Length;
            int res = nums[0];
            if (n == k)
            {
                for (int i = 1; i < n; i++)
                {
                    res = res & nums[i];
                }
                return res;
            }

            if (n > 1 && k == 1)
            {
                for (int i = 1; i < n; i++)
                {
                    res = res | nums[i];
                }
                return res;
            }

            int count = 0;
            res = 0;
            for (int j = 0; j < k; j++)
            {
                count = 0;
                while (count < k)
                {
                    for (int i = 0; i < n; i++)
                    {
                        int r = (int)Math.Pow(2, i);

                        if ((r & nums[i]) == r)
                            count++;
                        if (count == k - 1)
                        {

                            res = res + r;
                            Console.WriteLine(r);
                        }



                    }
                }
            }


            return res;
        }
            static void Main(string[] args)
        {

                int fink = FindKOr(new int[] { 7, 12, 9, 8, 9, 15 } ,4);
            int major=majorityElement(new List<int>() { 3, 2, 3 });



            int cntseg = CountSegments("hello, how are you?");

            int LIS =LengthOfLIS(new int[] { 11, 2, 3, 120 });


            int[,] matrix = new int[5, 5] { { 1, 4, 7, 11, 15 },{ 2, 5, 8, 12, 19 },{ 3, 6, 9, 16, 22 },{ 10, 13, 14, 17, 24 },{ 18, 21, 23, 26, 30 } };
            bool resultmat = SearchMatrix(matrix, 5);

            ListNode ll1 = new ListNode(1);
            ListNode ll2 = new ListNode(3);
            ListNode ll3 = new ListNode(2);
            ll1.next = ll2;
            ll2.next = ll3;

            ll1 = RemoveElements(ll1, 3);


            int[] pr = new int[] { 1, 2, 3 };
            IList<IList<int>> permute = new List<IList<int>>();
            permute = (IList<IList<int>>)Permute1(pr);




            List<string> paran= (List<string>)GenerateParenthesis(3);


            IList<int> lettercomb = new List<int>();
        //    lettercomb= (IList<int>)LetterCombinations("23");



            TreeNode treenode1 = new TreeNode(9, null, null);
            TreeNode treenode2 = new TreeNode(15, null, null);
            TreeNode treenode3 = new TreeNode(7, null, null);
            TreeNode treenode4 = new TreeNode(20, treenode2, treenode3);
            TreeNode treenode5 = new TreeNode(3, treenode1, treenode4);

            int TreeDep = MaxDepth(treenode5);


            string countandsay = CountAndSay(4);


            string binary = AddBinary("111", "11");
            int Length = LengthOfLastWord("  I wish I  was more capable   ");

            int[] Majornum = new int[] { 2, 3, 2, 3, 2, 3 };
            int major1 = MajorityElement(Majornum);

            int sum1 = GetSum1(3, 2);
            

            string res = Fraction(10, 3);
            
            

            int[] coins = new int[] { 1, 2, 5 };
            int amount = CoinChange(coins, 11);


            int[] canj = new int[] { 3, 0, 8, 2, 0, 0, 1 };

            bool can=CanJump(canj);



            int[] numss = new int[] { 12, 13,6, 5, 7, 4, 19, 16 };
            int kth = kthlargestelement(numss,3);


           ListNode l1 = new ListNode(5);
            ListNode pren = l1;
            for (int i = 3; i < 5; i++)
            {
                ListNode currNode = new ListNode(9-i);
                pren.next = currNode;
                pren = currNode;
            }
            ListNode l2 = new ListNode(9);
            pren = l2;
            for (int i = 1; i < 5; i++)
            {
                ListNode currNode = new ListNode(9 - i);
                pren.next = currNode;
                pren = currNode;
            }


            l1 = GetIntersectionNode(l1, l2);


             l1 = OddEvenList(l1);




            

            l2 = AddTwoNumbers(l1, l2);



            string pal = LongestPalindrome1("babab");

            int[] num1 = { 1, 2, 3, 4, 0, 0 };
            int[] num2 = {9,9,9 };


            bool istrue = IncreasingTriplet(num1);
             num2 = PlusOne1(num2);

            int[] numintersect = Intersect1(num1, num2);



            int lensub = LengthOfLongestSubstring1("PWWKEP");


            IList<IList<int>> n = ThreeSum(new int[]{-4,-1,-1,0,2,1 });



            bool chi = IsValids("()");


           
            MergeArray2(num1, 3, num2, 3);






            int y11 = 1 ^ 2 ^ 3 ^ 5 ^ 8 ^ 1;

            char[][] sodo = new char[9][] { new char[9] { '5', '3', '.' , '.', '7', '.' , '.', '.', '.' }  ,
                                            new char[9] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                                            new char[9]  {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                                            new char[9] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                                            new char[9] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                                            new char[9] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                                            new char[9] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                                            new char[9] {'.', '.', '.', '4', '1', '9', '.', '.', '5' },
                                            new char[9] {'.', '.', '.', '.', '8', '.', '.', '7', '9' } };


            bool isva = IsValidSudoku2(sodo);


            /*char[,] sodo1 ={{'8','3','.','.','7','.','.','.','.'},
                            {'6','.','.','1','9','5','.','.','.'},
                            { '.','9','8','.','.','.','.','6','.'},
                            { '8','.','.','.','6','.','.','.','3'},
                            { '4','.','.','8','.','3','.','.','1'},
                            { '7','.','.','.','2','.','.','.','6'},
                            { '.','6','.','.','.','.','2','8','.'},
                            { '.','.','.','4','1','9','.','.','5'},
                            { '.','.','.','.','8','.','.','7','9'} };

             isva = IsValidSudoku2(sodo1);*/


            char[,] sodo2 = {{'.', '.', '.', '.', '5', '.', '.', '1', '.'},
                            {'.', '4', '.', '3', '.', '.', '.', '.', '.'},
                            {'.', '.', '.', '.', '.', '3', '.', '.', '1'},
                            {'8', '.', '.', '.', '.', '.', '.', '2', '.'},
                            {'.', '.', '2', '.', '7', '.', '.', '.', '.'},
                            {'.', '1', '5', '.', '.', '.', '.', '.', '.'},
                            {'.', '.', '.', '.', '.', '2', '.', '.', '.'},
                            {'.', '2', '.', '9', '.', '.', '.', '.', '.'},
                            {'.', '.', '4', '.', '.', '.', '.', '.', '.'}};
            isva = IsValidSudoku1(sodo2);

            int yq = 1 ^ 2 ^ 3 ^ 0 ;

             yq = 1 ^ 0;
             yq = 1 ^ 1;


            int[] nums = new int[] { 1, 2, 3, 4, 3 ,6,7};
           nums= RotateArray2(nums, 8);
           nums = RotateArray(nums, 8);

            int[] prices = new int[] { 1, 1, 2, 3, 3,4 };
            int sums = MaxProfit(prices);

            nums = Intersect(nums, prices);

            nums = new int[] { 0, 0, 1, 2, 2};
            int K = RemoveDuplicates(nums);



            allSubStr("salam");

            abbre("Hi How are you doing");
            StringFuncs();


            int[] ints = { 0, 10, 100, 1000, 1000000 };
            Console.WriteLine("Array indices and elements: ");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("[{0}]={1, -5}", i, ints[i]);
            }
            Console.WriteLine();
            FindObject(ints, 25);
            FindObject(ints, 1000);
            FindObject(ints, 2000000);
            Console.ReadLine();



            joggedarray();


            int sumdigit = SumOfDigit(12345 );


            string hstirng = Reversestring("salaaaam ");
            
            string[] arrnum = new string[] { "102", "473", "251", "814" };
            int[][] queries = new int[][] { new int[] { 1, 1 }, new int[] { 2, 3 }, new int[] { 4, 2 }, new int[] { 1, 2 } };

            int[] wwww = SmallestTrimmedNumbers(arrnum, queries);



            ListNode n0 = new ListNode(0);
            ListNode n1 = new ListNode(4 ,n0);
            ListNode n2 = new ListNode(3,n1);
            ListNode n3 = new ListNode(5,n2);
            ListNode n4 = new ListNode(-1,n3);

            ListNode n5 = InsertionSortList(n4);



            TreeNode T1 = new TreeNode(2);
            TreeNode T2 = new TreeNode(4);
            TreeNode T3 = new TreeNode(3);
            TreeNode T4 = new TreeNode(6);
            T1.left = null;
            T1.right = T2;
            T2.left = T3;
            T2.right = T4;


            InorderTraversal(T1);


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

        private static void MergeArray(int[] num1, int v1, int[] num2, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
