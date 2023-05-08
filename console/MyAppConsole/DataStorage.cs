using System;

namespace MyAppConsole;

public class DataStorage<T> where T : class
{
    private T[] storage;

    public DataStorage(int count)
    {
        storage = new T[count];
    }

    public T this[int idx]
    {
        get
        {
            validate(idx);
            return storage[idx];
        }
        set
        {
            validate(idx);
            storage[idx] = value;
        }
    }

    private void validate(int idx)
    {
        bool valid;

        valid = (0 <= idx && storage.Length > idx);

        if (false == valid)
        {
            throw new IndexOutOfRangeException($"invalid index of {idx}");
        }
    }
}