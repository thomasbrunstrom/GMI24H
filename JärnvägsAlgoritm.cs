using System;
using System.Collections.Generic;

public class JärnvägsAlgoritm
{
    public void Algo()
    {
        //Bygg tåget med vagnar
        //Använder den inbygda stacken i dotnet.
        Stack<int> inputTrack = new Stack<int>();
        inputTrack.Push(3);
        inputTrack.Push(2);
        inputTrack.Push(1);
        inputTrack.Push(3);
        inputTrack.Push(2);

        Stack<int> StickSpårA = new Stack<int>();
        Stack<int> StickSpårB = new Stack<int>();
        Stack<int> OutputTrack = new Stack<int>();

        //Skicka in dem på egna spår
        StickSpårA.Push(inputTrack.Pop());
        StickSpårB.Push(inputTrack.Pop());
        OutputTrack.Push(inputTrack.Pop());
        StickSpårA.Push(inputTrack.Pop());

        //Koppla in dem i rätt ordning
        inputTrack.Push(StickSpårB.Pop());
        inputTrack.Push(StickSpårA.Pop());
        inputTrack.Push(StickSpårA.Pop());
        inputTrack.Push(OutputTrack.Pop());
        

        int val = inputTrack.Pop();
        while(inputTrack.Count > 0) 
        {
            Console.WriteLine(val);
            val = inputTrack.Pop();
        }
    }
}