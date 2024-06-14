# Enabgabe Fizz Buzz
# von: 08-Thomas Eichhorn-teichhorn

Variablen und Objekte

1. Public Variablen und Objekte
   - `genNum`, `genNubObj`, `FizzObj`, `BuzzObj`, `fizzBuzzObj`, `nixObj`, `Number`, `NumberObj`, `rightNumber`, `rightNumberObj`, `wrongNumber`, `wrongNumberObj`, `infoTxt`, `infoTxtObj`, `gameOver`, `answer`, `answerObj`, `WelcomeObj`, `RulesObj`, `exitBtnObj`, `scoreText`, `gameOverMessage`, `countdownText`, `restartButton`: Diese Variablen und Objekte sind öffentlich und werden in Unity Editor zugeordnet, um verschiedene UI-Elemente, Buttons und Texte zu verwalten.

2. Private Variablen
   - `arrowKeysActive`: Kontrolliert, ob die Pfeiltasten für die Eingabe aktiv sind.
   - `wrongAnswers`: Zählt die falschen Antworten.
   - `score`: Hält den aktuellen Punktestand.
   - `countdown`: Zählt die verbleibenden Versuche vor Spielende.
   - `rNumber`: Speichert die aktuelle Zufallszahl für das Spiel.

Methoden

1. Update()
   - Überprüft die Eingaben der Pfeiltasten (`DownArrow`, `UpArrow`, `LeftArrow`, `RightArrow`) und ruft `CheckAnswer()` auf, um die Antworten zu überprüfen.
   - Startet ein neues Spiel mit der Leertaste (`Space`).

2. CheckAnswer(bool isCorrect, string infoMessage)
   - Überprüft die gegebene Antwort (`isCorrect`) und aktualisiert entsprechend `rightNumber`, `wrongNumber`, `infoTxt`, `answer` und den Spielstatus.
   - Deaktiviert die Pfeiltasten nach einer Antwort.

3. UpdateScoreText()
   - Aktualisiert den angezeigten Punktestand (`scoreText`).

4. UpdateCountdownText()
   - Aktualisiert den Countdown der verbleibenden Versuche (`countdownText`).

5. GameOver()
   - Zeigt "Game Over" an, zeigt den endgültigen Punktestand (`score`) an und deaktiviert die Spielobjekte.
   - Aktiviert den Exit-Button und den Restart-Button.

6. Exit()
   - Beendet die Anwendung.

7. RestartGame()
   - Setzt das Spiel zurück, indem es den Punktestand, falsche Antworten, Countdown und alle relevanten UI-Elemente zurücksetzt.
   - Startet ein neues Spiel mit `StartNewGame()`.

8. StartNewGame()
   - Generiert eine neue Zufallszahl, aktualisiert die angezeigte Nummer und die Info-Texte, setzt die Antwort-Anzeige zurück und aktiviert die Pfeiltasten für die Eingabe.

Zusammenfassung

Das Skript verwaltet die Logik für ein interaktives Spiel, in dem der Spieler die Zahlen auf Bildschirmtasten drückt und überprüft, ob sie den FizzBuzz-Regeln entsprechen. Es zeigt den aktuellen Punktestand an, zählt die falschen Antworten und die verbleibenden Versuche bis zum Spielende. Der Spieler kann das Spiel neu starten oder beenden und erhält Feedback über seine Antworten in Echtzeit.
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

