﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopNr2 : MonoBehaviour

{

    //starts with creating the list by telling the system list is a list
    List<int> list = new List<int>();
    public int compare;


    // Use this for initialization
    void Start()
    {
        //all five parts of the list
        list.Add(1);
        list.Add(4);
        list.Add(69);
        list.Add(420);
        list.Add(999);
        //if the requirements are met the system prints the parts of the list
        for (int i = 0; i < list.Count; i++)
            //Loops and compares values
        {
            if(list[i] == compare)
            {
                //prints when process is done
                print(list[i]);
            }
        }

    }
}

