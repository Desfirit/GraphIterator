﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{
    class Graph
    {
        int[,] matrix;
        uint _n;
        public Graph(uint n)
        {
            matrix = new int[n, n];
            _n = n;
            for (var i = 0; i < n; ++i)
                for (var j = 0; j < n; ++j)
                    matrix[i,j] = 0;
        }

        public void AddEdge(uint vert1, uint vert2)
        {
            matrix[vert1, vert2] = 1;
        }

        public void RemoveEdge(uint vert1, uint vert2)
        {
            matrix[vert1, vert2] = 0;
        }

        public IEnumerable<uint> GetIterator(uint vertex)
        {
            if (vertex > _n - 1)
                throw new Exception($"Out of range graph vertex({vertex}) > {_n - 1}");


            //Вспомогательный структуры для обхода в ширину
            Queue<uint> queue = new Queue<uint>();
            int[] visited = new int[_n];
            //Инициализация нулями
            for (uint i = 0; i < _n; ++i)
                visited[i] = 0;


            //ВставОчка первой вершины
            visited[vertex] = 1;
            queue.Enqueue(vertex);

            while(queue.Count != 0)
            {
                yield return queue.Peek();
                var vert = queue.Dequeue();
                for (uint i = 0; i < _n; ++i)
                {
                    if (visited[i] == 0 && matrix[vert, i] != 0)
                        queue.Enqueue(i);
                }
            }
        }
    }
}
