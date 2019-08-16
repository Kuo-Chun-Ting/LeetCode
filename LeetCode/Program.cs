using LeetCode.Problem.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Algo.1

            //var algo1 = new Algorithms1();
            //var result = algo1.TwoSum(new int[] { 1, 7, 11, 15, 8 }, 9);

            #endregion

            #region Algo.2

            var node1 = new ListNode(2);
            node1.next = new ListNode(4);
            node1.next.next = new ListNode(3);

            var node2 = new ListNode(5);
            node2.next = new ListNode(6);
            node2.next.next = new ListNode(4);

            var algo2 = new Algorithms2();
            var result = algo2.AddTwoNumbers(node1, node2); 

            #endregion




            Console.ReadKey();
        }
    }
}
