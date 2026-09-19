using System.Collections;
using System.Security.Cryptography;
using System.Xml;

public class BinarySearchTree : IEnumerable<int>
{

    public BinarySearchTree(int value)
    {
        Value = value;
    }
    public BinarySearchTree(IEnumerable<int> values)
    {
        Value = values.First();
        foreach (var value in values.Skip(1))
        {
            Add(value);
        }
    }

    public int Value { get; set; }
    public BinarySearchTree Left { get; set; }
    public BinarySearchTree Right { get; set; }

    public BinarySearchTree Add(int value)
    {
        if (value <= Value)
            Left = Left?.Add(value) ?? new BinarySearchTree(value);
        else
            Right = Right?.Add(value) ?? new BinarySearchTree(value);
        
        return this;

       
    }

    public IEnumerator<int> GetEnumerator()
    {
        if (Left != null)
            foreach (var leftValue in Left)
                yield return leftValue;
        yield return Value;
        if (Right != null)
            foreach (var rightValue in Right)
                yield return rightValue;
        

            
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}