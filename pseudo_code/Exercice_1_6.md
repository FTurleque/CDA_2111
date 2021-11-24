***Doc ABC Algo 05 - Algorithme Exercices - 1.0.1 MD***

**VARIABLE**
************

    int : user_enter, divisor

    divisor <-- 2

**CODE**
**********
    
    write "Choisir un nombre pour verifier s'il est premier ou non :"
    read user_enter

    while user_enter % divisor != 0 ET divisor <= racine carrée de user_enter
        divisor <-- divisor + 1
    EndWhile

    if divisor > racine carrée de user_enter then
        write "Le chiffre choisi n'est pas premier."
    else
        write "Le chiffre choisi est premier."
    EndIf