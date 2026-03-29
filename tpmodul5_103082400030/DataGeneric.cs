using System;
public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    // method print
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
    }
}