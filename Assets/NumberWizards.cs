using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour
{
    int min, max, guess;
    public int maxGuesses;

    public Text guessedText;

    // Start is called before the first frame update
    void Start()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max += 1;
        maxGuesses = 0;
    }

    public void GuessLower()
    {
        max = guess;
        GuessNumber();
    }
    public void GuessHigher()
    {
        min = guess;
        GuessNumber();
    }
    
    void GuessNumber()
    {
        guess = (max + min) / 2;
        guessedText.text = guess.ToString();
        maxGuesses += 1;
    
        if (maxGuesses >= 5)
        {
            LoadLevelLost("Win");
        }
    }
    public void LoadLevelLost(string name)
    {
        SceneManager.LoadScene(name);
    }
}
