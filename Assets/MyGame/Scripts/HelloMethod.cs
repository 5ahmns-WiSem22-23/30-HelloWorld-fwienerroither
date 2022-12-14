using UnityEngine;

public class HelloMethod : MonoBehaviour
{
    //2) Instanzvariable nutzen
    private int startValue = 0;

    //3) Der Wert, der dazugezählt wird, ist bei der Deklaration noch nicht bekannt
    //z.B. Random oder User Input
    private int startValue3 = 0;

    //4) Copy by value
    private int startValue4 = 0;

    //5) Return
    private int startValue5 = 0;


    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden");

        //at 2)
        Debug.Log("before startValue: " + startValue);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue);

        //at 3)
        Debug.Log("before startValue3: " + startValue);
        IncrementBy(Random.Range(1, 10));
        Debug.Log("after startValue3: " + startValue);

        //at 4)
        Debug.Log("before startValue4: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after startValue4: " + startValue4);

        //at 5)
        Debug.Log("before startValue5: " + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after  startValue5: " + startValue5);
    }

    //5) incl. return value
    private int DecrementByX (int start, int valToSub)
    {
        return start - valToSub;
    }

    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    private void IncrementBy(int valToAdd)
    {
        startValue3 += Mathf.Abs(valToAdd);
    }

    private void IncrementByOne()
    {
        startValue++;
    }
}
