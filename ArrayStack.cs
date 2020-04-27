using System;

class ArrayStack : IStack
{
    private double[] array = null;
    int size = 0;
    public ArrayStack()
    {
        array = new double[2];
    }
    public double Pop()
    {
        throw new NotImplementedException();
    }

    public void Push(double aNumber)
    {
        throw new NotImplementedException();
    }
    public bool IsEmpty()
    {
        return array.Length <= 0;
    }
}