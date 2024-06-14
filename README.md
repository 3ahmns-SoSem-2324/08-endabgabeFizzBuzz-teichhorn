# Enabgabe Fizz Buzz
# von: 08-Thomas Eichhorn-teichhorn
# 08-endabgabeFizzBuzz-teichhorn

https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet 
https://mermaid.live/ 
https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/
``` mermaid
classDiagram
    class Manager2 {
        <<MonoBehaviour>>
        + genNum: Button
        + genNubObj: GameObject
        + FizzObj: GameObject
        + BuzzObj: GameObject
        + fizzBuzzObj: GameObject
        + nixObj: GameObject
        + Number: TMP_Text
        + NumberObj: GameObject
        + rightNumber: TMP_Text
        + rightNumberObj: GameObject
        + wrongNumber: TMP_Text
        + wrongNumberObj: GameObject
        + infoTxt: TMP_Text
        + infoTxtObj: GameObject
        + gameOver: TMP_Text
        + answer: Image
        + answerObj: GameObject
        + WelcomeObj: GameObject
        + RulesObj: GameObject
        + exitBtnObj: GameObject
        + scoreText: TMP_Text
        + gameOverMessage: TMP_Text
        + countdownText: TMP_Text
        + restartButton: Button
        - arrowKeysActive: bool
        - wrongAnswers: int
        - score: int
        - countdown: int
        - rNumber: int
        --
        + void Update()
        + void CheckAnswer(bool isCorrect, string infoMessage)
        + void UpdateScoreText()
        + void UpdateCountdownText()
        + void GameOver()
        + void Exit()
        + void RestartGame()
        + void StartNewGame()
    }

    Manager2 --|> MonoBehaviour
    Manager2 --> Button
    Manager2 --> GameObject
    Manager2 --> TMP_Text
    Manager2 --> Image

