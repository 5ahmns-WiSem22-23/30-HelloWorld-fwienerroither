using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVariablen : MonoBehaviour
{

int myInt = 0;
bool myBool = true;

int[] myArray = new int [3] {0,0,0};

    void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        int tmp = myInt;
        myInt = myInt++;
        Debug.Log("myInt: " + myInt + " tmp " + tmp);

        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        foreach(int a in tmpArray)
        {
            Debug.Log(a);
        }

        foreach(int a in myArray)
        {
            Debug.Log(a);
        }

        string tmpString = a;
        a = "hello";
        Debug.Log("a " + a + " tmpString " + tmpString);
    }
}
