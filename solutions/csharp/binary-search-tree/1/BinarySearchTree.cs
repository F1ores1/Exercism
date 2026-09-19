using System.Collections;
using System.Security.Cryptography;
using System.Xml;

public class BinarySearchTree : IEnumerable<int>
{

    private int _value;

    private BinarySearchTree node;

    private List<int> sort = new();

    
    public BinarySearchTree(int value)
    {
        Value = value;
        node = this;
        sort.Add(value);
    }

    public BinarySearchTree(IEnumerable<int> values)
    {
        var count = 0;
        foreach (var val in values)
        {
            if (count == 0)
            {
                Value = val;
                node = this;
                sort.Add(val);
            }
            else
            {
                Add(val);
            }
            
            count++;
        }
    }

    public int Value
    {
        get
        {
            return _value;
        }

        set
        {
            _value = value;
        }
    }

    public BinarySearchTree? Left
    {
        get; set;
    }

    public BinarySearchTree? Right
    {
        get; set;
    }

    public BinarySearchTree Add(int value)
    {
        var count = 0;
        BinarySearchTree prevNode;
        BinarySearchTree currentNode = node;
        while(count < 5)
        {
            prevNode = currentNode;

            if (value <= currentNode.Value)
            {
                if (currentNode.Left == null)
                {
                    prevNode.Left = new BinarySearchTree(value);
                    sort.Insert(sort.IndexOf(prevNode.Value), value);
                    break;
                }
                currentNode = currentNode.Left;
                
            }
            else 
            {
                if (currentNode.Right == null)
                {
                    prevNode.Right = new BinarySearchTree(value);
                    sort.Insert(sort.IndexOf(prevNode.Value)+1, value);
                    break;
                }
                currentNode = currentNode.Right;
            }
            count++;
        }
        

        return currentNode;

       
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var val in sort)
        {
            yield return val;
        }

            
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        yield return sort;
    }
}