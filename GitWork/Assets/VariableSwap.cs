using UnityEngine;
using System.Collections;

public class VariableSwap : MonoBehaviour {

    int a=1;
    int b=2;
    int c;

	void Start () 
    {
        Debug.Log(a);
        Debug.Log(b);
        c = b;
        b = a;
        a = c;
        Debug.Log(a);
        Debug.Log(b);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
