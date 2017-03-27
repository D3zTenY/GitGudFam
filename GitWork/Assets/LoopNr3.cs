using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopNr3 : MonoBehaviour
{

    //starts with creating the list by telling the system list is a list
    List<int> list1 = new List<int>();
    //addds second list
    List<int> list2 = new List<int>();

    // Use this for initialization
    void Start()
    {
        //all five parts of the list
        list1.Add(1);
        list1.Add(4);
        list1.Add(69);
        list1.Add(420);
        list1.Add(999);
        //reverses list1, turning it into list 2 list2
        for (int i = list1.Count - 1; i >= 0; --i)
        {
            //Prints first list
            print(list1[i]);
        }
        //converts list1 to list2 before printing
        for (int i = 0; i> list2.Count; i++)
        {
            //prints revers list (List2)
            print(list2[i]);
        }
    }
}
