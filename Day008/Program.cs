using System;
using System.Collections.Generic;

namespace Day008
{
    class Program
    {
        public class Graph
        {
            public Node[] nodes { get; set; }
            public Link[] links { get; set; }
        }

        public class Node
        {
            public int id { get; set; }
        }

        public class Link
        {
            public Node source { get; set; }
            public Node target { get; set; }
        }

        static void Main(string[] args)
        {
            Graph graph = new Graph();

            Console.Write("Write number of nodes: ");
            int n = Int32.Parse(Console.ReadLine());

            graph.nodes = new Node[n];

            Console.Write("The id's of nodes are: ");

            for(int i = 0; i < n; ++i)
            {
                graph.nodes[i] = new Node();
                graph.nodes[i].id = i;
                Console.Write($"{graph.nodes[i].id} ");
            }

            int counter = 0;

            List<Link> links2 = new List<Link>();

            while(true)
            {
                int source, target;

                try
                {
                    Console.WriteLine("\nWhen satisfied, enter anything except int.");
                    Console.Write($"Type the source for {counter}. link: ");
                    source = Int32.Parse(Console.ReadLine());
                    Console.Write($"Type the target for {counter}. link: ");
                    target = Int32.Parse(Console.ReadLine());

                    links2.Add(new Link());
                    links2[counter].source = graph.nodes[source];
                    links2[counter].target = graph.nodes[target];
                }
                catch
                {
                    break;
                }

                counter++;
            }

            graph.links = new Link[links2.Count];
            graph.links = links2.ToArray();

            Console.WriteLine("\nNon reversed graph:");
            for (int i = 0; i < counter; ++i)
            {
                Console.WriteLine($"{i}. list: {graph.links[i].source.id} - {graph.links[i].target.id}");
            }

            graph = reverseGraph(graph);

            Console.WriteLine("\nReversed graph:");
            for (int i = 0; i < counter; ++i)
            {
                Console.WriteLine($"{i}. list: {graph.links[i].source.id} - {graph.links[i].target.id}");
            }
        }

        public static Graph reverseGraph(Graph grapharr)
        {
            for(int i = 0; i < grapharr.links.Length; ++i)
            {
                (grapharr.links[i].source, grapharr.links[i].target) = (grapharr.links[i].target, grapharr.links[i].source);
            }

            return grapharr;
        }
    }
}
