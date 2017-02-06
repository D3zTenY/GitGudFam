using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAssignment : MonoBehaviour {

    //Tells the values of a, b and c
    public int a = 1;
    public int b = 2;
    int c = 0;

    //Method for combining a and b
    int Add( int left, int right)
    {
        return left + right;
    }

	// Use this for initialization
	void Start ()
        //Combines a and b
    {
        c = Add(a, b);

        //Checks the values 
        {
            if (a < b && a < c || a > b && a < b)
                //Prints if requirements are met
            {
                print("a");
                //Checks the other values
            }
            else if (b > a && b < c || b < a && b > c)
                //Prints if requirements are met
            {
                print("b");
            }
            else
            //Prints if no requirements for a and b are met
            {
                print("c");
            }
        }
         



		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
