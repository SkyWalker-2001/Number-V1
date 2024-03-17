using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    /*public Text sequenceText;
    public Text feedbackText;
    public Button[] numberButtons;
    public int sequenceLength = 3;
    public float displayTime = 1f;
    public float responseTime = 5f;

    private string currentSequence;
    private int currentIndex;
    private bool playerTurn;

    void Start()
    {
        
        StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {
        currentSequence = GenerateSequence(sequenceLength);
        sequenceText.text = currentSequence;
        feedbackText.text = "Memorize the sequence...";
        yield return new WaitForSeconds(displayTime);
        sequenceText.text = "";
        feedbackText.text = "Enter the sequence:";
        playerTurn = true;
        currentIndex = 0;

        yield return new WaitForSeconds(responseTime);

        if (currentIndex < sequenceLength)
        {
            GameOver();
        }
    }

    void OnNumberButtonClick(Button button)
    {
        if (!playerTurn)
            return;

        int number = int.Parse(button.GetComponentInChildren<Text>().text);
        if (number == int.Parse(currentSequence[currentIndex].ToString()))
        {
            currentIndex++;
            if (currentIndex >= sequenceLength)
            {
                feedbackText.text = "Correct!";
                StartCoroutine(PlaySequence());
            }
        }
        else
        {
            GameOver();
        }
    }

    string GenerateSequence(int length)
    {
        string sequence = "";
        for (int i = 0; i < length; i++)
        {
            sequence += Random.Range(1, 10).ToString();
        }
        return sequence;
    }

    void GameOver()
    {
        feedbackText.text = "Game Over!";
        sequenceText.text = "Correct sequence: " + currentSequence;
        playerTurn = false;
    }*/
}
