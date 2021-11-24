***Doc ABC Algo 05 - Algorithme Exercices - 1.0.1 MD***

**VARIABLE**
************

    int : nb1, nb2
    boolean : quit
    double : result

    quit <-- false

**CODE**
**********

    do
        wrrite "Entrez deux chiffres entier :"
        read nb1
        read nb2
        result <-- (nb1 + nb2)/2
        write result
        write "Voulez-vous continuer"
        read quit
    while quit égal à true