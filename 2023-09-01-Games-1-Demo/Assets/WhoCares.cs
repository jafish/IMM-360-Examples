using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhoCares : MonoBehaviour
{
    // Recipe for creating a variable:
    // type name (= value) (items inside parentheses are optional)
    int counter;
    string prefix;

    // Start is called before the first frame update
    void Start()
    {
        prefix = "Counter variable's value: ";
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Adding 1 to the current value of the counter variable
        //counter = counter + 1;
        counter++;
        //counter += 1;

        // An if statement is an example of a "control structure"
        // if statements are also often called "conditional statements"
        // Recipe for creating an if statement:
        // if (relational expression) {lines of code to run if
        //  relational expression evaluates to "true"}
        if (counter > 120)
        {
            counter = 0;
        }

        // Converting the counter variable to the string "type", then
        // concatenating that string to the end of the value of the
        // string variable "prefix", then writing the resulting string
        // value to the Unity console
        Debug.Log(prefix + counter);
    }
}
