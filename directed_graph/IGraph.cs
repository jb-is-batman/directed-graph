using System;
namespace GraphLibrary 
{
	public interface IGraph <T, K>
	{
		bool AddVertex(T vertex);
		void AddVertex(IEnumerable<T> vertexSet);
		bool DeleteVertex(T vertex);
		void DeleteVertex(IEnumerable<T> vertexSet);
		bool AddEdge(T v1, T v2, K weight);
		bool DeleteEdge(T v1, T v2);
		K GetWeight(T v1, T v2);
		bool AreAdjacent(T v1, T v2);
		int Degree(T vertex);
		int OutDegree(T vertex);
		int InDegree(T vertex);
		int VerticesNumber();
		int EdgesNumber();
		IEnumerable<T> AdjacentVertices(T vertex);
		IEnumerable<T> GetVertexSet();
		IEnumerable<IPairValue<T>> GetEdgeSet();
	}

	public interface IPairValue<T>
	{
		T GetFirst();
		T GetSecond();
		bool Contains(T value);
	}
}