# Enabgabe Fizz Buzz
# von: 08-Thomas Eichhorn-teichhorn

Scene: FizzBuzz
Script: MAnager2

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


# Spielbeschreibung
FizzBuzz ist ein Interaktives Mathematik Spiel in welchen man herausfinden muss, ob eine Zahl durch 3, 5 oder 3&5 teilbar ist. Für jede mögliche Antwort gibt es einen Button oder befehl mit dem man seine Antwort bestätigt. Auf dem Laptop sind es die Pfeiltasten und beim Makey Makey die Angeschlossenen Leiter. Das Spiel ist vorbei wenn man 3 mal eine Falsche Antwort gegeben hat. Ziel ist sein Mathematisches Grundwissen zu stärken und so viele Punkte wie es nur geht zu erreichen.
Pfeiltaste nach oben = Fizz
Pfeiltaste nach unten = FizzBuzz
Pfeiltaste nach rechts = nix
Pfeiltaste nach links = Buzz
Leertaste = Zahl überspringen/nächste Zahl
# Anleitung
Ohne Makey Makey:
               -   Drücke Leertaste zum generieren einer Zahl
               -   Drücke dann die richtige Pfeiltaste (Funktion dieser im Game beschrieben)
               -   Spiele so lang, bis zu 3 Mal falsch geraten hast
               -   Restarte danch das spiel oder beende es

Mit Makey Makey:
               -   Zuerst Makey Makey an den Computer anstecken
               -   dann die Klammern an der Platine und an Leitenden Gegenständen befestigen
               -   eine klmmer us am unteren rand befestigt und in der hand gehalten werden
               -   Jetzt ist es einem möglich das Spiel zu Spielen
               -   Die angeschlossenen Gegenstände ersetzen die Pfeiltasten
               -   der Rest bleibt Gleich
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

