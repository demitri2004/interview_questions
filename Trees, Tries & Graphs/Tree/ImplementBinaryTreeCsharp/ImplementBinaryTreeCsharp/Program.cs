using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root = new Node(5);
            tree.insert(tree.Root, new Node(3));
            tree.insert(tree.Root, new Node(2));
            tree.insert(tree.Root, new Node(12));
            tree.insert(tree.Root, new Node(9));
            tree.insert(tree.Root, new Node(7));
            tree.insert(tree.Root, new Node(10));
            tree.insert(tree.Root, new Node(1));
            tree.insert(tree.Root, new Node(4));
            tree.insert(tree.Root, new Node(20));

            //Console.WriteLine(tree.contains(tree.Root, 90));
            //tree.printInOrder(tree.Root);
            //tree.printPreOrder(tree.Root);
            tree.printPostOrder(tree.Root);
        }
    }
}

public class Node
{
    public int Data;
    public Node Left, Right;

    public Node(int data)
    {
        Data = data;
    }
}

public class Tree
{
    public Node Root;

    public void insert(Node curr, Node newNode)
    {
        if (curr == null)
        {
            curr = newNode;
        }
        else
        {
            if (curr.Data > newNode.Data) //go left
            {
                if (curr.Left == null)
                {
                    curr.Left = newNode; // insert
                }
                else
                {
                    insert(curr.Left, newNode); // keep going
                }
            }
            else // go right
            {
                if (curr.Right == null)
                {
                    curr.Right = newNode; // insert
                }
                else
                {
                    insert(curr.Right, newNode); // keep going
                }
            }
        }
    }

    public bool contains(Node curr, int lookup)
    {
        if (curr != null && curr.Data == lookup)
        {
            return true;
        }
        else if (curr != null && lookup > curr.Data)
        {
            return contains(curr.Right, lookup);
        }
        else if (curr != null && lookup < curr.Data)
        {
            return contains(curr.Left, lookup);
        }
        else
        {
            return false;
        }
    }

    public void printInOrder(Node root)
    {
        if (root != null)
        {
            printInOrder(root.Left);

            if (root != null)
            {
                Console.WriteLine(root.Data);
            }

            printInOrder(root.Right);
        }        
    }

    public void printPreOrder(Node root)
    {
        if (root != null)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data);
            }

            printPostOrder(root.Left);

            printPostOrder(root.Right);
        }        
    }

    public void printPostOrder(Node root)
    {
        if (root != null)
        {
            printPostOrder(root.Right);

            if (root != null)
            {
                Console.WriteLine(root.Data);
            }

            printPostOrder(root.Left);
        }
    }
}

