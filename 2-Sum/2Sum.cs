using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace _2_Sum
{
    class Program
    {
        public static bool verbosity = true;
        public static List<int> input = new List<int>();
        public static int target;
        public static Stopwatch sw =  new Stopwatch();
        public static int compliment;
        public static int[] ij = new int[2]{-1, -1};
        public static Random rand = new Random();
        public static double timeElapsedinSeconds;
        static void Main(string[] args)
        {
            target = rand.Next(1, 11);
            for(int k = 0; k < 10; k++){
                input.Add(rand.Next(1, 11));
            }
            Console.WriteLine("Target: {0}\nList: [{1}]\n", target, String.Join(",",input));
            Console.WriteLine("Brute Force Method - Time Complexity = O(n^2)");
            sw.Start();
            BruteForceONSquared();
            sw.Stop();
            timeElapsedinSeconds = sw.Elapsed.TotalMilliseconds;
            sw.Reset();
            printResults();
            Console.ReadLine(); 
        }

        static void BruteForceONSquared(){
            for(int i = 0; i < 10; i++){
                for(int j = 0; j < 10; j++){
                    if(input[i] + input[j] == target && i != j){
                        ij[0] = i;
                        ij[1] = j;
                    }
                }
            }
            if(ij[0] > ij[1]){
               int temp = ij[0];
               ij[0] = ij[1];
               ij[1] = temp; 
            }
        }

        static void printResults(){
            if(ij[0] == -1)
                Console.WriteLine("No Solution\nTime = {0}ms", timeElapsedinSeconds);
            else{
                if(verbosity)
                    Console.WriteLine("Index #1 = {0}, Index #2 = {1}\nResult of Index #1 = {2}, Result of Index #2 = {3}\nTime = {4}ms", ij[0], ij[1], input[ij[0]], input[ij[1]], timeElapsedinSeconds);
                else
                    Console.WriteLine("[{0},{1}]", ij[0], ij[1]);
            }
        }

        static void OptimalApproachOLinear(){

        }
    }
}
