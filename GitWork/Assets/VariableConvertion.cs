using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableConvertion : MonoBehaviour {
    //Values of a, b and c
    public int a = 64;
    public int b = 62;
    int c = 0;


	// Use this for initialization
	void Start ()
    {
        //Combines a + b to become c
        c = a + b;
        //Prints the value of c
        Debug.Log(c);
        //Prints the values combined
        Debug.Log(a + b);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
