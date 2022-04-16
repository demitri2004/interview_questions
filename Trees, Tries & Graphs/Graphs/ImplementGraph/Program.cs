
// C# code to demonstrate Graph representation
// using LinkedList in C#
using System;
using System.Collections.Generic;


LinkedList<int>[] graph = new LinkedList<int>[8];
int v = 8;

for(var i=0; i < v; i++)
{
    graph[i] = new LinkedList<int>();
}

Graph.addEdge(graph, 0, 1);
Graph.addEdge(graph, 1, 6);
Graph.addEdge(graph, 1, 2);
Graph.addEdge(graph, 2, 4);
Graph.addEdge(graph, 2, 3);
Graph.addEdge(graph, 2, 5);
Graph.addEdge(graph, 3, 5);
Graph.addEdge(graph, 3, 7);
Graph.addEdge(graph, 3, 6);
Graph.addEdge(graph, 4, 5);

Graph.PrintGraphEdges(graph);


public class Graph
{
    public static void addEdge(LinkedList<int>[] graph, int u, int v)
    {
        graph[u].AddLast(v);
        graph[v].AddLast(u);
    }


    public static void PrintGraphEdges(LinkedList<int>[] graph)
    {
        for(var i=0; i < graph.Length; i++)
        {
            Console.WriteLine("head -> " + i);

            foreach(var item in graph[i])
            {
                Console.WriteLine(" -> " + item);
            }            
        }
    }
}








































//class Graph
//{
//    // A utility function to add an edge in an
//    // undirected graph
//    static void addEdge(LinkedList<int>[] adj, int u, int v)
//    {
//        adj[u].AddLast(v);
//        adj[v].AddLast(u);
//    }

//    // A utility function to print the adjacency list
//    // representation of graph
//    static void printGraph(LinkedList<int>[] adj)
//    {
//        for (int i = 0; i < adj.Length; i++)
//        {
//            Console.WriteLine("\nAdjacency list of vertex " + i);
//            Console.Write("head");

//            foreach (var item in adj[i])
//            {
//                Console.Write(" -> " + item);
//            }
//            Console.WriteLine();
//        }
//    }

//    // Driver Code
//    public static void Main(String[] args)
//    {
//        // Creating a graph with 5 vertices
//        int V = 5;
//        LinkedList<int>[] adj = new LinkedList<int>[V];

//        for (int i = 0; i < V; i++)
//            adj[i] = new LinkedList<int>();

//        // Adding edges one by one
//        addEdge(adj, 0, 1);
//        addEdge(adj, 0, 4);
//        addEdge(adj, 1, 2);
//        addEdge(adj, 1, 3);
//        addEdge(adj, 1, 4);
//        addEdge(adj, 2, 3);
//        addEdge(adj, 3, 4);

//        printGraph(adj);

//        Console.ReadKey();
//    }
//}
