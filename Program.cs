using System;
using System.Collections.Generic;
using System.Linq;

namespace Compare
{
    class Program
    {
        public static List<int> compareTriplets(List<int> arr1, List<int> arr2)
        {

            List<int> res = new List<int>();
            int scoreA=0, scoreB=0;

            for (int i = 0; i < arr1.Count; i++)
            {
                if (arr1[i] > arr2[i]) scoreA += 1;
                else if (arr1[i] < arr2[i]) scoreB += 1;

            }
            res.Add(scoreA);
            res.Add(scoreB);

            return res;



        }
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
