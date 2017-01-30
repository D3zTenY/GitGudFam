using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableCount : MonoBehaviour {

    // The changable values of a and b
    public int a = 10;
    public int b = 20;

	// Use this for initialization
	void Start () {
        if (a > b)
    // Prints if a has a higher value
        {
            print("a is bigger");
        }
        else
        //Prints if b has a higher value
        {
            print("b is Bigger");
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
