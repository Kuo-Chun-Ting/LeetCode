using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problem.Algorithms
{
    public class Algorithms2
    {
        /// <summary>
        /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
        /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var curr1 = l1;
            var curr2 = l2;
            var plus = false;

            ListNode sum = null;
            ListNode curr = null;

            while (curr1 != null || curr2 != null || plus)
            {
                int digit = 0;

                if (plus)
                {
                    digit++;
                }

                if (curr1 != null)
                {
                    digit += curr1.val;

                    curr1 = curr1.next;
                }

                if (curr2 != null)
                {
                    digit += curr2.val;

                    curr2 = curr2.next;
                }

                if (digit >= 10)
                {
                    digit -= 10;

                    plus = true;
                }
                else
                {
                    plus = false;
                }

                if (sum == null)
                {
                    sum = new ListNode(digit);
                    curr = sum;
                }
                else
                {
                    curr.next = new ListNode(digit);
                    curr = curr.next;
                }
            }

            return sum;
        }

        /// <summary>
        /// 回傳10的N次方
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int NSquareOf10(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return NSquareOf10(n - 1) * 10;
            }
        }
    }

    /// <summary>
    /// Definition for singly-linked list
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
