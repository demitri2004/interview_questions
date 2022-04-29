
var queue = new QueueAsLinkedList();
queue.Enqueue(11);
queue.Enqueue(22);
queue.Enqueue(33);
queue.Enqueue(44);
queue.Print();
queue.Dequeue();
queue.Print();
queue.Enqueue(55);
queue.Dequeue();
queue.Print();

public class Node
{
    public int data;
    public Node next;
    public Node(int element)
    {
        this.data = element;
    }
}

public class LinkedList
{
    public Node root;
    public LinkedList(Node node)
    {
        this.root = node;
    }
}

public class QueueAsLinkedList
{
    private Node first;
    private Node last;
    private LinkedList queue;

    public void Enqueue(int element)
    {
        Node newNode = new Node(element);

        if(this.queue == null)
        {
            first = last = newNode;
            this.queue = new LinkedList(newNode);
        }
        else
        {
            Node temp = queue.root;
            
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            last = newNode;
        }
    }

    public int Dequeue()
    {
        if(queue == null)
        {
            Console.WriteLine("queue is empty");
            return -1;
        }
        else
        {
            queue.root = queue.root.next;
            first = queue.root;
            return queue.root.data;
        }
    }

    public void Print()
    {
        Node temp = queue.root;
        while(temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
        Console.WriteLine("*************");
    }

}