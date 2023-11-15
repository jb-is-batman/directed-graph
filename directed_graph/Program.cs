using GraphLibrary;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectedGraph<string, string> graph = new DirectedGraph<string, string>();
			graph.AddVertex(new string[] { "A", "B", "C", "D", "E", "F", "G" });
			graph.AddEdge("A", "B", "AB");
			graph.AddEdge("A", "C", "AC");

			foreach (var item in graph.GetVertexSet())
				Console.WriteLine(item);
			foreach (var item in graph.GetEdgeSet())
				Console.WriteLine(item.GetFirst() + " -> " + item.GetSecond());			
			Console.ReadLine();
		}
	}
}