using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Graph
    {
        public static void addEdge(LinkedList<int>[] graph, int u, int v)
        {
            graph[u].AddLast(v);
            graph[v].AddLast(u);
        }

        public void BreadthFirstSearchTraversal(Node[] graph, Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                Node temp = queue.Dequeue();
                if (!temp.Visited)
                {
                    temp.Visited = true; // visiting the node
                    Console.WriteLine(temp.Data);

                    foreach(int id in temp.Edges)
                    {
                        Node neighbor = graph[id];
                        if (!neighbor.Visited)
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
        }

        public void DepthFirstSearchTraversal(Node[] graph, Node node)
        {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                Node temp = stack.Pop();
                if (!temp.Visited)
                {
                    temp.Visited = true; // visiting the node
                    Console.WriteLine(temp.Data);

                    foreach (int id in temp.Edges)
                    {
                        Node neighbor = graph[id];
                        if (!neighbor.Visited)
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
            }
        }

        public static void PrintGraphEdges(LinkedList<int>[] graph)
        {
            for (var i = 0; i < graph.Length; i++)
            {
                Console.WriteLine("head -> " + i);

                foreach (var item in graph[i])
                {
                    Console.WriteLine(" -> " + item);
                }
            }
        }
    }

    public class Node
    {
        public int Id;
        public string Data;
        public List<int> Edges;
        public bool Visited;

        public Node(int id, string data, List<int> edges, bool visited)
        {
            Id = id;
            Data = data;
            Edges = edges;
            Visited = visited;
        }
    
    }
}
