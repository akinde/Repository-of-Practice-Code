using System;
using System.Collections.Generic;

/*
Round 1: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
Round 2: 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61, 65, 69, 73, 77, 81, 85, 89, 93, 97
Round 3: 1, 9, 17, 25, 33, 41, 49, 57, 65, 73, 81, 89, 97
Round 4: 9, 25, 41, 57, 73, 89
Round 5: 9, 41, 73
Round 6: 9, 73
Round 7: 73
Correct answer is 73 lives. 
If we were to vary the size of the circle, we would find that several of the results would have #1 be the victor in the circle. The sizes that have this pattern happen to be powers of two. We can rewrite 
all the other size as a powers of two, with a remainder k. k happens to be the number of steps that needs to be taken to get to the victor. Since we skip every other person, the victor will correspond to 2k+1, otherwise 
1 is the victor.
*/
class Program
{
    static List<int> circles = new List<int>();

    static void Main(string[] args)
    {
        int answer;
        for (int i = 0; i < 100; i++)
        {
            circles.Add(i + 1);
        }   
        answer = (int)Math.Floor(Math.Log2(circles.Count));
        answer = (int)Math.Pow(2, answer);
        answer = 2*(circles.Count - answer) + 1;
        Console.WriteLine("Answer is {0}", answer);
        Console.ReadLine();
    }
}
