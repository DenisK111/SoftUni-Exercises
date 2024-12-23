﻿namespace _05.TopView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BinaryTree<T> : IAbstractBinaryTree<T>
        where T : IComparable<T>
    {
        public BinaryTree(T value, BinaryTree<T> left, BinaryTree<T> right)
        {
            this.Value = value;
            this.LeftChild = left;
            this.RightChild = right;
        }

        public T Value { get; set; }

        public BinaryTree<T> LeftChild { get; set; }

        public BinaryTree<T> RightChild { get; set; }

        public List<T> TopView()
        {
            var dictionary = new Dictionary<int, (T nodeValue, int nodeLevel)>();

            TopView(this, 0, 0, dictionary);

            return dictionary.Select(x => x.Value.nodeValue).ToList();
        }

        private void TopView(BinaryTree<T> node, int dist,  int level,  Dictionary<int, (T nodeValue, int nodeLevel)> dictionary)
        {
            if (node==null)
            {
                return;
            }

            if (!dictionary.ContainsKey(dist))
            {
                dictionary.Add(dist, (node.Value, level));
            }

            else
            {
                if (dictionary[dist].nodeLevel > level)
                {
                    dictionary[dist] = (node.Value, level);
                }
            }

            TopView(node.LeftChild, dist - 1, level + 1, dictionary);
            TopView(node.RightChild, dist + 1, level + 1, dictionary);


        }
    }
}
