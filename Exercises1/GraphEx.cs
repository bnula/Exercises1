using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    class MyGraph
    {
        int numberOfNodes = 0;
        Dictionary<int, List<int>> adjecentList = new Dictionary<int, List<int>>();

        // add all the nodes
        public void AddNode(int node)
        {
            List<int> pairList = new List<int>();
            adjecentList.Add(node, pairList);
            numberOfNodes++;
        }

        // add all the connections
        public void AddEdge(int node1, int node2)
        {
            adjecentList[node1].Add(node2);
        }

        public void ShowConnections()
        {
            Console.WriteLine($"{numberOfNodes} nodes");
            foreach (var item in adjecentList)
            {
                foreach (var pair in item.Value)
                {
                    Console.WriteLine($"{item.Key} - {pair}");
                }
            }
        }
    }
}
