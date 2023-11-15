# Directed Graph Library in C#

## Overview
This C# library offers a simple implementation of a directed graph data structure, tailored for experimental and educational purposes. It provides basic functionality to create and manipulate directed graphs with generic vertex and edge types.

## Features
- Generic implementation supporting various data types for vertices and edges
- Methods for adding vertices and edges
- Ability to retrieve sets of vertices and edges
- Lightweight structure, ideal for extension and experimentation

## Getting Started
Clone the repository and include it in your C# project:

```bash
git clone git@github.com:jb-is-batman/directed-graph.git
```
## Usage
To use this library, include it in your project and follow this basic example:

```csharp
using GraphLibrary;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			// Initialize a new directed graph
			DirectedGraph<string, string> graph = new DirectedGraph<string, string>();
			
			// Add vertices
			graph.AddVertex(new string[] { "A", "B", "C", "D", "E", "F", "G" });
			
			// Add edges
			graph.AddEdge("A", "B", "AB");
			graph.AddEdge("A", "C", "AC");

			// Display vertices
			foreach (var item in graph.GetVertexSet())
				Console.WriteLine(item);
			
			// Display edges
			foreach (var item in graph.GetEdgeSet())
				Console.WriteLine(item.GetFirst() + " -> " + item.GetSecond());			
			Console.ReadLine();
		}
	}
}
```

## Extending the Library
This library is designed to be easily extendable for more complex graph algorithms or different graph structures. Feel free to build upon it to suit your specific needs.