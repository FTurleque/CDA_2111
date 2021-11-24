***Doc ABC Algo 05 - Algorithme Exercices - 1.0.1 MD***

**VARIABLE**
************

    int : nb_random, user_number
    nb_random <-- RANDOM(0, 100)


**CODE**
**********

    write "Trouvez le nombre mystère"
    do
        write "Choisir un nombre entre 0 et 100"
        read user_number

        if user_number > nb_random then
            write "Le nombre à trouver est plus petit."
        else if user_number < nb_random then
                write "Le nombre à trouver est plus grand."
            else
                write "Gagnez !!!"
            EndIf
        EndIf
