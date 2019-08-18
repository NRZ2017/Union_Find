using System;
using System.Collections.Generic;
using System.Text;

namespace Union_Find
{
    class Vertex<T> where T : IComparable
    {
        public T Value;
        public bool IsVisited;
        public double TotalDistance = double.NegativeInfinity;
        public Vertex<T> Founder = null;

        public Dictionary<Vertex<T>, double> Edges = new Dictionary<Vertex<T>, double>();

        public Vertex(T value)
        {
            this.Value = value;
            Edges = new Dictionary<Vertex<T>, double>();
        }

        public int CompareTo(Vertex<T> other)
        {
            return TotalDistance.CompareTo(other.TotalDistance);
        }
        
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
