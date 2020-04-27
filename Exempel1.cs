
using System;

class Exempel1 
{
    /*
    Den här algoritmen kontrollerar om key har ett värde som är lika med i:et elements värde i arrayen values.
    Indata: values, en array med n värden.
    Indata: i, index till det sökta elementet i values som ska kontrolleras. I måste ligga i intervallet [0, n].
    Indata: key, det sökta värdet.
    Utdata: Sant om elementets värde är lika med key, i annat fall falskt.
    */
    bool FindKey1(string[] values, int i, string key) 
    {
        return values[i] == key;
    }
    /**
    Den här algoritmen kontrollerar om key har ett värde som finns i arrayens values.
    Indata: values, en array med n värden.
    Indata: n, antal element som values består av
    Indata: key, det sökta värdet.
    Utdata: index till det element vars värde är lika med key, i annat fall -1
    */
    int FindKey2(string[] values, int n, string key) 
    {                               //Antal operationer
        int i = 0;                  //1 operation
        while(i < n) {              //1 operation som repeteras (n+1) gånger i värsta fall
            if(key == values[i])    //1 operation som repeteras n gånger i värsta fall
            {
                return i;           //Exekveras endast 1 gång om det sökta värdet har hittats
            }
            i++;                    //1 operation för addition. Exekveras n gånger i värsta fall = (1 + 1)*n = 2*n        
        }
        return -1;                  //1 operation i värsta fall, om det sökta värdet inte hittas.

                                    //Totalt antal exekverade operationer för det västa fallet blir:
                                    //T(n) = 1 + 1 * (n+1) + 1*n + 2*n = 4*n+3
    }

    /**
    De här algoritmen kontrollerar om key har ett värde som finns i array values.
    Indata: values, en array med n värden. OBS! värdena måste vara sorterade i växande ordning.
    Indata: n, antal element som values består av
    Indata: key, det sökta värdet
    Utdata: index till det element vars värde är lika med key, i annat fall -1.
    */
    int FindKey3(int[] values, int n, int key)
    {
        int left = 0, right = n - 1;            // 2 operationer
        while(left <= right) {                  // 1 upprepas i värsta fall 1 + log2(n) gånger    
            int middle = (left + right) / 2;    // 3 upprepas i värsta fall log2(n) gånger
            if(key < values[middle]) {          // 1 upprepas i värsta fall log2(n) gånger
                right = middle -1;              // 2
            }
            else if(key > values[middle]) {     // 1 upprepas i värsta fall log2(n) gånger
                left = middle + 1;              // 2 
            }
            else {
                return middle;                  // 1
            }
        }
        return -1;                              //1 gång (om tidigare in träffats)
    } 
}