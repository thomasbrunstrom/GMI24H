///<summary>///ADT Stack
///Stack är en abstrakt datatypsom består av värden vars positioner är ordnade i en
///sammanhållen linjär följd. Den ena änden av de linjärt ordnade positionerna utgör
///stackens topp. Endast det värde som finns i stackens topp går att komma åt och ta
///bort, alla andra värden i stacken är oåtkomliga. Det är endast möjligt att sätta
///in nya värden i stackens topp.
interface IStack 
{
    //<summary>
    ///Lägger in ett värde på stackens topp.
    ///Precondition: Alltid uppfyllt.
    ///Postkondition: Värdet aNumberär inlagt vid stackens topp.
    ///</summary>
    ///<paramname="aNumber">Värdet aNumberär inlagt vid stackens topp</param>
    void Push(double aNumber);

    ///<summary>
    ///Tar bort värdet vid stackens topp och returnerar det.
    ///Precondition: Stacken får inte vara tom.
    ///Postcondition: Värdet vid toppen är borttaget och är returnerat.
    ///</summary>
    ///<returns>double</returns>
    double Pop();

    ///<summary>
    ///Returnerar true/false beroende på om stacken innehåller information
    ///Precondition: Ingen.
    ///Postcondition: Sant om stacken innehåller värden, annars falskt
    ///</summary>
    ///<returns>bool</returns>
    bool IsEmpty();
    
    //Ytterligare delar av kontraktet
}