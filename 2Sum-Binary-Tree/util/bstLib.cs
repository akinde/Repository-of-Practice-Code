using System;
namespace _2Sum_Binary_Tree.util
{
    public enum NodePosition{
        left,
        right,
        center
    }
    public class node  
    { 
        public int data; 
        public node left; 
        public node right; 
        public node parent;
        public node(int data) 
        { 
            this.data = data; 
            left = null; 
            right = null; 
            parent = null;
        }
        public void Add(node addition){
            if(addition.data < this.data){
                if(this.left == null){
                    this.left = addition;
                    addition.parent = this;
                    return;
                }
                else{
                    this.left.Add(addition);
                }
            }
            if(addition.data > this.data){
                if(this.right == null){
                    this.right = addition;
                    addition.parent = this;
                    return;
                }
                else{
                    this.right.Add(addition);
                }
            }
        }
        private void PrintValue(string value, NodePosition p){
            switch(p)
            {
                case NodePosition.left:
                    PrintLeft(value);
                    break;
                case NodePosition.right:
                    PrintRight(value);
                    break;
                case NodePosition.center:
                    Console.WriteLine(value);
                    break;
                default:
                throw new NotImplementedException();
            }
        }

        private void PrintLeft(string value){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("L:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void PrintRight(string value){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("R:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        //Compliments to Xavier Pena on stack overflow: 
        //https://stackoverflow.com/a/36313190
        public void PrintPretty(string indent, NodePosition p, bool last, bool empty){
            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }

            var stringValue = empty ? "-" : data.ToString();
            PrintValue(stringValue, p);

            if(!empty && (this.left != null || this.right != null))
            {
                if (this.left != null)
                    this.left.PrintPretty(indent, NodePosition.left, false, false);
                else
                    PrintPretty(indent, NodePosition.left, false, true);

                if (this.right != null)
                    this.right.PrintPretty(indent, NodePosition.right, true, false);
                else
                    PrintPretty(indent, NodePosition.right, true, true);
            }
        }

    }; 
}