using System;
using System.Collections.Generic;
using System.Linq;
using _2Sum_Binary_Tree.util;
/* Given a binary search tree T, where each node contains a positive integer, and an 
integer K, you have to find whether or not there exist two different nodes A and B 
such that A.value + B.value = K.

Return 1 to denote that two such nodes exist. Return 0, otherwise.*/
namespace _2Sum_Binary_Tree
{
    class _2Sum_Binary_Tree
    {
        static Random rand = new Random();
        static List<int> bst = new List<int>();
        static node root;
        static int size;
        static int forIndex;
        static int range;
        static int target;
        static void Main(string[] args)
        {
            //generate bst and target
            range = 50;
            size = rand.Next(10, 20); 
            forIndex = size;
            for(int i=0; i < forIndex; i++){
                int temp = rand.Next(range);
                //All bst nodes are distinct
                if(i > 0 && !bst.Exists(t => t == temp)){
                    bst.Add(temp);
                }
                else{
                    size--;
                }
            }
            //The largest sum we will ever get is two values that have the highest value.
            target = rand.Next(100);
            Console.WriteLine("Target = {0}, Size = {1}, List = {2}", target, size, String.Join(", ", bst.ToArray()));
            Console.WriteLine("---");
            root = new node(bst[0]);
            for(int i = 1; i < bst.Count(); i++){
                root.Add(new node(bst[i]));
            }
            Console.WriteLine("Is there a pair? {0}", SumPair(root, target));
            root.PrintPretty("", NodePosition.center, true, false);
        }
        static bool SumPair(node root, int target){
            //Reverse and forward iterator
            Stack<node> forward = new Stack<node>(),
            reverse = new Stack<node>();
            node current = root;
            //Initialize forward iterator and Stack.
            while(current != null){
                forward.Push(current);
                current = current.left;
            }
            //Initialize reverse iterator and Stack.
            current = root;
            while(current != null){
                reverse.Push(current);
                current = current.right;
            }
            //While both iterators are not pointing to the same node.
            while(forward.Peek() != reverse.Peek()){
                //We store the current values of both iterators for comparison.
                int value1 = forward.Peek().data,
                value2 = reverse.Peek().data;
                //If the sum of both values equal target, we found a pair.
                if (value1 + value2 == target){
                    return true;
                }
                //If the sum of the values are less than the target, pop current value and then check subtree.
                if(value1 + value1 < target){
                    //Look at right node
                    current = forward.Peek().right;
                    //Pop previous value off stack.
                    forward.Pop();
                    //If we are not on a leaf node, traverse down left subtree. Else, we are on leaf node.
                    while(current != null){
                        //Add node to stack.
                        forward.Push(current);
                        //Traverse to the left until we cant.
                        current = current.left;
                    }
                }
                //If the sum of the values are greater than the target, pop current value and then check subtree.
                else{
                    //Look at left node
                    current = reverse.Peek().left;
                    //Pop previous value off stack.
                    reverse.Pop();
                    //If we are not on a leaf node, traverse down right subtree. Else, we are on leaf node.
                    while(current != null){
                        //Add node to stack.
                        reverse.Push(current);
                        //Traverse to the left until we cant.
                        current = current.right;
                    }
                }
            }
            return false;  
        }
    }
}
