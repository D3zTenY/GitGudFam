using UnityEngine;
using System.Collections;

public class VariableSwap : MonoBehaviour {

    int a;
    int b;
    int c;

	void Start () 
    {
        c = b;
        b = a;
        a = c;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
