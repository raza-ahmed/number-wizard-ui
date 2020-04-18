using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour
{
    int min, max, guess;
    // Start is called before the first frame update
    void Start()
    {
        Startgame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            GuessNumber();

        }else if (Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            GuessNumber();

        }else if (Input.GetKeyDown(KeyCode.Return)){
            print("I won" + guess);
            print("==================================");
            Start();
        }   
        
    }

    void Startgame()
    {
        print("Welcome to number wizard");
        print("Pick a number in your head but don't tell me!");

        max = 1000;
        min = 1;
        guess = 500;

        print("The largest number you can pick is" + max);
        print("The smallest number you can pick is" + min);

        print("Is the number higher or lower than " + guess);
        print("Up=higher, down=lower, return=equal");

        max += 1;
    }

    void GuessNumber()
    {
        guess = (max + min) / 2;
        print("Is the number higher or lower than" + (min + max) / 2);
        print("Up=higher, down=lower, return=equal");
       
    }
}
