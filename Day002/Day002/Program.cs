using System;
using System.Linq;

namespace Day002
{
    class Program
    {
        public class Node
        {
            public int value;
            public Node left, right;

            public Node(int itm)
            {
                value = itm;
                left = right = null;
            }
        }

        public class Count
        {
            public int count = 0;
        }


        public class BinaryTree
        {
            public Node root;
            public Count cnt = new Count();

            public virtual bool countSingleRec(Node node, Count C)
            {
                if (node == null)
                {
                    return true;
                }

                //Count recursively left and right nodes
                bool left = countSingleRec(node.left, C);
                bool right = countSingleRec(node.right, C);

                //If it's not unival return false
                if (left == false || right == false)
                {
                    return false;
                }

                if (node.left != null && node.value != node.left.value)
                {
                    return false;
                }

                if (node.right != null && node.value != node.right.value)
                {
                    return false;
                }

                //If it is return true
                C.count++;
                return true;
            }

            public virtual int countSingle()
            {
                return countSingle(root);
            }

            public virtual int countSingle(Node node)
            { 
                countSingleRec(node, cnt);
                return cnt.count;
            }
        }

        static void Main()
        {
            /*  Tree is:

                0
               / \
              1   0
                 / \
                1   0
               / \
              1   1

            */

            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(1);
            tree.root.right = new Node(0);
            tree.root.right.left = new Node(1);
            tree.root.right.right = new Node(0);
            tree.root.right.left.left = new Node(1);
            tree.root.right.left.right = new Node(1);

            Console.WriteLine("The number of unival trees is : " + tree.countSingle());
        }
    }
}
