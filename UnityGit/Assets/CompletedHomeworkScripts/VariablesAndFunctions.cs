using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }

    int MultiplyByTwo(int number)
    {
        int Result;
        Result = number * 2;
        return Result;
    }
    
}
