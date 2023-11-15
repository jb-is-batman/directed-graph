namespace GraphLibrary
{
	class DirectedGraph <T, K> : AbstractGraph <T, K>
	{
		public override bool AddEdge(T v1, T v2, K weight)
		{
			if(v1 == null || v2 == null || weight == null)
				throw new ArgumentNullException();
			if(!VertexSet.Contains(v1) || !VertexSet.Contains(v2))
				return false;
			IPairValue<T> pair = new PairValue<T>(v1, v2);
			if(EdgeSet.Contains(pair))
				return false;
			EdgeSet.Add(pair);
			Weights[pair] = weight;
			return true;
		}
		public override bool DeleteEdge(T v1, T v2)
		{
			if(v1 == null || v2 == null)
				throw new ArgumentNullException();
			IPairValue<T> pair = new PairValue<T>(v1, v2);
			if(!EdgeSet.Contains(pair))
				return false;
			EdgeSet.Remove(pair);
			Weights.Remove(pair);
			return true;
		}
		public override K GetWeight(T v1, T v2)
		{
			if(v1 == null || v2 == null)
				throw new ArgumentNullException();
			IPairValue<T> pair = new PairValue<T>(v1, v2);
			if(!Weights.ContainsKey(pair))
				throw new ArgumentException();
			return Weights[pair];
		}

		public override bool AreAdjacent(T v1, T v2)
		{
			if(v1 == null || v2 == null)
				throw new ArgumentNullException();

			if(!VertexSet.Contains(v1) || !VertexSet.Contains(v2))
				throw new ArgumentException();

			IPairValue<T> pair = new PairValue<T>(v1, v2);
			return EdgeSet.Contains(pair);
		}

		public override int Degree(T vertex)
		{
			if(vertex == null)
				throw new ArgumentNullException();
			if(!VertexSet.Contains(vertex))
				throw new ArgumentException();
			
			return InDegree(vertex) + OutDegree(vertex);
		}

		public override int OutDegree(T vertex)
		{
			if(vertex == null)
				throw new ArgumentNullException();
			if(!VertexSet.Contains(vertex))
				throw new ArgumentException();
			int count = 0;
			foreach(var pair in EdgeSet)
			{
				if(pair.GetFirst().Equals(vertex))
					count++;
			}
			return count;
		}

		public override int InDegree(T vertex)
		{
			if(vertex == null)
				throw new ArgumentNullException();
			if(!VertexSet.Contains(vertex))
				throw new ArgumentException();
			int count = 0;
			foreach(var pair in EdgeSet)
			{
				if(pair.GetSecond().Equals(vertex))
					count++;
			}
			return count;
		}

		public override IEnumerable<T> AdjacentVertices(T vertex)
		{
			if(vertex == null)
				throw new ArgumentNullException();
			if(!VertexSet.Contains(vertex))
				throw new ArgumentException();
			List<T> list = new List<T>();
			foreach(IPairValue<T> pair in EdgeSet)
				if(pair.GetFirst().Equals(vertex))
					yield return pair.GetSecond();
		}
	}
}