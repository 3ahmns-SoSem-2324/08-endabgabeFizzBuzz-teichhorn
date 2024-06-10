# Enabgabe Fizz Buzz
# von: 08-Thomas Eichhorn-teichhorn
# 08-endabgabeFizzBuzz-teichhorn

https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet 
https://mermaid.live/ 
https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/
``` mermaid
graph TD
    A[Start] -->|Update| B[Check Key Down]

    B -->|Space Key| C[Generate Random Number]
    C --> D[Display Number]
    D --> E[Reset rightNumber, wrongNumber, infoTxt]
    E --> F[Reset right, wrong colors]

    B -->|Down Arrow| G[Check if number divisible by 3 and 5]
    G --> H{Divisible by 3 and 5?}
    H -->|Yes| I[Right for 3 and 5]
    I --> J[Set right color to green]
    H -->|No| K[Wrong for 3 and 5]
    K --> L[Set right color to red]
    L --> M[Display info for 3 and 5]

    B -->|Up Arrow| N[Check if number divisible by 3]
    N --> O{Divisible by 3?}
    O -->|Yes| P[Right for 3]
    P --> Q[Set right color to green]
    O -->|No| R[Wrong for 3]
    R --> S[Set right color to red]
    S --> T[Display info for 3]

    B -->|Left Arrow| U[Check if number divisible by 5]
    U --> V{Divisible by 5?}
    V -->|Yes| W[Right for 5]
    W --> X[Set right color to green]
    V -->|No| Y[Wrong for 5]
    Y --> Z[Set right color to red]
    Z --> AA[Display info for 5]

    B -->|Right Arrow| AB[Check if number not divisible by 3 or 5]
    AB --> AC{Not divisible by 3 or 5?}
    AC -->|Yes| AD[Right for neither]
    AD --> AE[Set right color to green]
    AC -->|No| AF[Wrong for neither]
    AF --> AG[Set right color to red]

