using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem1 : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   
    void Start()
    {

        for(int i =0; i<numbers.Length;i++)
        {
            for(int j =i+1; j < numbers.Length; j++)
            {
                //O(N^2)
            }
        }

       
        // i j
        // 0 1 to N = N
        // 1 2 to N = N-1
        // 2 3 to N = N-2
        // 3 4 to N = N-3

        // N +(N-1) + (N-2) + (N-3) ...... +1

        // N*(N+1)
        //---------
        //    2

        // N^2 + N
        //--------
        //    2    


        // N^2      N
        //-----  + ---
        //  2       2

        //-------------------------------------

        // (N^2+N) = N(N+1)

        //N(N + 1 + 2) == N^2 + 1N +2N

        // N*N = N^2
        //eg: N = 5 == 5*5 = 5+5+5+5+5

        // N+N = 2N
        //eg: N = 5 == 2*5 = 5+5


    }
}

//n = Length

// O(1)
// O(log n)
// O(n)
// O(n log n)
// O(n^2)
// O(n^3)
// O(2^n)
