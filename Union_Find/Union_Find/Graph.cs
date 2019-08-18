using System;
using System.Collections.Generic;
using System.Text;

namespace Union_Find
{
    class Graph<T> where T : IComparable
    {
        public List<Vertex<T>> Vertices = new List<Vertex<T>>();
        public int EdgeCount { get; private set; }

        public Graph()
        {
        }

        public void AddVertex(Vertex<T> vert)
        {
            Vertices.Add(vert);
        }

        public bool RemoveVertex(Vertex<T> vertex)
        {
            foreach(var vert in Vertices)
            {
                vert.Edges.Remove(vertex);
            }
            return Vertices.Remove(vertex);
        }

        public void AddEdge(T a, T b, double weight)
        {
            var x = GetVertex(a);
            var y = GetVertex(b);

            if(x == null || y == null)
            {
                throw new Exception("Vertices Not Found");
            }

            AddEdge(x, y, weight);
        }

        public Vertex<T> GetVertex(T value)
        {
            foreach(var vert in Vertices)
            {
                if(vert.Value.Equals(value))
                {
                    return vert;
                }
            }
            return null;
        }
    }



}
