using BFS;

//LinkedList<int>[] graph = new LinkedList<int>[8];
//int v = 8;

//for (var i = 0; i < v; i++)
//{
//    graph[i] = new LinkedList<int>();
//}

//Graph.addEdge(graph, 0, 1);
//Graph.addEdge(graph, 1, 6);
//Graph.addEdge(graph, 1, 2);
//Graph.addEdge(graph, 2, 4);
//Graph.addEdge(graph, 2, 3);
//Graph.addEdge(graph, 2, 5);
//Graph.addEdge(graph, 3, 5);
//Graph.addEdge(graph, 3, 7);
//Graph.addEdge(graph, 3, 6);
//Graph.addEdge(graph, 4, 5);

//Graph.PrintGraphEdges(graph);


Node [] graph2 = new Node [10];
Node[] graph3 = new Node[10];
//vertices
graph2[0] = new Node(0, "A", new List<int> { 1, 2, 3 }, false);
graph2[1] = new Node(1, "B", new List<int> { 1 }, false);
graph2[2] = new Node(2, "C", new List<int> { 0, 3 }, false);
graph2[3] = new Node(3, "D", new List<int> { 0, 2, 4 }, false);
graph2[4] = new Node(4, "E", new List<int> { 3, 5 }, false);
graph2[5] = new Node(5, "F", new List<int> { 4, 6 }, false);
graph2[6] = new Node(6, "G", new List<int> { 5, 3 }, false);

graph3[0] = new Node(0, "A", new List<int> { 1, 2, 3 }, false);
graph3[1] = new Node(1, "B", new List<int> { 1 }, false);
graph3[2] = new Node(2, "C", new List<int> { 0, 3 }, false);
graph3[3] = new Node(3, "D", new List<int> { 0, 2, 4 }, false);
graph3[4] = new Node(4, "E", new List<int> { 3, 5 }, false);
graph3[5] = new Node(5, "F", new List<int> { 4, 6 }, false);
graph3[6] = new Node(6, "G", new List<int> { 5, 3 }, false);

Graph graph = new();
Console.WriteLine("--------BFS-------");
graph.BreadthFirstSearchTraversal(graph2, graph2[0]);
Console.WriteLine("--------DFS-------");
graph.DepthFirstSearchTraversal(graph3, graph3[0]);
