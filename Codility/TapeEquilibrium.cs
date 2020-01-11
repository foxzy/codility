using System;
using System.Linq;

//Task description
//A non-empty array A consisting of N integers is given.Array A represents numbers on a tape.

//Any integer P, such that 0 < P<N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].


//The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|

//In other words, it is the absolute difference between the sum of the first part and the sum of the second part.

//For example, consider array A such that:

//  A[0] = 3
//  A[1] = 1
//  A[2] = 2
//  A[3] = 4
//  A[4] = 3
//We can split this tape in four places:

//P = 1, difference = | 3 − 10| = 7
//P = 2, difference = | 4 − 9| = 5
//P = 3, difference = | 6 − 7| = 1
//P = 4, difference = | 10 − 3| = 7
//Write a function:

//class Solution { public int solution(int[] A); }

//that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.

//For example, given:

//  A[0] = 3
//  A[1] = 1
//  A[2] = 2
//  A[3] = 4
//  A[4] = 3
//the function should return 1, as explained above.

//Write an efficient algorithm for the following assumptions:

//N is an integer within the range[2..100, 000];
//each element of array A is an integer within the range[−1, 000..1, 000].
//Copyright 2009–2020 by Codility Limited.All Rights Reserved.Unauthorized copying, publication or disclosure prohibited.

// Note:
//1.Separate array follow by p with that p is number of int that less than Length-1 
//2.find min of deffValue

namespace Codility
{
    public class TapeEquilibrium
    {
        public TapeEquilibrium()
        {

        }

        public int simpifySolution(int[] A)
        {

            int sumLeft = 0;
            int sumRight = 0;
            int n = A.Length;
            int total = A.Sum();

            int[] sumDff = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii < i - 1; ii++)
                {
                    sumLeft += A[ii];
                    //Console.WriteLine(sumLeft);
                }
                sumRight = total - sumLeft;
                sumDff[i] = Math.Abs(sumLeft - sumRight);
            }

            return sumDff.Min();
        }

        public static int solution(int[] A)
        {
            int n = A.Length;
            int total = A.Sum();
            int[] sumDff = new int[n];
            int p, l, r, d;
            for (int i = 0; i < n; i++)
            {
                p = i + 1;
                l = A.Take(p).Sum();
                r = A.Skip(p).Sum();
                d = Math.Abs(l - r);
                sumDff[i] = d;
                Console.WriteLine("p={0} l={1} r={2} d={3}", p, l, r, d);
            }

            return sumDff.Min();
        }
    }

}
