using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    public float a = 3;
    public float b = 3;
    public bool c = false;
    public bool d = true;
    public bool e = true;

    // Start is called before the first frame update
    void Start()
    {
        if(a + b == 6)
        {
            Debug.Log("+ works");
        }

        if(c || d)
        {
            Debug.Log("|| works");
        }

        if(d && e)
        {
            Debug.Log("&& works");
        }

        if( a > 2)
        {
            Debug.Log("> works");
        }


    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
