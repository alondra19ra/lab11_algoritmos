using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree<T>
{
    public TreeNode<T> Root { get; private set; }

    public Tree(T rootValue)
    {
        Root = new TreeNode<T>(rootValue);
    }


    // B�squeda Recursiva
    public TreeNode<T> Find(TreeNode<T> node, T value)
    {
        if (EqualityComparer<T>.Default.Equals(node.Value, value))
            return node;

        foreach (var child in node.Children)
        {
            var result = Find(child, value);
            if (result != null)
                return result;
        }

        return null;
    }

    // Altura del �rbol desde un nodo
    public int GetHeight(TreeNode<T> node)
    {
        if (node.Children.Count == 0)
            return 0;

        int maxChildHeight = 0;
        foreach (var child in node.Children)
        {
            maxChildHeight = Math.Max(maxChildHeight, GetHeight(child));
        }

        return 1 + maxChildHeight;
    }

    // Recorrido Preorden (ra�z -> hijos)
    public void TraversePreOrder(TreeNode<T> node, Action<T> action)
    {
        action(node.Value);
        foreach (var child in node.Children)
        {
            TraversePreOrder(child, action);
        }
    }
}
