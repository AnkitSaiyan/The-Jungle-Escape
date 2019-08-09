using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuessNumber : MonoBehaviour
{

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;
    int flag = 0;

    public void StartGame()
    {
        if(flag==0)
        {
            ++max;
            UpdateGuess();
        }
    }

    public void FindLowerNumber()
    {
        if(flag==1)
        {
            max = guess;
            UpdateGuess();
        } 
    }

    public void FindHigherNumber()
    {
        if(flag==1)
        {
            min = guess + 1;
            UpdateGuess();
        }
    }

    private void UpdateGuess()
    {
        guess = Random.Range(min,max);
        guessText.text = guess.ToString();
        flag = 1;
    }
}
