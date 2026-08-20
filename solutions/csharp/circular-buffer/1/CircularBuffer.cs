public class CircularBuffer<T>
{
    
    List<T> buffer = new List<T> {};
    int bufferLength;
    public CircularBuffer(int capacity)
    {
        bufferLength = capacity;
    }

    public T Read()
    {
        if (buffer.Count() == 0)
            throw new InvalidOperationException("Buffer Empty");

        var temp = buffer[0];
        buffer.Remove(buffer[0]);
        return temp;
    }

    public void Write(T value)
    {

        if (buffer.Count() < bufferLength)
        {
       
            buffer.Add(value);
        }
        else
        {
            throw new InvalidOperationException("Buffer Full");
        }
            



    }

    public void Overwrite(T value)
    {
        if (buffer.Count() == bufferLength)
            buffer.Remove(buffer[0]);
        
        buffer.Add(value);
    }

    public void Clear()
    {
        buffer = new List<T>{};
    }

}