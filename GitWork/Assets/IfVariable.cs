using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfVariable : MonoBehaviour
{
    //The values of a, b and c
    public int a = 5;
    public int b = 10;
    public int c = 15;

    // Use this for initialization
    void Start()
    //Checks the position for a in cases of c and b
    {
        if (a < b && a < c || a > b && a < b)
        //Prints a if the requirements are met
        {
            print("a");
        }
        //Checks the position of b in cases of a and c
        else if (b > a && b < c || b < a && b > c)
        //Prints b if the requirements are met 
        {
            print("b");
        }
        //Prints c if none of the requirements above are met
        else
        {
            print("c");
        }


    }

        // Update is called once per frame
        void Update () {
        }
}
