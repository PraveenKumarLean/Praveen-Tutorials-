using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class TimeAndSpace : MonoBehaviour
{
    public string[] Names = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" };
   
    void Start()
    {
        for(int index = 0; index <Names.Length; index++)
        {
           // UnityEngine.Debug.Log($"{Names[index]} : {index}");
            if (Names[index] == "m")
            {
               // UnityEngine.Debug.Log($"m {index}");
                return;
            }
        }
    }
    // 1+n^2*3 sivaraj
    // n^2

    // 4
    //3
    //3
    //1+n*3

    // n

    //O(1) ---------> BEST
    //O(LOG N)
    //O(N)
    //O(N LOG N)
    //O(N^2)
    //O(N^3)
    //O(2^N) ---------> WORST
}
