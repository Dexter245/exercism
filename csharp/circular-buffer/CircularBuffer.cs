using System;

public class CircularBuffer<T>
{
    private T[] values;
    private readonly int cap;
    private bool isEmpty = true;
    private int oldest = 0;
    private int next = 0;

    public CircularBuffer(int capacity)
    {
        this.cap = capacity;
        this.values = new T[capacity];
    }

    public T Read()
    {
        if(next != oldest || !isEmpty)
        {
            var value = values[oldest];
            oldest = (oldest + 1) % cap;
            if (oldest == next)
                isEmpty = true;
            return value;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void Write(T value)
    {
        if(next != oldest || isEmpty)
        {
            values[next] = value;
            next = (next + 1) % cap;
            if (isEmpty)
                isEmpty = false;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void Overwrite(T value)
    {
        values[next] = value;
        if (isEmpty)
            isEmpty = false;
        if (next != oldest || isEmpty)
        {
            next = (next + 1) % cap;
        }
        else
        {
            next = (next + 1) % cap;
            oldest = (oldest + 1) % cap;
        }
    }

    public void Clear()
    {
        isEmpty = true;
        oldest = next = 0;
    }
}