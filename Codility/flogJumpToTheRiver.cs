using System;
using System.Linq;

namespace Codility
{
    public class FlogJumpToTheRiver
    {
        public FlogJumpToTheRiver()
        {
			Console.WriteLine("Hello World");
			int[] f = { 1, 3, 1, 4, 2, 3, 5, 4 };
			Console.WriteLine("ans: " + solution(5, f));
		}
		public static int solution(int X, int[] A)
		{

			int jumpCounter = X + 1;
			int[] B = new int[A.Length + 1];
			int position = 0;

			for (int i = 0; i <= A.Length; i++)
            {
				int p = i + 1;

				if (A[p] != null)
				{
					B[p] = 1;
					//Console.WriteLine("p:" + p +" B[p] : " + B[p] + " sum :" + B.Sum() + " jumpCounter: " + jumpCounter);
				}

				if ((B.Sum()) == jumpCounter)
				{
					position = p;
					break;
				}


			}
			return position;

		}
	}
}
