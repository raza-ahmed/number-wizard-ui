using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour
{
    int min, max, guess;
    int maxGuesses;

    public Text guessedText;
    public Text maxGuessesText;

    // Start is called before the first frame update
    void Start()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max += 1;
        maxGuesses = 8;
        maxGuessesText.text = maxGuesses.ToString();
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
        maxGuesses -= 1;
        maxGuessesText.text = maxGuesses.ToString();
        if (maxGuesses <= 0)
        {
            LoadLevelLost("Win");
        }
        guess = (max + min) / 2;
        guessedText.text = guess.ToString();
        
    }
    public void LoadLevelLost(string name)
    {
        SceneManager.LoadScene(name);
    }
}
