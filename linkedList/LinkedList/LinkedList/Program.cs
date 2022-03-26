using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert("head");
            list.Insert("one");
            list.Insert("two");
            list.Insert("three");
            list.Insert("four");
            list.Insert("five");
            
            Console.WriteLine("******Print in order*******");
            list.Print();

            //list.ReverseIteretiveMethod();
            //Console.WriteLine("******Print ReverseIteretive*******");
            //list.Print();
            
            list.ReverseRecursiveMethod(list.Head);
            Console.WriteLine("******Print ReverseRecursive*******");
            list.Print();
        }
    }
}


public class Node
{
    public string Data;
    public Node Next;
    public Node(string data)
    {
        Data = data;
    }
}

public class LinkedList
{
    public Node Head;

    public void Insert(string node)
    {
        Node newNode = new Node(node);
        Node current = null;

        if (this.Head == null)
        {
            this.Head = newNode;
        }
        else
        {
            current = this.Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Print()
    {
        Node current = null;
        current = this.Head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    public void ReverseIteretiveMethod()
    {
        Node prev = null;
        Node current = this.Head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        this.Head = prev;
    }

    public void ReverseRecursiveMethod(Node head)
    {
        Node curr = head;

        if (curr.Next == null)
        {
            this.Head = curr;
            return;
        }

        ReverseRecursiveMethod(curr.Next);

        curr.Next.Next = curr;
        curr.Next = null;
        
    }
}


//// fibonacci
//function fib(n)
//{
//    if (n >= 3)
//    {
//        return fib(n - 1) + fib(n - 2)
//    }
//    else
//    {
//        return 1
//    }
//}

//// factorial
//function fact(n)
//{
//    if (n > 0)
//    {
//        return n * fact(n - 1);
//    }
//    else
//    {
//        return 1
//    }
//}

// fib(10);

//fact(4)


















//public class Node
//{
//    internal Node Next { get; set; }
//    internal string Data { get; set; }
//    public Node(string data)
//    {
//        Data = data;
//    }
//}

//public class LinkedList
//{
//    public Node Head { get; set; }

//    public void InsertEnd(string data)
//    {
//        Node newNode = new Node(data);
//        Node current = new Node(null);

//        if (Head == null)
//        {
//            Head = newNode;
//        }
//        else
//        {
//            current = Head;
//            while (current.Next != null)
//            {
//                current = current.Next;
//            }
//            current.Next = newNode;
//        }
//    }

//    public void InsertFront(string data)
//    {
//        Node newNode = new Node(data);
//        Node current = new Node(null);

//        if (Head == null)
//        {
//            Head = newNode;
//        }
//        else
//        {
//            current = Head;
//            Head = newNode;
//            Head.Next = current;
//        }
//    }
//    public void InsertAfter(string data, string newData)
//    {
//        Node next = new Node(null);
//        Node node = FindByData(data);

//        next = node.Next;
//        node.Next = new Node(newData);
//        node.Next.Next = next;
//    }

//    public void DeleteLast()
//    {
//        Node current = new Node(null);
//        Node previous = new Node(null);

//        if (Head != null)
//        {
//            current = Head;

//            while (current.Next != null)
//            {
//                previous = current;
//                current = current.Next;
//            }

//            previous.Next = null;
//        }
//        else
//        {
//            Head = null;
//        }
//    }

//    public void DeleteNode(string data)
//    {
//        Node current = new Node(null);
//        Node previous = new Node(null);

//        if (FindByData(data) != null)
//        {
//            if (Head.Data == data)
//            {
//                Head = null;
//            }
//            else
//            {
//                current = Head.Next;
//                while (current.Data != data)
//                {
//                    previous = current;
//                    current = current.Next;
//                }
//                previous.Next = current.Next;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Not found");
//        }

//    }

//    public Node FindByData(string data)
//    {
//        Node node = new Node(null);

//        if (Head != null && Head.Data == data)
//        {
//            node = Head;
//        }
//        else
//        {
//            node = Head.Next;
//            while (node != null && node.Data != data)
//            {
//                node = node.Next;
//            }
//        }
//        return node;

//    }

//    public void Reverse(LinkedList list)
//    {
//        Node prev = null;
//        Node curr = list.Head;
//        Node next = null;

//        while (curr != null)
//        {
//            next = curr.Next;
//            curr.Next = prev;
//            prev = curr;
//            curr = next;
//        }
//        list.Head = prev;
//    }

//    public void PrintAllNodes()
//    {
//        if (Head == null)
//        {
//            Console.WriteLine("The list is empty");
//        }
//        else
//        {
//            Console.WriteLine(Head.Data);

//            Node current = new Node(null);
//            current = Head.Next;
//            while (current.Next != null)
//            {
//                Console.WriteLine(current.Data);
//                current = current.Next;
//            }
//            Console.WriteLine(current.Data);
//        }
//    }
//}