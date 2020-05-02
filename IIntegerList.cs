///<summary>///IIntegerList
///IIntegerList är en abstrakt datatyp som består av vars värden är sammanhållna
///i en linjär följd. Den ena änden utgör listans topp och den andra listans botten.
public interface IIntegerList
{
    ///<summary>///
    ///Lägger in ett värde på listans topp
    void Push(int number);

    ///<summary>///
    ///Hämtar och tar bort ett värde på listans topp
    int Pop();

    ///<summary>///
    ///Hämtar och tar bort ett värde på listans botten
    int Shift();

    ///<summary>///
    ///Sorterar listan i stigande ordning, 0, 1, 2, 3... 999
    void SortAscending();

    ///<summary>///
    ///Sorterar listan i fallande ordning, 999, 998, 997, 996... 0
    void SortDescending();
    
    ///<summary>///
    ///Returnerar listan som en array
    int[] ToArray();
}