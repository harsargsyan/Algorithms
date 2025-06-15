namespace Algorithms.Graph
{
    /// <summary>
    /// Implementation of Dijkstra's algorithm for finding single-source the shortest paths in a graph.
    /// 
    /// Time Complexity: O((V + E) log V) where:
    /// - V is the number of vertices (nodes) in the graph
    /// - E is the number of edges
    /// 
    /// Space Complexity: O(V) for storing distances, priority queue and visited set
    /// </summary>
    public class Dijkstra
    {
        public static Dictionary<int, int> ShortestPath(Dictionary<int, List<(int neighbor, int weight)>> graph, int start)
        {
            var distances = new Dictionary<int, int>();
            var priorityQueue = new SortedSet<(int distance, int node)>();
            var visited = new HashSet<int>();

            // Initialize distances
            foreach (var node in graph.Keys)
                distances[node] = int.MaxValue;

            distances[start] = 0;
            priorityQueue.Add((0, start));

            while (priorityQueue.Count > 0)
            {
                // Get minimum element directly
                var current = priorityQueue.Min;
                priorityQueue.Remove(current);
                
                var (currentDistance, currentNode) = current;

                // Skip if already visited
                if (visited.Contains(currentNode))
                    continue;

                visited.Add(currentNode);

                // Process neighbors
                if (graph.ContainsKey(currentNode))
                {
                    foreach (var (neighbor, weight) in graph[currentNode])
                    {
                        if (visited.Contains(neighbor))
                            continue;

                        int newDistance = currentDistance + weight;
                        if (newDistance < distances[neighbor])
                        {
                            distances[neighbor] = newDistance;
                            priorityQueue.Add((newDistance, neighbor));
                        }
                    }
                }
            }

            return distances;
        }
    }
}