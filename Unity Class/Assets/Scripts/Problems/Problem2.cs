using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int j = 0;
        for (int i =0; i< numbers.Length; i++)
        {
            for (j =0; j<numbers.Length && i > j; j++)
            {
               
                Debug.Log($"J {j}");
            }
           // UnityEngine.Debug.Log($" i {i}J {j}");
        }
    }


    // i j
    // 0 0 
    // 1 0,1
    // 2 0,1,2
    // 3 0,1,2,3

 
    // i = 3
    // j = 0<9 && 3>0 J =1
    // j = 1<9 && 3>1 J =2
    // j = 2<9 && 3>2 J =3
    // j = 3<9 && 3>3 J =3

    // i j
    // 0 N
    // 1 1
    // 2 2

    // N + 1 + 1 + 1
    //2N
    //O(2N)

}


// 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20