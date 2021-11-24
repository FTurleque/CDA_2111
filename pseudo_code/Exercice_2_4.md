***Doc ABC Algo 05 - Algorithme Exercices - 1.0.1 MD***

**VARIABLE**
************

    double : S, sum_spent
    int : store_count

    store_count <--> 1

**CODE**
**********

    write "Combien d'argent avez vous ?"
    red S

    do
        if S >= 2 then
            sum_spent <-- (S/2)+1
            S <-- S - sum_spent
        else
            S <-- S - S
        EndIf
        store_count <-- store_count + 1
    while S différent de 0

    write store_count
    