using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Manager2 : MonoBehaviour
{
    public Button genNum;
    public GameObject genNubObj;
    public GameObject FizzObj;
    public GameObject BuzzObj;
    public GameObject fizzBuzzObj;
    public GameObject nixObj;
    public TMP_Text Number;
    public GameObject NumberObj;
    public TMP_Text rightNumber;
    public GameObject rightNumberObj;
    public TMP_Text wrongNumber;
    public GameObject wrongNumberObj;
    public TMP_Text infoTxt;
    public GameObject infoTxtObj;
    public TMP_Text gameOver;
    public Image answer;
    public GameObject answerObj;
    public GameObject WelcomeObj;
    public GameObject RulesObj;
    public GameObject exitBtnObj;
    public TMP_Text scoreText; // Text-Objekt für den Score
    public TMP_Text gameOverMessage; // Text-Objekt für die Game Over-Nachricht
    public TMP_Text countdownText; // Text-Objekt für den Countdown
    public Button restartButton; // Button zum Neustarten des Spiels

    private bool arrowKeysActive = true;
    private int wrongAnswers = 0;
    private int score = 0; // Variable für den Score
    private int countdown = 3; // Variable für den Countdown
    int rNumber;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartNewGame();
        }

        if (arrowKeysActive)
        {
            if (wrongAnswers >= 3 || countdown <= 0)
            {
                GameOver();
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                CheckAnswer(rNumber % 3 == 0 && rNumber % 5 == 0, "Eine Zahl ist durch 3 + 5 teilbar wenn die Quersumme durch 3 teilbar ist und die letzte Zahl 0 oder 5 ist.");
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                CheckAnswer(rNumber % 3 == 0 && rNumber % 5 != 0, "Eine Zahl ist durch 3 teilbar, wenn ihre Quersumme, das heißt die Summe ihrer Ziffern, durch 3 teilbar ist.");
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                CheckAnswer(rNumber % 5 == 0 && rNumber % 3 != 0, "Eine Zahl ist durch 5 teilbar, wenn die letzte Ziffer eine 0 oder 5 ist.");
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                CheckAnswer(rNumber % 3 != 0 && rNumber % 5 != 0, "");
            }
        }
    }

    private void CheckAnswer(bool isCorrect, string infoMessage)
    {
        rightNumber.text = "";
        wrongNumber.text = "";
        infoTxt.text = infoMessage;

        if (isCorrect)
        {
            rightNumber.text = "right";
            answer.color = Color.green;
            score++;
            UpdateScoreText();
        }
        else
        {
            wrongNumber.text = "wrong";
            answer.color = Color.red;
            wrongAnswers++;
            countdown--;
            UpdateCountdownText();

            if (countdown <= 0)
            {
                GameOver();
            }
        }

        arrowKeysActive = false;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    private void UpdateCountdownText()
    {
        countdownText.text = "Remaining Attempts: " + countdown;
    }

    private void GameOver()
    {
        gameOver.text = "Game Over";
        gameOverMessage.text = "You scored " + score + " points."; // Zeigt den Score bei Game Over an
        arrowKeysActive = false;
        genNubObj.SetActive(false);
        FizzObj.SetActive(false);
        BuzzObj.SetActive(false);
        fizzBuzzObj.SetActive(false);
        nixObj.SetActive(false);
        NumberObj.SetActive(false);
        rightNumberObj.SetActive(false);
        wrongNumberObj.SetActive(false);
        infoTxtObj.SetActive(false);
        answerObj.SetActive(false);
        RulesObj.SetActive(false);
        WelcomeObj.SetActive(false);
        exitBtnObj.SetActive(true);
        restartButton.gameObject.SetActive(true); // Aktiviert den Restart-Button
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        score = 0;
        wrongAnswers = 0;
        countdown = 3;
        UpdateScoreText();
        UpdateCountdownText();
        gameOver.text = "";
        gameOverMessage.text = "";
        arrowKeysActive = true;
        genNubObj.SetActive(true);
        FizzObj.SetActive(true);
        BuzzObj.SetActive(true);
        fizzBuzzObj.SetActive(true);
        nixObj.SetActive(true);
        NumberObj.SetActive(true);
        rightNumberObj.SetActive(true);
        wrongNumberObj.SetActive(true);
        infoTxtObj.SetActive(true);
        answerObj.SetActive(true);
        RulesObj.SetActive(true);
        WelcomeObj.SetActive(true);
        exitBtnObj.SetActive(false);
        restartButton.gameObject.SetActive(false); // Deaktiviert den Restart-Button
        StartNewGame();
    }

    private void StartNewGame()
    {
        int randomNumber = Random.Range(0, 1001);
        string randomString = randomNumber.ToString();
        Number.text = randomString;
        rNumber = randomNumber;
        rightNumber.text = "";
        wrongNumber.text = "";
        infoTxt.text = " ";
        answer.color = Color.white;
        arrowKeysActive = true;
    }
}
