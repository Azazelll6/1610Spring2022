using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    void start()
    {
        myint = multiplybytwo(myInt);
        debug.log(myInt);
    }

    int multiplybytwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
    
}
