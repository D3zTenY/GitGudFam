using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{

    //starts with creating the list by telling the system list is a list
    List<int> list = new List<int>();
    //temporary variable
    int temp;
    //tells system the process is done
    int done;
    //tells system everything is sorted
    bool sorted; 

    // Use this for initialization
    void Start()
    {
        //all five parts of the list
        list.Add(4);
        list.Add(420);
        list.Add(999);
        list.Add(1);
        list.Add(69);
        //while the list isnt sorted, the process will run
        while (sorted == false)
        {
           for (int sort = 0; sort < list.Count -1; sort++)
            {
                //begins sorting the list
                if (list[sort] > list[sort + 1])
                {
                    sorted = 0;
                    temp = list[sort + 1];
                    list[sort + 1] = list[sort];
                    list[sort] = temp;
                }
                else
                {
                    //knows when list is done
                    done++;
                    if (done == list.Count)
                    {
                        //tells system its done
                        sorted = true;
                    }
                }
            }
        }
        //prints when list is sorted
        for (int i = 0; i < list.Count; i++)
            print(list[i]);
    }
}