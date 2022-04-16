
//var stack = new StackAsArray(10);
//stack.Push(11);
//stack.Push(22);
//stack.Push(33);
//stack.Push(44);
//stack.Push(55);
//stack.Pop();
//stack.Pop();
//stack.PrintStack();

var stack = new StackAsLinkedList();
stack.Push(11);
stack.Push(22);
stack.Push(33);
stack.Pop();
stack.PrintStack();



public class StackAsArray
{
    private int size;
    private int top = -1;
    private int[] stackAsArray;

    public StackAsArray(int size)
    {
        stackAsArray = new int[size];
        this.size = size;
    }

    public void Push(int element)
    {
        if(top == size - 1)
        {
            Console.WriteLine("stack is full, {0} can't be added", element);
            return;
        }
        else 
        {
            stackAsArray[++top] = element;
            Console.WriteLine("{0} has been added", element);
        }
    }

    public void Pop()
    {
        if(top == -1)
        {
            Console.WriteLine("the stack is empty");
            return;
        }
        else
        {
            Console.WriteLine("poped from stack {0}", stackAsArray[top]);
            stackAsArray[top] = 0;
            top--;
            return;
        }
    }

    public void PrintStack()
    {
        if(top == -1)
        {
            Console.WriteLine("stack is empty");
        }
        else
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stackAsArray[i]);
            }
        }
    }

}

public class StackAsLinkedList
{
    private LinkedList<int> stackAsLinkedList = new LinkedList<int>();

    public void Push(int element)
    {
        this.stackAsLinkedList.AddLast(element);
        Console.WriteLine("{0} pushed to stack", element);
    }

    public void Pop()
    {
        if(this.stackAsLinkedList.Count == 0)
        {
            Console.WriteLine("stack is empty");
        }
        else
        {
            Console.WriteLine("{0} popped from stack", stackAsLinkedList.Last());
            stackAsLinkedList.RemoveLast();
        }
    }

    public void PrintStack()
    {
        if (this.stackAsLinkedList.Count == 0)
        {
            Console.WriteLine("stack is empty");
            return;
        }
        else
        {
            foreach (int i in stackAsLinkedList)
            {
                Console.WriteLine(i);
            }
        }        
    }

}