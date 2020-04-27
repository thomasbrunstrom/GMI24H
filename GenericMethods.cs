using System;
using System.Collections;
using System.Collections.Generic;

public class Example
{
    public T MethodName<T>(T a, T b) //[restriktioner]
    {
        // Ett antal satser
        return a;
    }
    public bool MethodName3<T1, T2, T3>(T1 a, T2 b, T3 c)
        where T1 : Example //Restriktion
        where T2 : IComparable //Restriktion
        where T3 : IEnumerable //Restriktion
    {
        return true;
    }
    public void MethodName2<T>(T a, T b) where T : IComparable
    {

    }
}
public class Example2<T1, T2>
    where T1 : Example //Restriktion på T1
    where T2 : Example //Restriktion på T2
{
    public T1 variableName;
    public T2 MethodName(T1 name1, T2 name2)
    {
        return name2;
    }
}

public class Verktyg
{
    public bool IsLessThen(char val1, char val2)
    {
        return val1 < val2;
    }
    public bool IsLessThen<T>(T val1, T val2)
    where T : IComparable
    {
        return val1.CompareTo(val2) < 0;
    }
}


public class Person : IComparable<Person>
{
    private string Name;
    private int Age;
    public int CompareTo(Person enPerson)
    {
        if (enPerson == null)
            throw new Exception("Null reference error.");
        if (Age < enPerson.Age)
            return -1;
        else if (Age > enPerson.Age)
            return 1;
        else
            return 0;
    }
}

public class Tools
{
    public bool IsLessThen(Person val1, Person val2)
    {
        if (val1.CompareTo(val2) < 0)
            return true;
        else
            return false;
    }
    public bool IsLessThen<T>(T val1, T val2)
    where T : IComparable<T>
    {
        if (val1.CompareTo(val2) < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
public class a1
{
    public void CompareTest()
    {
        var tools = new Tools();

        Int32 tal1 = 55, tal2 = 65;
        tools.IsLessThen<Int32>(tal1, tal2);

        char c1 = 'a', c2 = 'b';
        tools.IsLessThen<char>(c1, c2);

        string s1 = "abc", s2 = "def";
        tools.IsLessThen<string>(s1, s2);

        Person p1 = new Person();
        Person p2 = new Person();
        tools.IsLessThen<Person>(p1, p2);
    }
}